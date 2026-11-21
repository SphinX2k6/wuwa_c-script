using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EA RID: 21994
	public class IDestroyStageConfigT
	{
		// Token: 0x17009D80 RID: 40320
		// (get) Token: 0x0602303F RID: 143423 RVA: 0x004D17CB File Offset: 0x004CF9CB
		// (set) Token: 0x06023040 RID: 143424 RVA: 0x004D17D3 File Offset: 0x004CF9D3
		public float PerformDuration { get; set; }

		// Token: 0x17009D81 RID: 40321
		// (get) Token: 0x06023041 RID: 143425 RVA: 0x004D17DC File Offset: 0x004CF9DC
		// (set) Token: 0x06023042 RID: 143426 RVA: 0x004D17E4 File Offset: 0x004CF9E4
		public long BulletId { get; set; }

		// Token: 0x17009D82 RID: 40322
		// (get) Token: 0x06023043 RID: 143427 RVA: 0x004D17ED File Offset: 0x004CF9ED
		// (set) Token: 0x06023044 RID: 143428 RVA: 0x004D17F5 File Offset: 0x004CF9F5
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17009D83 RID: 40323
		// (get) Token: 0x06023045 RID: 143429 RVA: 0x004D17FE File Offset: 0x004CF9FE
		// (set) Token: 0x06023046 RID: 143430 RVA: 0x004D1806 File Offset: 0x004CFA06
		public byte NullMask { get; set; }

		// Token: 0x06023047 RID: 143431 RVA: 0x004D180F File Offset: 0x004CFA0F
		public IDestroyStageConfigT()
		{
			this.PerformDuration = 0f;
			this.BulletId = 0L;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
