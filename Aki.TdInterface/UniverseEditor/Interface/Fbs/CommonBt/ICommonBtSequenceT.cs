using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200650D RID: 25869
	public class ICommonBtSequenceT
	{
		// Token: 0x1700BEDA RID: 48858
		// (get) Token: 0x0602C13F RID: 180543 RVA: 0x00600F1F File Offset: 0x005FF11F
		// (set) Token: 0x0602C140 RID: 180544 RVA: 0x00600F27 File Offset: 0x005FF127
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BEDB RID: 48859
		// (get) Token: 0x0602C141 RID: 180545 RVA: 0x00600F30 File Offset: 0x005FF130
		// (set) Token: 0x0602C142 RID: 180546 RVA: 0x00600F38 File Offset: 0x005FF138
		public int Id { get; set; }

		// Token: 0x1700BEDC RID: 48860
		// (get) Token: 0x0602C143 RID: 180547 RVA: 0x00600F41 File Offset: 0x005FF141
		// (set) Token: 0x0602C144 RID: 180548 RVA: 0x00600F49 File Offset: 0x005FF149
		public string Desc { get; set; }

		// Token: 0x1700BEDD RID: 48861
		// (get) Token: 0x0602C145 RID: 180549 RVA: 0x00600F52 File Offset: 0x005FF152
		// (set) Token: 0x0602C146 RID: 180550 RVA: 0x00600F5A File Offset: 0x005FF15A
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BEDE RID: 48862
		// (get) Token: 0x0602C147 RID: 180551 RVA: 0x00600F63 File Offset: 0x005FF163
		// (set) Token: 0x0602C148 RID: 180552 RVA: 0x00600F6B File Offset: 0x005FF16B
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BEDF RID: 48863
		// (get) Token: 0x0602C149 RID: 180553 RVA: 0x00600F74 File Offset: 0x005FF174
		// (set) Token: 0x0602C14A RID: 180554 RVA: 0x00600F7C File Offset: 0x005FF17C
		public List<TCommonBtNodeUnion> Children { get; set; }

		// Token: 0x1700BEE0 RID: 48864
		// (get) Token: 0x0602C14B RID: 180555 RVA: 0x00600F85 File Offset: 0x005FF185
		// (set) Token: 0x0602C14C RID: 180556 RVA: 0x00600F8D File Offset: 0x005FF18D
		public byte NullMask { get; set; }

		// Token: 0x0602C14D RID: 180557 RVA: 0x00600F96 File Offset: 0x005FF196
		public ICommonBtSequenceT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.Children = null;
			this.NullMask = 0;
		}
	}
}
