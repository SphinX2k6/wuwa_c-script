using System;

namespace Aki.UniverseEditor.Interface.Fbs.Command
{
	// Token: 0x02005EE1 RID: 24289
	public enum EP4ProxyResponseType : byte
	{
		// Token: 0x0400F9CB RID: 63947
		GetP4ClientInfo,
		// Token: 0x0400F9CC RID: 63948
		GetFilesState,
		// Token: 0x0400F9CD RID: 63949
		SyncFiles,
		// Token: 0x0400F9CE RID: 63950
		CreatePendingList,
		// Token: 0x0400F9CF RID: 63951
		GetLocalChangedFiles,
		// Token: 0x0400F9D0 RID: 63952
		GetDepotFile,
		// Token: 0x0400F9D1 RID: 63953
		GetDepotFiles,
		// Token: 0x0400F9D2 RID: 63954
		GetFileLogs,
		// Token: 0x0400F9D3 RID: 63955
		ResolveByDepot,
		// Token: 0x0400F9D4 RID: 63956
		ResolveByLocal,
		// Token: 0x0400F9D5 RID: 63957
		Reconcile,
		// Token: 0x0400F9D6 RID: 63958
		RevertFiles,
		// Token: 0x0400F9D7 RID: 63959
		Submit,
		// Token: 0x0400F9D8 RID: 63960
		IsSwarmPass,
		// Token: 0x0400F9D9 RID: 63961
		WaitForSwarmPass,
		// Token: 0x0400F9DA RID: 63962
		CreateSwarm,
		// Token: 0x0400F9DB RID: 63963
		IgnoreSwarm,
		// Token: 0x0400F9DC RID: 63964
		CancelSwarm,
		// Token: 0x0400F9DD RID: 63965
		GetSwarmStatus,
		// Token: 0x0400F9DE RID: 63966
		StopServer,
		// Token: 0x0400F9DF RID: 63967
		Echo
	}
}
