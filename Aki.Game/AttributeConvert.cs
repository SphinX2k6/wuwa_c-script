using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200244E RID: 9294
[NullableContext(1)]
[Nullable(0)]
public class AttributeConvert : BuffEffect
{
	// Token: 0x06017415 RID: 95253 RVA: 0x006D664C File Offset: 0x006D484C
	public AttributeConvert(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017416 RID: 95254 RVA: 0x006D6670 File Offset: 0x006D4870
	protected unsafe override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		float[] extraEffectGrowParameters = parameters.ExtraEffectGrowParameters1;
		float[] extraEffectGrowParameters2 = parameters.ExtraEffectGrowParameters2;
		int level = this.Level;
		this.ListenAttrId = (EAttributeType)int.Parse(extraEffectParameters_[0]);
		this.TargetAttrId = (EAttributeType)int.Parse(extraEffectParameters_[1]);
		this.IsPerTenThousand = (int.Parse(extraEffectParameters_[2]) == 1);
		if (this.IsPerTenThousand)
		{
			EAttributeType listenAttrMaxId;
			if (CharacterAttributeTypes.attributeIdsWithMax.TryGetValue(this.ListenAttrId, out listenAttrMaxId))
			{
				this.ListenAttrMaxId = listenAttrMaxId;
			}
			else
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
				Entity ownerEntity = base.OwnerEntity;
				string message = "属性转换额外效果监听属性为万分比时，监听属性没有对应的最大值属性";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.ActiveHandleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buff Id", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("instigator id", this.InstigatorEntityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("属性Id", this.ListenAttrId);
				instance.Error(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}
		}
		int listenType = 0;
		if (extraEffectParameters_.Length > 3)
		{
			int.TryParse(extraEffectParameters_[3], out listenType);
		}
		this.ListenType = (EAttributeConvertListenType)listenType;
		int num = 0;
		if (extraEffectParameters_.Length > 4)
		{
			int.TryParse(extraEffectParameters_[4], out num);
		}
		this.ListenAbsoluteValue = (num == 1);
		this.Rate = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters, level, -1f) * 0.0001f;
		this.Offset = AbilityUtils.GetLevelValue<float>(extraEffectGrowParameters2, level, -1f);
	}

	// Token: 0x06017417 RID: 95255 RVA: 0x006D6808 File Offset: 0x006D4A08
	public override void OnCreated()
	{
		if (this.IsPerTenThousand && this.ListenAttrMaxId == EAttributeType.None)
		{
			return;
		}
		BaseBuffComponent baseBuffComponent = base.ExactOwnerEntity.CheckGetComponent<BaseBuffComponent>();
		foreach (BaseAttributeComponent baseAttributeComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseAttributeComponent>(EComponent.BaseAttributeComponent, null) : null) ?? new List<BaseAttributeComponent>()))
		{
			Entity entity = baseAttributeComponent.Entity;
			Action<EAttributeType, float, float> action = delegate(EAttributeType attributeId, float newValue, float oldValue)
			{
				this.OnAttributeChanged(entity, attributeId, newValue, oldValue);
			};
			baseAttributeComponent.AddListener(this.ListenAttrId, action, "ExtraEffectAttributeEvent");
			this.EntityListenerMap[entity] = action;
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017418 RID: 95256 RVA: 0x006D6904 File Offset: 0x006D4B04
	public override void OnRemoved(bool bPremature)
	{
		BaseBuffComponent baseBuffComponent = base.ExactOwnerEntity.CheckGetComponent<BaseBuffComponent>();
		foreach (BaseAttributeComponent baseAttributeComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseAttributeComponent>(EComponent.BaseAttributeComponent, null) : null) ?? new List<BaseAttributeComponent>()))
		{
			Entity entity = baseAttributeComponent.Entity;
			Action<EAttributeType, float, float> callback;
			if (this.EntityListenerMap.TryGetValue(entity, out callback))
			{
				baseAttributeComponent.RemoveListener(this.ListenAttrId, callback);
				this.EntityListenerMap.Remove(entity);
			}
		}
		if (this.EntityListenerMap.Count > 0)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Buff, (baseBuffComponent != null) ? baseBuffComponent.Entity : null, "额外效果AttributeConvert有遗留的监听未释放", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (KeyValuePair<Entity, Action<EAttributeType, float, float>> keyValuePair in this.EntityListenerMap)
			{
				Entity key = keyValuePair.Key;
				Action<EAttributeType, float, float> value = keyValuePair.Value;
				BaseAttributeComponent baseAttributeComponent2 = key.CheckGetComponent<BaseAttributeComponent>();
				if (baseAttributeComponent2 != null)
				{
					baseAttributeComponent2.RemoveListener(this.ListenAttrId, value);
				}
			}
		}
		this.EntityListenerMap.Clear();
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017419 RID: 95257 RVA: 0x006D6A80 File Offset: 0x006D4C80
	[return: Nullable(2)]
	public unsafe override object OnExecute(params object[] parameters)
	{
		if (parameters.Length >= 2)
		{
			Entity entity = parameters[0] as Entity;
			if (entity != null)
			{
				object obj = parameters[1];
				float num2;
				if (obj is float)
				{
					float num = (float)obj;
					num2 = num;
				}
				else if (obj is double)
				{
					double num3 = (double)obj;
					num2 = (float)num3;
				}
				else
				{
					if (!(obj is int))
					{
						return null;
					}
					int num4 = (int)obj;
					num2 = (float)num4;
				}
				BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
				if (component == null)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
					Entity ownerEntity = base.OwnerEntity;
					string message = "属性转换额外效果没有找到属性组件";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.ActiveHandleId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buff Id", this.BuffId);
					instance.Error(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return null;
				}
				float num5 = this.ListenAbsoluteValue ? Math.Abs(num2) : num2;
				if (this.IsPerTenThousand)
				{
					num5 = num5 / component.GetCurrentValue(this.ListenAttrMaxId) * 10000f;
				}
				float value = this.Rate * num5 + this.Offset;
				component.AddBaseValue(this.TargetAttrId, value);
				return null;
			}
		}
		return null;
	}

	// Token: 0x0601741A RID: 95258 RVA: 0x006D6BBC File Offset: 0x006D4DBC
	private unsafe void OnAttributeChanged(Entity entity, EAttributeType attributeId, float newValue, float oldValue)
	{
		if (this.OwnerBuffComponent == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity ownerEntity = base.OwnerEntity;
			string message = "属性转换额外效果没有找到buff组件";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", this.ActiveHandleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buff Id", this.BuffId);
			instance.Error(flag, ownerEntity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		float num = newValue - oldValue;
		if (this.ListenType == EAttributeConvertListenType.IncreaseOnly && num <= 0f)
		{
			return;
		}
		if (this.ListenType == EAttributeConvertListenType.DecreaseOnly && num >= 0f)
		{
			return;
		}
		base.TryExecute(new Partial_RequirementPayload(), this.OwnerBuffComponent, new object[]
		{
			entity,
			num
		});
	}

	// Token: 0x0601741B RID: 95259 RVA: 0x006D6C8C File Offset: 0x006D4E8C
	private void OnChangeTeam()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<Entity, Action<EAttributeType, float, float>> keyValuePair in this.EntityListenerMap)
		{
			list.Add(keyValuePair.Key.Id);
		}
		foreach (int id in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, true))
		{
			CharacterModel instance = CharacterModel.Instance;
			BaseAttributeComponent baseAttributeComponent;
			if (instance == null)
			{
				baseAttributeComponent = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(id);
				if (handle == null)
				{
					baseAttributeComponent = null;
				}
				else
				{
					WorldEntity entity4 = handle.Entity;
					baseAttributeComponent = ((entity4 != null) ? entity4.CheckGetComponent<BaseAttributeComponent>() : null);
				}
			}
			BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
			if (baseAttributeComponent2 != null)
			{
				Entity entity = baseAttributeComponent2.Entity;
				Action<EAttributeType, float, float> action = delegate(EAttributeType attributeId, float newValue, float oldValue)
				{
					this.OnAttributeChanged(entity, attributeId, newValue, oldValue);
				};
				baseAttributeComponent2.AddListener(this.ListenAttrId, action, "ExtraEffectAttributeEvent");
				this.EntityListenerMap[entity] = action;
			}
		}
		foreach (int id2 in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, false))
		{
			CharacterModel instance2 = CharacterModel.Instance;
			BaseAttributeComponent baseAttributeComponent3;
			if (instance2 == null)
			{
				baseAttributeComponent3 = null;
			}
			else
			{
				EntityHandle handle2 = instance2.GetHandle(id2);
				if (handle2 == null)
				{
					baseAttributeComponent3 = null;
				}
				else
				{
					WorldEntity entity2 = handle2.Entity;
					baseAttributeComponent3 = ((entity2 != null) ? entity2.CheckGetComponent<BaseAttributeComponent>() : null);
				}
			}
			BaseAttributeComponent baseAttributeComponent4 = baseAttributeComponent3;
			if (baseAttributeComponent4 != null)
			{
				Entity entity3 = baseAttributeComponent4.Entity;
				Action<EAttributeType, float, float> callback;
				if (this.EntityListenerMap.TryGetValue(entity3, out callback))
				{
					baseAttributeComponent4.RemoveListener(this.ListenAttrId, callback);
				}
				this.EntityListenerMap.Remove(entity3);
			}
		}
	}

	// Token: 0x0601741C RID: 95260 RVA: 0x006D6E60 File Offset: 0x006D5060
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C469 RID: 50281
	private EAttributeType ListenAttrId;

	// Token: 0x0400C46A RID: 50282
	private EAttributeType ListenAttrMaxId;

	// Token: 0x0400C46B RID: 50283
	private EAttributeType TargetAttrId;

	// Token: 0x0400C46C RID: 50284
	private bool IsPerTenThousand;

	// Token: 0x0400C46D RID: 50285
	private EAttributeConvertListenType ListenType = EAttributeConvertListenType.All;

	// Token: 0x0400C46E RID: 50286
	private bool ListenAbsoluteValue;

	// Token: 0x0400C46F RID: 50287
	private float Rate;

	// Token: 0x0400C470 RID: 50288
	private float Offset;

	// Token: 0x0400C471 RID: 50289
	private readonly Dictionary<Entity, Action<EAttributeType, float, float>> EntityListenerMap = new Dictionary<Entity, Action<EAttributeType, float, float>>();
}
