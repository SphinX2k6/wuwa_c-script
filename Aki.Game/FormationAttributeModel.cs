using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020003BE RID: 958
[NullableContext(1)]
[Nullable(0)]
public class FormationAttributeModel : ModelBase, IFormationAttributeModel
{
	// Token: 0x06003455 RID: 13397 RVA: 0x001364D4 File Offset: 0x001346D4
	[NullableContext(2)]
	public IFormationAttributeConfig GetConfig(EFormationAttributeId attrId)
	{
		if (this.Configs.ContainsKey(attrId))
		{
			return this.Configs[attrId];
		}
		FormationProperty? config = ConfigFormationPropertyById.GetConfig((int)attrId, true);
		FormationAttributeConfig formationAttributeConfig = new FormationAttributeConfig
		{
			RawConfig = config,
			ForbidIncreaseTags = new int?[(config != null) ? config.GetValueOrDefault().MarkTagLength : 0],
			ForbidDecreaseTags = new int?[(config != null) ? config.GetValueOrDefault().ResistTagLength : 0]
		};
		if (config != null)
		{
			for (int i = 0; i < config.Value.MarkTagLength; i++)
			{
				formationAttributeConfig.ForbidIncreaseTags[i] = new int?(GameplayTagUtils.GetTagIdByName(config.Value.MarkTag(i)));
			}
		}
		if (config != null)
		{
			for (int j = 0; j < config.Value.ResistTagLength; j++)
			{
				formationAttributeConfig.ForbidDecreaseTags[j] = new int?(GameplayTagUtils.GetTagIdByName(config.Value.ResistTag(j)));
			}
		}
		this.Configs[attrId] = formationAttributeConfig;
		return formationAttributeConfig;
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00136604 File Offset: 0x00134804
	protected override bool OnInit()
	{
		double worldTime = Time.Instance.WorldTime;
		IReadOnlyList<FormationProperty> configList = ConfigFormationPropertyAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (FormationProperty formationProperty in configList)
			{
				this.AttributeSet[(EFormationAttributeId)formationProperty.Id] = new AttributeData
				{
					Max = (float)formationProperty.InitMax,
					BaseMax = (float)formationProperty.InitMax,
					Value = (float)formationProperty.InitValue,
					Speed = (float)formationProperty.InitRecoveryRate,
					BaseSpeed = (float)formationProperty.InitRecoveryRate,
					Timestamp = worldTime
				};
			}
		}
		return true;
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x001366C4 File Offset: 0x001348C4
	protected override bool OnClear()
	{
		this.Configs.Clear();
		this.AttributeSet.Clear();
		return true;
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x001366E0 File Offset: 0x001348E0
	public float GetValue(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		double num = this.GetPredictedServerStopTime() - data.Timestamp;
		float speed = data.Speed;
		if (speed == 0f || num <= 0.0)
		{
			return data.Value;
		}
		double num2 = num * 0.0010000000474974513 * (double)speed;
		return this.ClampValue(attrId, (float)((double)data.Value + num2), 0f, data.Max);
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x00136759 File Offset: 0x00134959
	public float GetMax(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.Max;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x00136771 File Offset: 0x00134971
	public float GetBaseMax(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.BaseMax;
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x00136789 File Offset: 0x00134989
	public float GetBaseRate(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.BaseSpeed;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x001367A1 File Offset: 0x001349A1
	public float GetSpeed(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.Speed;
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x001367BC File Offset: 0x001349BC
	[NullableContext(2)]
	public IAttributeData GetData(EFormationAttributeId attrId)
	{
		if (!this.AttributeSet.ContainsKey(attrId))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CombatInfo;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "尝试读取不存在的队伍属性。";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("typeId", attrId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return this.AttributeSet[attrId];
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x00136814 File Offset: 0x00134A14
	public void SetData(EFormationAttributeId attrId, float max, float baseMax, float value, float speed, double timestamp)
	{
		IAttributeData data = this.GetData(attrId);
		if (data != null)
		{
			data.Max = max;
			data.BaseMax = baseMax;
			data.Value = value;
			data.Speed = speed;
			data.Timestamp = timestamp;
		}
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x00136854 File Offset: 0x00134A54
	public void SetSpeed(EFormationAttributeId attrId, float newSpeed)
	{
		IAttributeData data = this.GetData(attrId);
		if (data != null)
		{
			float value = this.GetValue(attrId);
			data.Timestamp = this.GetPredictedServerStopTime();
			data.Value = value;
			data.Speed = newSpeed;
		}
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x00136890 File Offset: 0x00134A90
	public void SetValue(EFormationAttributeId attrId, float newValue)
	{
		IAttributeData data = this.GetData(attrId);
		if (data != null)
		{
			data.Timestamp = this.GetPredictedServerStopTime();
			data.Value = this.ClampValue(attrId, newValue, 0f, data.Max);
		}
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x001368D0 File Offset: 0x00134AD0
	public void SetMax(EFormationAttributeId attrId, float newMax)
	{
		if (this.AttributeSet.ContainsKey(attrId))
		{
			IAttributeData attributeData = this.AttributeSet[attrId];
			float value = this.GetValue(attrId);
			attributeData.Timestamp = this.GetPredictedServerStopTime();
			attributeData.Value = Math.Min(value, newMax);
			attributeData.Max = newMax;
		}
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00136920 File Offset: 0x00134B20
	public float ClampValue(EFormationAttributeId attrId, float baseValue, float minValue, float maxValue)
	{
		float num = baseValue;
		float? num2 = new float?(minValue);
		float val = maxValue;
		if (this.BoundsLockerMap.ContainsKey(attrId))
		{
			foreach (IBoundsLocker boundsLocker in this.BoundsLockerMap[attrId].Values)
			{
				if (boundsLocker.LockLowerBounds)
				{
					float num3 = (float)((double)boundsLocker.LowerPercent * (double)maxValue / 10000.0 + (double)boundsLocker.LowerOffset);
					num2 = new float?(Math.Max(num2.GetValueOrDefault(num3), num3));
				}
				if (boundsLocker.LockUpperBounds)
				{
					float val2 = (float)((double)boundsLocker.UpperPercent * (double)maxValue / 10000.0 + (double)boundsLocker.UpperOffset);
					val = Math.Min(val, val2);
				}
			}
		}
		num = Math.Min(val, num);
		if (num2 != null)
		{
			num = Math.Max(num2.Value, num);
		}
		return num;
	}

	// Token: 0x06003463 RID: 13411 RVA: 0x00136A34 File Offset: 0x00134C34
	public unsafe int AddBoundsLocker(EFormationAttributeId attrId, IBoundsLocker locker, int lockerHandle)
	{
		this.SetValue(attrId, this.GetValue(attrId));
		if (!this.BoundsLockerMap.ContainsKey(attrId))
		{
			this.BoundsLockerMap[attrId] = new Dictionary<int, IBoundsLocker>();
		}
		Dictionary<int, IBoundsLocker> dictionary = this.BoundsLockerMap[attrId];
		if (dictionary.ContainsKey(lockerHandle))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "重复添加队伍属性锁";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attrId", attrId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("handle", lockerHandle);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		dictionary[lockerHandle] = locker;
		this.SetValue(attrId, this.GetValue(attrId));
		return lockerHandle;
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x00136AF8 File Offset: 0x00134CF8
	public bool RemoveBoundsLocker(EFormationAttributeId attrId, int lockerHandle)
	{
		this.SetValue(attrId, this.GetValue(attrId));
		if (!this.BoundsLockerMap.ContainsKey(attrId))
		{
			return false;
		}
		if (!this.BoundsLockerMap[attrId].Remove(lockerHandle))
		{
			return false;
		}
		this.SetValue(attrId, this.GetValue(attrId));
		return true;
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x00136B48 File Offset: 0x00134D48
	public double GetPredictedServerStopTime()
	{
		return Time.Instance.ServerCombatStopTime;
	}

	// Token: 0x170007AF RID: 1967
	// (get) Token: 0x06003466 RID: 13414 RVA: 0x00136B54 File Offset: 0x00134D54
	public static FormationAttributeModel Instance
	{
		get
		{
			return FormationAttributeModel._Instance;
		}
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x00136B5B File Offset: 0x00134D5B
	public static FormationAttributeModel GetOrCreateInstance()
	{
		if (FormationAttributeModel._Instance == null)
		{
			FormationAttributeModel.CreateInstance();
		}
		return FormationAttributeModel._Instance;
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x00136B6F File Offset: 0x00134D6F
	public static bool CreateInstance()
	{
		if (FormationAttributeModel._Instance != null)
		{
			return true;
		}
		FormationAttributeModel._Instance = new FormationAttributeModel();
		return true;
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x00136B85 File Offset: 0x00134D85
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x00136B87 File Offset: 0x00134D87
	public static void ResetStaticDefaultValue()
	{
		FormationAttributeModel._Instance = null;
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x00136B8F File Offset: 0x00134D8F
	static FormationAttributeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationAttributeModel.CreateStaticDefaultValue), new Action(FormationAttributeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002CB5 RID: 11445
	private readonly Dictionary<EFormationAttributeId, IFormationAttributeConfig> Configs = new Dictionary<EFormationAttributeId, IFormationAttributeConfig>();

	// Token: 0x04002CB6 RID: 11446
	private readonly Dictionary<EFormationAttributeId, IAttributeData> AttributeSet = new Dictionary<EFormationAttributeId, IAttributeData>();

	// Token: 0x04002CB7 RID: 11447
	protected readonly Dictionary<EFormationAttributeId, Dictionary<int, IBoundsLocker>> BoundsLockerMap = new Dictionary<EFormationAttributeId, Dictionary<int, IBoundsLocker>>();

	// Token: 0x04002CB8 RID: 11448
	[Nullable(2)]
	private static FormationAttributeModel _Instance;
}
