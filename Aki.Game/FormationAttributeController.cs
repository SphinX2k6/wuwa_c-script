using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x020003B8 RID: 952
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class FormationAttributeController : ControllerBase
{
	// Token: 0x060033FF RID: 13311 RVA: 0x00135380 File Offset: 0x00133580
	protected override bool OnInit()
	{
		this.ConfigList = ConfigFormationPropertyAll.GetConfigList(true);
		Net.Instance.Register(ENotifyMessageId.FormationAttrNotify, new Action<IMessage, Net.CallbackStatus>(this.FormationAttrNotify));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x001353D4 File Offset: 0x001335D4
	protected override void OnTick(float delta)
	{
		if (this.ConfigList == null)
		{
			return;
		}
		foreach (FormationProperty formationProperty in this.ConfigList)
		{
			this.RefreshValue((EFormationAttributeId)formationProperty.Id);
		}
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x00135430 File Offset: 0x00133630
	protected override bool OnClear()
	{
		this.ClearListeners();
		this.PauseLocks.Clear();
		this.PauseRateLocks.Clear();
		Net.Instance.UnRegister(ENotifyMessageId.FormationAttrNotify);
		return true;
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x00135460 File Offset: 0x00133660
	[NullableContext(2)]
	public void FormationAttrNotify(IMessage msg, Net.CallbackStatus status)
	{
		FormationAttrNotify formationAttrNotify = (FormationAttrNotify)msg;
		long curTime = formationAttrNotify.CurTime;
		foreach (FormationAttr formationAttr in formationAttrNotify.FormationAttrs)
		{
			int attrId = formationAttr.AttrId;
			float max = this.Model.GetMax((EFormationAttributeId)formationAttr.AttrId);
			int maxValue = formationAttr.MaxValue;
			int baseMaxValue = formationAttr.BaseMaxValue;
			float value = (float)formationAttr.CurrentValue;
			float speed = (float)formationAttr.Ratio;
			if (this.HasAuthority((EFormationAttributeId)attrId))
			{
				value = this.GetValue((EFormationAttributeId)attrId);
				speed = this.GetSpeed((EFormationAttributeId)attrId);
			}
			this.Model.SetData((EFormationAttributeId)attrId, (float)maxValue, (float)baseMaxValue, value, speed, (double)curTime);
			this.OnSetMax((EFormationAttributeId)attrId, (float)maxValue, max);
		}
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x00135534 File Offset: 0x00133734
	protected void OnFormationAttrChanged(EFormationAttributeId attrId)
	{
		FormationAttributeModel model = this.Model;
		IAttributeData attributeData = (model != null) ? model.GetData(attrId) : null;
		if (attributeData == null)
		{
			return;
		}
		FormationAttrRequest formationAttrRequest = new FormationAttrRequest();
		FormationAttr formationAttr = new FormationAttr();
		formationAttrRequest.FormationAttrs.Add(formationAttr);
		formationAttrRequest.CurTime = (long)attributeData.Timestamp;
		formationAttr.AttrId = (int)attrId;
		formationAttr.CurrentValue = (int)attributeData.Value;
		formationAttr.MaxValue = (int)attributeData.Max;
		formationAttr.BaseMaxValue = (int)attributeData.BaseMax;
		formationAttr.Ratio = (int)attributeData.Speed;
		Net.Instance.Call(ERequestMessageId.FormationAttrRequest, formationAttrRequest, null, 0);
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x001355CC File Offset: 0x001337CC
	public void SetValue(EFormationAttributeId attrId, float value)
	{
		if (!this.HasAuthority(attrId))
		{
			return;
		}
		float value2 = this.GetValue(attrId);
		this.Model.SetValue(attrId, value);
		this.RefreshValue(attrId);
		if (this.GetValue(attrId) != value2)
		{
			this.OnFormationAttrChanged(attrId);
		}
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x00135610 File Offset: 0x00133810
	public void AddValue(EFormationAttributeId attrId, float value)
	{
		if (!this.HasAuthority(attrId))
		{
			return;
		}
		this.SetValue(attrId, this.Model.GetValue(attrId) + value);
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x00135631 File Offset: 0x00133831
	public float GetValue(EFormationAttributeId attrId)
	{
		if (this.AttributeCache.ContainsKey(attrId))
		{
			return this.AttributeCache[attrId];
		}
		return this.Model.GetValue(attrId);
	}

	// Token: 0x06003407 RID: 13319 RVA: 0x0013565A File Offset: 0x0013385A
	public float GetMax(EFormationAttributeId attrId)
	{
		return this.Model.GetMax(attrId);
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x00135668 File Offset: 0x00133868
	public void AddMaxModifier(string key, EFormationAttributeId attrId, float percent, float offset)
	{
		if (!this.MaxModifiers.ContainsKey(attrId))
		{
			this.MaxModifiers[attrId] = new Dictionary<string, IMaxModifier>();
		}
		this.MaxModifiers[attrId][key] = new MaxModifier
		{
			Percent = percent,
			Offset = offset
		};
		this.RefreshMax(attrId);
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x001356C1 File Offset: 0x001338C1
	public void RemoveMaxModifier(string key, EFormationAttributeId attrId)
	{
		if (this.MaxModifiers.ContainsKey(attrId))
		{
			Dictionary<string, IMaxModifier> dictionary = this.MaxModifiers[attrId];
			dictionary.Remove(key);
			if (dictionary.Count == 0)
			{
				this.MaxModifiers.Remove(attrId);
			}
			this.RefreshMax(attrId);
		}
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x00135700 File Offset: 0x00133900
	public float GetBaseMax(EFormationAttributeId attrId)
	{
		return this.Model.GetBaseMax(attrId);
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x0013570E File Offset: 0x0013390E
	public float GetSpeed(EFormationAttributeId attrId)
	{
		return this.Model.GetSpeed(attrId);
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x0013571C File Offset: 0x0013391C
	public float GetRatio(EFormationAttributeId attrId)
	{
		return this.GetValue(attrId) / this.GetMax(attrId) * 10000f;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x00135734 File Offset: 0x00133934
	public void AddSpeedModifier(string key, EFormationAttributeId attrId, EModifierType type, float value, int priority = 100)
	{
		if (!this.SpeedModifiers.ContainsKey(attrId))
		{
			this.SpeedModifiers[attrId] = new Dictionary<string, ISpeedModifier>();
		}
		this.SpeedModifiers[attrId][key] = new SpeedModifier
		{
			Type = type,
			Value = value,
			Priority = priority
		};
		this.RefreshSpeed(attrId);
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x00135795 File Offset: 0x00133995
	public void RemoveSpeedModifier(string key, EFormationAttributeId attrId)
	{
		if (this.SpeedModifiers.ContainsKey(attrId))
		{
			Dictionary<string, ISpeedModifier> dictionary = this.SpeedModifiers[attrId];
			dictionary.Remove(key);
			if (dictionary.Count == 0)
			{
				this.SpeedModifiers.Remove(attrId);
			}
			this.RefreshSpeed(attrId);
		}
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x001357D4 File Offset: 0x001339D4
	public int AddBoundsLocker(EFormationAttributeId attrId, IBoundsLocker locker, int lockerHandle)
	{
		FormationAttributeModel model = this.Model;
		if (model == null)
		{
			return -1;
		}
		return model.AddBoundsLocker(attrId, locker, lockerHandle);
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x001357EA File Offset: 0x001339EA
	public bool RemoveBoundsLocker(EFormationAttributeId attrId, int lockerHandle)
	{
		FormationAttributeModel model = this.Model;
		return model != null && model.RemoveBoundsLocker(attrId, lockerHandle);
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x00135800 File Offset: 0x00133A00
	public void AddPauseLock(string key, float timeScale = 0f)
	{
		if (timeScale <= 0f)
		{
			this.PauseLocks.Add(key);
			this.PauseRateLocks.Remove(key);
		}
		else
		{
			this.PauseLocks.Remove(key);
			this.PauseRateLocks[key] = MathUtils.Instance.Clamp(timeScale, 0f, 1f);
		}
		this.RefreshAllSpeed();
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x00135865 File Offset: 0x00133A65
	public void RemovePauseLock(string key)
	{
		this.PauseLocks.Remove(key);
		this.PauseRateLocks.Remove(key);
		this.RefreshAllSpeed();
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x00135887 File Offset: 0x00133A87
	public bool IsPaused()
	{
		return this.PauseLocks.Count > 0;
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x00135898 File Offset: 0x00133A98
	public float GetPauseRate()
	{
		float num = 1f;
		foreach (float val in this.PauseRateLocks.Values)
		{
			num = Math.Min(num, val);
		}
		return num;
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x001358F8 File Offset: 0x00133AF8
	private bool HasAuthority(EFormationAttributeId attrId)
	{
		return attrId == EFormationAttributeId.Strength || attrId == EFormationAttributeId.MigrationStrength || attrId == EFormationAttributeId.MotorcycleStrength || attrId == EFormationAttributeId.MotorcycleSoarStrength || attrId == EFormationAttributeId.LevelQuickHackRam;
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x00135914 File Offset: 0x00133B14
	private BaseTagComponent.TTagSwitchedCallback GetCheckTagCallback(EFormationAttributeId attrId)
	{
		if (!this.CheckTagCallbacks.ContainsKey(attrId))
		{
			this.CheckTagCallbacks[attrId] = delegate(int _, bool _)
			{
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				BaseTagComponent baseTagComponent;
				if (getCurrentEntity == null)
				{
					baseTagComponent = null;
				}
				else
				{
					WorldEntity entity = getCurrentEntity.Entity;
					baseTagComponent = ((entity != null) ? entity.CheckGetComponent<BaseTagComponent>() : null);
				}
				BaseTagComponent baseTagComponent2 = baseTagComponent;
				IFormationAttributeConfig config = this.Model.GetConfig(attrId);
				if (config == null || baseTagComponent2 == null)
				{
					return;
				}
				if (baseTagComponent2.HasAnyTag(config.ForbidIncreaseTags))
				{
					this.AddSpeedModifier("TagForbidIncrease", attrId, EModifierType.IncreaseModify, float.NegativeInfinity, 100);
				}
				else
				{
					this.RemoveSpeedModifier("TagForbidIncrease", attrId);
				}
				if (baseTagComponent2.HasAnyTag(config.ForbidDecreaseTags))
				{
					this.AddSpeedModifier("TagForbidDecrease", attrId, EModifierType.DecreaseModify, float.NegativeInfinity, 100);
					return;
				}
				this.RemoveSpeedModifier("TagForbidDecrease", attrId);
			};
		}
		return this.CheckTagCallbacks[attrId];
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x00135978 File Offset: 0x00133B78
	private void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		if (this.ConfigList == null)
		{
			return;
		}
		foreach (FormationProperty formationProperty in this.ConfigList)
		{
			EFormationAttributeId id = (EFormationAttributeId)formationProperty.Id;
			WorldEntity entity = newEntityHandle.Entity;
			BaseTagComponent baseTagComponent = (entity != null) ? entity.CheckGetComponent<BaseTagComponent>() : null;
			if (baseTagComponent != null)
			{
				IFormationAttributeConfig config = this.Model.GetConfig(id);
				BaseTagComponent.TTagSwitchedCallback checkTagCallback = this.GetCheckTagCallback(id);
				int?[] array = (config != null) ? config.ForbidIncreaseTags : null;
				if (array != null)
				{
					foreach (int num in array)
					{
						if (num != null && num.Value != 0 && !baseTagComponent.HasTagAddOrRemoveListener(num.Value, checkTagCallback))
						{
							baseTagComponent.AddTagAddOrRemoveListener(num.Value, checkTagCallback, null);
						}
					}
				}
				int?[] array3 = (config != null) ? config.ForbidDecreaseTags : null;
				if (array3 != null)
				{
					foreach (int num2 in array3)
					{
						if (num2 != null && num2.Value != 0 && !baseTagComponent.HasTagAddOrRemoveListener(num2.Value, checkTagCallback))
						{
							baseTagComponent.AddTagAddOrRemoveListener(num2.Value, checkTagCallback, null);
						}
					}
				}
			}
			this.GetCheckTagCallback(id)(0, false);
		}
	}

	// Token: 0x1700079B RID: 1947
	// (get) Token: 0x06003418 RID: 13336 RVA: 0x00135AF4 File Offset: 0x00133CF4
	[Nullable(2)]
	public FormationAttributeModel Model
	{
		[NullableContext(2)]
		get
		{
			return FormationAttributeModel.Instance;
		}
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x00135AFC File Offset: 0x00133CFC
	protected void OnSetMax(EFormationAttributeId attrId, float newMax, float oldMax)
	{
		if (newMax != oldMax && this.MaxListeners.ContainsKey(attrId))
		{
			foreach (TValueListener tvalueListener in this.MaxListeners[attrId])
			{
				tvalueListener(attrId, newMax, oldMax);
			}
		}
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x00135B68 File Offset: 0x00133D68
	protected void RefreshAllSpeed()
	{
		if (this.ConfigList != null)
		{
			foreach (FormationProperty formationProperty in this.ConfigList)
			{
				this.RefreshSpeed((EFormationAttributeId)formationProperty.Id);
			}
		}
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x00135BC4 File Offset: 0x00133DC4
	protected void RefreshSpeed(EFormationAttributeId attrId)
	{
		Dictionary<string, ISpeedModifier> dictionary = this.SpeedModifiers.ContainsKey(attrId) ? this.SpeedModifiers[attrId] : null;
		float num = this.Model.GetBaseRate(attrId);
		float num2 = num;
		float speed = this.Model.GetSpeed(attrId);
		if (this.IsPaused())
		{
			num2 = 0f;
		}
		else if (dictionary != null)
		{
			float num3 = 0f;
			float num4 = 0f;
			int num5 = 0;
			foreach (ISpeedModifier speedModifier in dictionary.Values)
			{
				switch (speedModifier.Type)
				{
				case EModifierType.Override:
					if (speedModifier.Priority >= num5)
					{
						num5 = speedModifier.Priority;
						num = speedModifier.Value;
					}
					break;
				case EModifierType.IncreaseModify:
					num3 += speedModifier.Value;
					break;
				case EModifierType.DecreaseModify:
					num4 += speedModifier.Value;
					break;
				}
			}
			float num6 = Math.Max(1f + ((num > 0f) ? num3 : num4) * 0.0001f, 0f);
			num2 = num * num6;
		}
		if (!this.IsPaused())
		{
			num2 *= this.GetPauseRate();
		}
		if (num2 != speed)
		{
			this.Model.SetSpeed(attrId, num2);
			this.OnFormationAttrChanged(attrId);
		}
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x00135D24 File Offset: 0x00133F24
	protected void RefreshMax(EFormationAttributeId attrId)
	{
		Dictionary<string, IMaxModifier> dictionary = this.MaxModifiers.ContainsKey(attrId) ? this.MaxModifiers[attrId] : null;
		float baseMax = this.Model.GetBaseMax(attrId);
		float num = baseMax;
		float max = this.Model.GetMax(attrId);
		if (dictionary != null)
		{
			float num2 = 0f;
			float num3 = 0f;
			foreach (IMaxModifier maxModifier in dictionary.Values)
			{
				num2 += maxModifier.Offset;
				num3 += maxModifier.Percent;
			}
			num = baseMax + num2 + baseMax * num3 * 0.0001f;
		}
		if (max != num)
		{
			this.Model.SetMax(attrId, num);
			this.RefreshValue(attrId);
			this.OnSetMax(attrId, num, max);
			this.OnFormationAttrChanged(attrId);
		}
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x00135E10 File Offset: 0x00134010
	private unsafe void RefreshValue(EFormationAttributeId attrId)
	{
		float value = this.Model.GetValue(attrId);
		float num = this.AttributeCache.ContainsKey(attrId) ? this.AttributeCache[attrId] : value;
		if (!this.AttributeCache.ContainsKey(attrId))
		{
			this.AttributeCache[attrId] = value;
			num = value;
		}
		if (value != num)
		{
			this.AttributeCache[attrId] = value;
			if (this.ValueListeners.ContainsKey(attrId))
			{
				HashSet<TValueListener> hashSet = this.ValueListeners[attrId];
				TValueListener[] array = new TValueListener[hashSet.Count];
				hashSet.CopyTo(array);
				foreach (TValueListener tvalueListener in array)
				{
					if (hashSet.Contains(tvalueListener))
					{
						try
						{
							tvalueListener(attrId, value, num);
						}
						catch (Exception ex)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.Event;
							ELogAuthor author = ELogAuthor.ZQR;
							string message = "队伍属性回调异常";
							Exception error = ex;
							<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attrId", attrId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newValue", value);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("oldValue", num);
							instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						}
					}
				}
			}
			if (this.ThresholdListeners.ContainsKey(attrId))
			{
				List<IThresholdListenerInfo> list = this.ThresholdListeners[attrId];
				float ratio = this.GetRatio(attrId);
				IThresholdListenerInfo[] array3 = new IThresholdListenerInfo[list.Count];
				list.CopyTo(array3);
				foreach (IThresholdListenerInfo thresholdListenerInfo in array3)
				{
					if (list.Contains(thresholdListenerInfo))
					{
						bool flag = ratio >= thresholdListenerInfo.Min && ratio <= thresholdListenerInfo.Max;
						if (flag != thresholdListenerInfo.InInterval)
						{
							thresholdListenerInfo.InInterval = flag;
							try
							{
								thresholdListenerInfo.Func(attrId, flag, ratio);
							}
							catch (Exception ex2)
							{
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.Event;
								ELogAuthor author2 = ELogAuthor.ZQR;
								string message2 = "队伍属性回调异常";
								Exception error2 = ex2;
								<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("attrId", attrId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("inInterval", flag);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ratio", ratio);
								instance2.ErrorWithStack(module2, author2, message2, error2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x001360CC File Offset: 0x001342CC
	private void ClearListeners()
	{
		this.ValueListeners.Clear();
		this.ThresholdListeners.Clear();
		this.MaxListeners.Clear();
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x001360EF File Offset: 0x001342EF
	public void AddValueListener(EFormationAttributeId attrId, TValueListener listener, [Nullable(2)] string profileLabel = null)
	{
		if (!this.ValueListeners.ContainsKey(attrId))
		{
			this.ValueListeners[attrId] = new HashSet<TValueListener>();
		}
		this.ValueListeners[attrId].Add(listener);
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x00136123 File Offset: 0x00134323
	public void RemoveValueListener(EFormationAttributeId attrId, TValueListener listener)
	{
		if (this.ValueListeners.ContainsKey(attrId))
		{
			HashSet<TValueListener> hashSet = this.ValueListeners[attrId];
			hashSet.Remove(listener);
			if (hashSet.Count == 0)
			{
				this.ValueListeners.Remove(attrId);
			}
		}
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x0013615C File Offset: 0x0013435C
	public unsafe void AddThresholdListener(EFormationAttributeId attrId, TThresholdListener listener, float maxLimit, float minLimit, [Nullable(2)] string profileLabel = null)
	{
		if (maxLimit < minLimit)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.ZQR;
			string message = "尝试添加的阈值监听器上限小于下限";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("attrId", attrId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("区间上限", maxLimit);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("区间下限", minLimit);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (!this.ThresholdListeners.ContainsKey(attrId))
		{
			this.ThresholdListeners[attrId] = new List<IThresholdListenerInfo>();
		}
		List<IThresholdListenerInfo> list = this.ThresholdListeners[attrId];
		bool flag = false;
		using (List<IThresholdListenerInfo>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Func == listener)
				{
					flag = true;
					break;
				}
			}
		}
		if (!flag)
		{
			float ratio = this.GetRatio(attrId);
			bool inInterval = ratio >= minLimit && ratio <= maxLimit;
			list.Add(new ThresholdListenerInfo
			{
				Func = listener,
				Max = maxLimit,
				Min = minLimit,
				InInterval = inInterval
			});
		}
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x001362AC File Offset: 0x001344AC
	public void RemoveThresholdListener(EFormationAttributeId attrId, TThresholdListener listener)
	{
		if (!this.ThresholdListeners.ContainsKey(attrId))
		{
			return;
		}
		List<IThresholdListenerInfo> list = this.ThresholdListeners[attrId];
		int num = list.FindIndex((IThresholdListenerInfo info) => info.Func == listener);
		if (num >= 0)
		{
			list.RemoveAt(num);
		}
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x00136300 File Offset: 0x00134500
	public void AddMaxListener(EFormationAttributeId attrId, TValueListener listener, [Nullable(2)] string profileLabel = null)
	{
		if (!this.MaxListeners.ContainsKey(attrId))
		{
			this.MaxListeners[attrId] = new HashSet<TValueListener>();
		}
		this.MaxListeners[attrId].Add(listener);
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x00136334 File Offset: 0x00134534
	public void RemoveMaxListener(EFormationAttributeId attrId, TValueListener listener)
	{
		if (this.MaxListeners.ContainsKey(attrId))
		{
			this.MaxListeners[attrId].Remove(listener);
		}
	}

	// Token: 0x1700079C RID: 1948
	// (get) Token: 0x06003425 RID: 13349 RVA: 0x00136357 File Offset: 0x00134557
	public static FormationAttributeController Instance
	{
		get
		{
			return FormationAttributeController._Instance;
		}
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x0013635E File Offset: 0x0013455E
	public static FormationAttributeController GetOrCreateInstance()
	{
		if (FormationAttributeController._Instance == null)
		{
			FormationAttributeController.CreateInstance();
		}
		return FormationAttributeController._Instance;
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x00136372 File Offset: 0x00134572
	public static bool CreateInstance()
	{
		if (FormationAttributeController._Instance != null)
		{
			return true;
		}
		FormationAttributeController._Instance = new FormationAttributeController();
		return true;
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x00136388 File Offset: 0x00134588
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x0013638A File Offset: 0x0013458A
	public static void ResetStaticDefaultValue()
	{
		FormationAttributeController._Instance = null;
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x00136392 File Offset: 0x00134592
	static FormationAttributeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationAttributeController.CreateStaticDefaultValue), new Action(FormationAttributeController.ResetStaticDefaultValue));
	}

	// Token: 0x04002CA1 RID: 11425
	[Nullable(2)]
	protected IReadOnlyList<FormationProperty> ConfigList;

	// Token: 0x04002CA2 RID: 11426
	public Dictionary<EFormationAttributeId, Dictionary<string, ISpeedModifier>> SpeedModifiers = new Dictionary<EFormationAttributeId, Dictionary<string, ISpeedModifier>>();

	// Token: 0x04002CA3 RID: 11427
	public Dictionary<EFormationAttributeId, Dictionary<string, IMaxModifier>> MaxModifiers = new Dictionary<EFormationAttributeId, Dictionary<string, IMaxModifier>>();

	// Token: 0x04002CA4 RID: 11428
	protected HashSet<string> PauseLocks = new HashSet<string>();

	// Token: 0x04002CA5 RID: 11429
	protected readonly Dictionary<string, float> PauseRateLocks = new Dictionary<string, float>();

	// Token: 0x04002CA6 RID: 11430
	private readonly Dictionary<EFormationAttributeId, BaseTagComponent.TTagSwitchedCallback> CheckTagCallbacks = new Dictionary<EFormationAttributeId, BaseTagComponent.TTagSwitchedCallback>();

	// Token: 0x04002CA7 RID: 11431
	private readonly Dictionary<EFormationAttributeId, float> AttributeCache = new Dictionary<EFormationAttributeId, float>();

	// Token: 0x04002CA8 RID: 11432
	private readonly Dictionary<EFormationAttributeId, HashSet<TValueListener>> ValueListeners = new Dictionary<EFormationAttributeId, HashSet<TValueListener>>();

	// Token: 0x04002CA9 RID: 11433
	private readonly Dictionary<EFormationAttributeId, List<IThresholdListenerInfo>> ThresholdListeners = new Dictionary<EFormationAttributeId, List<IThresholdListenerInfo>>();

	// Token: 0x04002CAA RID: 11434
	private readonly Dictionary<EFormationAttributeId, HashSet<TValueListener>> MaxListeners = new Dictionary<EFormationAttributeId, HashSet<TValueListener>>();

	// Token: 0x04002CAB RID: 11435
	[Nullable(2)]
	private static FormationAttributeController _Instance;
}
