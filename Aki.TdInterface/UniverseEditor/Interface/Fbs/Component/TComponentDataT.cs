using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF5 RID: 23541
	public class TComponentDataT
	{
		// Token: 0x1700B1D0 RID: 45520
		// (get) Token: 0x06028637 RID: 165431 RVA: 0x0058F623 File Offset: 0x0058D823
		// (set) Token: 0x06028638 RID: 165432 RVA: 0x0058F62B File Offset: 0x0058D82B
		public string Key { get; set; }

		// Token: 0x1700B1D1 RID: 45521
		// (get) Token: 0x06028639 RID: 165433 RVA: 0x0058F634 File Offset: 0x0058D834
		// (set) Token: 0x0602863A RID: 165434 RVA: 0x0058F63C File Offset: 0x0058D83C
		public IComponentBase_UnionUnion Value { get; set; }

		// Token: 0x0602863B RID: 165435 RVA: 0x0058F645 File Offset: 0x0058D845
		public TComponentDataT()
		{
			this.Key = null;
			this.Value = null;
		}
	}
}
