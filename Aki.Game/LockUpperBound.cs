using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F42 RID: 12098
[NullableContext(1)]
[Nullable(0)]
public class LockUpperBound : BuffEffect
{
	// Token: 0x06019C1C RID: 105500 RVA: 0x006B681B File Offset: 0x006B4A1B
	public LockUpperBound(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C1D RID: 105501 RVA: 0x006B682C File Offset: 0x006B4A2C
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

	// Token: 0x06019C1E RID: 105502 RVA: 0x006B68A4 File Offset: 0x006B4AA4
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

	// Token: 0x06019C1F RID: 105503 RVA: 0x006B68D9 File Offset: 0x006B4AD9
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C20 RID: 105504 RVA: 0x006B68DC File Offset: 0x006B4ADC
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

	// Token: 0x06019C21 RID: 105505 RVA: 0x006B6908 File Offset: 0x006B4B08
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

	// Token: 0x0400C22A RID: 49706
	protected EAttributeType AttributeId;

	// Token: 0x0400C22B RID: 49707
	protected float Offset;

	// Token: 0x0400C22C RID: 49708
	protected float Percent;
}
