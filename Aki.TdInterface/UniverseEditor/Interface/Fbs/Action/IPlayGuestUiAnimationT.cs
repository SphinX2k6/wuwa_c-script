using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1B RID: 27931
	public class IPlayGuestUiAnimationT
	{
		// Token: 0x1700CFF9 RID: 53241
		// (get) Token: 0x06031414 RID: 201748 RVA: 0x006AE217 File Offset: 0x006AC417
		// (set) Token: 0x06031415 RID: 201749 RVA: 0x006AE21F File Offset: 0x006AC41F
		public EGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700CFFA RID: 53242
		// (get) Token: 0x06031416 RID: 201750 RVA: 0x006AE228 File Offset: 0x006AC428
		// (set) Token: 0x06031417 RID: 201751 RVA: 0x006AE230 File Offset: 0x006AC430
		public IPlayGuestCartethyiaT PlayGuestUiAnimation { get; set; }

		// Token: 0x06031418 RID: 201752 RVA: 0x006AE239 File Offset: 0x006AC439
		public IPlayGuestUiAnimationT()
		{
			this.Type = EGuestOperateUiAnimation.Play;
			this.PlayGuestUiAnimation = null;
		}
	}
}
