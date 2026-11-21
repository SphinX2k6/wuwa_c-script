using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595B RID: 22875
	public class IHookLockScreenDetectTypeFullScreenT
	{
		// Token: 0x1700A61D RID: 42525
		// (get) Token: 0x0602543F RID: 152639 RVA: 0x0051D9CA File Offset: 0x0051BBCA
		// (set) Token: 0x06025440 RID: 152640 RVA: 0x0051D9D2 File Offset: 0x0051BBD2
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x06025441 RID: 152641 RVA: 0x0051D9DB File Offset: 0x0051BBDB
		public IHookLockScreenDetectTypeFullScreenT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}
