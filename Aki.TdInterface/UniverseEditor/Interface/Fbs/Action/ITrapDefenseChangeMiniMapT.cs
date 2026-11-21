using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4B RID: 31819
	public class ITrapDefenseChangeMiniMapT
	{
		// Token: 0x1700EE3A RID: 60986
		// (get) Token: 0x060395B6 RID: 234934 RVA: 0x007BE92E File Offset: 0x007BCB2E
		// (set) Token: 0x060395B7 RID: 234935 RVA: 0x007BE936 File Offset: 0x007BCB36
		public int MiniMapId { get; set; }

		// Token: 0x060395B8 RID: 234936 RVA: 0x007BE93F File Offset: 0x007BCB3F
		public ITrapDefenseChangeMiniMapT()
		{
			this.MiniMapId = 0;
		}
	}
}
