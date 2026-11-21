using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DC RID: 30428
	public class ISceneUiSubtitleOperationBaseT
	{
		// Token: 0x1700DF36 RID: 57142
		// (get) Token: 0x0603563B RID: 218683 RVA: 0x0072938E File Offset: 0x0072758E
		// (set) Token: 0x0603563C RID: 218684 RVA: 0x00729396 File Offset: 0x00727596
		public ESceneUiSubtitleOperationType Type { get; set; }

		// Token: 0x0603563D RID: 218685 RVA: 0x0072939F File Offset: 0x0072759F
		public ISceneUiSubtitleOperationBaseT()
		{
			this.Type = ESceneUiSubtitleOperationType.Spawn;
		}
	}
}
