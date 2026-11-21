using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EB RID: 30443
	public class ISceneUiSubtitlePositionEntityT
	{
		// Token: 0x1700DF46 RID: 57158
		// (get) Token: 0x06035693 RID: 218771 RVA: 0x00729BFC File Offset: 0x00727DFC
		// (set) Token: 0x06035694 RID: 218772 RVA: 0x00729C04 File Offset: 0x00727E04
		public ESceneUiSubtitlePositionType Type { get; set; }

		// Token: 0x1700DF47 RID: 57159
		// (get) Token: 0x06035695 RID: 218773 RVA: 0x00729C0D File Offset: 0x00727E0D
		// (set) Token: 0x06035696 RID: 218774 RVA: 0x00729C15 File Offset: 0x00727E15
		public int EntityId { get; set; }

		// Token: 0x06035697 RID: 218775 RVA: 0x00729C1E File Offset: 0x00727E1E
		public ISceneUiSubtitlePositionEntityT()
		{
			this.Type = ESceneUiSubtitlePositionType.Position;
			this.EntityId = 0;
		}
	}
}
