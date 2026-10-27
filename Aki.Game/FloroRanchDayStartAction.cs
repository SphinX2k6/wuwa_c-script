using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001ADE RID: 6878
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDayStartAction : FloroRanchAsyncActionBase
{
	// Token: 0x0600CC08 RID: 52232 RVA: 0x002E906B File Offset: 0x002E726B
	public FloroRanchDayStartAction(FloroRanchDayStart dayStartData)
	{
		this.DayStartData = dayStartData;
	}

	// Token: 0x0600CC09 RID: 52233 RVA: 0x002E907C File Offset: 0x002E727C
	public override UniTask OnExecute()
	{
		FloroRanchDayStartAction.<OnExecute>d__2 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<FloroRanchDayStartAction.<OnExecute>d__2>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x04005DCA RID: 24010
	private readonly FloroRanchDayStart DayStartData;
}
