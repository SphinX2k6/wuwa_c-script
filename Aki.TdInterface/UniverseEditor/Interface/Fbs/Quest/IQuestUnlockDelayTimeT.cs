using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004065 RID: 16485
	public class IQuestUnlockDelayTimeT
	{
		// Token: 0x17007427 RID: 29735
		// (get) Token: 0x06017ECB RID: 97995 RVA: 0x00373E9E File Offset: 0x0037209E
		// (set) Token: 0x06017ECC RID: 97996 RVA: 0x00373EA6 File Offset: 0x003720A6
		public int Day { get; set; }

		// Token: 0x17007428 RID: 29736
		// (get) Token: 0x06017ECD RID: 97997 RVA: 0x00373EAF File Offset: 0x003720AF
		// (set) Token: 0x06017ECE RID: 97998 RVA: 0x00373EB7 File Offset: 0x003720B7
		public int Hour { get; set; }

		// Token: 0x17007429 RID: 29737
		// (get) Token: 0x06017ECF RID: 97999 RVA: 0x00373EC0 File Offset: 0x003720C0
		// (set) Token: 0x06017ED0 RID: 98000 RVA: 0x00373EC8 File Offset: 0x003720C8
		public int Minute { get; set; }

		// Token: 0x06017ED1 RID: 98001 RVA: 0x00373ED1 File Offset: 0x003720D1
		public IQuestUnlockDelayTimeT()
		{
			this.Day = 0;
			this.Hour = 0;
			this.Minute = 0;
		}
	}
}
