using System;
using System.Runtime.CompilerServices;

// Token: 0x020024AD RID: 9389
[NullableContext(1)]
[Nullable(0)]
public class SyncMaxStackFromAnotherBuffEffect : BuffEffect
{
	// Token: 0x060175CC RID: 95692 RVA: 0x006E09C4 File Offset: 0x006DEBC4
	public SyncMaxStackFromAnotherBuffEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175CD RID: 95693 RVA: 0x006E09D4 File Offset: 0x006DEBD4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.SourceBuffId = long.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x060175CE RID: 95694 RVA: 0x006E09FD File Offset: 0x006DEBFD
	public override void OnCreated()
	{
		if (base.OwnerEntity != null)
		{
			AbilityEvent.Instance.Add(base.OwnerEntity, EAbilityEventName.OnBuffMaxStackModifier, this.SourceBuffId, new Action<long>(this.OnBuffMaxStackModifier));
		}
		this.SyncMaxStack();
	}

	// Token: 0x060175CF RID: 95695 RVA: 0x006E0A30 File Offset: 0x006DEC30
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

	// Token: 0x060175D0 RID: 95696 RVA: 0x006E0A84 File Offset: 0x006DEC84
	protected void OnBuffMaxStackModifier(long buffId)
	{
		this.SyncMaxStack();
	}

	// Token: 0x060175D1 RID: 95697 RVA: 0x006E0A8C File Offset: 0x006DEC8C
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

	// Token: 0x060175D2 RID: 95698 RVA: 0x006E0ADD File Offset: 0x006DECDD
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175D3 RID: 95699 RVA: 0x006E0AE0 File Offset: 0x006DECE0
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 1);
		defaultInterpolatedStringHandler.AppendLiteral("同步buff[");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.SourceBuffId);
		defaultInterpolatedStringHandler.AppendLiteral("]的最大层数");
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C613 RID: 50707
	private long SourceBuffId;
}
