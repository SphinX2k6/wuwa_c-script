using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005961 RID: 22881
	public class IHookSpaceStationEnergyCoreT
	{
		// Token: 0x1700A62B RID: 42539
		// (get) Token: 0x06025485 RID: 152709 RVA: 0x0051E4C2 File Offset: 0x0051C6C2
		// (set) Token: 0x06025486 RID: 152710 RVA: 0x0051E4CA File Offset: 0x0051C6CA
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A62C RID: 42540
		// (get) Token: 0x06025487 RID: 152711 RVA: 0x0051E4D3 File Offset: 0x0051C6D3
		// (set) Token: 0x06025488 RID: 152712 RVA: 0x0051E4DB File Offset: 0x0051C6DB
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A62D RID: 42541
		// (get) Token: 0x06025489 RID: 152713 RVA: 0x0051E4E4 File Offset: 0x0051C6E4
		// (set) Token: 0x0602548A RID: 152714 RVA: 0x0051E4EC File Offset: 0x0051C6EC
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A62E RID: 42542
		// (get) Token: 0x0602548B RID: 152715 RVA: 0x0051E4F5 File Offset: 0x0051C6F5
		// (set) Token: 0x0602548C RID: 152716 RVA: 0x0051E4FD File Offset: 0x0051C6FD
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A62F RID: 42543
		// (get) Token: 0x0602548D RID: 152717 RVA: 0x0051E506 File Offset: 0x0051C706
		// (set) Token: 0x0602548E RID: 152718 RVA: 0x0051E50E File Offset: 0x0051C70E
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A630 RID: 42544
		// (get) Token: 0x0602548F RID: 152719 RVA: 0x0051E517 File Offset: 0x0051C717
		// (set) Token: 0x06025490 RID: 152720 RVA: 0x0051E51F File Offset: 0x0051C71F
		public int HookSpeed { get; set; }

		// Token: 0x1700A631 RID: 42545
		// (get) Token: 0x06025491 RID: 152721 RVA: 0x0051E528 File Offset: 0x0051C728
		// (set) Token: 0x06025492 RID: 152722 RVA: 0x0051E530 File Offset: 0x0051C730
		public byte NullMask { get; set; }

		// Token: 0x06025493 RID: 152723 RVA: 0x0051E539 File Offset: 0x0051C739
		public IHookSpaceStationEnergyCoreT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.HookSpeed = 0;
			this.NullMask = 0;
		}
	}
}
