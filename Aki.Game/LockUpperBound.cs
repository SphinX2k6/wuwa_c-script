using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002495 RID: 9365
[NullableContext(1)]
[Nullable(0)]
public class LockUpperBound : BuffEffect
{
	// Token: 0x06017527 RID: 95527 RVA: 0x006DCB41 File Offset: 0x006DAD41
	public LockUpperBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017528 RID: 95528 RVA: 0x006DCB50 File Offset: 0x006DAD50
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			return;
		}
		if (extraEffectParameters_.Length != 0)
		{
			this.AttributeId = (EAttributeType)int.Parse(extraEffectParameters_[0]);
		}
		this.Percent = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters1, this.Level, 0f);
		this.Offset = AbilityUtils.GetLevelValue<float>(parameters.ExtraEffectGrowParameters2, this.Level, 0f);
		if (extraEffectParameters_.Length > 2)
		{
			this.Percent = float.Parse(extraEffectParameters_[2]);
		}
	}

	// Token: 0x06017529 RID: 95529 RVA: 0x006DCBC8 File Offset: 0x006DADC8
	public override void OnCreated()
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity == null)
		{
			return;
		}
		BaseAttributeComponent baseAttributeComponent = ownerEntity.CheckGetComponent<BaseAttributeComponent>();
		if (baseAttributeComponent == null)
		{
			return;
		}
		baseAttributeComponent.AddIntervalLock(EAttributeIntervalLockType.UpperBoundLock, this.ActiveHandleId, this.AttributeId, this.Percent, this.Offset);
	}

	// Token: 0x0601752A RID: 95530 RVA: 0x006DCBFD File Offset: 0x006DADFD
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601752B RID: 95531 RVA: 0x006DCC00 File Offset: 0x006DAE00
	public override void OnRemoved(bool bPremature)
	{
		Entity ownerEntity = base.OwnerEntity;
		if (ownerEntity == null)
		{
			return;
		}
		BaseAttributeComponent baseAttributeComponent = ownerEntity.CheckGetComponent<BaseAttributeComponent>();
		if (baseAttributeComponent == null)
		{
			return;
		}
		baseAttributeComponent.RemoveIntervalLock(EAttributeIntervalLockType.UpperBoundLock, this.ActiveHandleId, this.AttributeId);
	}

	// Token: 0x0601752C RID: 95532 RVA: 0x006DCC2C File Offset: 0x006DAE2C
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
		defaultInterpolatedStringHandler.AppendLiteral("锁定属性");
		defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("的上限为");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Percent / 100f, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("% + ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Offset);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C5CC RID: 50636
	protected EAttributeType AttributeId;

	// Token: 0x0400C5CD RID: 50637
	protected float Offset;

	// Token: 0x0400C5CE RID: 50638
	protected float Percent;
}
