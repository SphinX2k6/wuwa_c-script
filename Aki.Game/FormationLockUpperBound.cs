using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F3A RID: 12090
[NullableContext(1)]
[Nullable(0)]
public class FormationLockUpperBound : BuffEffect
{
	// Token: 0x06019BE3 RID: 105443 RVA: 0x006B536F File Offset: 0x006B356F
	public FormationLockUpperBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019BE4 RID: 105444 RVA: 0x006B5388 File Offset: 0x006B3588
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

	// Token: 0x06019BE5 RID: 105445 RVA: 0x006B5408 File Offset: 0x006B3608
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
					UpperPercent = this.Percent * 0.0001f,
					UpperOffset = this.Offset,
					LowerPercent = 0f,
					LowerOffset = 0f
				}, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x06019BE6 RID: 105446 RVA: 0x006B5490 File Offset: 0x006B3690
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019BE7 RID: 105447 RVA: 0x006B5493 File Offset: 0x006B3693
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

	// Token: 0x0400C215 RID: 49685
	protected EFormationAttributeId AttributeId = (EFormationAttributeId)(-1);

	// Token: 0x0400C216 RID: 49686
	protected float Offset;

	// Token: 0x0400C217 RID: 49687
	protected float Percent;
}
