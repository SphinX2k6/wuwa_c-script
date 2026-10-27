using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F88 RID: 12168
[NullableContext(1)]
[Nullable(0)]
public class AddEnergyExecution : PeriodExecution
{
	// Token: 0x06019D8B RID: 105867 RVA: 0x006BECAF File Offset: 0x006BCEAF
	public AddEnergyExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D8C RID: 105868 RVA: 0x006BECB8 File Offset: 0x006BCEB8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.AddValue = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
	}

	// Token: 0x06019D8D RID: 105869 RVA: 0x006BECD8 File Offset: 0x006BCED8
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		BaseAttributeComponent baseAttributeComponent = (ownerBuffComponent != null) ? ownerBuffComponent.GetAttributeComponent() : null;
		if (baseAttributeComponent == null)
		{
			return null;
		}
		float num = baseAttributeComponent.GetCurrentValue(EAttributeType.EnergyEfficiency) / 10000f;
		EAttributeType attrId = EAttributeType.Energy;
		float addValue = this.AddValue;
		float value = addValue * num;
		baseAttributeComponent.AddBaseValue(attrId, value);
		Entity entity = baseAttributeComponent.Entity;
		bool flag;
		if (entity == null)
		{
			flag = false;
		}
		else
		{
			CharacterUnifiedStateComponent characterUnifiedStateComponent = entity.CheckGetComponent<CharacterUnifiedStateComponent>();
			flag = ((characterUnifiedStateComponent != null) ? characterUnifiedStateComponent.IsInGame : null).GetValueOrDefault();
		}
		if (flag)
		{
			int num2 = 0;
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
			{
				CharacterUnifiedStateComponent characterUnifiedStateComponent2;
				if (entityHandle == null)
				{
					characterUnifiedStateComponent2 = null;
				}
				else
				{
					WorldEntity entity2 = entityHandle.Entity;
					characterUnifiedStateComponent2 = ((entity2 != null) ? entity2.CheckGetComponent<CharacterUnifiedStateComponent>() : null);
				}
				CharacterUnifiedStateComponent characterUnifiedStateComponent3 = characterUnifiedStateComponent2;
				BaseAttributeComponent baseAttributeComponent2;
				if (entityHandle == null)
				{
					baseAttributeComponent2 = null;
				}
				else
				{
					WorldEntity entity3 = entityHandle.Entity;
					baseAttributeComponent2 = ((entity3 != null) ? entity3.CheckGetComponent<BaseAttributeComponent>() : null);
				}
				BaseAttributeComponent baseAttributeComponent3 = baseAttributeComponent2;
				if (characterUnifiedStateComponent3 != null && !characterUnifiedStateComponent3.IsInGame.GetValueOrDefault() && baseAttributeComponent3 != null)
				{
					float num3 = baseAttributeComponent3.GetCurrentValue(EAttributeType.EnergyEfficiency) / 10000f;
					float num4 = addValue * num3;
					baseAttributeComponent3.AddBaseValue(attrId, num4 * (float)num2);
				}
			}
		}
		return null;
	}

	// Token: 0x0400C32F RID: 49967
	public float AddValue;
}
