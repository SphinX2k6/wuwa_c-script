using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F41 RID: 12097
[NullableContext(1)]
[Nullable(0)]
public class LockValue : BuffEffect
{
	// Token: 0x06019C16 RID: 105494 RVA: 0x006B666C File Offset: 0x006B486C
	public LockValue(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C17 RID: 105495 RVA: 0x006B667C File Offset: 0x006B487C
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
		if (extraEffectParameters_.Length > 1)
		{
			this.Offset = float.Parse(extraEffectParameters_[1]);
		}
		this.Percent = 0f;
		if (extraEffectParameters_.Length > 2)
		{
			this.Percent = float.Parse(extraEffectParameters_[2]);
		}
	}

	// Token: 0x06019C18 RID: 105496 RVA: 0x006B66DC File Offset: 0x006B48DC
	public override void OnCreated()
	{
		Entity ownerEntity = base.OwnerEntity;
		BaseAttributeComponent baseAttributeComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		baseAttributeComponent.AddAttributeValueLock(this.ActiveHandleId, this.AttributeId, this.Percent, this.Offset);
	}

	// Token: 0x06019C19 RID: 105497 RVA: 0x006B671E File Offset: 0x006B491E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C1A RID: 105498 RVA: 0x006B6724 File Offset: 0x006B4924
	public override void OnRemoved(bool bPremature)
	{
		Entity ownerEntity = base.OwnerEntity;
		BaseAttributeComponent baseAttributeComponent = (ownerEntity != null) ? ownerEntity.CheckGetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return;
		}
		baseAttributeComponent.RemoveAttributeValueLock(this.ActiveHandleId, this.AttributeId);
	}

	// Token: 0x06019C1B RID: 105499 RVA: 0x006B675C File Offset: 0x006B495C
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (CharacterAttributeTypes.stateAttributeIds.Contains(this.AttributeId))
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
			defaultInterpolatedStringHandler.AppendLiteral("锁定状态属性");
			defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
			defaultInterpolatedStringHandler.AppendLiteral("为");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Percent);
			defaultInterpolatedStringHandler.AppendLiteral("% + ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Offset);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
		defaultInterpolatedStringHandler.AppendLiteral("锁定非状态属性");
		defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
		defaultInterpolatedStringHandler.AppendLiteral("为固定值");
		defaultInterpolatedStringHandler.AppendFormatted<float>(this.Offset);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C227 RID: 49703
	protected EAttributeType AttributeId;

	// Token: 0x0400C228 RID: 49704
	protected float Offset;

	// Token: 0x0400C229 RID: 49705
	protected float Percent;
}
