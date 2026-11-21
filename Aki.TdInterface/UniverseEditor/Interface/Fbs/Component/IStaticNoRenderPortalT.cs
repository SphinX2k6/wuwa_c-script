using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD3 RID: 24531
	public class IStaticNoRenderPortalT
	{
		// Token: 0x1700B5C4 RID: 46532
		// (get) Token: 0x060294E6 RID: 169190 RVA: 0x005A3AC1 File Offset: 0x005A1CC1
		// (set) Token: 0x060294E7 RID: 169191 RVA: 0x005A3AC9 File Offset: 0x005A1CC9
		public ENoRenderPortalType Type { get; set; }

		// Token: 0x1700B5C5 RID: 46533
		// (get) Token: 0x060294E8 RID: 169192 RVA: 0x005A3AD2 File Offset: 0x005A1CD2
		// (set) Token: 0x060294E9 RID: 169193 RVA: 0x005A3ADA File Offset: 0x005A1CDA
		public EPortalModel PortalModel { get; set; }

		// Token: 0x1700B5C6 RID: 46534
		// (get) Token: 0x060294EA RID: 169194 RVA: 0x005A3AE3 File Offset: 0x005A1CE3
		// (set) Token: 0x060294EB RID: 169195 RVA: 0x005A3AEB File Offset: 0x005A1CEB
		public int LinkPortalEntityId { get; set; }

		// Token: 0x1700B5C7 RID: 46535
		// (get) Token: 0x060294EC RID: 169196 RVA: 0x005A3AF4 File Offset: 0x005A1CF4
		// (set) Token: 0x060294ED RID: 169197 RVA: 0x005A3AFC File Offset: 0x005A1CFC
		public ICubeMapBindingT CubeMapBinding { get; set; }

		// Token: 0x1700B5C8 RID: 46536
		// (get) Token: 0x060294EE RID: 169198 RVA: 0x005A3B05 File Offset: 0x005A1D05
		// (set) Token: 0x060294EF RID: 169199 RVA: 0x005A3B0D File Offset: 0x005A1D0D
		public ITeleportSceneEffectT TeleportSceneEffect { get; set; }

		// Token: 0x1700B5C9 RID: 46537
		// (get) Token: 0x060294F0 RID: 169200 RVA: 0x005A3B16 File Offset: 0x005A1D16
		// (set) Token: 0x060294F1 RID: 169201 RVA: 0x005A3B1E File Offset: 0x005A1D1E
		public TTeleportTransitionOptionUnion TeleportLoadingEffect { get; set; }

		// Token: 0x1700B5CA RID: 46538
		// (get) Token: 0x060294F2 RID: 169202 RVA: 0x005A3B27 File Offset: 0x005A1D27
		// (set) Token: 0x060294F3 RID: 169203 RVA: 0x005A3B2F File Offset: 0x005A1D2F
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B5CB RID: 46539
		// (get) Token: 0x060294F4 RID: 169204 RVA: 0x005A3B38 File Offset: 0x005A1D38
		// (set) Token: 0x060294F5 RID: 169205 RVA: 0x005A3B40 File Offset: 0x005A1D40
		public IVectorInfoT TeleportToSelfPos { get; set; }

		// Token: 0x1700B5CC RID: 46540
		// (get) Token: 0x060294F6 RID: 169206 RVA: 0x005A3B49 File Offset: 0x005A1D49
		// (set) Token: 0x060294F7 RID: 169207 RVA: 0x005A3B51 File Offset: 0x005A1D51
		public IGravityFlipTeleportConfigT GravityConfig { get; set; }

		// Token: 0x1700B5CD RID: 46541
		// (get) Token: 0x060294F8 RID: 169208 RVA: 0x005A3B5A File Offset: 0x005A1D5A
		// (set) Token: 0x060294F9 RID: 169209 RVA: 0x005A3B62 File Offset: 0x005A1D62
		public bool NoBlindSpot { get; set; }

		// Token: 0x1700B5CE RID: 46542
		// (get) Token: 0x060294FA RID: 169210 RVA: 0x005A3B6B File Offset: 0x005A1D6B
		// (set) Token: 0x060294FB RID: 169211 RVA: 0x005A3B73 File Offset: 0x005A1D73
		public ETeleportActionType ActionAfterTeleport { get; set; }

		// Token: 0x1700B5CF RID: 46543
		// (get) Token: 0x060294FC RID: 169212 RVA: 0x005A3B7C File Offset: 0x005A1D7C
		// (set) Token: 0x060294FD RID: 169213 RVA: 0x005A3B84 File Offset: 0x005A1D84
		public List<int> NpcMonsterEntityIds { get; set; }

		// Token: 0x1700B5D0 RID: 46544
		// (get) Token: 0x060294FE RID: 169214 RVA: 0x005A3B8D File Offset: 0x005A1D8D
		// (set) Token: 0x060294FF RID: 169215 RVA: 0x005A3B95 File Offset: 0x005A1D95
		public IAfterTeleportConfigT AfterTeleportConfig { get; set; }

		// Token: 0x1700B5D1 RID: 46545
		// (get) Token: 0x06029500 RID: 169216 RVA: 0x005A3B9E File Offset: 0x005A1D9E
		// (set) Token: 0x06029501 RID: 169217 RVA: 0x005A3BA6 File Offset: 0x005A1DA6
		public int TeleportStreamRadius { get; set; }

		// Token: 0x1700B5D2 RID: 46546
		// (get) Token: 0x06029502 RID: 169218 RVA: 0x005A3BAF File Offset: 0x005A1DAF
		// (set) Token: 0x06029503 RID: 169219 RVA: 0x005A3BB7 File Offset: 0x005A1DB7
		public byte NullMask { get; set; }

		// Token: 0x06029504 RID: 169220 RVA: 0x005A3BC0 File Offset: 0x005A1DC0
		public IStaticNoRenderPortalT()
		{
			this.Type = ENoRenderPortalType.Static;
			this.PortalModel = EPortalModel.A;
			this.LinkPortalEntityId = 0;
			this.CubeMapBinding = null;
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
