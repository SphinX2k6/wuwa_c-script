using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041DF RID: 16863
	public class ITimerUiConfigT
	{
		// Token: 0x1700779E RID: 30622
		// (get) Token: 0x06018DBA RID: 101818 RVA: 0x00393ACF File Offset: 0x00391CCF
		// (set) Token: 0x06018DBB RID: 101819 RVA: 0x00393AD7 File Offset: 0x00391CD7
		public ETimerUiType UiType { get; set; }

		// Token: 0x1700779F RID: 30623
		// (get) Token: 0x06018DBC RID: 101820 RVA: 0x00393AE0 File Offset: 0x00391CE0
		// (set) Token: 0x06018DBD RID: 101821 RVA: 0x00393AE8 File Offset: 0x00391CE8
		public string TidTitle { get; set; }

		// Token: 0x06018DBE RID: 101822 RVA: 0x00393AF1 File Offset: 0x00391CF1
		public ITimerUiConfigT()
		{
			this.UiType = ETimerUiType.Default;
			this.TidTitle = null;
		}
	}
}
