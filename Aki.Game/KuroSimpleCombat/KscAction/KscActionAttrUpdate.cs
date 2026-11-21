using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x0200302C RID: 12332
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionAttrUpdate : KscActionBase
	{
		// Token: 0x0601D414 RID: 119828 RVA: 0x008EE95E File Offset: 0x008ECB5E
		public KscActionAttrUpdate(long creatureId, SimpleCombatEntityAttributeUpdateNotify data) : base(creatureId)
		{
			this.Data = data;
		}

		// Token: 0x0601D415 RID: 119829 RVA: 0x008EE970 File Offset: 0x008ECB70
		protected override UniTask RunContent()
		{
			KscActionAttrUpdate.<RunContent>d__2 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionAttrUpdate.<RunContent>d__2>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0400F672 RID: 63090
		public SimpleCombatEntityAttributeUpdateNotify Data;
	}
}
