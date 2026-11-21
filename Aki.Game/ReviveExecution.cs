using System;
using System.Runtime.CompilerServices;

// Token: 0x020024DA RID: 9434
[NullableContext(1)]
[Nullable(0)]
public class ReviveExecution : PeriodExecution
{
	// Token: 0x06017697 RID: 95895 RVA: 0x006E53C3 File Offset: 0x006E35C3
	public ReviveExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06017698 RID: 95896 RVA: 0x006E53CC File Offset: 0x006E35CC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.HealRate = ((extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? (float.Parse(extraEffectParameters_[0]) * 0.0001f) : 0f);
		this.HealValue = ((extraEffectParameters_ != null && extraEffectParameters_.Length > 1) ? float.Parse(extraEffectParameters_[1]) : 0f);
	}

	// Token: 0x06017699 RID: 95897 RVA: 0x006E5420 File Offset: 0x006E3620
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

	// Token: 0x0400C6D2 RID: 50898
	public float HealRate;

	// Token: 0x0400C6D3 RID: 50899
	public float HealValue;
}
