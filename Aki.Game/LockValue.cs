using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002494 RID: 9364
[NullableContext(1)]
[Nullable(0)]
public class LockValue : BuffEffect
{
	// Token: 0x06017521 RID: 95521 RVA: 0x006DC98C File Offset: 0x006DAB8C
	public LockValue(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017522 RID: 95522 RVA: 0x006DC99C File Offset: 0x006DAB9C
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

	// Token: 0x06017523 RID: 95523 RVA: 0x006DC9FC File Offset: 0x006DABFC
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

	// Token: 0x06017524 RID: 95524 RVA: 0x006DCA3E File Offset: 0x006DAC3E
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017525 RID: 95525 RVA: 0x006DCA44 File Offset: 0x006DAC44
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

	// Token: 0x06017526 RID: 95526 RVA: 0x006DCA7C File Offset: 0x006DAC7C
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler;
		if (CharacterAttributeTypes.stateAttributeIds.Contains(this.AttributeId))
		{
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 3);
			defaultInterpolatedStringHandler.AppendLiteral("锁定状态属性");
			defaultInterpolatedStringHandler.AppendFormatted<EAttributeType>(this.AttributeId);
			defaultInterpolatedStringHandler.AppendLiteral("为");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Percent / 100f);
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

	// Token: 0x0400C5C9 RID: 50633
	protected EAttributeType AttributeId;

	// Token: 0x0400C5CA RID: 50634
	protected float Offset;

	// Token: 0x0400C5CB RID: 50635
	protected float Percent;
}
