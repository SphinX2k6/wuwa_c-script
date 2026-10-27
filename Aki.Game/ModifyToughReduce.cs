using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F48 RID: 12104
[NullableContext(1)]
[Nullable(0)]
public class ModifyToughReduce : BuffEffect
{
	// Token: 0x06019C4A RID: 105546 RVA: 0x006B787C File Offset: 0x006B5A7C
	public ModifyToughReduce(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C4B RID: 105547 RVA: 0x006B7898 File Offset: 0x006B5A98
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.ModifyRate = float.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x06019C4C RID: 105548 RVA: 0x006B78C4 File Offset: 0x006B5AC4
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

	// Token: 0x06019C4D RID: 105549 RVA: 0x006B79A8 File Offset: 0x006B5BA8
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C4E RID: 105550 RVA: 0x006B79AC File Offset: 0x006B5BAC
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

	// Token: 0x06019C4F RID: 105551 RVA: 0x006B7A84 File Offset: 0x006B5C84
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

	// Token: 0x06019C50 RID: 105552 RVA: 0x006B7C1C File Offset: 0x006B5E1C
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

	// Token: 0x0400C23E RID: 49726
	protected float ModifyRate;

	// Token: 0x0400C23F RID: 49727
	protected Dictionary<int, int> EntityModifierMap = new Dictionary<int, int>();
}
