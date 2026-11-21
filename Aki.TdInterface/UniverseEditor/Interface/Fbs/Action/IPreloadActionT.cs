using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007505 RID: 29957
	public class IPreloadActionT
	{
		// Token: 0x1700DC7E RID: 56446
		// (get) Token: 0x06034897 RID: 215191 RVA: 0x007126E9 File Offset: 0x007108E9
		// (set) Token: 0x06034898 RID: 215192 RVA: 0x007126F1 File Offset: 0x007108F1
		public TPreloadObjectTypeConfigUnion PreloadObjectType { get; set; }

		// Token: 0x06034899 RID: 215193 RVA: 0x007126FA File Offset: 0x007108FA
		public IPreloadActionT()
		{
			this.PreloadObjectType = null;
		}
	}
}
