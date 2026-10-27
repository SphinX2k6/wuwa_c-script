using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02005EDF RID: 24287
	public enum EGameCommand : byte
	{
		// Token: 0x0400F9B7 RID: 63927
		RpcReq,
		// Token: 0x0400F9B8 RID: 63928
		ResetRpc,
		// Token: 0x0400F9B9 RID: 63929
		SelectEntity,
		// Token: 0x0400F9BA RID: 63930
		GetPlayerInfo,
		// Token: 0x0400F9BB RID: 63931
		GetBehaviorTreeRunningActions,
		// Token: 0x0400F9BC RID: 63932
		ExecGm,
		// Token: 0x0400F9BD RID: 63933
		RequireSelectedEntity,
		// Token: 0x0400F9BE RID: 63934
		DevPkgHeartBeat,
		// Token: 0x0400F9BF RID: 63935
		ExecEdUseCaseTest,
		// Token: 0x0400F9C0 RID: 63936
		ExecPkgUseCaseTest,
		// Token: 0x0400F9C1 RID: 63937
		EnableGameCommandServiceLog
	}
}
