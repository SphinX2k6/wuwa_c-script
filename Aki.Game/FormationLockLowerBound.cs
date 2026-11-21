using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248E RID: 9358
[NullableContext(1)]
[Nullable(0)]
public class FormationLockLowerBound : BuffEffect
{
	// Token: 0x060174F3 RID: 95475 RVA: 0x006DB7EB File Offset: 0x006D99EB
	public FormationLockLowerBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174F4 RID: 95476 RVA: 0x006DB804 File Offset: 0x006D9A04
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
		if (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			this.Percent = float.Parse(extraEffectParameters_[2]);
		}
	}

	// Token: 0x060174F5 RID: 95477 RVA: 0x006DB884 File Offset: 0x006D9A84
	public override void OnCreated()
	{
		if (this.AttributeId != (EFormationAttributeId)(-1))
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority())
			{
				FormationAttributeController.Instance.AddBoundsLocker(this.AttributeId, new BoundsLocker
				{
					LockUpperBounds = false,
					LockLowerBounds = true,
					UpperPercent = 0f,
					UpperOffset = 0f,
					LowerPercent = this.Percent,
					LowerOffset = this.Offset
				}, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x060174F6 RID: 95478 RVA: 0x006DB906 File Offset: 0x006D9B06
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060174F7 RID: 95479 RVA: 0x006DB909 File Offset: 0x006D9B09
	public override void OnRemoved(bool bPremature)
	{
		if (this.AttributeId != (EFormationAttributeId)(-1))
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority())
			{
				FormationAttributeController.Instance.RemoveBoundsLocker(this.AttributeId, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x0400C5BA RID: 50618
	protected EFormationAttributeId AttributeId = (EFormationAttributeId)(-1);

	// Token: 0x0400C5BB RID: 50619
	protected float Offset;

	// Token: 0x0400C5BC RID: 50620
	protected float Percent;
}
