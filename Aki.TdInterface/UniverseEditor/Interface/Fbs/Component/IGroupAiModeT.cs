using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005336 RID: 21302
	public class IGroupAiModeT
	{
		// Token: 0x17009C7F RID: 40063
		// (get) Token: 0x06022D5C RID: 142684 RVA: 0x004D3986 File Offset: 0x004D1B86
		// (set) Token: 0x06022D5D RID: 142685 RVA: 0x004D398E File Offset: 0x004D1B8E
		public EGroupAiMode Type { get; set; }

		// Token: 0x06022D5E RID: 142686 RVA: 0x004D3997 File Offset: 0x004D1B97
		public IGroupAiModeT()
		{
			this.Type = EGroupAiMode.Default;
		}
	}
}
