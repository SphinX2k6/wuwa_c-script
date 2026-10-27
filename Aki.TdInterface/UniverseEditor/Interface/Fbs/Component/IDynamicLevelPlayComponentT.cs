using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E5 RID: 20709
	public class IDynamicLevelPlayComponentT
	{
		// Token: 0x170096C2 RID: 38594
		// (get) Token: 0x06021565 RID: 136549 RVA: 0x004A12BE File Offset: 0x0049F4BE
		// (set) Token: 0x06021566 RID: 136550 RVA: 0x004A12C6 File Offset: 0x0049F4C6
		public bool Disabled { get; set; }

		// Token: 0x170096C3 RID: 38595
		// (get) Token: 0x06021567 RID: 136551 RVA: 0x004A12CF File Offset: 0x0049F4CF
		// (set) Token: 0x06021568 RID: 136552 RVA: 0x004A12D7 File Offset: 0x0049F4D7
		public int DynamicLevelPlayId { get; set; }

		// Token: 0x170096C4 RID: 38596
		// (get) Token: 0x06021569 RID: 136553 RVA: 0x004A12E0 File Offset: 0x0049F4E0
		// (set) Token: 0x0602156A RID: 136554 RVA: 0x004A12E8 File Offset: 0x0049F4E8
		public byte NullMask { get; set; }

		// Token: 0x0602156B RID: 136555 RVA: 0x004A12F1 File Offset: 0x0049F4F1
		public IDynamicLevelPlayComponentT()
		{
			this.Disabled = false;
			this.DynamicLevelPlayId = 0;
			this.NullMask = 0;
		}
	}
}
