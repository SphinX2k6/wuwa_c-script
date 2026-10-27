using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F0 RID: 23024
	public class ISuiGuangHookT
	{
		// Token: 0x1700ACF8 RID: 44280
		// (get) Token: 0x06027120 RID: 160032 RVA: 0x005601EC File Offset: 0x0055E3EC
		// (set) Token: 0x06027121 RID: 160033 RVA: 0x005601F4 File Offset: 0x0055E3F4
		public EHookInteractType Type { get; set; }

		// Token: 0x1700ACF9 RID: 44281
		// (get) Token: 0x06027122 RID: 160034 RVA: 0x005601FD File Offset: 0x0055E3FD
		// (set) Token: 0x06027123 RID: 160035 RVA: 0x00560205 File Offset: 0x0055E405
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700ACFA RID: 44282
		// (get) Token: 0x06027124 RID: 160036 RVA: 0x0056020E File Offset: 0x0055E40E
		// (set) Token: 0x06027125 RID: 160037 RVA: 0x00560216 File Offset: 0x0055E416
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700ACFB RID: 44283
		// (get) Token: 0x06027126 RID: 160038 RVA: 0x0056021F File Offset: 0x0055E41F
		// (set) Token: 0x06027127 RID: 160039 RVA: 0x00560227 File Offset: 0x0055E427
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700ACFC RID: 44284
		// (get) Token: 0x06027128 RID: 160040 RVA: 0x00560230 File Offset: 0x0055E430
		// (set) Token: 0x06027129 RID: 160041 RVA: 0x00560238 File Offset: 0x0055E438
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700ACFD RID: 44285
		// (get) Token: 0x0602712A RID: 160042 RVA: 0x00560241 File Offset: 0x0055E441
		// (set) Token: 0x0602712B RID: 160043 RVA: 0x00560249 File Offset: 0x0055E449
		public byte NullMask { get; set; }

		// Token: 0x0602712C RID: 160044 RVA: 0x00560252 File Offset: 0x0055E452
		public ISuiGuangHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}
