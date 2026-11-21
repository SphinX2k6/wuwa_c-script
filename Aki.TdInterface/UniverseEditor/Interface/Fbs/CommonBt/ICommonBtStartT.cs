using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006510 RID: 25872
	public class ICommonBtStartT
	{
		// Token: 0x1700BEEA RID: 48874
		// (get) Token: 0x0602C182 RID: 180610 RVA: 0x00601B0F File Offset: 0x005FFD0F
		// (set) Token: 0x0602C183 RID: 180611 RVA: 0x00601B17 File Offset: 0x005FFD17
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BEEB RID: 48875
		// (get) Token: 0x0602C184 RID: 180612 RVA: 0x00601B20 File Offset: 0x005FFD20
		// (set) Token: 0x0602C185 RID: 180613 RVA: 0x00601B28 File Offset: 0x005FFD28
		public int Id { get; set; }

		// Token: 0x1700BEEC RID: 48876
		// (get) Token: 0x0602C186 RID: 180614 RVA: 0x00601B31 File Offset: 0x005FFD31
		// (set) Token: 0x0602C187 RID: 180615 RVA: 0x00601B39 File Offset: 0x005FFD39
		public string Desc { get; set; }

		// Token: 0x1700BEED RID: 48877
		// (get) Token: 0x0602C188 RID: 180616 RVA: 0x00601B42 File Offset: 0x005FFD42
		// (set) Token: 0x0602C189 RID: 180617 RVA: 0x00601B4A File Offset: 0x005FFD4A
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BEEE RID: 48878
		// (get) Token: 0x0602C18A RID: 180618 RVA: 0x00601B53 File Offset: 0x005FFD53
		// (set) Token: 0x0602C18B RID: 180619 RVA: 0x00601B5B File Offset: 0x005FFD5B
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BEEF RID: 48879
		// (get) Token: 0x0602C18C RID: 180620 RVA: 0x00601B64 File Offset: 0x005FFD64
		// (set) Token: 0x0602C18D RID: 180621 RVA: 0x00601B6C File Offset: 0x005FFD6C
		public TCommonBtNodeUnion Child { get; set; }

		// Token: 0x1700BEF0 RID: 48880
		// (get) Token: 0x0602C18E RID: 180622 RVA: 0x00601B75 File Offset: 0x005FFD75
		// (set) Token: 0x0602C18F RID: 180623 RVA: 0x00601B7D File Offset: 0x005FFD7D
		public byte NullMask { get; set; }

		// Token: 0x0602C190 RID: 180624 RVA: 0x00601B86 File Offset: 0x005FFD86
		public ICommonBtStartT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
