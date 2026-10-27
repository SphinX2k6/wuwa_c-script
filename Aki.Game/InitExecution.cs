using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F85 RID: 12165
[NullableContext(1)]
[Nullable(0)]
public abstract class InitExecution : BuffExecution
{
	// Token: 0x06019D82 RID: 105858 RVA: 0x006BEAC1 File Offset: 0x006BCCC1
	protected InitExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D83 RID: 105859
	[return: Nullable(2)]
	public abstract override object OnExecute(params object[] args);

	// Token: 0x06019D84 RID: 105860 RVA: 0x006BEACA File Offset: 0x006BCCCA
	public override void OnBuffAddedCallback(ActiveBuffInternal buff, bool isIterable)
	{
		base.TryExecute(buff, new object[]
		{
			isIterable
		});
	}
}
