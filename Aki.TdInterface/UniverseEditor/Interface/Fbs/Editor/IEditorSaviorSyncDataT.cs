using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200486C RID: 18540
	public class IEditorSaviorSyncDataT
	{
		// Token: 0x170085C0 RID: 34240
		// (get) Token: 0x0601CCD6 RID: 117974 RVA: 0x00412110 File Offset: 0x00410310
		// (set) Token: 0x0601CCD7 RID: 117975 RVA: 0x00412118 File Offset: 0x00410318
		public EP4SyncMethodType Type { get; set; }

		// Token: 0x170085C1 RID: 34241
		// (get) Token: 0x0601CCD8 RID: 117976 RVA: 0x00412121 File Offset: 0x00410321
		// (set) Token: 0x0601CCD9 RID: 117977 RVA: 0x00412129 File Offset: 0x00410329
		public string ClientName { get; set; }

		// Token: 0x170085C2 RID: 34242
		// (get) Token: 0x0601CCDA RID: 117978 RVA: 0x00412132 File Offset: 0x00410332
		// (set) Token: 0x0601CCDB RID: 117979 RVA: 0x0041213A File Offset: 0x0041033A
		public string ClientRoot { get; set; }

		// Token: 0x170085C3 RID: 34243
		// (get) Token: 0x0601CCDC RID: 117980 RVA: 0x00412143 File Offset: 0x00410343
		// (set) Token: 0x0601CCDD RID: 117981 RVA: 0x0041214B File Offset: 0x0041034B
		public int ChangeNum { get; set; }

		// Token: 0x170085C4 RID: 34244
		// (get) Token: 0x0601CCDE RID: 117982 RVA: 0x00412154 File Offset: 0x00410354
		// (set) Token: 0x0601CCDF RID: 117983 RVA: 0x0041215C File Offset: 0x0041035C
		public int Timestamp { get; set; }

		// Token: 0x0601CCE0 RID: 117984 RVA: 0x00412165 File Offset: 0x00410365
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
