using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

// Token: 0x02000F03 RID: 3843
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class FormationAttributeController : ControllerBase
{
	// Token: 0x06006067 RID: 24679 RVA: 0x0012CA7C File Offset: 0x0012AC7C
	protected override bool OnInit()
	{
		this.ConfigList = ConfigFormationPropertyAll.GetConfigList(true);
		Net.Instance.Register(ENotifyMessageId.FormationAttrNotify, new Action<IMessage, Net.CallbackStatus>(this.FormationAttrNotify));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		return true;
	}

	// Token: 0x06006068 RID: 24680 RVA: 0x0012CAD0 File Offset: 0x0012ACD0
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

	// Token: 0x06006069 RID: 24681 RVA: 0x0012CB2C File Offset: 0x0012AD2C
	protected override bool OnClear()
	{
		this.ClearListeners();
		this.PauseLocks.Clear();
		this.PauseRateLocks.Clear();
		Net.Instance.UnRegister(ENotifyMessageId.FormationAttrNotify);
		return true;
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x0012CB5C File Offset: 0x0012AD5C
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

	// Token: 0x0600606B RID: 24683 RVA: 0x0012CC30 File Offset: 0x0012AE30
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

	// Token: 0x0600606C RID: 24684 RVA: 0x0012CCC8 File Offset: 0x0012AEC8
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

	// Token: 0x0600606D RID: 24685 RVA: 0x0012CD0C File Offset: 0x0012AF0C
	public void AddValue(EFormationAttributeId attrId, float value)
	{
		if (!this.HasAuthority(attrId))
		{
			return;
		}
		this.SetValue(attrId, this.Model.GetValue(attrId) + value);
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x0012CD2D File Offset: 0x0012AF2D
	public float GetValue(EFormationAttributeId attrId)
	{
		if (this.AttributeCache.ContainsKey(attrId))
		{
			return this.AttributeCache[attrId];
		}
		return this.Model.GetValue(attrId);
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x0012CD56 File Offset: 0x0012AF56
	public float GetMax(EFormationAttributeId attrId)
	{
		return this.Model.GetMax(attrId);
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x0012CD64 File Offset: 0x0012AF64
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

	// Token: 0x06006071 RID: 24689 RVA: 0x0012CDBD File Offset: 0x0012AFBD
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

	// Token: 0x06006072 RID: 24690 RVA: 0x0012CDFC File Offset: 0x0012AFFC
	public float GetBaseMax(EFormationAttributeId attrId)
	{
		return this.Model.GetBaseMax(attrId);
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x0012CE0A File Offset: 0x0012B00A
	public float GetSpeed(EFormationAttributeId attrId)
	{
		return this.Model.GetSpeed(attrId);
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x0012CE18 File Offset: 0x0012B018
	public float GetRatio(EFormationAttributeId attrId)
	{
		return this.GetValue(attrId) / this.GetMax(attrId) * 10000f;
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x0012CE30 File Offset: 0x0012B030
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

	// Token: 0x06006076 RID: 24694 RVA: 0x0012CE91 File Offset: 0x0012B091
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

	// Token: 0x06006077 RID: 24695 RVA: 0x0012CED0 File Offset: 0x0012B0D0
	public int AddBoundsLocker(EFormationAttributeId attrId, IBoundsLocker locker, int lockerHandle)
	{
		FormationAttributeModel model = this.Model;
		if (model == null)
		{
			return -1;
		}
		return model.AddBoundsLocker(attrId, locker, lockerHandle);
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x0012CEE6 File Offset: 0x0012B0E6
	public bool RemoveBoundsLocker(EFormationAttributeId attrId, int lockerHandle)
	{
		FormationAttributeModel model = this.Model;
		return model != null && model.RemoveBoundsLocker(attrId, lockerHandle);
	}

	// Token: 0x06006079 RID: 24697 RVA: 0x0012CEFC File Offset: 0x0012B0FC
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

	// Token: 0x0600607A RID: 24698 RVA: 0x0012CF61 File Offset: 0x0012B161
	public void RemovePauseLock(string key)
	{
		this.PauseLocks.Remove(key);
		this.PauseRateLocks.Remove(key);
		this.RefreshAllSpeed();
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x0012CF83 File Offset: 0x0012B183
	public bool IsPaused()
	{
		return this.PauseLocks.Count > 0;
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x0012CF94 File Offset: 0x0012B194
	public float GetPauseRate()
	{
		float num = 1f;
		foreach (float val in this.PauseRateLocks.Values)
		{
			num = Math.Min(num, val);
		}
		return num;
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x0012CFF4 File Offset: 0x0012B1F4
	private bool HasAuthority(EFormationAttributeId attrId)
	{
		return attrId == EFormationAttributeId.Strength || attrId == EFormationAttributeId.MigrationStrength || attrId == EFormationAttributeId.MotorcycleStrength || attrId == EFormationAttributeId.MotorcycleSoarStrength || attrId == EFormationAttributeId.LevelQuickHackRam;
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x0012D010 File Offset: 0x0012B210
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

	// Token: 0x0600607F RID: 24703 RVA: 0x0012D074 File Offset: 0x0012B274
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

	// Token: 0x17000779 RID: 1913
	// (get) Token: 0x06006080 RID: 24704 RVA: 0x0012D1F0 File Offset: 0x0012B3F0
	[Nullable(2)]
	public FormationAttributeModel Model
	{
		[NullableContext(2)]
		get
		{
			return FormationAttributeModel.Instance;
		}
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x0012D1F8 File Offset: 0x0012B3F8
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

	// Token: 0x06006082 RID: 24706 RVA: 0x0012D264 File Offset: 0x0012B464
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

	// Token: 0x06006083 RID: 24707 RVA: 0x0012D2C0 File Offset: 0x0012B4C0
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

	// Token: 0x06006084 RID: 24708 RVA: 0x0012D420 File Offset: 0x0012B620
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

	// Token: 0x06006085 RID: 24709 RVA: 0x0012D50C File Offset: 0x0012B70C
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

	// Token: 0x06006086 RID: 24710 RVA: 0x0012D7C8 File Offset: 0x0012B9C8
	private void ClearListeners()
	{
		this.ValueListeners.Clear();
		this.ThresholdListeners.Clear();
		this.MaxListeners.Clear();
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x0012D7EB File Offset: 0x0012B9EB
	public void AddValueListener(EFormationAttributeId attrId, TValueListener listener, [Nullable(2)] string profileLabel = null)
	{
		if (!this.ValueListeners.ContainsKey(attrId))
		{
			this.ValueListeners[attrId] = new HashSet<TValueListener>();
		}
		this.ValueListeners[attrId].Add(listener);
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x0012D81F File Offset: 0x0012BA1F
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

	// Token: 0x06006089 RID: 24713 RVA: 0x0012D858 File Offset: 0x0012BA58
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

	// Token: 0x0600608A RID: 24714 RVA: 0x0012D9A8 File Offset: 0x0012BBA8
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

	// Token: 0x0600608B RID: 24715 RVA: 0x0012D9FC File Offset: 0x0012BBFC
	public void AddMaxListener(EFormationAttributeId attrId, TValueListener listener, [Nullable(2)] string profileLabel = null)
	{
		if (!this.MaxListeners.ContainsKey(attrId))
		{
			this.MaxListeners[attrId] = new HashSet<TValueListener>();
		}
		this.MaxListeners[attrId].Add(listener);
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x0012DA30 File Offset: 0x0012BC30
	public void RemoveMaxListener(EFormationAttributeId attrId, TValueListener listener)
	{
		if (this.MaxListeners.ContainsKey(attrId))
		{
			this.MaxListeners[attrId].Remove(listener);
		}
	}

	// Token: 0x1700077A RID: 1914
	// (get) Token: 0x0600608D RID: 24717 RVA: 0x0012DA53 File Offset: 0x0012BC53
	public static FormationAttributeController Instance
	{
		get
		{
			return FormationAttributeController._Instance;
		}
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x0012DA5A File Offset: 0x0012BC5A
	public static FormationAttributeController GetOrCreateInstance()
	{
		if (FormationAttributeController._Instance == null)
		{
			FormationAttributeController.CreateInstance();
		}
		return FormationAttributeController._Instance;
	}

	// Token: 0x0600608F RID: 24719 RVA: 0x0012DA6E File Offset: 0x0012BC6E
	public static bool CreateInstance()
	{
		if (FormationAttributeController._Instance != null)
		{
			return true;
		}
		FormationAttributeController._Instance = new FormationAttributeController();
		return true;
	}

	// Token: 0x06006090 RID: 24720 RVA: 0x0012DA84 File Offset: 0x0012BC84
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x0012DA86 File Offset: 0x0012BC86
	public static void ResetStaticDefaultValue()
	{
		FormationAttributeController._Instance = null;
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x0012DA8E File Offset: 0x0012BC8E
	static FormationAttributeController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationAttributeController.CreateStaticDefaultValue), new Action(FormationAttributeController.ResetStaticDefaultValue));
	}

	// Token: 0x04002C08 RID: 11272
	[Nullable(2)]
	protected IReadOnlyList<FormationProperty> ConfigList;

	// Token: 0x04002C09 RID: 11273
	public Dictionary<EFormationAttributeId, Dictionary<string, ISpeedModifier>> SpeedModifiers = new Dictionary<EFormationAttributeId, Dictionary<string, ISpeedModifier>>();

	// Token: 0x04002C0A RID: 11274
	public Dictionary<EFormationAttributeId, Dictionary<string, IMaxModifier>> MaxModifiers = new Dictionary<EFormationAttributeId, Dictionary<string, IMaxModifier>>();

	// Token: 0x04002C0B RID: 11275
	protected HashSet<string> PauseLocks = new HashSet<string>();

	// Token: 0x04002C0C RID: 11276
	protected readonly Dictionary<string, float> PauseRateLocks = new Dictionary<string, float>();

	// Token: 0x04002C0D RID: 11277
	private readonly Dictionary<EFormationAttributeId, BaseTagComponent.TTagSwitchedCallback> CheckTagCallbacks = new Dictionary<EFormationAttributeId, BaseTagComponent.TTagSwitchedCallback>();

	// Token: 0x04002C0E RID: 11278
	private readonly Dictionary<EFormationAttributeId, float> AttributeCache = new Dictionary<EFormationAttributeId, float>();

	// Token: 0x04002C0F RID: 11279
	private readonly Dictionary<EFormationAttributeId, HashSet<TValueListener>> ValueListeners = new Dictionary<EFormationAttributeId, HashSet<TValueListener>>();

	// Token: 0x04002C10 RID: 11280
	private readonly Dictionary<EFormationAttributeId, List<IThresholdListenerInfo>> ThresholdListeners = new Dictionary<EFormationAttributeId, List<IThresholdListenerInfo>>();

	// Token: 0x04002C11 RID: 11281
	private readonly Dictionary<EFormationAttributeId, HashSet<TValueListener>> MaxListeners = new Dictionary<EFormationAttributeId, HashSet<TValueListener>>();

	// Token: 0x04002C12 RID: 11282
	[Nullable(2)]
	private static FormationAttributeController _Instance;
}
