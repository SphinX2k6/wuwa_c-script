using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006513 RID: 25875
	public class ICommonBtTaskT
	{
		// Token: 0x1700BEFA RID: 48890
		// (get) Token: 0x0602C1BE RID: 180670 RVA: 0x0060252E File Offset: 0x0060072E
		// (set) Token: 0x0602C1BF RID: 180671 RVA: 0x00602536 File Offset: 0x00600736
		public ECommonBtNodeType Type { get; set; }

		// Token: 0x1700BEFB RID: 48891
		// (get) Token: 0x0602C1C0 RID: 180672 RVA: 0x0060253F File Offset: 0x0060073F
		// (set) Token: 0x0602C1C1 RID: 180673 RVA: 0x00602547 File Offset: 0x00600747
		public int Id { get; set; }

		// Token: 0x1700BEFC RID: 48892
		// (get) Token: 0x0602C1C2 RID: 180674 RVA: 0x00602550 File Offset: 0x00600750
		// (set) Token: 0x0602C1C3 RID: 180675 RVA: 0x00602558 File Offset: 0x00600758
		public string Desc { get; set; }

		// Token: 0x1700BEFD RID: 48893
		// (get) Token: 0x0602C1C4 RID: 180676 RVA: 0x00602561 File Offset: 0x00600761
		// (set) Token: 0x0602C1C5 RID: 180677 RVA: 0x00602569 File Offset: 0x00600769
		public List<TCommonBtDecoratorUnion> Decorators { get; set; }

		// Token: 0x1700BEFE RID: 48894
		// (get) Token: 0x0602C1C6 RID: 180678 RVA: 0x00602572 File Offset: 0x00600772
		// (set) Token: 0x0602C1C7 RID: 180679 RVA: 0x0060257A File Offset: 0x0060077A
		public bool _FoldedForTree { get; set; }

		// Token: 0x1700BEFF RID: 48895
		// (get) Token: 0x0602C1C8 RID: 180680 RVA: 0x00602583 File Offset: 0x00600783
		// (set) Token: 0x0602C1C9 RID: 180681 RVA: 0x0060258B File Offset: 0x0060078B
		public ICommonBtActionInfoT ActionInfo { get; set; }

		// Token: 0x1700BF00 RID: 48896
		// (get) Token: 0x0602C1CA RID: 180682 RVA: 0x00602594 File Offset: 0x00600794
		// (set) Token: 0x0602C1CB RID: 180683 RVA: 0x0060259C File Offset: 0x0060079C
		public byte NullMask { get; set; }

		// Token: 0x0602C1CC RID: 180684 RVA: 0x006025A5 File Offset: 0x006007A5
		public ICommonBtTaskT()
		{
			this.Type = ECommonBtNodeType.Start;
			this.Id = 0;
			this.Desc = null;
			this.Decorators = null;
			this._FoldedForTree = false;
			this.ActionInfo = null;
			this.NullMask = 0;
		}
	}
}
