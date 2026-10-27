using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F68 RID: 12136
[NullableContext(1)]
[Nullable(0)]
public class ConvertShieldAttribute : BuffEffect
{
	// Token: 0x06019CF1 RID: 105713 RVA: 0x006BB126 File Offset: 0x006B9326
	public ConvertShieldAttribute(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CF2 RID: 105714 RVA: 0x006BB14C File Offset: 0x006B934C
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			return;
		}
		this.BuffHolderType = new int?((extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0]) : 0);
		this.ShieldId = ((extraEffectParameters_.Length > 1) ? int.Parse(extraEffectParameters_[1]) : 0);
		this.AttributeId = (EAttributeType)((extraEffectParameters_.Length > 2) ? int.Parse(extraEffectParameters_[2]) : 0);
		this.CompareFactor = ((extraEffectParameters_.Length > 3) ? float.Parse(extraEffectParameters_[3]) : 0f);
		this.ConvertThreshold = ((extraEffectParameters_.Length > 4) ? float.Parse(extraEffectParameters_[4]) : 0f);
		this.ConvertLimit = ((extraEffectParameters_.Length > 5) ? float.Parse(extraEffectParameters_[5]) : 0f);
		this.ConvertMagnitude = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		this.ConvertRatio = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
	}

	// Token: 0x06019CF3 RID: 105715 RVA: 0x006BB235 File Offset: 0x006B9435
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CF4 RID: 105716 RVA: 0x006BB238 File Offset: 0x006B9438
	public override void OnCreated()
	{
		BaseBuffComponent baseBuffComponent = base.ExactOwnerEntity.CheckGetComponent<BaseBuffComponent>();
		foreach (CharacterShieldComponent characterShieldComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<CharacterShieldComponent>(EComponent.CharacterShieldComponent, null) : null) ?? new List<CharacterShieldComponent>()))
		{
			this.AddShieldListenerForEntity(characterShieldComponent.Entity);
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06019CF5 RID: 105717 RVA: 0x006BB2E0 File Offset: 0x006B94E0
	private void AddShieldListenerForEntity(Entity entity)
	{
		Action<float> action = delegate(float shield)
		{
			this.OnShieldChanged(entity, shield);
		};
		EventSystem.Instance.AddWithTarget<float>(entity, EEventName.CharShieldChange, action);
		this.EntityShieldListenerMap[entity] = action;
		this.AddShieldAttributeModifier(entity);
	}

	// Token: 0x06019CF6 RID: 105718 RVA: 0x006BB340 File Offset: 0x006B9540
	private void OnShieldChanged(Entity entity, float shield)
	{
		this.RemoveShieldAttributeModifier(entity);
		this.AddShieldAttributeModifier(entity);
	}

	// Token: 0x06019CF7 RID: 105719 RVA: 0x006BB350 File Offset: 0x006B9550
	private void AddShieldAttributeModifier(Entity inEntity)
	{
		int? buffHolderType = this.BuffHolderType;
		int num = 0;
		Entity entity;
		if (buffHolderType.GetValueOrDefault() == num & buffHolderType != null)
		{
			entity = inEntity;
		}
		else
		{
			EntityHandle instigatorEntity = base.InstigatorEntity;
			entity = ((instigatorEntity != null) ? instigatorEntity.Entity : null);
		}
		Entity entity2 = entity;
		if (entity2 != null)
		{
			CharacterShieldComponent characterShieldComponent = entity2.CheckGetComponent<CharacterShieldComponent>();
			BaseAttributeComponent baseAttributeComponent = inEntity.CheckGetComponent<BaseAttributeComponent>();
			float num2 = (characterShieldComponent != null) ? characterShieldComponent.GetShieldValue(this.ShieldId) : 0f;
			bool flag = num2 >= this.ConvertThreshold;
			float num3 = num2;
			if (this.ConvertLimit > 0f)
			{
				num3 = Math.Min(num3, this.ConvertLimit);
			}
			if (this.CompareFactor > 0f)
			{
				float num4 = (baseAttributeComponent != null) ? baseAttributeComponent.GetCurrentValue((EAttributeType)this.CompareFactor) : 0f;
				flag = (num2 >= num4 * this.ConvertThreshold * 0.0001f);
				if (this.ConvertLimit > 0f)
				{
					num3 = Math.Min(num2, num4 * this.ConvertLimit * 0.0001f);
				}
			}
			float num5 = num3 * this.ConvertRatio * 0.0001f + this.ConvertMagnitude;
			if (flag && num5 != 0f)
			{
				int value = (baseAttributeComponent != null) ? baseAttributeComponent.AddModifier(this.AttributeId, new CharacterAttributeTypes.AttributeModifier
				{
					Type = ECalculationPolicyType.AddValue,
					Value1 = num5
				}) : 0;
				this.EntityModifierMap[inEntity] = value;
			}
		}
	}

	// Token: 0x06019CF8 RID: 105720 RVA: 0x006BB4A8 File Offset: 0x006B96A8
	private void RemoveShieldAttributeModifier(Entity inEntity)
	{
		int num;
		if (!this.EntityModifierMap.TryGetValue(inEntity, out num) || num == 0)
		{
			return;
		}
		BaseAttributeComponent baseAttributeComponent = inEntity.CheckGetComponent<BaseAttributeComponent>();
		if (baseAttributeComponent != null)
		{
			baseAttributeComponent.RemoveModifier(this.AttributeId, num);
		}
		this.EntityModifierMap.Remove(inEntity);
	}

	// Token: 0x06019CF9 RID: 105721 RVA: 0x006BB4F0 File Offset: 0x006B96F0
	public override void OnRemoved(bool bPremature)
	{
		BaseBuffComponent baseBuffComponent = base.ExactOwnerEntity.CheckGetComponent<BaseBuffComponent>();
		foreach (CharacterShieldComponent characterShieldComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<CharacterShieldComponent>(EComponent.CharacterShieldComponent, null) : null) ?? new List<CharacterShieldComponent>()))
		{
			Entity entity = characterShieldComponent.Entity;
			Action<float> handle;
			if (this.EntityShieldListenerMap.TryGetValue(entity, out handle))
			{
				EventSystem.Instance.RemoveWithTarget<float>(entity, EEventName.CharShieldChange, handle);
			}
			this.RemoveShieldAttributeModifier(entity);
			this.EntityShieldListenerMap.Remove(entity);
		}
		if (this.EntityShieldListenerMap.Count > 0)
		{
			CombatLog.Instance.Error(CombatLog.EDebugModule.Buff, (baseBuffComponent != null) ? baseBuffComponent.Entity : null, "额外效果ConvertShieldAttribute有遗留的监听未释放", default(ReadOnlySpan<ValueTuple<string, object>>));
			foreach (KeyValuePair<Entity, Action<float>> keyValuePair in this.EntityShieldListenerMap)
			{
				EventSystem.Instance.RemoveWithTarget<float>(keyValuePair.Key, EEventName.CharShieldChange, keyValuePair.Value);
			}
		}
		this.EntityShieldListenerMap.Clear();
		this.EntityModifierMap.Clear();
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06019CFA RID: 105722 RVA: 0x006BB664 File Offset: 0x006B9864
	private void OnChangeTeam()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<Entity, Action<float>> keyValuePair in this.EntityShieldListenerMap)
		{
			list.Add(keyValuePair.Key.Id);
		}
		foreach (int id in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, true))
		{
			CharacterModel instance = CharacterModel.Instance;
			WorldEntity worldEntity;
			if (instance == null)
			{
				worldEntity = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(id);
				worldEntity = ((handle != null) ? handle.Entity : null);
			}
			WorldEntity worldEntity2 = worldEntity;
			if (worldEntity2 != null)
			{
				this.AddShieldListenerForEntity(worldEntity2);
			}
		}
		foreach (int id2 in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, false))
		{
			CharacterModel instance2 = CharacterModel.Instance;
			WorldEntity worldEntity3;
			if (instance2 == null)
			{
				worldEntity3 = null;
			}
			else
			{
				EntityHandle handle2 = instance2.GetHandle(id2);
				worldEntity3 = ((handle2 != null) ? handle2.Entity : null);
			}
			WorldEntity worldEntity4 = worldEntity3;
			if (worldEntity4 != null)
			{
				Action<float> handle3;
				if (this.EntityShieldListenerMap.TryGetValue(worldEntity4, out handle3))
				{
					EventSystem.Instance.RemoveWithTarget<float>(worldEntity4, EEventName.CharShieldChange, handle3);
				}
				this.RemoveShieldAttributeModifier(worldEntity4);
				this.EntityShieldListenerMap.Remove(worldEntity4);
			}
		}
	}

	// Token: 0x0400C2B0 RID: 49840
	private int? BuffHolderType;

	// Token: 0x0400C2B1 RID: 49841
	private int ShieldId;

	// Token: 0x0400C2B2 RID: 49842
	private EAttributeType AttributeId;

	// Token: 0x0400C2B3 RID: 49843
	private float CompareFactor;

	// Token: 0x0400C2B4 RID: 49844
	private float ConvertThreshold;

	// Token: 0x0400C2B5 RID: 49845
	private float ConvertLimit;

	// Token: 0x0400C2B6 RID: 49846
	private float ConvertMagnitude;

	// Token: 0x0400C2B7 RID: 49847
	private float ConvertRatio;

	// Token: 0x0400C2B8 RID: 49848
	private readonly Dictionary<Entity, int> EntityModifierMap = new Dictionary<Entity, int>();

	// Token: 0x0400C2B9 RID: 49849
	private readonly Dictionary<Entity, Action<float>> EntityShieldListenerMap = new Dictionary<Entity, Action<float>>();
}
