using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D2 RID: 21458
	public class IHookLockScreenDetectTypeCentralEllipseT
	{
		// Token: 0x17009DE0 RID: 40416
		// (get) Token: 0x06023375 RID: 144245 RVA: 0x004E0826 File Offset: 0x004DEA26
		// (set) Token: 0x06023376 RID: 144246 RVA: 0x004E082E File Offset: 0x004DEA2E
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x06023377 RID: 144247 RVA: 0x004E0837 File Offset: 0x004DEA37
		public IHookLockScreenDetectTypeCentralEllipseT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}
