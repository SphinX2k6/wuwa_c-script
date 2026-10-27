using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x020030B6 RID: 12470
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class DisableHandler<[Nullable(0)] T> : AbstractHandler<T> where T : IParameterContext
{
	// Token: 0x0601AB6B RID: 109419 RVA: 0x007325C2 File Offset: 0x007307C2
	protected override bool CanHandle(T context)
	{
		return true;
	}

	// Token: 0x0601AB6C RID: 109420 RVA: 0x007325C5 File Offset: 0x007307C5
	protected override void ExecuteProcessing(T context)
	{
	}

	// Token: 0x0601AB6D RID: 109421 RVA: 0x007325C7 File Offset: 0x007307C7
	protected override void ExecuteStopping(T context)
	{
	}
}
