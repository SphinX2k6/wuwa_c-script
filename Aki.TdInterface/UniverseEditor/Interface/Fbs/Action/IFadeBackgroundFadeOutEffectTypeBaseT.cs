using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF5 RID: 28149
	public class IFadeBackgroundFadeOutEffectTypeBaseT
	{
		// Token: 0x1700CE4F RID: 52815
		// (get) Token: 0x06030987 RID: 199047 RVA: 0x00699056 File Offset: 0x00697256
		// (set) Token: 0x06030988 RID: 199048 RVA: 0x0069905E File Offset: 0x0069725E
		public EFadeBackgroundFadeOutEffectType Type { get; set; }

		// Token: 0x06030989 RID: 199049 RVA: 0x00699067 File Offset: 0x00697267
		public IFadeBackgroundFadeOutEffectTypeBaseT()
		{
			this.Type = EFadeBackgroundFadeOutEffectType.Black;
		}
	}
}
