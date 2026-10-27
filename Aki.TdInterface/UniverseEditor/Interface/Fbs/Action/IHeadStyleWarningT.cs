using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D7 RID: 26839
	public class IHeadStyleWarningT
	{
		// Token: 0x1700C723 RID: 50979
		// (get) Token: 0x0602ED00 RID: 191744 RVA: 0x0066335E File Offset: 0x0066155E
		// (set) Token: 0x0602ED01 RID: 191745 RVA: 0x00663366 File Offset: 0x00661566
		public EHeadStyle Type { get; set; }

		// Token: 0x0602ED02 RID: 191746 RVA: 0x0066336F File Offset: 0x0066156F
		public IHeadStyleWarningT()
		{
			this.Type = EHeadStyle.Normal;
		}
	}
}
