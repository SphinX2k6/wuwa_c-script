using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007703 RID: 30467
	public class IScreenTypeT
	{
		// Token: 0x1700DF75 RID: 57205
		// (get) Token: 0x06035757 RID: 218967 RVA: 0x0072B2F2 File Offset: 0x007294F2
		// (set) Token: 0x06035758 RID: 218968 RVA: 0x0072B2FA File Offset: 0x007294FA
		public EScreenType Type { get; set; }

		// Token: 0x06035759 RID: 218969 RVA: 0x0072B303 File Offset: 0x00729503
		public IScreenTypeT()
		{
			this.Type = EScreenType.Main;
		}
	}
}
