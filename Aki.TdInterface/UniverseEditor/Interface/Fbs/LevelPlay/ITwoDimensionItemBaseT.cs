using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A44 RID: 19012
	public class ITwoDimensionItemBaseT
	{
		// Token: 0x17008568 RID: 34152
		// (get) Token: 0x0601C8F8 RID: 116984 RVA: 0x00407CD1 File Offset: 0x00405ED1
		// (set) Token: 0x0601C8F9 RID: 116985 RVA: 0x00407CD9 File Offset: 0x00405ED9
		public int Id { get; set; }

		// Token: 0x17008569 RID: 34153
		// (get) Token: 0x0601C8FA RID: 116986 RVA: 0x00407CE2 File Offset: 0x00405EE2
		// (set) Token: 0x0601C8FB RID: 116987 RVA: 0x00407CEA File Offset: 0x00405EEA
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x1700856A RID: 34154
		// (get) Token: 0x0601C8FC RID: 116988 RVA: 0x00407CF3 File Offset: 0x00405EF3
		// (set) Token: 0x0601C8FD RID: 116989 RVA: 0x00407CFB File Offset: 0x00405EFB
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x0601C8FE RID: 116990 RVA: 0x00407D04 File Offset: 0x00405F04
		public ITwoDimensionItemBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
		}
	}
}
