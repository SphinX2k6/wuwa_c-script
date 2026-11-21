using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006048 RID: 24648
	public class ITeleControl2T
	{
		// Token: 0x1700B6F8 RID: 46840
		// (get) Token: 0x060299E2 RID: 170466 RVA: 0x005AECA9 File Offset: 0x005ACEA9
		// (set) Token: 0x060299E3 RID: 170467 RVA: 0x005AECB1 File Offset: 0x005ACEB1
		public bool Disabled { get; set; }

		// Token: 0x1700B6F9 RID: 46841
		// (get) Token: 0x060299E4 RID: 170468 RVA: 0x005AECBA File Offset: 0x005ACEBA
		// (set) Token: 0x060299E5 RID: 170469 RVA: 0x005AECC2 File Offset: 0x005ACEC2
		public ITeleControlBaseCfgT BaseCfg { get; set; }

		// Token: 0x1700B6FA RID: 46842
		// (get) Token: 0x060299E6 RID: 170470 RVA: 0x005AECCB File Offset: 0x005ACECB
		// (set) Token: 0x060299E7 RID: 170471 RVA: 0x005AECD3 File Offset: 0x005ACED3
		public ISearchTargetCfgT SearchTargetCfg { get; set; }

		// Token: 0x1700B6FB RID: 46843
		// (get) Token: 0x060299E8 RID: 170472 RVA: 0x005AECDC File Offset: 0x005ACEDC
		// (set) Token: 0x060299E9 RID: 170473 RVA: 0x005AECE4 File Offset: 0x005ACEE4
		public IBulletCfgT BulletCfg { get; set; }

		// Token: 0x1700B6FC RID: 46844
		// (get) Token: 0x060299EA RID: 170474 RVA: 0x005AECED File Offset: 0x005ACEED
		// (set) Token: 0x060299EB RID: 170475 RVA: 0x005AECF5 File Offset: 0x005ACEF5
		public IDestroyCfgT DestroyCfg { get; set; }

		// Token: 0x1700B6FD RID: 46845
		// (get) Token: 0x060299EC RID: 170476 RVA: 0x005AECFE File Offset: 0x005ACEFE
		// (set) Token: 0x060299ED RID: 170477 RVA: 0x005AED06 File Offset: 0x005ACF06
		public IHoldCfgT HoldCfg { get; set; }

		// Token: 0x1700B6FE RID: 46846
		// (get) Token: 0x060299EE RID: 170478 RVA: 0x005AED0F File Offset: 0x005ACF0F
		// (set) Token: 0x060299EF RID: 170479 RVA: 0x005AED17 File Offset: 0x005ACF17
		public IThrowCfgT ThrowCfg { get; set; }

		// Token: 0x1700B6FF RID: 46847
		// (get) Token: 0x060299F0 RID: 170480 RVA: 0x005AED20 File Offset: 0x005ACF20
		// (set) Token: 0x060299F1 RID: 170481 RVA: 0x005AED28 File Offset: 0x005ACF28
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700B700 RID: 46848
		// (get) Token: 0x060299F2 RID: 170482 RVA: 0x005AED31 File Offset: 0x005ACF31
		// (set) Token: 0x060299F3 RID: 170483 RVA: 0x005AED39 File Offset: 0x005ACF39
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700B701 RID: 46849
		// (get) Token: 0x060299F4 RID: 170484 RVA: 0x005AED42 File Offset: 0x005ACF42
		// (set) Token: 0x060299F5 RID: 170485 RVA: 0x005AED4A File Offset: 0x005ACF4A
		public TTeleCtrlTriggerConfigUnion TriggerCfg { get; set; }

		// Token: 0x1700B702 RID: 46850
		// (get) Token: 0x060299F6 RID: 170486 RVA: 0x005AED53 File Offset: 0x005ACF53
		// (set) Token: 0x060299F7 RID: 170487 RVA: 0x005AED5B File Offset: 0x005ACF5B
		public byte NullMask { get; set; }

		// Token: 0x060299F8 RID: 170488 RVA: 0x005AED64 File Offset: 0x005ACF64
		public ITeleControl2T()
		{
			this.Disabled = false;
			this.BaseCfg = null;
			this.SearchTargetCfg = null;
			this.BulletCfg = null;
			this.DestroyCfg = null;
			this.HoldCfg = null;
			this.ThrowCfg = null;
			this.PlayerStateRestritionId = 0;
			this.MatchRoleOption = null;
			this.TriggerCfg = null;
			this.NullMask = 0;
		}
	}
}
