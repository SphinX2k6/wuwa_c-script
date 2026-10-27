using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755A RID: 30042
	public class IVisualNovelBackgroundBaseT
	{
		// Token: 0x1700E3E8 RID: 58344
		// (get) Token: 0x06036A88 RID: 223880 RVA: 0x0076C746 File Offset: 0x0076A946
		// (set) Token: 0x06036A89 RID: 223881 RVA: 0x0076C74E File Offset: 0x0076A94E
		public EVisualNovelBackgroundType Type { get; set; }

		// Token: 0x06036A8A RID: 223882 RVA: 0x0076C757 File Offset: 0x0076A957
		public IVisualNovelBackgroundBaseT()
		{
			this.Type = EVisualNovelBackgroundType.Load;
		}
	}
}
