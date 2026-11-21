using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B7 RID: 17847
	public class ISystemPromptTypeT
	{
		// Token: 0x17007CB9 RID: 31929
		// (get) Token: 0x0601A09D RID: 106653 RVA: 0x003B5F7E File Offset: 0x003B417E
		// (set) Token: 0x0601A09E RID: 106654 RVA: 0x003B5F86 File Offset: 0x003B4186
		public ESystemPromptType Type { get; set; }

		// Token: 0x0601A09F RID: 106655 RVA: 0x003B5F8F File Offset: 0x003B418F
		public ISystemPromptTypeT()
		{
			this.Type = ESystemPromptType.AreaName;
		}
	}
}
