using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000F9D RID: 3997
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayStartAction : FloroRanchAsyncActionBase
{
	// Token: 0x0600A019 RID: 40985 RVA: 0x002F41FF File Offset: 0x002F23FF
	public FloroRanchDayStartAction(FloroRanchDayStart dayStartData)
	{
		this.DayStartData = dayStartData;
	}

	// Token: 0x0600A01A RID: 40986 RVA: 0x002F4210 File Offset: 0x002F2410
	public override UniTask OnExecute()
	{
		FloroRanchDayStartAction.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchDayStartAction.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005E99 RID: 24217
	private readonly FloroRanchDayStart DayStartData;
}
