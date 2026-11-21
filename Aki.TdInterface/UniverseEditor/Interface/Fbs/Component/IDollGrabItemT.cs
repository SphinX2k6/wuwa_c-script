using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005605 RID: 22021
	public class IDollGrabItemT
	{
		// Token: 0x17009DDC RID: 40412
		// (get) Token: 0x0602319F RID: 143775 RVA: 0x004D4E60 File Offset: 0x004D3060
		// (set) Token: 0x060231A0 RID: 143776 RVA: 0x004D4E68 File Offset: 0x004D3068
		public int Id { get; set; }

		// Token: 0x17009DDD RID: 40413
		// (get) Token: 0x060231A1 RID: 143777 RVA: 0x004D4E71 File Offset: 0x004D3071
		// (set) Token: 0x060231A2 RID: 143778 RVA: 0x004D4E79 File Offset: 0x004D3079
		public int ItemId { get; set; }

		// Token: 0x060231A3 RID: 143779 RVA: 0x004D4E82 File Offset: 0x004D3082
		public IDollGrabItemT()
		{
			this.Id = 0;
			this.ItemId = 0;
		}
	}
}
