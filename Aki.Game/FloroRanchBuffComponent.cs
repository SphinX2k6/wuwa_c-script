using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FD0 RID: 4048
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchBuffComponent)]
public class FloroRanchBuffComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600A1AD RID: 41389 RVA: 0x002F84C0 File Offset: 0x002F66C0
	public UniTask ShowAddBuff(int buffId)
	{
		FloroRanchBuffComponent.<ShowAddBuff>d__0 <ShowAddBuff>d__;
		<ShowAddBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowAddBuff>d__.<>1__state = -1;
		<ShowAddBuff>d__.<>t__builder.Start<FloroRanchBuffComponent.<ShowAddBuff>d__0>(ref <ShowAddBuff>d__);
		return <ShowAddBuff>d__.<>t__builder.Task;
	}
}
