using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004116 RID: 16662
	public class IAlwaysTrueBtNodeT
	{
		// Token: 0x170070DB RID: 28891
		// (get) Token: 0x06016DC9 RID: 93641 RVA: 0x00343E88 File Offset: 0x00342088
		// (set) Token: 0x06016DCA RID: 93642 RVA: 0x00343E90 File Offset: 0x00342090
		public EBtNode Type { get; set; }

		// Token: 0x170070DC RID: 28892
		// (get) Token: 0x06016DCB RID: 93643 RVA: 0x00343E99 File Offset: 0x00342099
		// (set) Token: 0x06016DCC RID: 93644 RVA: 0x00343EA1 File Offset: 0x003420A1
		public int Id { get; set; }

		// Token: 0x170070DD RID: 28893
		// (get) Token: 0x06016DCD RID: 93645 RVA: 0x00343EAA File Offset: 0x003420AA
		// (set) Token: 0x06016DCE RID: 93646 RVA: 0x00343EB2 File Offset: 0x003420B2
		public string Desc { get; set; }

		// Token: 0x170070DE RID: 28894
		// (get) Token: 0x06016DCF RID: 93647 RVA: 0x00343EBB File Offset: 0x003420BB
		// (set) Token: 0x06016DD0 RID: 93648 RVA: 0x00343EC3 File Offset: 0x003420C3
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170070DF RID: 28895
		// (get) Token: 0x06016DD1 RID: 93649 RVA: 0x00343ECC File Offset: 0x003420CC
		// (set) Token: 0x06016DD2 RID: 93650 RVA: 0x00343ED4 File Offset: 0x003420D4
		public bool _FoldedForTree { get; set; }

		// Token: 0x170070E0 RID: 28896
		// (get) Token: 0x06016DD3 RID: 93651 RVA: 0x00343EDD File Offset: 0x003420DD
		// (set) Token: 0x06016DD4 RID: 93652 RVA: 0x00343EE5 File Offset: 0x003420E5
		public bool Disabled { get; set; }

		// Token: 0x170070E1 RID: 28897
		// (get) Token: 0x06016DD5 RID: 93653 RVA: 0x00343EEE File Offset: 0x003420EE
		// (set) Token: 0x06016DD6 RID: 93654 RVA: 0x00343EF6 File Offset: 0x003420F6
		public TBtNodeUnion Child { get; set; }

		// Token: 0x170070E2 RID: 28898
		// (get) Token: 0x06016DD7 RID: 93655 RVA: 0x00343EFF File Offset: 0x003420FF
		// (set) Token: 0x06016DD8 RID: 93656 RVA: 0x00343F07 File Offset: 0x00342107
		public byte NullMask { get; set; }

		// Token: 0x06016DD9 RID: 93657 RVA: 0x00343F10 File Offset: 0x00342110
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
