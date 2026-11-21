using System;
using System.Runtime.CompilerServices;

// Token: 0x0200248D RID: 9357
[NullableContext(1)]
[Nullable(0)]
public class FormationLockUpperBound : BuffEffect
{
	// Token: 0x060174EE RID: 95470 RVA: 0x006DB697 File Offset: 0x006D9897
	public FormationLockUpperBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060174EF RID: 95471 RVA: 0x006DB6B0 File Offset: 0x006D98B0
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

	// Token: 0x060174F0 RID: 95472 RVA: 0x006DB730 File Offset: 0x006D9930
	public override void OnCreated()
	{
		if (this.AttributeId != (EFormationAttributeId)(-1))
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority())
			{
				FormationAttributeController.Instance.AddBoundsLocker(this.AttributeId, new BoundsLocker
				{
					LockUpperBounds = true,
					LockLowerBounds = false,
					UpperPercent = this.Percent,
					UpperOffset = this.Offset,
					LowerPercent = 0f,
					LowerOffset = 0f
				}, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x060174F1 RID: 95473 RVA: 0x006DB7B2 File Offset: 0x006D99B2
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060174F2 RID: 95474 RVA: 0x006DB7B5 File Offset: 0x006D99B5
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

	// Token: 0x0400C5B7 RID: 50615
	protected EFormationAttributeId AttributeId = (EFormationAttributeId)(-1);

	// Token: 0x0400C5B8 RID: 50616
	protected float Offset;

	// Token: 0x0400C5B9 RID: 50617
	protected float Percent;
}
