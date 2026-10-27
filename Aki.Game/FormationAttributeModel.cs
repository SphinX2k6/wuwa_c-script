using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F09 RID: 3849
[NullableContext(1)]
[Nullable(0)]
public class FormationAttributeModel : ModelBase, IFormationAttributeModel
{
	// Token: 0x060060BD RID: 24765 RVA: 0x0012DBD0 File Offset: 0x0012BDD0
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

	// Token: 0x060060BE RID: 24766 RVA: 0x0012DD00 File Offset: 0x0012BF00
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

	// Token: 0x060060BF RID: 24767 RVA: 0x0012DDC0 File Offset: 0x0012BFC0
	protected override bool OnClear()
	{
		this.Configs.Clear();
		this.AttributeSet.Clear();
		return true;
	}

	// Token: 0x060060C0 RID: 24768 RVA: 0x0012DDDC File Offset: 0x0012BFDC
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

	// Token: 0x060060C1 RID: 24769 RVA: 0x0012DE55 File Offset: 0x0012C055
	public float GetMax(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.Max;
	}

	// Token: 0x060060C2 RID: 24770 RVA: 0x0012DE6D File Offset: 0x0012C06D
	public float GetBaseMax(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.BaseMax;
	}

	// Token: 0x060060C3 RID: 24771 RVA: 0x0012DE85 File Offset: 0x0012C085
	public float GetBaseRate(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.BaseSpeed;
	}

	// Token: 0x060060C4 RID: 24772 RVA: 0x0012DE9D File Offset: 0x0012C09D
	public float GetSpeed(EFormationAttributeId attrId)
	{
		IAttributeData data = this.GetData(attrId);
		if (data == null)
		{
			return 0f;
		}
		return data.Speed;
	}

	// Token: 0x060060C5 RID: 24773 RVA: 0x0012DEB8 File Offset: 0x0012C0B8
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

	// Token: 0x060060C6 RID: 24774 RVA: 0x0012DF10 File Offset: 0x0012C110
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

	// Token: 0x060060C7 RID: 24775 RVA: 0x0012DF50 File Offset: 0x0012C150
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

	// Token: 0x060060C8 RID: 24776 RVA: 0x0012DF8C File Offset: 0x0012C18C
	public void SetValue(EFormationAttributeId attrId, float newValue)
	{
		IAttributeData data = this.GetData(attrId);
		if (data != null)
		{
			data.Timestamp = this.GetPredictedServerStopTime();
			data.Value = this.ClampValue(attrId, newValue, 0f, data.Max);
		}
	}

	// Token: 0x060060C9 RID: 24777 RVA: 0x0012DFCC File Offset: 0x0012C1CC
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

	// Token: 0x060060CA RID: 24778 RVA: 0x0012E01C File Offset: 0x0012C21C
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
					float num3 = boundsLocker.LowerPercent * maxValue + boundsLocker.LowerOffset;
					num2 = new float?(Math.Max(num2.GetValueOrDefault(num3), num3));
				}
				if (boundsLocker.LockUpperBounds)
				{
					float val2 = boundsLocker.UpperPercent * maxValue + boundsLocker.UpperOffset;
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

	// Token: 0x060060CB RID: 24779 RVA: 0x0012E110 File Offset: 0x0012C310
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

	// Token: 0x060060CC RID: 24780 RVA: 0x0012E1D4 File Offset: 0x0012C3D4
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

	// Token: 0x060060CD RID: 24781 RVA: 0x0012E224 File Offset: 0x0012C424
	public double GetPredictedServerStopTime()
	{
		return Time.Instance.ServerCombatStopTime;
	}

	// Token: 0x1700078D RID: 1933
	// (get) Token: 0x060060CE RID: 24782 RVA: 0x0012E230 File Offset: 0x0012C430
	public static FormationAttributeModel Instance
	{
		get
		{
			return FormationAttributeModel._Instance;
		}
	}

	// Token: 0x060060CF RID: 24783 RVA: 0x0012E237 File Offset: 0x0012C437
	public static FormationAttributeModel GetOrCreateInstance()
	{
		if (FormationAttributeModel._Instance == null)
		{
			FormationAttributeModel.CreateInstance();
		}
		return FormationAttributeModel._Instance;
	}

	// Token: 0x060060D0 RID: 24784 RVA: 0x0012E24B File Offset: 0x0012C44B
	public static bool CreateInstance()
	{
		if (FormationAttributeModel._Instance != null)
		{
			return true;
		}
		FormationAttributeModel._Instance = new FormationAttributeModel();
		return true;
	}

	// Token: 0x060060D1 RID: 24785 RVA: 0x0012E261 File Offset: 0x0012C461
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060060D2 RID: 24786 RVA: 0x0012E263 File Offset: 0x0012C463
	public static void ResetStaticDefaultValue()
	{
		FormationAttributeModel._Instance = null;
	}

	// Token: 0x060060D3 RID: 24787 RVA: 0x0012E26B File Offset: 0x0012C46B
	static FormationAttributeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationAttributeModel.CreateStaticDefaultValue), new Action(FormationAttributeModel.ResetStaticDefaultValue));
	}

	// Token: 0x04002C1C RID: 11292
	private readonly Dictionary<EFormationAttributeId, IFormationAttributeConfig> Configs = new Dictionary<EFormationAttributeId, IFormationAttributeConfig>();

	// Token: 0x04002C1D RID: 11293
	private readonly Dictionary<EFormationAttributeId, IAttributeData> AttributeSet = new Dictionary<EFormationAttributeId, IAttributeData>();

	// Token: 0x04002C1E RID: 11294
	protected readonly Dictionary<EFormationAttributeId, Dictionary<int, IBoundsLocker>> BoundsLockerMap = new Dictionary<EFormationAttributeId, Dictionary<int, IBoundsLocker>>();

	// Token: 0x04002C1F RID: 11295
	[Nullable(2)]
	private static FormationAttributeModel _Instance;
}
