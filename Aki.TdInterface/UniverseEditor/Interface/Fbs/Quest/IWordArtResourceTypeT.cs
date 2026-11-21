using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004707 RID: 18183
	public class IWordArtResourceTypeT
	{
		// Token: 0x17007F54 RID: 32596
		// (get) Token: 0x0601AC0F RID: 109583 RVA: 0x003CCFBE File Offset: 0x003CB1BE
		// (set) Token: 0x0601AC10 RID: 109584 RVA: 0x003CCFC6 File Offset: 0x003CB1C6
		public EWordArtResourceType Type { get; set; }

		// Token: 0x0601AC11 RID: 109585 RVA: 0x003CCFCF File Offset: 0x003CB1CF
		public IWordArtResourceTypeT()
		{
			this.Type = EWordArtResourceType.Default;
		}
	}
}
