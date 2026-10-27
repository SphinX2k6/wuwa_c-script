using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004173 RID: 16755
	public class ISystemPromptTypeT
	{
		// Token: 0x170076AA RID: 30378
		// (get) Token: 0x060189D5 RID: 100821 RVA: 0x0038B9C2 File Offset: 0x00389BC2
		// (set) Token: 0x060189D6 RID: 100822 RVA: 0x0038B9CA File Offset: 0x00389BCA
		public ESystemPromptType Type { get; set; }

		// Token: 0x060189D7 RID: 100823 RVA: 0x0038B9D3 File Offset: 0x00389BD3
		public ISystemPromptTypeT()
		{
			this.Type = ESystemPromptType.AreaName;
		}
	}
}
