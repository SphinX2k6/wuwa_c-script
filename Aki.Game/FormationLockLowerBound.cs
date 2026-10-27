using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F3B RID: 12091
[NullableContext(1)]
[Nullable(0)]
public class FormationLockLowerBound : BuffEffect
{
	// Token: 0x06019BE8 RID: 105448 RVA: 0x006B54C9 File Offset: 0x006B36C9
	public FormationLockLowerBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BE9 RID: 105449 RVA: 0x006B54E0 File Offset: 0x006B36E0
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

	// Token: 0x06019BEA RID: 105450 RVA: 0x006B5560 File Offset: 0x006B3760
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
					LowerPercent = this.Percent * 0.0001f,
					LowerOffset = this.Offset
				}, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x06019BEB RID: 105451 RVA: 0x006B55E8 File Offset: 0x006B37E8
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BEC RID: 105452 RVA: 0x006B55EB File Offset: 0x006B37EB
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

	// Token: 0x0400C218 RID: 49688
	protected EFormationAttributeId AttributeId = (EFormationAttributeId)(-1);

	// Token: 0x0400C219 RID: 49689
	protected float Offset;

	// Token: 0x0400C21A RID: 49690
	protected float Percent;
}
