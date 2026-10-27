using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B2 RID: 21938
	public class IMotorEjectHookT
	{
		// Token: 0x1700A20E RID: 41486
		// (get) Token: 0x06024545 RID: 148805 RVA: 0x00503F11 File Offset: 0x00502111
		// (set) Token: 0x06024546 RID: 148806 RVA: 0x00503F19 File Offset: 0x00502119
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A20F RID: 41487
		// (get) Token: 0x06024547 RID: 148807 RVA: 0x00503F22 File Offset: 0x00502122
		// (set) Token: 0x06024548 RID: 148808 RVA: 0x00503F2A File Offset: 0x0050212A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A210 RID: 41488
		// (get) Token: 0x06024549 RID: 148809 RVA: 0x00503F33 File Offset: 0x00502133
		// (set) Token: 0x0602454A RID: 148810 RVA: 0x00503F3B File Offset: 0x0050213B
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A211 RID: 41489
		// (get) Token: 0x0602454B RID: 148811 RVA: 0x00503F44 File Offset: 0x00502144
		// (set) Token: 0x0602454C RID: 148812 RVA: 0x00503F4C File Offset: 0x0050214C
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A212 RID: 41490
		// (get) Token: 0x0602454D RID: 148813 RVA: 0x00503F55 File Offset: 0x00502155
		// (set) Token: 0x0602454E RID: 148814 RVA: 0x00503F5D File Offset: 0x0050215D
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A213 RID: 41491
		// (get) Token: 0x0602454F RID: 148815 RVA: 0x00503F66 File Offset: 0x00502166
		// (set) Token: 0x06024550 RID: 148816 RVA: 0x00503F6E File Offset: 0x0050216E
		public float MinPitchAngle { get; set; }

		// Token: 0x1700A214 RID: 41492
		// (get) Token: 0x06024551 RID: 148817 RVA: 0x00503F77 File Offset: 0x00502177
		// (set) Token: 0x06024552 RID: 148818 RVA: 0x00503F7F File Offset: 0x0050217F
		public float DefaultPitchAngle { get; set; }

		// Token: 0x1700A215 RID: 41493
		// (get) Token: 0x06024553 RID: 148819 RVA: 0x00503F88 File Offset: 0x00502188
		// (set) Token: 0x06024554 RID: 148820 RVA: 0x00503F90 File Offset: 0x00502190
		public float MaxPitchAngle { get; set; }

		// Token: 0x1700A216 RID: 41494
		// (get) Token: 0x06024555 RID: 148821 RVA: 0x00503F99 File Offset: 0x00502199
		// (set) Token: 0x06024556 RID: 148822 RVA: 0x00503FA1 File Offset: 0x005021A1
		public float MaxYawAngleDelta { get; set; }

		// Token: 0x1700A217 RID: 41495
		// (get) Token: 0x06024557 RID: 148823 RVA: 0x00503FAA File Offset: 0x005021AA
		// (set) Token: 0x06024558 RID: 148824 RVA: 0x00503FB2 File Offset: 0x005021B2
		public float MaxEjectDistance { get; set; }

		// Token: 0x1700A218 RID: 41496
		// (get) Token: 0x06024559 RID: 148825 RVA: 0x00503FBB File Offset: 0x005021BB
		// (set) Token: 0x0602455A RID: 148826 RVA: 0x00503FC3 File Offset: 0x005021C3
		public float InterpSpeed { get; set; }

		// Token: 0x1700A219 RID: 41497
		// (get) Token: 0x0602455B RID: 148827 RVA: 0x00503FCC File Offset: 0x005021CC
		// (set) Token: 0x0602455C RID: 148828 RVA: 0x00503FD4 File Offset: 0x005021D4
		public TMotorAutoEjectConfigUnion AutoEjectConfig { get; set; }

		// Token: 0x1700A21A RID: 41498
		// (get) Token: 0x0602455D RID: 148829 RVA: 0x00503FDD File Offset: 0x005021DD
		// (set) Token: 0x0602455E RID: 148830 RVA: 0x00503FE5 File Offset: 0x005021E5
		public byte NullMask { get; set; }

		// Token: 0x0602455F RID: 148831 RVA: 0x00503FF0 File Offset: 0x005021F0
		public IMotorEjectHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.MinPitchAngle = 0f;
			this.DefaultPitchAngle = 0f;
			this.MaxPitchAngle = 0f;
			this.MaxYawAngleDelta = 0f;
			this.MaxEjectDistance = 0f;
			this.InterpSpeed = 0f;
			this.AutoEjectConfig = null;
			this.NullMask = 0;
		}
	}
}
