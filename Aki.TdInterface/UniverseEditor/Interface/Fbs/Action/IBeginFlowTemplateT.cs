using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061FE RID: 25086
	public class IBeginFlowTemplateT
	{
		// Token: 0x1700BAFF RID: 47871
		// (get) Token: 0x0602B3E7 RID: 177127 RVA: 0x005F54AC File Offset: 0x005F36AC
		// (set) Token: 0x0602B3E8 RID: 177128 RVA: 0x005F54B4 File Offset: 0x005F36B4
		public bool _Folded { get; set; }

		// Token: 0x1700BB00 RID: 47872
		// (get) Token: 0x0602B3E9 RID: 177129 RVA: 0x005F54BD File Offset: 0x005F36BD
		// (set) Token: 0x0602B3EA RID: 177130 RVA: 0x005F54C5 File Offset: 0x005F36C5
		public List<IFlowActorUnitT> Actors { get; set; }

		// Token: 0x1700BB01 RID: 47873
		// (get) Token: 0x0602B3EB RID: 177131 RVA: 0x005F54CE File Offset: 0x005F36CE
		// (set) Token: 0x0602B3EC RID: 177132 RVA: 0x005F54D6 File Offset: 0x005F36D6
		public List<int> MontageIds { get; set; }

		// Token: 0x1700BB02 RID: 47874
		// (get) Token: 0x0602B3ED RID: 177133 RVA: 0x005F54DF File Offset: 0x005F36DF
		// (set) Token: 0x0602B3EE RID: 177134 RVA: 0x005F54E7 File Offset: 0x005F36E7
		public bool UseFreeCamera { get; set; }

		// Token: 0x1700BB03 RID: 47875
		// (get) Token: 0x0602B3EF RID: 177135 RVA: 0x005F54F0 File Offset: 0x005F36F0
		// (set) Token: 0x0602B3F0 RID: 177136 RVA: 0x005F54F8 File Offset: 0x005F36F8
		public bool IsSwitchMainRole { get; set; }

		// Token: 0x1700BB04 RID: 47876
		// (get) Token: 0x0602B3F1 RID: 177137 RVA: 0x005F5501 File Offset: 0x005F3701
		// (set) Token: 0x0602B3F2 RID: 177138 RVA: 0x005F5509 File Offset: 0x005F3709
		public bool IsUseSeqFace { get; set; }

		// Token: 0x1700BB05 RID: 47877
		// (get) Token: 0x0602B3F3 RID: 177139 RVA: 0x005F5512 File Offset: 0x005F3712
		// (set) Token: 0x0602B3F4 RID: 177140 RVA: 0x005F551A File Offset: 0x005F371A
		public byte NullMask { get; set; }

		// Token: 0x0602B3F5 RID: 177141 RVA: 0x005F5523 File Offset: 0x005F3723
		public IBeginFlowTemplateT()
		{
			this._Folded = false;
			this.Actors = null;
			this.MontageIds = null;
			this.UseFreeCamera = false;
			this.IsSwitchMainRole = false;
			this.IsUseSeqFace = false;
			this.NullMask = 0;
		}
	}
}
