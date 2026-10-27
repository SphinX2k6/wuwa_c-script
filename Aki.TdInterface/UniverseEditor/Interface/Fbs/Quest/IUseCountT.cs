using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423F RID: 16959
	public class IUseCountT
	{
		// Token: 0x17007869 RID: 30825
		// (get) Token: 0x06019149 RID: 102729 RVA: 0x0039B6A2 File Offset: 0x003998A2
		// (set) Token: 0x0601914A RID: 102730 RVA: 0x0039B6AA File Offset: 0x003998AA
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x0601914B RID: 102731 RVA: 0x0039B6B3 File Offset: 0x003998B3
		public IUseCountT()
		{
			this.Type = EProgressBarLeftType.UseCount;
		}
	}
}
