using System;
using System.Runtime.CompilerServices;

// Token: 0x020024A3 RID: 9379
[NullableContext(1)]
[Nullable(0)]
public class BuffOverStackCompensation : BuffEffect
{
	// Token: 0x06017582 RID: 95618 RVA: 0x006DEFF9 File Offset: 0x006DD1F9
	public BuffOverStackCompensation(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017583 RID: 95619 RVA: 0x006DF008 File Offset: 0x006DD208
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}
}
