using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C7 RID: 21959
	public class IMotorPullInteractT
	{
		// Token: 0x1700A24E RID: 41550
		// (get) Token: 0x0602462F RID: 149039 RVA: 0x00505F76 File Offset: 0x00504176
		// (set) Token: 0x06024630 RID: 149040 RVA: 0x00505F7E File Offset: 0x0050417E
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A24F RID: 41551
		// (get) Token: 0x06024631 RID: 149041 RVA: 0x00505F87 File Offset: 0x00504187
		// (set) Token: 0x06024632 RID: 149042 RVA: 0x00505F8F File Offset: 0x0050418F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A250 RID: 41552
		// (get) Token: 0x06024633 RID: 149043 RVA: 0x00505F98 File Offset: 0x00504198
		// (set) Token: 0x06024634 RID: 149044 RVA: 0x00505FA0 File Offset: 0x005041A0
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A251 RID: 41553
		// (get) Token: 0x06024635 RID: 149045 RVA: 0x00505FA9 File Offset: 0x005041A9
		// (set) Token: 0x06024636 RID: 149046 RVA: 0x00505FB1 File Offset: 0x005041B1
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A252 RID: 41554
		// (get) Token: 0x06024637 RID: 149047 RVA: 0x00505FBA File Offset: 0x005041BA
		// (set) Token: 0x06024638 RID: 149048 RVA: 0x00505FC2 File Offset: 0x005041C2
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A253 RID: 41555
		// (get) Token: 0x06024639 RID: 149049 RVA: 0x00505FCB File Offset: 0x005041CB
		// (set) Token: 0x0602463A RID: 149050 RVA: 0x00505FD3 File Offset: 0x005041D3
		public bool IsPlayPullProgress { get; set; }

		// Token: 0x1700A254 RID: 41556
		// (get) Token: 0x0602463B RID: 149051 RVA: 0x00505FDC File Offset: 0x005041DC
		// (set) Token: 0x0602463C RID: 149052 RVA: 0x00505FE4 File Offset: 0x005041E4
		public float PullMoveSpeed { get; set; }

		// Token: 0x1700A255 RID: 41557
		// (get) Token: 0x0602463D RID: 149053 RVA: 0x00505FED File Offset: 0x005041ED
		// (set) Token: 0x0602463E RID: 149054 RVA: 0x00505FF5 File Offset: 0x005041F5
		public bool IsFixedWhenNotRide { get; set; }

		// Token: 0x1700A256 RID: 41558
		// (get) Token: 0x0602463F RID: 149055 RVA: 0x00505FFE File Offset: 0x005041FE
		// (set) Token: 0x06024640 RID: 149056 RVA: 0x00506006 File Offset: 0x00504206
		public bool DisableAreaEffect { get; set; }

		// Token: 0x1700A257 RID: 41559
		// (get) Token: 0x06024641 RID: 149057 RVA: 0x0050600F File Offset: 0x0050420F
		// (set) Token: 0x06024642 RID: 149058 RVA: 0x00506017 File Offset: 0x00504217
		public bool DisableCollectEffect { get; set; }

		// Token: 0x1700A258 RID: 41560
		// (get) Token: 0x06024643 RID: 149059 RVA: 0x00506020 File Offset: 0x00504220
		// (set) Token: 0x06024644 RID: 149060 RVA: 0x00506028 File Offset: 0x00504228
		public byte NullMask { get; set; }

		// Token: 0x06024645 RID: 149061 RVA: 0x00506034 File Offset: 0x00504234
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
