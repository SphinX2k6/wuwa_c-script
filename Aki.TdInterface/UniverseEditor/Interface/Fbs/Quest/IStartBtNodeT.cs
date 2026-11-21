using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200458A RID: 17802
	public class IStartBtNodeT
	{
		// Token: 0x17007C66 RID: 31846
		// (get) Token: 0x06019F08 RID: 106248 RVA: 0x003B3184 File Offset: 0x003B1384
		// (set) Token: 0x06019F09 RID: 106249 RVA: 0x003B318C File Offset: 0x003B138C
		public EBtNode Type { get; set; }

		// Token: 0x17007C67 RID: 31847
		// (get) Token: 0x06019F0A RID: 106250 RVA: 0x003B3195 File Offset: 0x003B1395
		// (set) Token: 0x06019F0B RID: 106251 RVA: 0x003B319D File Offset: 0x003B139D
		public int Id { get; set; }

		// Token: 0x17007C68 RID: 31848
		// (get) Token: 0x06019F0C RID: 106252 RVA: 0x003B31A6 File Offset: 0x003B13A6
		// (set) Token: 0x06019F0D RID: 106253 RVA: 0x003B31AE File Offset: 0x003B13AE
		public string Desc { get; set; }

		// Token: 0x17007C69 RID: 31849
		// (get) Token: 0x06019F0E RID: 106254 RVA: 0x003B31B7 File Offset: 0x003B13B7
		// (set) Token: 0x06019F0F RID: 106255 RVA: 0x003B31BF File Offset: 0x003B13BF
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007C6A RID: 31850
		// (get) Token: 0x06019F10 RID: 106256 RVA: 0x003B31C8 File Offset: 0x003B13C8
		// (set) Token: 0x06019F11 RID: 106257 RVA: 0x003B31D0 File Offset: 0x003B13D0
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007C6B RID: 31851
		// (get) Token: 0x06019F12 RID: 106258 RVA: 0x003B31D9 File Offset: 0x003B13D9
		// (set) Token: 0x06019F13 RID: 106259 RVA: 0x003B31E1 File Offset: 0x003B13E1
		public bool Disabled { get; set; }

		// Token: 0x17007C6C RID: 31852
		// (get) Token: 0x06019F14 RID: 106260 RVA: 0x003B31EA File Offset: 0x003B13EA
		// (set) Token: 0x06019F15 RID: 106261 RVA: 0x003B31F2 File Offset: 0x003B13F2
		public TBtNodeUnion Child { get; set; }

		// Token: 0x17007C6D RID: 31853
		// (get) Token: 0x06019F16 RID: 106262 RVA: 0x003B31FB File Offset: 0x003B13FB
		// (set) Token: 0x06019F17 RID: 106263 RVA: 0x003B3203 File Offset: 0x003B1403
		public byte NullMask { get; set; }

		// Token: 0x06019F18 RID: 106264 RVA: 0x003B320C File Offset: 0x003B140C
		public IStartBtNodeT()
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
