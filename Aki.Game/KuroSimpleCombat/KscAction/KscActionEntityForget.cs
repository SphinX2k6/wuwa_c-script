using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x02003033 RID: 12339
	public class KscActionEntityForget : KscActionBase
	{
		// Token: 0x0601D439 RID: 119865 RVA: 0x008EF584 File Offset: 0x008ED784
		public KscActionEntityForget(long creatureId) : base(creatureId)
		{
		}

		// Token: 0x0601D43A RID: 119866 RVA: 0x008EF590 File Offset: 0x008ED790
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
