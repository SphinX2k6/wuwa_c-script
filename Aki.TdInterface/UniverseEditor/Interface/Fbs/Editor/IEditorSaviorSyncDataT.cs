using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CD1 RID: 19665
	public class IEditorSaviorSyncDataT
	{
		// Token: 0x17008C0A RID: 35850
		// (get) Token: 0x0601E4C7 RID: 124103 RVA: 0x0043E9B8 File Offset: 0x0043CBB8
		// (set) Token: 0x0601E4C8 RID: 124104 RVA: 0x0043E9C0 File Offset: 0x0043CBC0
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x17008C0B RID: 35851
		// (get) Token: 0x0601E4C9 RID: 124105 RVA: 0x0043E9C9 File Offset: 0x0043CBC9
		// (set) Token: 0x0601E4CA RID: 124106 RVA: 0x0043E9D1 File Offset: 0x0043CBD1
		public string ClientName { get; set; }

		// Token: 0x17008C0C RID: 35852
		// (get) Token: 0x0601E4CB RID: 124107 RVA: 0x0043E9DA File Offset: 0x0043CBDA
		// (set) Token: 0x0601E4CC RID: 124108 RVA: 0x0043E9E2 File Offset: 0x0043CBE2
		public string ClientRoot { get; set; }

		// Token: 0x17008C0D RID: 35853
		// (get) Token: 0x0601E4CD RID: 124109 RVA: 0x0043E9EB File Offset: 0x0043CBEB
		// (set) Token: 0x0601E4CE RID: 124110 RVA: 0x0043E9F3 File Offset: 0x0043CBF3
		public int ChangeNum { get; set; }

		// Token: 0x17008C0E RID: 35854
		// (get) Token: 0x0601E4CF RID: 124111 RVA: 0x0043E9FC File Offset: 0x0043CBFC
		// (set) Token: 0x0601E4D0 RID: 124112 RVA: 0x0043EA04 File Offset: 0x0043CC04
		public int Timestamp { get; set; }

		// Token: 0x0601E4D1 RID: 124113 RVA: 0x0043EA0D File Offset: 0x0043CC0D
		public IEditorSaviorSyncDataT()
		{
			this.Type = EP4SyncMethodType.EditorSavior;
			this.ClientName = null;
			this.ClientRoot = null;
			this.ChangeNum = 0;
			this.Timestamp = 0;
		}
	}
}
