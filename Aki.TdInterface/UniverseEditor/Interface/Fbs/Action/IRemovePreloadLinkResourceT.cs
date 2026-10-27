using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E59 RID: 28249
	public class IRemovePreloadLinkResourceT
	{
		// Token: 0x1700D271 RID: 53873
		// (get) Token: 0x06031EB4 RID: 204468 RVA: 0x006C1028 File Offset: 0x006BF228
		// (set) Token: 0x06031EB5 RID: 204469 RVA: 0x006C1030 File Offset: 0x006BF230
		public ERemovePreloadResourceObjectType Type { get; set; }

		// Token: 0x1700D272 RID: 53874
		// (get) Token: 0x06031EB6 RID: 204470 RVA: 0x006C1039 File Offset: 0x006BF239
		// (set) Token: 0x06031EB7 RID: 204471 RVA: 0x006C1041 File Offset: 0x006BF241
		public int LinkResourceId { get; set; }

		// Token: 0x06031EB8 RID: 204472 RVA: 0x006C104A File Offset: 0x006BF24A
		public IRemovePreloadLinkResourceT()
		{
			this.Type = ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
			this.LinkResourceId = 0;
		}
	}
}
