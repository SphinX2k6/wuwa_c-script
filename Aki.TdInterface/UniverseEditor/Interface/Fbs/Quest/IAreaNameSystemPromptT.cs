using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D0E RID: 15630
	public class IAreaNameSystemPromptT
	{
		// Token: 0x17006B3A RID: 27450
		// (get) Token: 0x060158FD RID: 88317 RVA: 0x0031D5AE File Offset: 0x0031B7AE
		// (set) Token: 0x060158FE RID: 88318 RVA: 0x0031D5B6 File Offset: 0x0031B7B6
		public ESystemPromptType Type { get; set; }

		// Token: 0x060158FF RID: 88319 RVA: 0x0031D5BF File Offset: 0x0031B7BF
		public IAreaNameSystemPromptT()
		{
			this.Type = ESystemPromptType.AreaName;
		}
	}
}
