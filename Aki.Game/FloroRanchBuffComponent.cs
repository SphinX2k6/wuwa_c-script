using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B11 RID: 6929
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchBuffComponent)]
public class FloroRanchBuffComponent : FloroRanchEntityComponentBase
{
	// Token: 0x0600CD9C RID: 52636 RVA: 0x002ED3D4 File Offset: 0x002EB5D4
	public UniTask ShowAddBuff(int buffId)
	{
		FloroRanchBuffComponent.<ShowAddBuff>d__0 <ShowAddBuff>d__;
		<ShowAddBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowAddBuff>d__.<>1__state = -1;
		<ShowAddBuff>d__.<>t__builder.Start<FloroRanchBuffComponent.<ShowAddBuff>d__0>(ref <ShowAddBuff>d__);
		return <ShowAddBuff>d__.<>t__builder.Task;
	}
}
