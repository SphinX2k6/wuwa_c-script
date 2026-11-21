using System;
using System.Runtime.CompilerServices;

// Token: 0x020024D9 RID: 9433
[NullableContext(1)]
[Nullable(0)]
public abstract class InitExecution : BuffExecution
{
	// Token: 0x06017694 RID: 95892 RVA: 0x006E53A1 File Offset: 0x006E35A1
	protected InitExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06017695 RID: 95893
	[return: Nullable(2)]
	public abstract override object OnExecute(params object[] args);

	// Token: 0x06017696 RID: 95894 RVA: 0x006E53AA File Offset: 0x006E35AA
	public override void OnBuffAddedCallback(ActiveBuffInternal buff, bool isIterable)
	{
		base.TryExecute(buff, new object[]
		{
			isIterable
		});
	}
}
