using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E8 RID: 17640
	public class KscActionEntityRemove : KscActionBase
	{
		// Token: 0x0602D6F1 RID: 186097 RVA: 0x00A4173B File Offset: 0x00A3F93B
		public KscActionEntityRemove(long entityId, FName? removeReason, EKscEntityRemoveReasonType removeReasonType = EKscEntityRemoveReasonType.None) : base(entityId)
		{
			this.RemoveReason = removeReason;
			this.RemoveReasonType = removeReasonType;
		}

		// Token: 0x0602D6F2 RID: 186098 RVA: 0x00A4175C File Offset: 0x00A3F95C
		protected override UniTask RunContent()
		{
			KscActionEntityRemove.<RunContent>d__3 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionEntityRemove.<RunContent>d__3>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x040184B7 RID: 99511
		public FName? RemoveReason;

		// Token: 0x040184B8 RID: 99512
		public EKscEntityRemoveReasonType RemoveReasonType = EKscEntityRemoveReasonType.None;
	}
}
