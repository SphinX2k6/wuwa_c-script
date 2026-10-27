using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CFC RID: 15612
	public class IAlwaysFalseBtNodeT
	{
		// Token: 0x17006B10 RID: 27408
		// (get) Token: 0x06015851 RID: 88145 RVA: 0x0031C020 File Offset: 0x0031A220
		// (set) Token: 0x06015852 RID: 88146 RVA: 0x0031C028 File Offset: 0x0031A228
		public EBtNode Type { get; set; }

		// Token: 0x17006B11 RID: 27409
		// (get) Token: 0x06015853 RID: 88147 RVA: 0x0031C031 File Offset: 0x0031A231
		// (set) Token: 0x06015854 RID: 88148 RVA: 0x0031C039 File Offset: 0x0031A239
		public int Id { get; set; }

		// Token: 0x17006B12 RID: 27410
		// (get) Token: 0x06015855 RID: 88149 RVA: 0x0031C042 File Offset: 0x0031A242
		// (set) Token: 0x06015856 RID: 88150 RVA: 0x0031C04A File Offset: 0x0031A24A
		public string Desc { get; set; }

		// Token: 0x17006B13 RID: 27411
		// (get) Token: 0x06015857 RID: 88151 RVA: 0x0031C053 File Offset: 0x0031A253
		// (set) Token: 0x06015858 RID: 88152 RVA: 0x0031C05B File Offset: 0x0031A25B
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006B14 RID: 27412
		// (get) Token: 0x06015859 RID: 88153 RVA: 0x0031C064 File Offset: 0x0031A264
		// (set) Token: 0x0601585A RID: 88154 RVA: 0x0031C06C File Offset: 0x0031A26C
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006B15 RID: 27413
		// (get) Token: 0x0601585B RID: 88155 RVA: 0x0031C075 File Offset: 0x0031A275
		// (set) Token: 0x0601585C RID: 88156 RVA: 0x0031C07D File Offset: 0x0031A27D
		public bool Disabled { get; set; }

		// Token: 0x17006B16 RID: 27414
		// (get) Token: 0x0601585D RID: 88157 RVA: 0x0031C086 File Offset: 0x0031A286
		// (set) Token: 0x0601585E RID: 88158 RVA: 0x0031C08E File Offset: 0x0031A28E
		public TBtNodeUnion Child { get; set; }

		// Token: 0x17006B17 RID: 27415
		// (get) Token: 0x0601585F RID: 88159 RVA: 0x0031C097 File Offset: 0x0031A297
		// (set) Token: 0x06015860 RID: 88160 RVA: 0x0031C09F File Offset: 0x0031A29F
		public byte NullMask { get; set; }

		// Token: 0x06015861 RID: 88161 RVA: 0x0031C0A8 File Offset: 0x0031A2A8
		public IAlwaysFalseBtNodeT()
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
