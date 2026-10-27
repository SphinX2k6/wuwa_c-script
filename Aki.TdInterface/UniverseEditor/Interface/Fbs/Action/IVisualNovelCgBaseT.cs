using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007566 RID: 30054
	public class IVisualNovelCgBaseT
	{
		// Token: 0x1700E3F5 RID: 58357
		// (get) Token: 0x06036AD0 RID: 223952 RVA: 0x0076CD7E File Offset: 0x0076AF7E
		// (set) Token: 0x06036AD1 RID: 223953 RVA: 0x0076CD86 File Offset: 0x0076AF86
		public EVisualNovelCgType Type { get; set; }

		// Token: 0x06036AD2 RID: 223954 RVA: 0x0076CD8F File Offset: 0x0076AF8F
		public IVisualNovelCgBaseT()
		{
			this.Type = EVisualNovelCgType.LoadSpine;
		}
	}
}
