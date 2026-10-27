using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B8 RID: 27064
	public class IItemDataT
	{
		// Token: 0x1700C8C2 RID: 51394
		// (get) Token: 0x0602F4AB RID: 193707 RVA: 0x00670E98 File Offset: 0x0066F098
		// (set) Token: 0x0602F4AC RID: 193708 RVA: 0x00670EA0 File Offset: 0x0066F0A0
		public int ItemId { get; set; }

		// Token: 0x1700C8C3 RID: 51395
		// (get) Token: 0x0602F4AD RID: 193709 RVA: 0x00670EA9 File Offset: 0x0066F0A9
		// (set) Token: 0x0602F4AE RID: 193710 RVA: 0x00670EB1 File Offset: 0x0066F0B1
		public int Count { get; set; }

		// Token: 0x0602F4AF RID: 193711 RVA: 0x00670EBA File Offset: 0x0066F0BA
		public IItemDataT()
		{
			this.ItemId = 0;
			this.Count = 0;
		}
	}
}
