using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E01 RID: 28161
	public class IFadeBackgroundTypeT
	{
		// Token: 0x1700CE66 RID: 52838
		// (get) Token: 0x060309E5 RID: 199141 RVA: 0x00699B8A File Offset: 0x00697D8A
		// (set) Token: 0x060309E6 RID: 199142 RVA: 0x00699B92 File Offset: 0x00697D92
		public EFadeBackgroundType Type { get; set; }

		// Token: 0x060309E7 RID: 199143 RVA: 0x00699B9B File Offset: 0x00697D9B
		public IFadeBackgroundTypeT()
		{
			this.Type = EFadeBackgroundType.Spine;
		}
	}
}
