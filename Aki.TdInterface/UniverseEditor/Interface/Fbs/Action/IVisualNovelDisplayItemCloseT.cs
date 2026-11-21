using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D77 RID: 32119
	public class IVisualNovelDisplayItemCloseT
	{
		// Token: 0x1700F050 RID: 61520
		// (get) Token: 0x06039FBC RID: 237500 RVA: 0x007D1636 File Offset: 0x007CF836
		// (set) Token: 0x06039FBD RID: 237501 RVA: 0x007D163E File Offset: 0x007CF83E
		public EVisualNovelDisplayItemType Type { get; set; }

		// Token: 0x06039FBE RID: 237502 RVA: 0x007D1647 File Offset: 0x007CF847
		public IVisualNovelDisplayItemCloseT()
		{
			this.Type = EVisualNovelDisplayItemType.Image;
		}
	}
}
