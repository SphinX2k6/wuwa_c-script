using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F84 RID: 12164
[NullableContext(1)]
[Nullable(0)]
public abstract class PeriodExecution : BuffExecution
{
	// Token: 0x06019D7F RID: 105855 RVA: 0x006BEAA9 File Offset: 0x006BCCA9
	protected PeriodExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D80 RID: 105856
	[return: Nullable(2)]
	public abstract override object OnExecute(params object[] args);

	// Token: 0x06019D81 RID: 105857 RVA: 0x006BEAB2 File Offset: 0x006BCCB2
	public override void OnPeriodCallback(ActiveBuffInternal buff)
	{
		base.TryExecute(buff, Array.Empty<object>());
	}
}
