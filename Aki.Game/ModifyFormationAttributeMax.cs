using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F3C RID: 12092
[NullableContext(1)]
[Nullable(0)]
public class ModifyFormationAttributeMax : BuffEffect
{
	// Token: 0x06019BED RID: 105453 RVA: 0x006B5621 File Offset: 0x006B3821
	public ModifyFormationAttributeMax(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BEE RID: 105454 RVA: 0x006B5638 File Offset: 0x006B3838
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			return;
		}
		this.AttributeId = (EFormationAttributeId)int.Parse(extraEffectParameters_[0]);
		this.Percent = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		this.Offset = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
		this.ModifierKey = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06019BEF RID: 105455 RVA: 0x006B56CC File Offset: 0x006B38CC
	public override void OnCreated()
	{
		if (this.AttributeId != (EFormationAttributeId)(-1))
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority())
			{
				FormationAttributeController.Instance.AddMaxModifier(this.ModifierKey, this.AttributeId, this.Percent, this.Offset);
			}
		}
	}

	// Token: 0x06019BF0 RID: 105456 RVA: 0x006B5718 File Offset: 0x006B3918
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BF1 RID: 105457 RVA: 0x006B571B File Offset: 0x006B391B
	public override void OnRemoved(bool bPremature)
	{
		if (this.AttributeId != (EFormationAttributeId)(-1))
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority())
			{
				FormationAttributeController.Instance.RemoveMaxModifier(this.ModifierKey, this.AttributeId);
			}
		}
	}

	// Token: 0x0400C21B RID: 49691
	protected EFormationAttributeId AttributeId = (EFormationAttributeId)(-1);

	// Token: 0x0400C21C RID: 49692
	protected float Offset;

	// Token: 0x0400C21D RID: 49693
	protected float Percent;

	// Token: 0x0400C21E RID: 49694
	[Nullable(2)]
	protected string ModifierKey;
}
