using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02006522 RID: 25890
	public enum EGameCommand : byte
	{
		// Token: 0x0401071B RID: 67355
		RpcReq,
		// Token: 0x0401071C RID: 67356
		ResetRpc,
		// Token: 0x0401071D RID: 67357
		SelectEntity,
		// Token: 0x0401071E RID: 67358
		GetPlayerInfo,
		// Token: 0x0401071F RID: 67359
		GetBehaviorTreeRunningActions,
		// Token: 0x04010720 RID: 67360
		ExecGm,
		// Token: 0x04010721 RID: 67361
		RequireSelectedEntity,
		// Token: 0x04010722 RID: 67362
		DevPkgHeartBeat,
		// Token: 0x04010723 RID: 67363
		ExecEdUseCaseTest,
		// Token: 0x04010724 RID: 67364
		ExecPkgUseCaseTest,
		// Token: 0x04010725 RID: 67365
		EnableGameCommandServiceLog
	}
}
