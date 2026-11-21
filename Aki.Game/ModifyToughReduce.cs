using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x0200249B RID: 9371
[NullableContext(1)]
[Nullable(0)]
public class ModifyToughReduce : BuffEffect
{
	// Token: 0x06017555 RID: 95573 RVA: 0x006DDB98 File Offset: 0x006DBD98
	public ModifyToughReduce(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017556 RID: 95574 RVA: 0x006DDBB4 File Offset: 0x006DBDB4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.ModifyRate = float.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x06017557 RID: 95575 RVA: 0x006DDBE0 File Offset: 0x006DBDE0
	public override void OnCreated()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		foreach (BaseAttributeComponent baseAttributeComponent in (((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseAttributeComponent>(EComponent.BaseAttributeComponent, null) : null) ?? new List<BaseAttributeComponent>()))
		{
			if (baseAttributeComponent != null)
			{
				Entity entity = baseAttributeComponent.Entity;
				int value = baseAttributeComponent.AddModifier(EAttributeType.ToughReduce, new CharacterAttributeTypes.AttributeModifier
				{
					Type = ECalculationPolicyType.AdvancedMultiplyMagnitude1,
					Value1 = this.ModifyRate
				});
				this.EntityModifierMap[entity.Id] = value;
			}
		}
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
	}

	// Token: 0x06017558 RID: 95576 RVA: 0x006DDCC4 File Offset: 0x006DBEC4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017559 RID: 95577 RVA: 0x006DDCC8 File Offset: 0x006DBEC8
	public override void OnRemoved(bool bPremature)
	{
		foreach (KeyValuePair<int, int> keyValuePair in this.EntityModifierMap)
		{
			CharacterModel instance = CharacterModel.Instance;
			BaseAttributeComponent baseAttributeComponent;
			if (instance == null)
			{
				baseAttributeComponent = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(keyValuePair.Key);
				if (handle == null)
				{
					baseAttributeComponent = null;
				}
				else
				{
					WorldEntity entity = handle.Entity;
					baseAttributeComponent = ((entity != null) ? entity.CheckGetComponent<BaseAttributeComponent>() : null);
				}
			}
			BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
			if (baseAttributeComponent2 != null)
			{
				baseAttributeComponent2.RemoveModifier(EAttributeType.ToughReduce, keyValuePair.Value);
			}
		}
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		if (baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent())
		{
			EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnChangeTeam));
		}
		this.EntityModifierMap.Clear();
	}

	// Token: 0x0601755A RID: 95578 RVA: 0x006DDDA0 File Offset: 0x006DBFA0
	private void OnChangeTeam()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, int> keyValuePair in this.EntityModifierMap)
		{
			list.Add(keyValuePair.Key);
		}
		foreach (int num in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, true))
		{
			CharacterModel instance = CharacterModel.Instance;
			BaseAttributeComponent baseAttributeComponent;
			if (instance == null)
			{
				baseAttributeComponent = null;
			}
			else
			{
				EntityHandle handle = instance.GetHandle(num);
				if (handle == null)
				{
					baseAttributeComponent = null;
				}
				else
				{
					WorldEntity entity = handle.Entity;
					baseAttributeComponent = ((entity != null) ? entity.CheckGetComponent<BaseAttributeComponent>() : null);
				}
			}
			BaseAttributeComponent baseAttributeComponent2 = baseAttributeComponent;
			if (baseAttributeComponent2 != null)
			{
				int value = baseAttributeComponent2.AddModifier(EAttributeType.ToughReduce, new CharacterAttributeTypes.AttributeModifier
				{
					Type = ECalculationPolicyType.AdvancedMultiplyMagnitude1,
					Value1 = this.ModifyRate
				});
				this.EntityModifierMap[num] = value;
			}
		}
		foreach (int num2 in BaseBuffComponent.GetNewOrRemoveTeamEntityIds(list, false))
		{
			CharacterModel instance2 = CharacterModel.Instance;
			BaseAttributeComponent baseAttributeComponent3;
			if (instance2 == null)
			{
				baseAttributeComponent3 = null;
			}
			else
			{
				EntityHandle handle2 = instance2.GetHandle(num2);
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
			int handle3;
			if (baseAttributeComponent4 != null && this.EntityModifierMap.TryGetValue(num2, out handle3))
			{
				baseAttributeComponent4.RemoveModifier(EAttributeType.ToughReduce, handle3);
			}
			this.EntityModifierMap.Remove(num2);
		}
	}

	// Token: 0x0601755B RID: 95579 RVA: 0x006DDF38 File Offset: 0x006DC138
	public override string GetDebugEffectString()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 2);
		defaultInterpolatedStringHandler.AppendFormatted((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff");
		defaultInterpolatedStringHandler.AppendLiteral(",修改韧性扣减率");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.ModifyRate * 100f, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("%");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C5E0 RID: 50656
	protected float ModifyRate;

	// Token: 0x0400C5E1 RID: 50657
	protected Dictionary<int, int> EntityModifierMap = new Dictionary<int, int>();
}
