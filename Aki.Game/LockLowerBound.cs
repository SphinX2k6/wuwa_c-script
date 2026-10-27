using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F43 RID: 12099
[NullableContext(1)]
[Nullable(0)]
public class LockLowerBound : BuffEffect
{
	// Token: 0x06019C22 RID: 105506 RVA: 0x006B697C File Offset: 0x006B4B7C
	public LockLowerBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C23 RID: 105507 RVA: 0x006B698C File Offset: 0x006B4B8C
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

	// Token: 0x06019C24 RID: 105508 RVA: 0x006B6A04 File Offset: 0x006B4C04
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
		baseAttributeComponent.AddIntervalLock(EAttributeIntervalLockType.LowerBoundLock, this.ActiveHandleId, this.AttributeId, this.Percent, this.Offset);
	}

	// Token: 0x06019C25 RID: 105509 RVA: 0x006B6A39 File Offset: 0x006B4C39
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C26 RID: 105510 RVA: 0x006B6A3C File Offset: 0x006B4C3C
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
		baseAttributeComponent.RemoveIntervalLock(EAttributeIntervalLockType.LowerBoundLock, this.ActiveHandleId, this.AttributeId);
	}

	// Token: 0x06019C27 RID: 105511 RVA: 0x006B6A68 File Offset: 0x006B4C68
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 3);
		defaultInterpolatedStringHandler.AppendLiteral("锁定属性");
		defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("的下限为");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Percent / 100f, "F1");
		defaultInterpolatedStringHandler.AppendLiteral("% + ");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Offset);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C22D RID: 49709
	protected EAttributeType AttributeId;

	// Token: 0x0400C22E RID: 49710
	protected float Offset;

	// Token: 0x0400C22F RID: 49711
	protected float Percent;
}
