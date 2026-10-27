using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D5 RID: 21461
	public class IHookLockScreenDetectTypeFullScreenT
	{
		// Token: 0x17009DE3 RID: 40419
		// (get) Token: 0x06023387 RID: 144263 RVA: 0x004E099E File Offset: 0x004DEB9E
		// (set) Token: 0x06023388 RID: 144264 RVA: 0x004E09A6 File Offset: 0x004DEBA6
		public EHookLockScreenDetectType Type { get; set; }

		// Token: 0x06023389 RID: 144265 RVA: 0x004E09AF File Offset: 0x004DEBAF
		public IHookLockScreenDetectTypeFullScreenT()
		{
			this.Type = EHookLockScreenDetectType.CentralEllipse;
		}
	}
}
