using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200749D RID: 29853
	public class IUiAnimConfigT
	{
		// Token: 0x1700E2AC RID: 58028
		// (get) Token: 0x0603644A RID: 222282 RVA: 0x0076084E File Offset: 0x0075EA4E
		// (set) Token: 0x0603644B RID: 222283 RVA: 0x00760856 File Offset: 0x0075EA56
		public string UiStartAnimName { get; set; }

		// Token: 0x1700E2AD RID: 58029
		// (get) Token: 0x0603644C RID: 222284 RVA: 0x0076085F File Offset: 0x0075EA5F
		// (set) Token: 0x0603644D RID: 222285 RVA: 0x00760867 File Offset: 0x0075EA67
		public string UiEndAnimName { get; set; }

		// Token: 0x0603644E RID: 222286 RVA: 0x00760870 File Offset: 0x0075EA70
		public IUiAnimConfigT()
		{
			this.UiStartAnimName = null;
			this.UiEndAnimName = null;
		}
	}
}
