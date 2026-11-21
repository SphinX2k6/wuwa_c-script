using System;
using System.Runtime.CompilerServices;

// Token: 0x020024A9 RID: 9385
[NullableContext(1)]
[Nullable(0)]
public class DynamicModifyBuffStackEffect : BuffEffect
{
	// Token: 0x060175AF RID: 95663 RVA: 0x006DFF18 File Offset: 0x006DE118
	public DynamicModifyBuffStackEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175B0 RID: 95664 RVA: 0x006DFF34 File Offset: 0x006DE134
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.BuffIds = Array.Empty<long>();
			return;
		}
		string[] array = extraEffectParameters_[0].Split('|', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('#', StringSplitOptions.None);
			this.BuffIds[i] = ((array2.Length != 0) ? long.Parse(array2[0]) : 0L);
		}
	}

	// Token: 0x060175B1 RID: 95665 RVA: 0x006DFFA7 File Offset: 0x006DE1A7
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175B2 RID: 95666 RVA: 0x006DFFAA File Offset: 0x006DE1AA
	public override void OnCreated()
	{
	}

	// Token: 0x060175B3 RID: 95667 RVA: 0x006DFFAC File Offset: 0x006DE1AC
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null)
		{
			foreach (long targetBuffId in this.BuffIds)
			{
				ownerBuffComponent.RemoveBuffStackModifier(targetBuffId, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x0400C60F RID: 50703
	public long[] BuffIds = Array.Empty<long>();
}
