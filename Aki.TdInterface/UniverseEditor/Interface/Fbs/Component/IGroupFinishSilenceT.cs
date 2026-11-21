using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DD RID: 22749
	public class IGroupFinishSilenceT
	{
		// Token: 0x1700A4F7 RID: 42231
		// (get) Token: 0x06024F20 RID: 151328 RVA: 0x005127EB File Offset: 0x005109EB
		// (set) Token: 0x06024F21 RID: 151329 RVA: 0x005127F3 File Offset: 0x005109F3
		public EGroupFinishConfig Type { get; set; }

		// Token: 0x1700A4F8 RID: 42232
		// (get) Token: 0x06024F22 RID: 151330 RVA: 0x005127FC File Offset: 0x005109FC
		// (set) Token: 0x06024F23 RID: 151331 RVA: 0x00512804 File Offset: 0x00510A04
		public IEntityStateT SwitchSpecifiedStatus { get; set; }

		// Token: 0x06024F24 RID: 151332 RVA: 0x0051280D File Offset: 0x00510A0D
		public IGroupFinishSilenceT()
		{
			this.Type = EGroupFinishConfig.Silence;
			this.SwitchSpecifiedStatus = null;
		}
	}
}
