using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02006524 RID: 25892
	public enum EP4ProxyResponseType : byte
	{
		// Token: 0x0401072F RID: 67375
		GetP4ClientInfo,
		// Token: 0x04010730 RID: 67376
		GetFilesState,
		// Token: 0x04010731 RID: 67377
		SyncFiles,
		// Token: 0x04010732 RID: 67378
		CreatePendingList,
		// Token: 0x04010733 RID: 67379
		GetLocalChangedFiles,
		// Token: 0x04010734 RID: 67380
		GetDepotFile,
		// Token: 0x04010735 RID: 67381
		GetDepotFiles,
		// Token: 0x04010736 RID: 67382
		GetFileLogs,
		// Token: 0x04010737 RID: 67383
		ResolveByDepot,
		// Token: 0x04010738 RID: 67384
		ResolveByLocal,
		// Token: 0x04010739 RID: 67385
		Reconcile,
		// Token: 0x0401073A RID: 67386
		RevertFiles,
		// Token: 0x0401073B RID: 67387
		Submit,
		// Token: 0x0401073C RID: 67388
		IsSwarmPass,
		// Token: 0x0401073D RID: 67389
		WaitForSwarmPass,
		// Token: 0x0401073E RID: 67390
		CreateSwarm,
		// Token: 0x0401073F RID: 67391
		IgnoreSwarm,
		// Token: 0x04010740 RID: 67392
		CancelSwarm,
		// Token: 0x04010741 RID: 67393
		GetSwarmStatus,
		// Token: 0x04010742 RID: 67394
		StopServer,
		// Token: 0x04010743 RID: 67395
		Echo
	}
}
