using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F86 RID: 12166
[NullableContext(1)]
[Nullable(0)]
public class ReviveExecution : PeriodExecution
{
	// Token: 0x06019D85 RID: 105861 RVA: 0x006BEAE3 File Offset: 0x006BCCE3
	public ReviveExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D86 RID: 105862 RVA: 0x006BEAEC File Offset: 0x006BCCEC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.HealRate = ((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? (float.Parse(extraEffectParameters_[0]) * 0.0001f) : 0f);
		this.HealValue = ((extraEffectParameters_ != null && extraEffectParameters_.Length > 1) ? float.Parse(extraEffectParameters_[1]) : 0f);
	}

	// Token: 0x06019D87 RID: 105863 RVA: 0x006BEB40 File Offset: 0x006BCD40
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		Entity entity = (ownerBuffComponent != null) ? ownerBuffComponent.GetEntity() : null;
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new int?(component.GetPlayerId()) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		if (SceneTeamModel.Instance.GetCurrentGroupLivingState(valueOrDefault) == ETeamLivingState.Dead)
		{
			return null;
		}
		RoleDeathComponent roleDeathComponent = (entity != null) ? entity.CheckGetComponent<RoleDeathComponent>() : null;
		if (roleDeathComponent != null)
		{
			roleDeathComponent.ExecuteRevive();
		}
		return null;
	}

	// Token: 0x0400C329 RID: 49961
	public float HealRate;

	// Token: 0x0400C32A RID: 49962
	public float HealValue;
}
