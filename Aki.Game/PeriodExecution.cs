using System;
using System.Runtime.CompilerServices;

// Token: 0x020024D8 RID: 9432
[NullableContext(1)]
[Nullable(0)]
public abstract class PeriodExecution : BuffExecution
{
	// Token: 0x06017691 RID: 95889 RVA: 0x006E5389 File Offset: 0x006E3589
	protected PeriodExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06017692 RID: 95890
	[return: Nullable(2)]
	public abstract override object OnExecute(params object[] args);

	// Token: 0x06017693 RID: 95891 RVA: 0x006E5392 File Offset: 0x006E3592
	public override void OnPeriodCallback(ActiveBuffInternal buff)
	{
		base.TryExecute(buff, Array.Empty<object>());
	}
}
