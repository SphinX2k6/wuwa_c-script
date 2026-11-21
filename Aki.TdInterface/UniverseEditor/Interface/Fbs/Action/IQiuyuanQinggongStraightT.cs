using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756B RID: 30059
	public class IQiuyuanQinggongStraightT
	{
		// Token: 0x1700DD07 RID: 56583
		// (get) Token: 0x06034B53 RID: 215891 RVA: 0x0071696A File Offset: 0x00714B6A
		// (set) Token: 0x06034B54 RID: 215892 RVA: 0x00716972 File Offset: 0x00714B72
		public ELeisureInteract Type { get; set; }

		// Token: 0x06034B55 RID: 215893 RVA: 0x0071697B File Offset: 0x00714B7B
		public IQiuyuanQinggongStraightT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
