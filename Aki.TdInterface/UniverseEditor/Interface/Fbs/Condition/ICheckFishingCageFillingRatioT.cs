using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A25 RID: 18981
	public class ICheckFishingCageFillingRatioT
	{
		// Token: 0x17008967 RID: 35175
		// (get) Token: 0x0601DB3D RID: 121661 RVA: 0x0042D9F6 File Offset: 0x0042BBF6
		// (set) Token: 0x0601DB3E RID: 121662 RVA: 0x0042D9FE File Offset: 0x0042BBFE
		public ECondition Type { get; set; }

		// Token: 0x17008968 RID: 35176
		// (get) Token: 0x0601DB3F RID: 121663 RVA: 0x0042DA07 File Offset: 0x0042BC07
		// (set) Token: 0x0601DB40 RID: 121664 RVA: 0x0042DA0F File Offset: 0x0042BC0F
		public ECompare Compare { get; set; }

		// Token: 0x17008969 RID: 35177
		// (get) Token: 0x0601DB41 RID: 121665 RVA: 0x0042DA18 File Offset: 0x0042BC18
		// (set) Token: 0x0601DB42 RID: 121666 RVA: 0x0042DA20 File Offset: 0x0042BC20
		public int Ratio { get; set; }

		// Token: 0x0601DB43 RID: 121667 RVA: 0x0042DA29 File Offset: 0x0042BC29
		public ICheckFishingCageFillingRatioT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Ratio = 0;
		}
	}
}
