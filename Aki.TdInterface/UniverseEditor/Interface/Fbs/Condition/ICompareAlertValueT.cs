using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200506B RID: 20587
	public class ICompareAlertValueT
	{
		// Token: 0x1700935C RID: 37724
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x00476A27 File Offset: 0x00474C27
		// (set) Token: 0x06020315 RID: 131861 RVA: 0x00476A2F File Offset: 0x00474C2F
		public ECondition Type { get; set; }

		// Token: 0x1700935D RID: 37725
		// (get) Token: 0x06020316 RID: 131862 RVA: 0x00476A38 File Offset: 0x00474C38
		// (set) Token: 0x06020317 RID: 131863 RVA: 0x00476A40 File Offset: 0x00474C40
		public int AreaId { get; set; }

		// Token: 0x1700935E RID: 37726
		// (get) Token: 0x06020318 RID: 131864 RVA: 0x00476A49 File Offset: 0x00474C49
		// (set) Token: 0x06020319 RID: 131865 RVA: 0x00476A51 File Offset: 0x00474C51
		public ECompare CompareType { get; set; }

		// Token: 0x1700935F RID: 37727
		// (get) Token: 0x0602031A RID: 131866 RVA: 0x00476A5A File Offset: 0x00474C5A
		// (set) Token: 0x0602031B RID: 131867 RVA: 0x00476A62 File Offset: 0x00474C62
		public TComparedAlertValueUnion CompareValue { get; set; }

		// Token: 0x0602031C RID: 131868 RVA: 0x00476A6B File Offset: 0x00474C6B
		public ICompareAlertValueT()
		{
			this.Type = ECondition.CompareVar;
			this.AreaId = 0;
			this.CompareType = ECompare.Eq;
			this.CompareValue = null;
		}
	}
}
