using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200685C RID: 26716
	public class IFoxPickUpT
	{
		// Token: 0x1700C66E RID: 50798
		// (get) Token: 0x0602E959 RID: 190809 RVA: 0x0065AC98 File Offset: 0x00658E98
		// (set) Token: 0x0602E95A RID: 190810 RVA: 0x0065ACA0 File Offset: 0x00658EA0
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C66F RID: 50799
		// (get) Token: 0x0602E95B RID: 190811 RVA: 0x0065ACA9 File Offset: 0x00658EA9
		// (set) Token: 0x0602E95C RID: 190812 RVA: 0x0065ACB1 File Offset: 0x00658EB1
		public int DataTableIndex { get; set; }

		// Token: 0x1700C670 RID: 50800
		// (get) Token: 0x0602E95D RID: 190813 RVA: 0x0065ACBA File Offset: 0x00658EBA
		// (set) Token: 0x0602E95E RID: 190814 RVA: 0x0065ACC2 File Offset: 0x00658EC2
		public bool MouthOpen { get; set; }

		// Token: 0x1700C671 RID: 50801
		// (get) Token: 0x0602E95F RID: 190815 RVA: 0x0065ACCB File Offset: 0x00658ECB
		// (set) Token: 0x0602E960 RID: 190816 RVA: 0x0065ACD3 File Offset: 0x00658ED3
		public byte NullMask { get; set; }

		// Token: 0x0602E961 RID: 190817 RVA: 0x0065ACDC File Offset: 0x00658EDC
		public IFoxPickUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.DataTableIndex = 0;
			this.MouthOpen = false;
			this.NullMask = 0;
		}
	}
}
