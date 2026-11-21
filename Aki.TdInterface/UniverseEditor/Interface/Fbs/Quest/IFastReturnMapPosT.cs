using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425D RID: 16989
	public class IFastReturnMapPosT
	{
		// Token: 0x170073E3 RID: 29667
		// (get) Token: 0x06017ACC RID: 96972 RVA: 0x00360BD2 File Offset: 0x0035EDD2
		// (set) Token: 0x06017ACD RID: 96973 RVA: 0x00360BDA File Offset: 0x0035EDDA
		public string TidTip { get; set; }

		// Token: 0x170073E4 RID: 29668
		// (get) Token: 0x06017ACE RID: 96974 RVA: 0x00360BE3 File Offset: 0x0035EDE3
		// (set) Token: 0x06017ACF RID: 96975 RVA: 0x00360BEB File Offset: 0x0035EDEB
		public List<IConditionGroupT> ShowButtonConditionGroup { get; set; }

		// Token: 0x170073E5 RID: 29669
		// (get) Token: 0x06017AD0 RID: 96976 RVA: 0x00360BF4 File Offset: 0x0035EDF4
		// (set) Token: 0x06017AD1 RID: 96977 RVA: 0x00360BFC File Offset: 0x0035EDFC
		public TFastReturnPosUnion DefaultPos { get; set; }

		// Token: 0x170073E6 RID: 29670
		// (get) Token: 0x06017AD2 RID: 96978 RVA: 0x00360C05 File Offset: 0x0035EE05
		// (set) Token: 0x06017AD3 RID: 96979 RVA: 0x00360C0D File Offset: 0x0035EE0D
		public List<IConditionReturnPosT> ConditionPositionGroup { get; set; }

		// Token: 0x170073E7 RID: 29671
		// (get) Token: 0x06017AD4 RID: 96980 RVA: 0x00360C16 File Offset: 0x0035EE16
		// (set) Token: 0x06017AD5 RID: 96981 RVA: 0x00360C1E File Offset: 0x0035EE1E
		public byte NullMask { get; set; }

		// Token: 0x06017AD6 RID: 96982 RVA: 0x00360C27 File Offset: 0x0035EE27
		public IFastReturnMapPosT()
		{
			this.TidTip = null;
			this.ShowButtonConditionGroup = null;
			this.DefaultPos = null;
			this.ConditionPositionGroup = null;
			this.NullMask = 0;
		}
	}
}
