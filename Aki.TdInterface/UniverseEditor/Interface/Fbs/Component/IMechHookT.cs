using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005540 RID: 21824
	public class IMechHookT
	{
		// Token: 0x1700A121 RID: 41249
		// (get) Token: 0x06024113 RID: 147731 RVA: 0x004FBB01 File Offset: 0x004F9D01
		// (set) Token: 0x06024114 RID: 147732 RVA: 0x004FBB09 File Offset: 0x004F9D09
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A122 RID: 41250
		// (get) Token: 0x06024115 RID: 147733 RVA: 0x004FBB12 File Offset: 0x004F9D12
		// (set) Token: 0x06024116 RID: 147734 RVA: 0x004FBB1A File Offset: 0x004F9D1A
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A123 RID: 41251
		// (get) Token: 0x06024117 RID: 147735 RVA: 0x004FBB23 File Offset: 0x004F9D23
		// (set) Token: 0x06024118 RID: 147736 RVA: 0x004FBB2B File Offset: 0x004F9D2B
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A124 RID: 41252
		// (get) Token: 0x06024119 RID: 147737 RVA: 0x004FBB34 File Offset: 0x004F9D34
		// (set) Token: 0x0602411A RID: 147738 RVA: 0x004FBB3C File Offset: 0x004F9D3C
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A125 RID: 41253
		// (get) Token: 0x0602411B RID: 147739 RVA: 0x004FBB45 File Offset: 0x004F9D45
		// (set) Token: 0x0602411C RID: 147740 RVA: 0x004FBB4D File Offset: 0x004F9D4D
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A126 RID: 41254
		// (get) Token: 0x0602411D RID: 147741 RVA: 0x004FBB56 File Offset: 0x004F9D56
		// (set) Token: 0x0602411E RID: 147742 RVA: 0x004FBB5E File Offset: 0x004F9D5E
		public TMechHookConfigUnion HookConfig { get; set; }

		// Token: 0x1700A127 RID: 41255
		// (get) Token: 0x0602411F RID: 147743 RVA: 0x004FBB67 File Offset: 0x004F9D67
		// (set) Token: 0x06024120 RID: 147744 RVA: 0x004FBB6F File Offset: 0x004F9D6F
		public byte NullMask { get; set; }

		// Token: 0x06024121 RID: 147745 RVA: 0x004FBB78 File Offset: 0x004F9D78
		public IMechHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookConfig = null;
			this.NullMask = 0;
		}
	}
}
