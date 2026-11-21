using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F2 RID: 18162
	public class IWarningPreformTypeT
	{
		// Token: 0x17007F3B RID: 32571
		// (get) Token: 0x0601AB8F RID: 109455 RVA: 0x003CC366 File Offset: 0x003CA566
		// (set) Token: 0x0601AB90 RID: 109456 RVA: 0x003CC36E File Offset: 0x003CA56E
		public EWarningPreformType Type { get; set; }

		// Token: 0x0601AB91 RID: 109457 RVA: 0x003CC377 File Offset: 0x003CA577
		public IWarningPreformTypeT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
		}
	}
}
