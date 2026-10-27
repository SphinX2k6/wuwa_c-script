using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E78 RID: 20088
	public class IAiComponentT
	{
		// Token: 0x17008FE5 RID: 36837
		// (get) Token: 0x0601F936 RID: 129334 RVA: 0x0046610A File Offset: 0x0046430A
		// (set) Token: 0x0601F937 RID: 129335 RVA: 0x00466112 File Offset: 0x00464312
		public bool Disabled { get; set; }

		// Token: 0x17008FE6 RID: 36838
		// (get) Token: 0x0601F938 RID: 129336 RVA: 0x0046611B File Offset: 0x0046431B
		// (set) Token: 0x0601F939 RID: 129337 RVA: 0x00466123 File Offset: 0x00464323
		public int AiId { get; set; }

		// Token: 0x17008FE7 RID: 36839
		// (get) Token: 0x0601F93A RID: 129338 RVA: 0x0046612C File Offset: 0x0046432C
		// (set) Token: 0x0601F93B RID: 129339 RVA: 0x00466134 File Offset: 0x00464334
		public IPatrolT Patrol { get; set; }

		// Token: 0x17008FE8 RID: 36840
		// (get) Token: 0x0601F93C RID: 129340 RVA: 0x0046613D File Offset: 0x0046433D
		// (set) Token: 0x0601F93D RID: 129341 RVA: 0x00466145 File Offset: 0x00464345
		public TInitStateUnion InitState { get; set; }

		// Token: 0x17008FE9 RID: 36841
		// (get) Token: 0x0601F93E RID: 129342 RVA: 0x0046614E File Offset: 0x0046434E
		// (set) Token: 0x0601F93F RID: 129343 RVA: 0x00466156 File Offset: 0x00464356
		public int CenterPoint { get; set; }

		// Token: 0x17008FEA RID: 36842
		// (get) Token: 0x0601F940 RID: 129344 RVA: 0x0046615F File Offset: 0x0046435F
		// (set) Token: 0x0601F941 RID: 129345 RVA: 0x00466167 File Offset: 0x00464367
		public List<TBlackBoardUnion> InitBlackBoard { get; set; }

		// Token: 0x17008FEB RID: 36843
		// (get) Token: 0x0601F942 RID: 129346 RVA: 0x00466170 File Offset: 0x00464370
		// (set) Token: 0x0601F943 RID: 129347 RVA: 0x00466178 File Offset: 0x00464378
		public string WeaponId { get; set; }

		// Token: 0x17008FEC RID: 36844
		// (get) Token: 0x0601F944 RID: 129348 RVA: 0x00466181 File Offset: 0x00464381
		// (set) Token: 0x0601F945 RID: 129349 RVA: 0x00466189 File Offset: 0x00464389
		public int AiTeamLevelId { get; set; }

		// Token: 0x17008FED RID: 36845
		// (get) Token: 0x0601F946 RID: 129350 RVA: 0x00466192 File Offset: 0x00464392
		// (set) Token: 0x0601F947 RID: 129351 RVA: 0x0046619A File Offset: 0x0046439A
		public List<IStateRepPerfItemT> StateRepPerfList { get; set; }

		// Token: 0x17008FEE RID: 36846
		// (get) Token: 0x0601F948 RID: 129352 RVA: 0x004661A3 File Offset: 0x004643A3
		// (set) Token: 0x0601F949 RID: 129353 RVA: 0x004661AB File Offset: 0x004643AB
		public IAiAlertSystemConfigT AlertSystemConfig { get; set; }

		// Token: 0x17008FEF RID: 36847
		// (get) Token: 0x0601F94A RID: 129354 RVA: 0x004661B4 File Offset: 0x004643B4
		// (set) Token: 0x0601F94B RID: 129355 RVA: 0x004661BC File Offset: 0x004643BC
		public byte NullMask { get; set; }

		// Token: 0x0601F94C RID: 129356 RVA: 0x004661C8 File Offset: 0x004643C8
		public IAiComponentT()
		{
			this.Disabled = false;
			this.AiId = 0;
			this.Patrol = null;
			this.InitState = null;
			this.CenterPoint = 0;
			this.InitBlackBoard = null;
			this.WeaponId = null;
			this.AiTeamLevelId = 0;
			this.StateRepPerfList = null;
			this.AlertSystemConfig = null;
			this.NullMask = 0;
		}
	}
}
