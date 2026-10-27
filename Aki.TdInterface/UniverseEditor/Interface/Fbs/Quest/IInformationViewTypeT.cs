using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EAF RID: 16047
	public class IInformationViewTypeT
	{
		// Token: 0x17006F65 RID: 28517
		// (get) Token: 0x06016AA1 RID: 92833 RVA: 0x00345C8A File Offset: 0x00343E8A
		// (set) Token: 0x06016AA2 RID: 92834 RVA: 0x00345C92 File Offset: 0x00343E92
		public EInformationViewType Type { get; set; }

		// Token: 0x06016AA3 RID: 92835 RVA: 0x00345C9B File Offset: 0x00343E9B
		public IInformationViewTypeT()
		{
			this.Type = EInformationViewType.LevelPlay;
		}
	}
}
