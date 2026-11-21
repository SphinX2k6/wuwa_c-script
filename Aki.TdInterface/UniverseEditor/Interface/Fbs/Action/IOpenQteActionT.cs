using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007380 RID: 29568
	public class IOpenQteActionT
	{
		// Token: 0x1700D8EF RID: 55535
		// (get) Token: 0x06033A0D RID: 211469 RVA: 0x006F5AD1 File Offset: 0x006F3CD1
		// (set) Token: 0x06033A0E RID: 211470 RVA: 0x006F5AD9 File Offset: 0x006F3CD9
		public TOpenQteConfigUnion Config { get; set; }

		// Token: 0x06033A0F RID: 211471 RVA: 0x006F5AE2 File Offset: 0x006F3CE2
		public IOpenQteActionT()
		{
			this.Config = null;
		}
	}
}
