using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E2 RID: 30434
	public class ISceneUiSubtitlePositionT
	{
		// Token: 0x1700DF3C RID: 57148
		// (get) Token: 0x0603565D RID: 218717 RVA: 0x0072971B File Offset: 0x0072791B
		// (set) Token: 0x0603565E RID: 218718 RVA: 0x00729723 File Offset: 0x00727923
		public ESceneUiSubtitlePositionType Type { get; set; }

		// Token: 0x1700DF3D RID: 57149
		// (get) Token: 0x0603565F RID: 218719 RVA: 0x0072972C File Offset: 0x0072792C
		// (set) Token: 0x06035660 RID: 218720 RVA: 0x00729734 File Offset: 0x00727934
		public IPosAndRotT Pos { get; set; }

		// Token: 0x06035661 RID: 218721 RVA: 0x0072973D File Offset: 0x0072793D
		public ISceneUiSubtitlePositionT()
		{
			this.Type = ESceneUiSubtitlePositionType.Position;
			this.Pos = null;
		}
	}
}
