using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004125 RID: 16677
	public class IAreaNameSystemPromptT
	{
		// Token: 0x170070F4 RID: 28916
		// (get) Token: 0x06016E35 RID: 93749 RVA: 0x00344826 File Offset: 0x00342A26
		// (set) Token: 0x06016E36 RID: 93750 RVA: 0x0034482E File Offset: 0x00342A2E
		public ESystemPromptType Type { get; set; }

		// Token: 0x06016E37 RID: 93751 RVA: 0x00344837 File Offset: 0x00342A37
		public IAreaNameSystemPromptT()
		{
			this.Type = ESystemPromptType.AreaName;
		}
	}
}
