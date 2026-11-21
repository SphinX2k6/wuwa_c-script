using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC6 RID: 23238
	public class IMechBurrowHookInteractT
	{
		// Token: 0x1700A95C RID: 43356
		// (get) Token: 0x060261CD RID: 156109 RVA: 0x00538B46 File Offset: 0x00536D46
		// (set) Token: 0x060261CE RID: 156110 RVA: 0x00538B4E File Offset: 0x00536D4E
		public EMechHookInteractType Type { get; set; }

		// Token: 0x1700A95D RID: 43357
		// (get) Token: 0x060261CF RID: 156111 RVA: 0x00538B57 File Offset: 0x00536D57
		// (set) Token: 0x060261D0 RID: 156112 RVA: 0x00538B5F File Offset: 0x00536D5F
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A95E RID: 43358
		// (get) Token: 0x060261D1 RID: 156113 RVA: 0x00538B68 File Offset: 0x00536D68
		// (set) Token: 0x060261D2 RID: 156114 RVA: 0x00538B70 File Offset: 0x00536D70
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A95F RID: 43359
		// (get) Token: 0x060261D3 RID: 156115 RVA: 0x00538B79 File Offset: 0x00536D79
		// (set) Token: 0x060261D4 RID: 156116 RVA: 0x00538B81 File Offset: 0x00536D81
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A960 RID: 43360
		// (get) Token: 0x060261D5 RID: 156117 RVA: 0x00538B8A File Offset: 0x00536D8A
		// (set) Token: 0x060261D6 RID: 156118 RVA: 0x00538B92 File Offset: 0x00536D92
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A961 RID: 43361
		// (get) Token: 0x060261D7 RID: 156119 RVA: 0x00538B9B File Offset: 0x00536D9B
		// (set) Token: 0x060261D8 RID: 156120 RVA: 0x00538BA3 File Offset: 0x00536DA3
		public IVectorInfoT TargetPos { get; set; }

		// Token: 0x1700A962 RID: 43362
		// (get) Token: 0x060261D9 RID: 156121 RVA: 0x00538BAC File Offset: 0x00536DAC
		// (set) Token: 0x060261DA RID: 156122 RVA: 0x00538BB4 File Offset: 0x00536DB4
		public bool CanInterrupt { get; set; }

		// Token: 0x1700A963 RID: 43363
		// (get) Token: 0x060261DB RID: 156123 RVA: 0x00538BBD File Offset: 0x00536DBD
		// (set) Token: 0x060261DC RID: 156124 RVA: 0x00538BC5 File Offset: 0x00536DC5
		public byte NullMask { get; set; }

		// Token: 0x060261DD RID: 156125 RVA: 0x00538BCE File Offset: 0x00536DCE
		public IMechBurrowHookInteractT()
		{
			this.Type = EMechHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.TargetPos = null;
			this.CanInterrupt = false;
			this.NullMask = 0;
		}
	}
}
