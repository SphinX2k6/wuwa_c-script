using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200469B RID: 18075
	public class IUseCountT
	{
		// Token: 0x17007E9A RID: 32410
		// (get) Token: 0x0601A8B5 RID: 108725 RVA: 0x003C6D7A File Offset: 0x003C4F7A
		// (set) Token: 0x0601A8B6 RID: 108726 RVA: 0x003C6D82 File Offset: 0x003C4F82
		public EProgressBarLeftType Type { get; set; }

		// Token: 0x0601A8B7 RID: 108727 RVA: 0x003C6D8B File Offset: 0x003C4F8B
		public IUseCountT()
		{
			this.Type = EProgressBarLeftType.UseCount;
		}
	}
}
