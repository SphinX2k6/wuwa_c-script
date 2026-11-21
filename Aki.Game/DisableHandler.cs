using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils.ResponsibilityChain;

// Token: 0x0200260E RID: 9742
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public abstract class DisableHandler<[Nullable(0)] T> : AbstractHandler<T> where T : IParameterContext
{
	// Token: 0x0601857A RID: 99706 RVA: 0x00757F2E File Offset: 0x0075612E
	protected override bool CanHandle(T context)
	{
		return true;
	}

	// Token: 0x0601857B RID: 99707 RVA: 0x00757F31 File Offset: 0x00756131
	protected override void ExecuteProcessing(T context)
	{
	}

	// Token: 0x0601857C RID: 99708 RVA: 0x00757F33 File Offset: 0x00756133
	protected override void ExecuteStopping(T context)
	{
	}
}
