using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D0 RID: 29136
	public class IStopGuestUiAnimationT
	{
		// Token: 0x1700D878 RID: 55416
		// (get) Token: 0x06033AFB RID: 211707 RVA: 0x006F5AA7 File Offset: 0x006F3CA7
		// (set) Token: 0x06033AFC RID: 211708 RVA: 0x006F5AAF File Offset: 0x006F3CAF
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700D879 RID: 55417
		// (get) Token: 0x06033AFD RID: 211709 RVA: 0x006F5AB8 File Offset: 0x006F3CB8
		// (set) Token: 0x06033AFE RID: 211710 RVA: 0x006F5AC0 File Offset: 0x006F3CC0
		public IStopGuestCartethyiaT StopGuestUiAnimation { get; set; }

		// Token: 0x06033AFF RID: 211711 RVA: 0x006F5AC9 File Offset: 0x006F3CC9
		public IStopGuestUiAnimationT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
			this.StopGuestUiAnimation = null;
		}
	}
}
