using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x02003034 RID: 12340
	public class KscActionEntityRemove : KscActionBase
	{
		// Token: 0x0601D43B RID: 119867 RVA: 0x008EF5D3 File Offset: 0x008ED7D3
		public KscActionEntityRemove(long entityId, FName? removeReason, EKscEntityRemoveReasonType removeReasonType = EKscEntityRemoveReasonType.None) : base(entityId)
		{
			this.RemoveReason = removeReason;
			this.RemoveReasonType = removeReasonType;
		}

		// Token: 0x0601D43C RID: 119868 RVA: 0x008EF5F4 File Offset: 0x008ED7F4
		protected override UniTask RunContent()
		{
			KscActionEntityRemove.<RunContent>d__3 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionEntityRemove.<RunContent>d__3>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0400F682 RID: 63106
		public FName? RemoveReason;

		// Token: 0x0400F683 RID: 63107
		public EKscEntityRemoveReasonType RemoveReasonType = EKscEntityRemoveReasonType.None;
	}
}
