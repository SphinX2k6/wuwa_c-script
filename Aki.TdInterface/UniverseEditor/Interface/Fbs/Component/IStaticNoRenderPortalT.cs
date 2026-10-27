using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C6 RID: 22982
	public class IStaticNoRenderPortalT
	{
		// Token: 0x1700AC8D RID: 44173
		// (get) Token: 0x06026F70 RID: 159600 RVA: 0x0055CB39 File Offset: 0x0055AD39
		// (set) Token: 0x06026F71 RID: 159601 RVA: 0x0055CB41 File Offset: 0x0055AD41
		public ENoRenderPortalType Type { get; set; }

		// Token: 0x1700AC8E RID: 44174
		// (get) Token: 0x06026F72 RID: 159602 RVA: 0x0055CB4A File Offset: 0x0055AD4A
		// (set) Token: 0x06026F73 RID: 159603 RVA: 0x0055CB52 File Offset: 0x0055AD52
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700AC8F RID: 44175
		// (get) Token: 0x06026F74 RID: 159604 RVA: 0x0055CB5B File Offset: 0x0055AD5B
		// (set) Token: 0x06026F75 RID: 159605 RVA: 0x0055CB63 File Offset: 0x0055AD63
		public int LinkPortalEntityId { get; set; }

		// Token: 0x1700AC90 RID: 44176
		// (get) Token: 0x06026F76 RID: 159606 RVA: 0x0055CB6C File Offset: 0x0055AD6C
		// (set) Token: 0x06026F77 RID: 159607 RVA: 0x0055CB74 File Offset: 0x0055AD74
		public ITeleportSceneEffectT TeleportSceneEffect { get; set; }

		// Token: 0x1700AC91 RID: 44177
		// (get) Token: 0x06026F78 RID: 159608 RVA: 0x0055CB7D File Offset: 0x0055AD7D
		// (set) Token: 0x06026F79 RID: 159609 RVA: 0x0055CB85 File Offset: 0x0055AD85
		public TTeleportTransitionOptionUnion TeleportLoadingEffect { get; set; }

		// Token: 0x1700AC92 RID: 44178
		// (get) Token: 0x06026F7A RID: 159610 RVA: 0x0055CB8E File Offset: 0x0055AD8E
		// (set) Token: 0x06026F7B RID: 159611 RVA: 0x0055CB96 File Offset: 0x0055AD96
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700AC93 RID: 44179
		// (get) Token: 0x06026F7C RID: 159612 RVA: 0x0055CB9F File Offset: 0x0055AD9F
		// (set) Token: 0x06026F7D RID: 159613 RVA: 0x0055CBA7 File Offset: 0x0055ADA7
		public IVectorInfoT TeleportToSelfPos { get; set; }

		// Token: 0x1700AC94 RID: 44180
		// (get) Token: 0x06026F7E RID: 159614 RVA: 0x0055CBB0 File Offset: 0x0055ADB0
		// (set) Token: 0x06026F7F RID: 159615 RVA: 0x0055CBB8 File Offset: 0x0055ADB8
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700AC95 RID: 44181
		// (get) Token: 0x06026F80 RID: 159616 RVA: 0x0055CBC1 File Offset: 0x0055ADC1
		// (set) Token: 0x06026F81 RID: 159617 RVA: 0x0055CBC9 File Offset: 0x0055ADC9
		public bool NoBlindSpot { get; set; }

		// Token: 0x1700AC96 RID: 44182
		// (get) Token: 0x06026F82 RID: 159618 RVA: 0x0055CBD2 File Offset: 0x0055ADD2
		// (set) Token: 0x06026F83 RID: 159619 RVA: 0x0055CBDA File Offset: 0x0055ADDA
		public ETeleportActionType ActionAfterTeleport { get; set; }

		// Token: 0x1700AC97 RID: 44183
		// (get) Token: 0x06026F84 RID: 159620 RVA: 0x0055CBE3 File Offset: 0x0055ADE3
		// (set) Token: 0x06026F85 RID: 159621 RVA: 0x0055CBEB File Offset: 0x0055ADEB
		public List<int> NpcMonsterEntityIds { get; set; }

		// Token: 0x1700AC98 RID: 44184
		// (get) Token: 0x06026F86 RID: 159622 RVA: 0x0055CBF4 File Offset: 0x0055ADF4
		// (set) Token: 0x06026F87 RID: 159623 RVA: 0x0055CBFC File Offset: 0x0055ADFC
		public IAfterTeleportConfigT AfterTeleportConfig { get; set; }

		// Token: 0x1700AC99 RID: 44185
		// (get) Token: 0x06026F88 RID: 159624 RVA: 0x0055CC05 File Offset: 0x0055AE05
		// (set) Token: 0x06026F89 RID: 159625 RVA: 0x0055CC0D File Offset: 0x0055AE0D
		public int TeleportStreamRadius { get; set; }

		// Token: 0x1700AC9A RID: 44186
		// (get) Token: 0x06026F8A RID: 159626 RVA: 0x0055CC16 File Offset: 0x0055AE16
		// (set) Token: 0x06026F8B RID: 159627 RVA: 0x0055CC1E File Offset: 0x0055AE1E
		public byte NullMask { get; set; }

		// Token: 0x06026F8C RID: 159628 RVA: 0x0055CC28 File Offset: 0x0055AE28
		public IStaticNoRenderPortalT()
		{
			this.Type = ENoRenderPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.LinkPortalEntityId = 0;
			this.TeleportSceneEffect = null;
			this.TeleportLoadingEffect = null;
			this.Condition = null;
			this.TeleportToSelfPos = null;
			this.GravityConfig = null;
			this.NoBlindSpot = false;
			this.ActionAfterTeleport = ETeleportActionType.Dodge;
			this.NpcMonsterEntityIds = null;
			this.AfterTeleportConfig = null;
			this.TeleportStreamRadius = 0;
			this.NullMask = 0;
		}
	}
}
