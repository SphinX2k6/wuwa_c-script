using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200636E RID: 25454
	public class ICipherGameplayT
	{
		// Token: 0x1700BDE1 RID: 48609
		// (get) Token: 0x0602C091 RID: 180369 RVA: 0x0060CDEB File Offset: 0x0060AFEB
		// (set) Token: 0x0602C092 RID: 180370 RVA: 0x0060CDF3 File Offset: 0x0060AFF3
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700BDE2 RID: 48610
		// (get) Token: 0x0602C093 RID: 180371 RVA: 0x0060CDFC File Offset: 0x0060AFFC
		// (set) Token: 0x0602C094 RID: 180372 RVA: 0x0060CE04 File Offset: 0x0060B004
		public string CipherId { get; set; }

		// Token: 0x0602C095 RID: 180373 RVA: 0x0060CE0D File Offset: 0x0060B00D
		public ICipherGameplayT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.CipherId = null;
		}
	}
}
