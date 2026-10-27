using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3D RID: 19005
	public class ICheckGiantTotalProgressCanActivateNodeT
	{
		// Token: 0x17008998 RID: 35224
		// (get) Token: 0x0601DC1C RID: 121884 RVA: 0x0042F434 File Offset: 0x0042D634
		// (set) Token: 0x0601DC1D RID: 121885 RVA: 0x0042F43C File Offset: 0x0042D63C
		public ECondition Type { get; set; }

		// Token: 0x17008999 RID: 35225
		// (get) Token: 0x0601DC1E RID: 121886 RVA: 0x0042F445 File Offset: 0x0042D645
		// (set) Token: 0x0601DC1F RID: 121887 RVA: 0x0042F44D File Offset: 0x0042D64D
		public bool HasActivateNode { get; set; }

		// Token: 0x0601DC20 RID: 121888 RVA: 0x0042F456 File Offset: 0x0042D656
		public ICheckGiantTotalProgressCanActivateNodeT()
		{
			this.Type = ECondition.CompareVar;
			this.HasActivateNode = false;
		}
	}
}
