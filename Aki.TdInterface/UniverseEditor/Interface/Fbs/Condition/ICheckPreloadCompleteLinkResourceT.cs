using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE7 RID: 20455
	public class ICheckPreloadCompleteLinkResourceT
	{
		// Token: 0x1700925D RID: 37469
		// (get) Token: 0x0601FEAF RID: 130735 RVA: 0x0046EA3C File Offset: 0x0046CC3C
		// (set) Token: 0x0601FEB0 RID: 130736 RVA: 0x0046EA44 File Offset: 0x0046CC44
		public ECheckPreloadCompleteObjectType Type { get; set; }

		// Token: 0x1700925E RID: 37470
		// (get) Token: 0x0601FEB1 RID: 130737 RVA: 0x0046EA4D File Offset: 0x0046CC4D
		// (set) Token: 0x0601FEB2 RID: 130738 RVA: 0x0046EA55 File Offset: 0x0046CC55
		public int LinkResourceId { get; set; }

		// Token: 0x0601FEB3 RID: 130739 RVA: 0x0046EA5E File Offset: 0x0046CC5E
		public ICheckPreloadCompleteLinkResourceT()
		{
			this.Type = ECheckPreloadCompleteObjectType.PreloadLinkResource;
			this.LinkResourceId = 0;
		}
	}
}
