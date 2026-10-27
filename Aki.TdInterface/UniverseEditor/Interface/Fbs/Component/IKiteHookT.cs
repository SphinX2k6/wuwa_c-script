using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B9 RID: 21689
	public class IKiteHookT
	{
		// Token: 0x17009FD3 RID: 40915
		// (get) Token: 0x06023BD4 RID: 146388 RVA: 0x004F12D2 File Offset: 0x004EF4D2
		// (set) Token: 0x06023BD5 RID: 146389 RVA: 0x004F12DA File Offset: 0x004EF4DA
		public EHookInteractType Type { get; set; }

		// Token: 0x17009FD4 RID: 40916
		// (get) Token: 0x06023BD6 RID: 146390 RVA: 0x004F12E3 File Offset: 0x004EF4E3
		// (set) Token: 0x06023BD7 RID: 146391 RVA: 0x004F12EB File Offset: 0x004EF4EB
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x17009FD5 RID: 40917
		// (get) Token: 0x06023BD8 RID: 146392 RVA: 0x004F12F4 File Offset: 0x004EF4F4
		// (set) Token: 0x06023BD9 RID: 146393 RVA: 0x004F12FC File Offset: 0x004EF4FC
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x17009FD6 RID: 40918
		// (get) Token: 0x06023BDA RID: 146394 RVA: 0x004F1305 File Offset: 0x004EF505
		// (set) Token: 0x06023BDB RID: 146395 RVA: 0x004F130D File Offset: 0x004EF50D
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17009FD7 RID: 40919
		// (get) Token: 0x06023BDC RID: 146396 RVA: 0x004F1316 File Offset: 0x004EF516
		// (set) Token: 0x06023BDD RID: 146397 RVA: 0x004F131E File Offset: 0x004EF51E
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x17009FD8 RID: 40920
		// (get) Token: 0x06023BDE RID: 146398 RVA: 0x004F1327 File Offset: 0x004EF527
		// (set) Token: 0x06023BDF RID: 146399 RVA: 0x004F132F File Offset: 0x004EF52F
		public string HookDataAssetOverride { get; set; }

		// Token: 0x17009FD9 RID: 40921
		// (get) Token: 0x06023BE0 RID: 146400 RVA: 0x004F1338 File Offset: 0x004EF538
		// (set) Token: 0x06023BE1 RID: 146401 RVA: 0x004F1340 File Offset: 0x004EF540
		public bool SupportSwitchHookMidway { get; set; }

		// Token: 0x17009FDA RID: 40922
		// (get) Token: 0x06023BE2 RID: 146402 RVA: 0x004F1349 File Offset: 0x004EF549
		// (set) Token: 0x06023BE3 RID: 146403 RVA: 0x004F1351 File Offset: 0x004EF551
		public byte NullMask { get; set; }

		// Token: 0x06023BE4 RID: 146404 RVA: 0x004F135A File Offset: 0x004EF55A
		public IKiteHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookDataAssetOverride = null;
			this.SupportSwitchHookMidway = false;
			this.NullMask = 0;
		}
	}
}
