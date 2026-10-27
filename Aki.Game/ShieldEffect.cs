using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F40 RID: 12096
[NullableContext(1)]
[Nullable(0)]
public class ShieldEffect : BuffEffect
{
	// Token: 0x06019C12 RID: 105490 RVA: 0x006B65BC File Offset: 0x006B47BC
	public ShieldEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C13 RID: 105491 RVA: 0x006B65CC File Offset: 0x006B47CC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.ShieldTemplateId = int.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x06019C14 RID: 105492 RVA: 0x006B65F5 File Offset: 0x006B47F5
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C15 RID: 105493 RVA: 0x006B65F8 File Offset: 0x006B47F8
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

	// Token: 0x0400C226 RID: 49702
	protected int ShieldTemplateId;
}
