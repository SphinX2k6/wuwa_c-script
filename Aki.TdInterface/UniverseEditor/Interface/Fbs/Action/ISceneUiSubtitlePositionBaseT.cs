using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E5 RID: 30437
	public class ISceneUiSubtitlePositionBaseT
	{
		// Token: 0x1700DF40 RID: 57152
		// (get) Token: 0x06035671 RID: 218737 RVA: 0x007298DA File Offset: 0x00727ADA
		// (set) Token: 0x06035672 RID: 218738 RVA: 0x007298E2 File Offset: 0x00727AE2
		public ESceneUiSubtitlePositionType Type { get; set; }

		// Token: 0x06035673 RID: 218739 RVA: 0x007298EB File Offset: 0x00727AEB
		public ISceneUiSubtitlePositionBaseT()
		{
			this.Type = ESceneUiSubtitlePositionType.Position;
		}
	}
}
