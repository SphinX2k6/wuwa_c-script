using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F7 RID: 30455
	public class ISceneUiSubtitleTextBaseT
	{
		// Token: 0x1700DF66 RID: 57190
		// (get) Token: 0x06035709 RID: 218889 RVA: 0x0072AB72 File Offset: 0x00728D72
		// (set) Token: 0x0603570A RID: 218890 RVA: 0x0072AB7A File Offset: 0x00728D7A
		public ESceneUiSubtitleTextType Type { get; set; }

		// Token: 0x0603570B RID: 218891 RVA: 0x0072AB83 File Offset: 0x00728D83
		public ISceneUiSubtitleTextBaseT()
		{
			this.Type = ESceneUiSubtitleTextType.Flow;
		}
	}
}
