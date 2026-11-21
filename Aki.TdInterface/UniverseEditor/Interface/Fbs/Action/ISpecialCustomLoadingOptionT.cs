using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007942 RID: 31042
	public class ISpecialCustomLoadingOptionT
	{
		// Token: 0x1700E3BB RID: 58299
		// (get) Token: 0x06036ACF RID: 223951 RVA: 0x00750FB6 File Offset: 0x0074F1B6
		// (set) Token: 0x06036AD0 RID: 223952 RVA: 0x00750FBE File Offset: 0x0074F1BE
		public ESpecialCustomLoadingType Type { get; set; }

		// Token: 0x06036AD1 RID: 223953 RVA: 0x00750FC7 File Offset: 0x0074F1C7
		public ISpecialCustomLoadingOptionT()
		{
			this.Type = ESpecialCustomLoadingType.HonamiStory;
		}
	}
}
