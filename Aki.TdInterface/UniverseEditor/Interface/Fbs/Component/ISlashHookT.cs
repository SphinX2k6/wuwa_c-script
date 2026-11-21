using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F37 RID: 24375
	public class ISlashHookT
	{
		// Token: 0x1700B46E RID: 46190
		// (get) Token: 0x06028F1E RID: 167710 RVA: 0x0059829C File Offset: 0x0059649C
		// (set) Token: 0x06028F1F RID: 167711 RVA: 0x005982A4 File Offset: 0x005964A4
		public EHookInteractType Type { get; set; }

		// Token: 0x1700B46F RID: 46191
		// (get) Token: 0x06028F20 RID: 167712 RVA: 0x005982AD File Offset: 0x005964AD
		// (set) Token: 0x06028F21 RID: 167713 RVA: 0x005982B5 File Offset: 0x005964B5
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700B470 RID: 46192
		// (get) Token: 0x06028F22 RID: 167714 RVA: 0x005982BE File Offset: 0x005964BE
		// (set) Token: 0x06028F23 RID: 167715 RVA: 0x005982C6 File Offset: 0x005964C6
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700B471 RID: 46193
		// (get) Token: 0x06028F24 RID: 167716 RVA: 0x005982CF File Offset: 0x005964CF
		// (set) Token: 0x06028F25 RID: 167717 RVA: 0x005982D7 File Offset: 0x005964D7
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700B472 RID: 46194
		// (get) Token: 0x06028F26 RID: 167718 RVA: 0x005982E0 File Offset: 0x005964E0
		// (set) Token: 0x06028F27 RID: 167719 RVA: 0x005982E8 File Offset: 0x005964E8
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700B473 RID: 46195
		// (get) Token: 0x06028F28 RID: 167720 RVA: 0x005982F1 File Offset: 0x005964F1
		// (set) Token: 0x06028F29 RID: 167721 RVA: 0x005982F9 File Offset: 0x005964F9
		public ESlashHitType SlashHitType { get; set; }

		// Token: 0x1700B474 RID: 46196
		// (get) Token: 0x06028F2A RID: 167722 RVA: 0x00598302 File Offset: 0x00596502
		// (set) Token: 0x06028F2B RID: 167723 RVA: 0x0059830A File Offset: 0x0059650A
		public ESlashAngleType SlashAngleType { get; set; }

		// Token: 0x1700B475 RID: 46197
		// (get) Token: 0x06028F2C RID: 167724 RVA: 0x00598313 File Offset: 0x00596513
		// (set) Token: 0x06028F2D RID: 167725 RVA: 0x0059831B File Offset: 0x0059651B
		public ESlashDirType DefaultSlashDir { get; set; }

		// Token: 0x1700B476 RID: 46198
		// (get) Token: 0x06028F2E RID: 167726 RVA: 0x00598324 File Offset: 0x00596524
		// (set) Token: 0x06028F2F RID: 167727 RVA: 0x0059832C File Offset: 0x0059652C
		public IVectorInfoT CharacterLookAt { get; set; }

		// Token: 0x1700B477 RID: 46199
		// (get) Token: 0x06028F30 RID: 167728 RVA: 0x00598335 File Offset: 0x00596535
		// (set) Token: 0x06028F31 RID: 167729 RVA: 0x0059833D File Offset: 0x0059653D
		public int CharacterLookAtPointId { get; set; }

		// Token: 0x1700B478 RID: 46200
		// (get) Token: 0x06028F32 RID: 167730 RVA: 0x00598346 File Offset: 0x00596546
		// (set) Token: 0x06028F33 RID: 167731 RVA: 0x0059834E File Offset: 0x0059654E
		public int SlashBackSafePointId { get; set; }

		// Token: 0x1700B479 RID: 46201
		// (get) Token: 0x06028F34 RID: 167732 RVA: 0x00598357 File Offset: 0x00596557
		// (set) Token: 0x06028F35 RID: 167733 RVA: 0x0059835F File Offset: 0x0059655F
		public bool IsAdjustCameraConfig { get; set; }

		// Token: 0x1700B47A RID: 46202
		// (get) Token: 0x06028F36 RID: 167734 RVA: 0x00598368 File Offset: 0x00596568
		// (set) Token: 0x06028F37 RID: 167735 RVA: 0x00598370 File Offset: 0x00596570
		public byte NullMask { get; set; }

		// Token: 0x06028F38 RID: 167736 RVA: 0x0059837C File Offset: 0x0059657C
		public ISlashHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.SlashHitType = ESlashHitType.HeavySlash;
			this.SlashAngleType = ESlashAngleType.Slash45;
			this.DefaultSlashDir = ESlashDirType.Horizontal;
			this.CharacterLookAt = null;
			this.CharacterLookAtPointId = 0;
			this.SlashBackSafePointId = 0;
			this.IsAdjustCameraConfig = false;
			this.NullMask = 0;
		}
	}
}
