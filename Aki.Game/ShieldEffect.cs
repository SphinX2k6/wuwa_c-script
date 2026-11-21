using System;
using System.Runtime.CompilerServices;

// Token: 0x02002493 RID: 9363
[NullableContext(1)]
[Nullable(0)]
public class ShieldEffect : BuffEffect
{
	// Token: 0x0601751D RID: 95517 RVA: 0x006DC8DC File Offset: 0x006DAADC
	public ShieldEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601751E RID: 95518 RVA: 0x006DC8EC File Offset: 0x006DAAEC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.ShieldTemplateId = int.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x0601751F RID: 95519 RVA: 0x006DC915 File Offset: 0x006DAB15
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017520 RID: 95520 RVA: 0x006DC918 File Offset: 0x006DAB18
	public override string GetDebugEffectString()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 2);
		defaultInterpolatedStringHandler.AppendFormatted((baseBuffComponent != null && baseBuffComponent.IsTeamBuffComponent()) ? "编队buff" : "非编队buff");
		defaultInterpolatedStringHandler.AppendLiteral("添加护盾");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ShieldTemplateId);
		defaultInterpolatedStringHandler.AppendLiteral("(纯服务端逻辑)");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C5C8 RID: 50632
	protected int ShieldTemplateId;
}
