using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D8 RID: 26584
	public class IFixGetItemT
	{
		// Token: 0x1700C556 RID: 50518
		// (get) Token: 0x0602E47E RID: 189566 RVA: 0x00651D25 File Offset: 0x0064FF25
		// (set) Token: 0x0602E47F RID: 189567 RVA: 0x00651D2D File Offset: 0x0064FF2D
		public List<IItemDataT> Items { get; set; }

		// Token: 0x0602E480 RID: 189568 RVA: 0x00651D36 File Offset: 0x0064FF36
		public IFixGetItemT()
		{
			this.Items = null;
		}
	}
}
