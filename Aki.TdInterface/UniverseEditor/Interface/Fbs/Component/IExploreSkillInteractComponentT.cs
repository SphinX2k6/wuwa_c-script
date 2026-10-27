using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051E7 RID: 20967
	public class IExploreSkillInteractComponentT
	{
		// Token: 0x17009990 RID: 39312
		// (get) Token: 0x060220B0 RID: 139440 RVA: 0x004B9C23 File Offset: 0x004B7E23
		// (set) Token: 0x060220B1 RID: 139441 RVA: 0x004B9C2B File Offset: 0x004B7E2B
		public bool Disabled { get; set; }

		// Token: 0x17009991 RID: 39313
		// (get) Token: 0x060220B2 RID: 139442 RVA: 0x004B9C34 File Offset: 0x004B7E34
		// (set) Token: 0x060220B3 RID: 139443 RVA: 0x004B9C3C File Offset: 0x004B7E3C
		public string ExploreSkillUiResource { get; set; }

		// Token: 0x17009992 RID: 39314
		// (get) Token: 0x060220B4 RID: 139444 RVA: 0x004B9C45 File Offset: 0x004B7E45
		// (set) Token: 0x060220B5 RID: 139445 RVA: 0x004B9C4D File Offset: 0x004B7E4D
		public TExploreSkillInteractOptionUnion Option { get; set; }

		// Token: 0x17009993 RID: 39315
		// (get) Token: 0x060220B6 RID: 139446 RVA: 0x004B9C56 File Offset: 0x004B7E56
		// (set) Token: 0x060220B7 RID: 139447 RVA: 0x004B9C5E File Offset: 0x004B7E5E
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x17009994 RID: 39316
		// (get) Token: 0x060220B8 RID: 139448 RVA: 0x004B9C67 File Offset: 0x004B7E67
		// (set) Token: 0x060220B9 RID: 139449 RVA: 0x004B9C6F File Offset: 0x004B7E6F
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17009995 RID: 39317
		// (get) Token: 0x060220BA RID: 139450 RVA: 0x004B9C78 File Offset: 0x004B7E78
		// (set) Token: 0x060220BB RID: 139451 RVA: 0x004B9C80 File Offset: 0x004B7E80
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17009996 RID: 39318
		// (get) Token: 0x060220BC RID: 139452 RVA: 0x004B9C89 File Offset: 0x004B7E89
		// (set) Token: 0x060220BD RID: 139453 RVA: 0x004B9C91 File Offset: 0x004B7E91
		public TExploreSkillSearchTargetCfgUnion SearchTargetCfg { get; set; }

		// Token: 0x17009997 RID: 39319
		// (get) Token: 0x060220BE RID: 139454 RVA: 0x004B9C9A File Offset: 0x004B7E9A
		// (set) Token: 0x060220BF RID: 139455 RVA: 0x004B9CA2 File Offset: 0x004B7EA2
		public IIgnoresCollisionCfgT IgnoresCollisionCfg { get; set; }

		// Token: 0x17009998 RID: 39320
		// (get) Token: 0x060220C0 RID: 139456 RVA: 0x004B9CAB File Offset: 0x004B7EAB
		// (set) Token: 0x060220C1 RID: 139457 RVA: 0x004B9CB3 File Offset: 0x004B7EB3
		public List<string> SelfInteractBlockDetectionKeys { get; set; }

		// Token: 0x17009999 RID: 39321
		// (get) Token: 0x060220C2 RID: 139458 RVA: 0x004B9CBC File Offset: 0x004B7EBC
		// (set) Token: 0x060220C3 RID: 139459 RVA: 0x004B9CC4 File Offset: 0x004B7EC4
		public byte NullMask { get; set; }

		// Token: 0x060220C4 RID: 139460 RVA: 0x004B9CD0 File Offset: 0x004B7ED0
		public IExploreSkillInteractComponentT()
		{
			this.Disabled = false;
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
