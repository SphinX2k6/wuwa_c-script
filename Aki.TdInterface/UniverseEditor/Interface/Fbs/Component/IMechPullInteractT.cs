using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005549 RID: 21833
	public class IMechPullInteractT
	{
		// Token: 0x1700A139 RID: 41273
		// (get) Token: 0x06024177 RID: 147831 RVA: 0x004FC9EA File Offset: 0x004FABEA
		// (set) Token: 0x06024178 RID: 147832 RVA: 0x004FC9F2 File Offset: 0x004FABF2
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A13A RID: 41274
		// (get) Token: 0x06024179 RID: 147833 RVA: 0x004FC9FB File Offset: 0x004FABFB
		// (set) Token: 0x0602417A RID: 147834 RVA: 0x004FCA03 File Offset: 0x004FAC03
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A13B RID: 41275
		// (get) Token: 0x0602417B RID: 147835 RVA: 0x004FCA0C File Offset: 0x004FAC0C
		// (set) Token: 0x0602417C RID: 147836 RVA: 0x004FCA14 File Offset: 0x004FAC14
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A13C RID: 41276
		// (get) Token: 0x0602417D RID: 147837 RVA: 0x004FCA1D File Offset: 0x004FAC1D
		// (set) Token: 0x0602417E RID: 147838 RVA: 0x004FCA25 File Offset: 0x004FAC25
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A13D RID: 41277
		// (get) Token: 0x0602417F RID: 147839 RVA: 0x004FCA2E File Offset: 0x004FAC2E
		// (set) Token: 0x06024180 RID: 147840 RVA: 0x004FCA36 File Offset: 0x004FAC36
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A13E RID: 41278
		// (get) Token: 0x06024181 RID: 147841 RVA: 0x004FCA3F File Offset: 0x004FAC3F
		// (set) Token: 0x06024182 RID: 147842 RVA: 0x004FCA47 File Offset: 0x004FAC47
		public bool IsPlayPullProgress { get; set; }

		// Token: 0x1700A13F RID: 41279
		// (get) Token: 0x06024183 RID: 147843 RVA: 0x004FCA50 File Offset: 0x004FAC50
		// (set) Token: 0x06024184 RID: 147844 RVA: 0x004FCA58 File Offset: 0x004FAC58
		public float PullMoveSpeed { get; set; }

		// Token: 0x1700A140 RID: 41280
		// (get) Token: 0x06024185 RID: 147845 RVA: 0x004FCA61 File Offset: 0x004FAC61
		// (set) Token: 0x06024186 RID: 147846 RVA: 0x004FCA69 File Offset: 0x004FAC69
		public bool IsFixedWhenNotMech { get; set; }

		// Token: 0x1700A141 RID: 41281
		// (get) Token: 0x06024187 RID: 147847 RVA: 0x004FCA72 File Offset: 0x004FAC72
		// (set) Token: 0x06024188 RID: 147848 RVA: 0x004FCA7A File Offset: 0x004FAC7A
		public bool DisableAreaEffect { get; set; }

		// Token: 0x1700A142 RID: 41282
		// (get) Token: 0x06024189 RID: 147849 RVA: 0x004FCA83 File Offset: 0x004FAC83
		// (set) Token: 0x0602418A RID: 147850 RVA: 0x004FCA8B File Offset: 0x004FAC8B
		public bool DisableCollectEffect { get; set; }

		// Token: 0x1700A143 RID: 41283
		// (get) Token: 0x0602418B RID: 147851 RVA: 0x004FCA94 File Offset: 0x004FAC94
		// (set) Token: 0x0602418C RID: 147852 RVA: 0x004FCA9C File Offset: 0x004FAC9C
		public byte NullMask { get; set; }

		// Token: 0x0602418D RID: 147853 RVA: 0x004FCAA8 File Offset: 0x004FACA8
		public IMechPullInteractT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.IsPlayPullProgress = false;
			this.PullMoveSpeed = 0f;
			this.IsFixedWhenNotMech = false;
			this.DisableAreaEffect = false;
			this.DisableCollectEffect = false;
			this.NullMask = 0;
		}
	}
}
