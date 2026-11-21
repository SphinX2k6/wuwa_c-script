using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200706E RID: 28782
	public class IItemGetUiConfigBaseT
	{
		// Token: 0x1700D2C9 RID: 53961
		// (get) Token: 0x06031E91 RID: 204433 RVA: 0x006C1506 File Offset: 0x006BF706
		// (set) Token: 0x06031E92 RID: 204434 RVA: 0x006C150E File Offset: 0x006BF70E
		public EItemGetUiType Type { get; set; }

		// Token: 0x06031E93 RID: 204435 RVA: 0x006C1517 File Offset: 0x006BF717
		public IItemGetUiConfigBaseT()
		{
			this.Type = EItemGetUiType.None;
		}
	}
}
