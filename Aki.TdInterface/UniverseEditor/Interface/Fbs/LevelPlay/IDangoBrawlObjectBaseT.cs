using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048C7 RID: 18631
	public class IDangoBrawlObjectBaseT
	{
		// Token: 0x170081B9 RID: 33209
		// (get) Token: 0x0601B8FD RID: 112893 RVA: 0x003E5E01 File Offset: 0x003E4001
		// (set) Token: 0x0601B8FE RID: 112894 RVA: 0x003E5E09 File Offset: 0x003E4009
		public int Id { get; set; }

		// Token: 0x170081BA RID: 33210
		// (get) Token: 0x0601B8FF RID: 112895 RVA: 0x003E5E12 File Offset: 0x003E4012
		// (set) Token: 0x0601B900 RID: 112896 RVA: 0x003E5E1A File Offset: 0x003E401A
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x170081BB RID: 33211
		// (get) Token: 0x0601B901 RID: 112897 RVA: 0x003E5E23 File Offset: 0x003E4023
		// (set) Token: 0x0601B902 RID: 112898 RVA: 0x003E5E2B File Offset: 0x003E402B
		public ITwoDimensionTransformT Transform { get; set; }

		// Token: 0x170081BC RID: 33212
		// (get) Token: 0x0601B903 RID: 112899 RVA: 0x003E5E34 File Offset: 0x003E4034
		// (set) Token: 0x0601B904 RID: 112900 RVA: 0x003E5E3C File Offset: 0x003E403C
		public EDangoBrawlObjectType SubType { get; set; }

		// Token: 0x170081BD RID: 33213
		// (get) Token: 0x0601B905 RID: 112901 RVA: 0x003E5E45 File Offset: 0x003E4045
		// (set) Token: 0x0601B906 RID: 112902 RVA: 0x003E5E4D File Offset: 0x003E404D
		public int DataId { get; set; }

		// Token: 0x170081BE RID: 33214
		// (get) Token: 0x0601B907 RID: 112903 RVA: 0x003E5E56 File Offset: 0x003E4056
		// (set) Token: 0x0601B908 RID: 112904 RVA: 0x003E5E5E File Offset: 0x003E405E
		public EDangoBrawlDirection Direction { get; set; }

		// Token: 0x170081BF RID: 33215
		// (get) Token: 0x0601B909 RID: 112905 RVA: 0x003E5E67 File Offset: 0x003E4067
		// (set) Token: 0x0601B90A RID: 112906 RVA: 0x003E5E6F File Offset: 0x003E406F
		public int TemplateId { get; set; }

		// Token: 0x0601B90B RID: 112907 RVA: 0x003E5E78 File Offset: 0x003E4078
		public IDangoBrawlObjectBaseT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.Transform = null;
			this.SubType = EDangoBrawlObjectType.Bag;
			this.DataId = 0;
			this.Direction = EDangoBrawlDirection.Up;
			this.TemplateId = 0;
		}
	}
}
