using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046EF RID: 18159
	public class IWarningPreformFadeInScreenT
	{
		// Token: 0x17007F38 RID: 32568
		// (get) Token: 0x0601AB7D RID: 109437 RVA: 0x003CC1EE File Offset: 0x003CA3EE
		// (set) Token: 0x0601AB7E RID: 109438 RVA: 0x003CC1F6 File Offset: 0x003CA3F6
		public EWarningPreformType Type { get; set; }

		// Token: 0x0601AB7F RID: 109439 RVA: 0x003CC1FF File Offset: 0x003CA3FF
		public IWarningPreformFadeInScreenT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
		}
	}
}
