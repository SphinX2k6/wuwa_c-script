using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CBC RID: 19644
	public class ISaveConfigEnterMethodT
	{
		// Token: 0x17008EA0 RID: 36512
		// (get) Token: 0x0601F2BB RID: 127675 RVA: 0x0045A4A2 File Offset: 0x004586A2
		// (set) Token: 0x0601F2BC RID: 127676 RVA: 0x0045A4AA File Offset: 0x004586AA
		public ECondition Type { get; set; }

		// Token: 0x17008EA1 RID: 36513
		// (get) Token: 0x0601F2BD RID: 127677 RVA: 0x0045A4B3 File Offset: 0x004586B3
		// (set) Token: 0x0601F2BE RID: 127678 RVA: 0x0045A4BB File Offset: 0x004586BB
		public ECompare Compare { get; set; }

		// Token: 0x17008EA2 RID: 36514
		// (get) Token: 0x0601F2BF RID: 127679 RVA: 0x0045A4C4 File Offset: 0x004586C4
		// (set) Token: 0x0601F2C0 RID: 127680 RVA: 0x0045A4CC File Offset: 0x004586CC
		public ESaveConfigEnterMethod EnterMethod { get; set; }

		// Token: 0x0601F2C1 RID: 127681 RVA: 0x0045A4D5 File Offset: 0x004586D5
		public ISaveConfigEnterMethodT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.EnterMethod = ESaveConfigEnterMethod.FirstTime;
		}
	}
}
