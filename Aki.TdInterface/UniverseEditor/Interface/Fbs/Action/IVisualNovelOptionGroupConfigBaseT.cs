using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D83 RID: 32131
	public class IVisualNovelOptionGroupConfigBaseT
	{
		// Token: 0x1700F060 RID: 61536
		// (get) Token: 0x0603A00C RID: 237580 RVA: 0x007D1D26 File Offset: 0x007CFF26
		// (set) Token: 0x0603A00D RID: 237581 RVA: 0x007D1D2E File Offset: 0x007CFF2E
		public EVisualNovelOptionGroupType Type { get; set; }

		// Token: 0x0603A00E RID: 237582 RVA: 0x007D1D37 File Offset: 0x007CFF37
		public IVisualNovelOptionGroupConfigBaseT()
		{
			this.Type = EVisualNovelOptionGroupType.Normal;
		}
	}
}
