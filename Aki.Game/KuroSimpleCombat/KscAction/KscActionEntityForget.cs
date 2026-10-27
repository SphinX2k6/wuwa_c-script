using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E7 RID: 17639
	public class KscActionEntityForget : KscActionBase
	{
		// Token: 0x0602D6EF RID: 186095 RVA: 0x00A416EC File Offset: 0x00A3F8EC
		public KscActionEntityForget(long creatureId) : base(creatureId)
		{
		}

		// Token: 0x0602D6F0 RID: 186096 RVA: 0x00A416F8 File Offset: 0x00A3F8F8
		protected override UniTask RunContent()
		{
			KscActionEntityForget.<RunContent>d__1 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionEntityForget.<RunContent>d__1>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}
	}
}
