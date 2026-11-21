using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004723 RID: 18211
	public class TCsvTetrisBoardDataT
	{
		// Token: 0x17007F6D RID: 32621
		// (get) Token: 0x0601AD27 RID: 109863 RVA: 0x003CEF7F File Offset: 0x003CD17F
		// (set) Token: 0x0601AD28 RID: 109864 RVA: 0x003CEF87 File Offset: 0x003CD187
		public int Id { get; set; }

		// Token: 0x17007F6E RID: 32622
		// (get) Token: 0x0601AD29 RID: 109865 RVA: 0x003CEF90 File Offset: 0x003CD190
		// (set) Token: 0x0601AD2A RID: 109866 RVA: 0x003CEF98 File Offset: 0x003CD198
		public ITetrisBoardT Data { get; set; }

		// Token: 0x0601AD2B RID: 109867 RVA: 0x003CEFA1 File Offset: 0x003CD1A1
		public TCsvTetrisBoardDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
