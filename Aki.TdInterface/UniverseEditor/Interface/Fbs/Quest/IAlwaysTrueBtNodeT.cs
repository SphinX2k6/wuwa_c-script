using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFF RID: 15615
	public class IAlwaysTrueBtNodeT
	{
		// Token: 0x17006B21 RID: 27425
		// (get) Token: 0x06015891 RID: 88209 RVA: 0x0031CC10 File Offset: 0x0031AE10
		// (set) Token: 0x06015892 RID: 88210 RVA: 0x0031CC18 File Offset: 0x0031AE18
		public EBtNode Type { get; set; }

		// Token: 0x17006B22 RID: 27426
		// (get) Token: 0x06015893 RID: 88211 RVA: 0x0031CC21 File Offset: 0x0031AE21
		// (set) Token: 0x06015894 RID: 88212 RVA: 0x0031CC29 File Offset: 0x0031AE29
		public int Id { get; set; }

		// Token: 0x17006B23 RID: 27427
		// (get) Token: 0x06015895 RID: 88213 RVA: 0x0031CC32 File Offset: 0x0031AE32
		// (set) Token: 0x06015896 RID: 88214 RVA: 0x0031CC3A File Offset: 0x0031AE3A
		public string Desc { get; set; }

		// Token: 0x17006B24 RID: 27428
		// (get) Token: 0x06015897 RID: 88215 RVA: 0x0031CC43 File Offset: 0x0031AE43
		// (set) Token: 0x06015898 RID: 88216 RVA: 0x0031CC4B File Offset: 0x0031AE4B
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006B25 RID: 27429
		// (get) Token: 0x06015899 RID: 88217 RVA: 0x0031CC54 File Offset: 0x0031AE54
		// (set) Token: 0x0601589A RID: 88218 RVA: 0x0031CC5C File Offset: 0x0031AE5C
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006B26 RID: 27430
		// (get) Token: 0x0601589B RID: 88219 RVA: 0x0031CC65 File Offset: 0x0031AE65
		// (set) Token: 0x0601589C RID: 88220 RVA: 0x0031CC6D File Offset: 0x0031AE6D
		public bool Disabled { get; set; }

		// Token: 0x17006B27 RID: 27431
		// (get) Token: 0x0601589D RID: 88221 RVA: 0x0031CC76 File Offset: 0x0031AE76
		// (set) Token: 0x0601589E RID: 88222 RVA: 0x0031CC7E File Offset: 0x0031AE7E
		public TBtNodeUnion Child { get; set; }

		// Token: 0x17006B28 RID: 27432
		// (get) Token: 0x0601589F RID: 88223 RVA: 0x0031CC87 File Offset: 0x0031AE87
		// (set) Token: 0x060158A0 RID: 88224 RVA: 0x0031CC8F File Offset: 0x0031AE8F
		public byte NullMask { get; set; }

		// Token: 0x060158A1 RID: 88225 RVA: 0x0031CC98 File Offset: 0x0031AE98
		public IAlwaysTrueBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Child = null;
			this.NullMask = 0;
		}
	}
}
