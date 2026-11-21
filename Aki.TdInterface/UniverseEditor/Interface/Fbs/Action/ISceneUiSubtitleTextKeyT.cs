using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007700 RID: 30464
	public class ISceneUiSubtitleTextKeyT
	{
		// Token: 0x1700DF71 RID: 57201
		// (get) Token: 0x06035743 RID: 218947 RVA: 0x0072B157 File Offset: 0x00729357
		// (set) Token: 0x06035744 RID: 218948 RVA: 0x0072B15F File Offset: 0x0072935F
		public ESceneUiSubtitleTextType Type { get; set; }

		// Token: 0x1700DF72 RID: 57202
		// (get) Token: 0x06035745 RID: 218949 RVA: 0x0072B168 File Offset: 0x00729368
		// (set) Token: 0x06035746 RID: 218950 RVA: 0x0072B170 File Offset: 0x00729370
		public string TextKey { get; set; }

		// Token: 0x06035747 RID: 218951 RVA: 0x0072B179 File Offset: 0x00729379
		public ISceneUiSubtitleTextKeyT()
		{
			this.Type = ESceneUiSubtitleTextType.Flow;
			this.TextKey = null;
		}
	}
}
