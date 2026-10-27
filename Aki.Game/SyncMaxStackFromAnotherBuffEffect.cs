using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F5A RID: 12122
[NullableContext(1)]
[Nullable(0)]
public class SyncMaxStackFromAnotherBuffEffect : BuffEffect
{
	// Token: 0x06019CC1 RID: 105665 RVA: 0x006BA6A8 File Offset: 0x006B88A8
	public SyncMaxStackFromAnotherBuffEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CC2 RID: 105666 RVA: 0x006BA6B8 File Offset: 0x006B88B8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.SourceBuffId = long.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x06019CC3 RID: 105667 RVA: 0x006BA6E1 File Offset: 0x006B88E1
	public override void OnCreated()
	{
		if (base.OwnerEntity != null)
		{
			AbilityEvent.Instance.Add(base.OwnerEntity, EAbilityEventName.OnBuffMaxStackModifier, this.SourceBuffId, new Action<long>(this.OnBuffMaxStackModifier));
		}
		this.SyncMaxStack();
	}

	// Token: 0x06019CC4 RID: 105668 RVA: 0x006BA714 File Offset: 0x006B8914
	public override void OnRemoved(bool bPremature)
	{
		if (base.OwnerEntity != null)
		{
			AbilityEvent.Instance.Remove(base.OwnerEntity, EAbilityEventName.OnBuffMaxStackModifier, this.SourceBuffId, new Action<long>(this.OnBuffMaxStackModifier));
		}
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		ownerBuffComponent.RemoveBuffStackModifier(this.BuffId, this.ActiveHandleId);
	}

	// Token: 0x06019CC5 RID: 105669 RVA: 0x006BA768 File Offset: 0x006B8968
	protected void OnBuffMaxStackModifier(long buffId)
	{
		this.SyncMaxStack();
	}

	// Token: 0x06019CC6 RID: 105670 RVA: 0x006BA770 File Offset: 0x006B8970
	private void SyncMaxStack()
	{
		if (this.OwnerBuffComponent == null)
		{
			return;
		}
		int? num = this.OwnerBuffComponent.CalculateBuffStackMax(this.SourceBuffId);
		if (num == null)
		{
			return;
		}
		this.OwnerBuffComponent.AddBuffStackModifier(this.BuffId, this.ActiveHandleId, num.Value, EBuffStackModifierType.Override);
	}

	// Token: 0x06019CC7 RID: 105671 RVA: 0x006BA7C1 File Offset: 0x006B89C1
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CC8 RID: 105672 RVA: 0x006BA7C4 File Offset: 0x006B89C4
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("同步buff[");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.SourceBuffId);
		defaultInterpolatedStringHandler.AppendLiteral("]的最大层数");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C271 RID: 49777
	private long SourceBuffId;
}
