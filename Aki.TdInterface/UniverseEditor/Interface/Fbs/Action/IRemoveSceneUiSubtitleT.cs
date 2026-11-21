using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EC RID: 30188
	public class IRemoveSceneUiSubtitleT
	{
		// Token: 0x1700DDDC RID: 56796
		// (get) Token: 0x06034F68 RID: 216936 RVA: 0x0071DA93 File Offset: 0x0071BC93
		// (set) Token: 0x06034F69 RID: 216937 RVA: 0x0071DA9B File Offset: 0x0071BC9B
		public ESceneUiSubtitleOperationType Type { get; set; }

		// Token: 0x1700DDDD RID: 56797
		// (get) Token: 0x06034F6A RID: 216938 RVA: 0x0071DAA4 File Offset: 0x0071BCA4
		// (set) Token: 0x06034F6B RID: 216939 RVA: 0x0071DAAC File Offset: 0x0071BCAC
		public string Mark { get; set; }

		// Token: 0x06034F6C RID: 216940 RVA: 0x0071DAB5 File Offset: 0x0071BCB5
		public IRemoveSceneUiSubtitleT()
		{
			this.Type = ESceneUiSubtitleOperationType.Spawn;
			this.Mark = null;
		}
	}
}
