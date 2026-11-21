using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B65 RID: 23397
	public class IMotorPullInteractT
	{
		// Token: 0x1700AAD6 RID: 43734
		// (get) Token: 0x0602683C RID: 157756 RVA: 0x005464EE File Offset: 0x005446EE
		// (set) Token: 0x0602683D RID: 157757 RVA: 0x005464F6 File Offset: 0x005446F6
		public EHookInteractType Type { get; set; }

		// Token: 0x1700AAD7 RID: 43735
		// (get) Token: 0x0602683E RID: 157758 RVA: 0x005464FF File Offset: 0x005446FF
		// (set) Token: 0x0602683F RID: 157759 RVA: 0x00546507 File Offset: 0x00544707
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700AAD8 RID: 43736
		// (get) Token: 0x06026840 RID: 157760 RVA: 0x00546510 File Offset: 0x00544710
		// (set) Token: 0x06026841 RID: 157761 RVA: 0x00546518 File Offset: 0x00544718
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700AAD9 RID: 43737
		// (get) Token: 0x06026842 RID: 157762 RVA: 0x00546521 File Offset: 0x00544721
		// (set) Token: 0x06026843 RID: 157763 RVA: 0x00546529 File Offset: 0x00544729
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700AADA RID: 43738
		// (get) Token: 0x06026844 RID: 157764 RVA: 0x00546532 File Offset: 0x00544732
		// (set) Token: 0x06026845 RID: 157765 RVA: 0x0054653A File Offset: 0x0054473A
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700AADB RID: 43739
		// (get) Token: 0x06026846 RID: 157766 RVA: 0x00546543 File Offset: 0x00544743
		// (set) Token: 0x06026847 RID: 157767 RVA: 0x0054654B File Offset: 0x0054474B
		public bool IsPlayPullProgress { get; set; }

		// Token: 0x1700AADC RID: 43740
		// (get) Token: 0x06026848 RID: 157768 RVA: 0x00546554 File Offset: 0x00544754
		// (set) Token: 0x06026849 RID: 157769 RVA: 0x0054655C File Offset: 0x0054475C
		public float PullMoveSpeed { get; set; }

		// Token: 0x1700AADD RID: 43741
		// (get) Token: 0x0602684A RID: 157770 RVA: 0x00546565 File Offset: 0x00544765
		// (set) Token: 0x0602684B RID: 157771 RVA: 0x0054656D File Offset: 0x0054476D
		public bool IsFixedWhenNotRide { get; set; }

		// Token: 0x1700AADE RID: 43742
		// (get) Token: 0x0602684C RID: 157772 RVA: 0x00546576 File Offset: 0x00544776
		// (set) Token: 0x0602684D RID: 157773 RVA: 0x0054657E File Offset: 0x0054477E
		public bool DisableAreaEffect { get; set; }

		// Token: 0x1700AADF RID: 43743
		// (get) Token: 0x0602684E RID: 157774 RVA: 0x00546587 File Offset: 0x00544787
		// (set) Token: 0x0602684F RID: 157775 RVA: 0x0054658F File Offset: 0x0054478F
		public bool DisableCollectEffect { get; set; }

		// Token: 0x1700AAE0 RID: 43744
		// (get) Token: 0x06026850 RID: 157776 RVA: 0x00546598 File Offset: 0x00544798
		// (set) Token: 0x06026851 RID: 157777 RVA: 0x005465A0 File Offset: 0x005447A0
		public byte NullMask { get; set; }

		// Token: 0x06026852 RID: 157778 RVA: 0x005465AC File Offset: 0x005447AC
		public IMotorPullInteractT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.IsPlayPullProgress = false;
			this.PullMoveSpeed = 0f;
			this.IsFixedWhenNotRide = false;
			this.DisableAreaEffect = false;
			this.DisableCollectEffect = false;
			this.NullMask = 0;
		}
	}
}
