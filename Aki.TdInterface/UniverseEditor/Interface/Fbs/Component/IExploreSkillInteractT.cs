using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574C RID: 22348
	public class IExploreSkillInteractT
	{
		// Token: 0x1700A177 RID: 41335
		// (get) Token: 0x06023FE3 RID: 147427 RVA: 0x004F31E9 File Offset: 0x004F13E9
		// (set) Token: 0x06023FE4 RID: 147428 RVA: 0x004F31F1 File Offset: 0x004F13F1
		public string ExploreSkillUiResource { get; set; }

		// Token: 0x1700A178 RID: 41336
		// (get) Token: 0x06023FE5 RID: 147429 RVA: 0x004F31FA File Offset: 0x004F13FA
		// (set) Token: 0x06023FE6 RID: 147430 RVA: 0x004F3202 File Offset: 0x004F1402
		public TExploreSkillInteractOptionUnion Option { get; set; }

		// Token: 0x1700A179 RID: 41337
		// (get) Token: 0x06023FE7 RID: 147431 RVA: 0x004F320B File Offset: 0x004F140B
		// (set) Token: 0x06023FE8 RID: 147432 RVA: 0x004F3213 File Offset: 0x004F1413
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700A17A RID: 41338
		// (get) Token: 0x06023FE9 RID: 147433 RVA: 0x004F321C File Offset: 0x004F141C
		// (set) Token: 0x06023FEA RID: 147434 RVA: 0x004F3224 File Offset: 0x004F1424
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700A17B RID: 41339
		// (get) Token: 0x06023FEB RID: 147435 RVA: 0x004F322D File Offset: 0x004F142D
		// (set) Token: 0x06023FEC RID: 147436 RVA: 0x004F3235 File Offset: 0x004F1435
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A17C RID: 41340
		// (get) Token: 0x06023FED RID: 147437 RVA: 0x004F323E File Offset: 0x004F143E
		// (set) Token: 0x06023FEE RID: 147438 RVA: 0x004F3246 File Offset: 0x004F1446
		public TExploreSkillSearchTargetCfgUnion SearchTargetCfg { get; set; }

		// Token: 0x1700A17D RID: 41341
		// (get) Token: 0x06023FEF RID: 147439 RVA: 0x004F324F File Offset: 0x004F144F
		// (set) Token: 0x06023FF0 RID: 147440 RVA: 0x004F3257 File Offset: 0x004F1457
		public IIgnoresCollisionCfgT IgnoresCollisionCfg { get; set; }

		// Token: 0x1700A17E RID: 41342
		// (get) Token: 0x06023FF1 RID: 147441 RVA: 0x004F3260 File Offset: 0x004F1460
		// (set) Token: 0x06023FF2 RID: 147442 RVA: 0x004F3268 File Offset: 0x004F1468
		public List<string> SelfInteractBlockDetectionKeys { get; set; }

		// Token: 0x1700A17F RID: 41343
		// (get) Token: 0x06023FF3 RID: 147443 RVA: 0x004F3271 File Offset: 0x004F1471
		// (set) Token: 0x06023FF4 RID: 147444 RVA: 0x004F3279 File Offset: 0x004F1479
		public byte NullMask { get; set; }

		// Token: 0x06023FF5 RID: 147445 RVA: 0x004F3284 File Offset: 0x004F1484
		public IExploreSkillInteractT()
		{
			this.ExploreSkillUiResource = null;
			this.Option = null;
			this.PlayerStateRestritionId = 0;
			this.MatchRoleOption = null;
			this.Condition = null;
			this.SearchTargetCfg = null;
			this.IgnoresCollisionCfg = null;
			this.SelfInteractBlockDetectionKeys = null;
			this.NullMask = 0;
		}
	}
}
