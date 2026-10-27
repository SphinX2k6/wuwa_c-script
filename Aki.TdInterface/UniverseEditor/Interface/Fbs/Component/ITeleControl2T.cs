using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3B RID: 23099
	public class ITeleControl2T
	{
		// Token: 0x1700ADC0 RID: 44480
		// (get) Token: 0x0602746A RID: 160874 RVA: 0x00567C9D File Offset: 0x00565E9D
		// (set) Token: 0x0602746B RID: 160875 RVA: 0x00567CA5 File Offset: 0x00565EA5
		public bool Disabled { get; set; }

		// Token: 0x1700ADC1 RID: 44481
		// (get) Token: 0x0602746C RID: 160876 RVA: 0x00567CAE File Offset: 0x00565EAE
		// (set) Token: 0x0602746D RID: 160877 RVA: 0x00567CB6 File Offset: 0x00565EB6
		public ITeleControlBaseCfgT BaseCfg { get; set; }

		// Token: 0x1700ADC2 RID: 44482
		// (get) Token: 0x0602746E RID: 160878 RVA: 0x00567CBF File Offset: 0x00565EBF
		// (set) Token: 0x0602746F RID: 160879 RVA: 0x00567CC7 File Offset: 0x00565EC7
		public ISearchTargetCfgT SearchTargetCfg { get; set; }

		// Token: 0x1700ADC3 RID: 44483
		// (get) Token: 0x06027470 RID: 160880 RVA: 0x00567CD0 File Offset: 0x00565ED0
		// (set) Token: 0x06027471 RID: 160881 RVA: 0x00567CD8 File Offset: 0x00565ED8
		public IBulletCfgT BulletCfg { get; set; }

		// Token: 0x1700ADC4 RID: 44484
		// (get) Token: 0x06027472 RID: 160882 RVA: 0x00567CE1 File Offset: 0x00565EE1
		// (set) Token: 0x06027473 RID: 160883 RVA: 0x00567CE9 File Offset: 0x00565EE9
		public IDestroyCfgT DestroyCfg { get; set; }

		// Token: 0x1700ADC5 RID: 44485
		// (get) Token: 0x06027474 RID: 160884 RVA: 0x00567CF2 File Offset: 0x00565EF2
		// (set) Token: 0x06027475 RID: 160885 RVA: 0x00567CFA File Offset: 0x00565EFA
		public IHoldCfgT HoldCfg { get; set; }

		// Token: 0x1700ADC6 RID: 44486
		// (get) Token: 0x06027476 RID: 160886 RVA: 0x00567D03 File Offset: 0x00565F03
		// (set) Token: 0x06027477 RID: 160887 RVA: 0x00567D0B File Offset: 0x00565F0B
		public IThrowCfgT ThrowCfg { get; set; }

		// Token: 0x1700ADC7 RID: 44487
		// (get) Token: 0x06027478 RID: 160888 RVA: 0x00567D14 File Offset: 0x00565F14
		// (set) Token: 0x06027479 RID: 160889 RVA: 0x00567D1C File Offset: 0x00565F1C
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700ADC8 RID: 44488
		// (get) Token: 0x0602747A RID: 160890 RVA: 0x00567D25 File Offset: 0x00565F25
		// (set) Token: 0x0602747B RID: 160891 RVA: 0x00567D2D File Offset: 0x00565F2D
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700ADC9 RID: 44489
		// (get) Token: 0x0602747C RID: 160892 RVA: 0x00567D36 File Offset: 0x00565F36
		// (set) Token: 0x0602747D RID: 160893 RVA: 0x00567D3E File Offset: 0x00565F3E
		public TTeleCtrlTriggerConfigUnion TriggerCfg { get; set; }

		// Token: 0x1700ADCA RID: 44490
		// (get) Token: 0x0602747E RID: 160894 RVA: 0x00567D47 File Offset: 0x00565F47
		// (set) Token: 0x0602747F RID: 160895 RVA: 0x00567D4F File Offset: 0x00565F4F
		public byte NullMask { get; set; }

		// Token: 0x06027480 RID: 160896 RVA: 0x00567D58 File Offset: 0x00565F58
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
