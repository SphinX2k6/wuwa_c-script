using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005608 RID: 22024
	public class IDollGrabMachineComponentT
	{
		// Token: 0x17009DE7 RID: 40423
		// (get) Token: 0x060231C9 RID: 143817 RVA: 0x004D5511 File Offset: 0x004D3711
		// (set) Token: 0x060231CA RID: 143818 RVA: 0x004D5519 File Offset: 0x004D3719
		public bool Disabled { get; set; }

		// Token: 0x17009DE8 RID: 40424
		// (get) Token: 0x060231CB RID: 143819 RVA: 0x004D5522 File Offset: 0x004D3722
		// (set) Token: 0x060231CC RID: 143820 RVA: 0x004D552A File Offset: 0x004D372A
		public EDollGrabShowcaseBelongType BelongType { get; set; }

		// Token: 0x17009DE9 RID: 40425
		// (get) Token: 0x060231CD RID: 143821 RVA: 0x004D5533 File Offset: 0x004D3733
		// (set) Token: 0x060231CE RID: 143822 RVA: 0x004D553B File Offset: 0x004D373B
		public float TimeLimit { get; set; }

		// Token: 0x17009DEA RID: 40426
		// (get) Token: 0x060231CF RID: 143823 RVA: 0x004D5544 File Offset: 0x004D3744
		// (set) Token: 0x060231D0 RID: 143824 RVA: 0x004D554C File Offset: 0x004D374C
		public float PlayCost { get; set; }

		// Token: 0x17009DEB RID: 40427
		// (get) Token: 0x060231D1 RID: 143825 RVA: 0x004D5555 File Offset: 0x004D3755
		// (set) Token: 0x060231D2 RID: 143826 RVA: 0x004D555D File Offset: 0x004D375D
		public List<IDollGrabItemT> Items { get; set; }

		// Token: 0x17009DEC RID: 40428
		// (get) Token: 0x060231D3 RID: 143827 RVA: 0x004D5566 File Offset: 0x004D3766
		// (set) Token: 0x060231D4 RID: 143828 RVA: 0x004D556E File Offset: 0x004D376E
		public IDollGrabInfiniteModeDataT InfiniteModeData { get; set; }

		// Token: 0x17009DED RID: 40429
		// (get) Token: 0x060231D5 RID: 143829 RVA: 0x004D5577 File Offset: 0x004D3777
		// (set) Token: 0x060231D6 RID: 143830 RVA: 0x004D557F File Offset: 0x004D377F
		public string AkEvent { get; set; }

		// Token: 0x17009DEE RID: 40430
		// (get) Token: 0x060231D7 RID: 143831 RVA: 0x004D5588 File Offset: 0x004D3788
		// (set) Token: 0x060231D8 RID: 143832 RVA: 0x004D5590 File Offset: 0x004D3790
		public byte NullMask { get; set; }

		// Token: 0x060231D9 RID: 143833 RVA: 0x004D559C File Offset: 0x004D379C
		public IDollGrabMachineComponentT()
		{
			this.Disabled = false;
			this.BelongType = EDollGrabShowcaseBelongType.LandOfXuanfang;
			this.TimeLimit = 0f;
			this.PlayCost = 0f;
			this.Items = null;
			this.InfiniteModeData = null;
			this.AkEvent = null;
			this.NullMask = 0;
		}
	}
}
