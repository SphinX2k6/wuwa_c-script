using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667C RID: 26236
	public class IEnableSceneInteractionOperationT
	{
		// Token: 0x1700C2E2 RID: 49890
		// (get) Token: 0x0602D94F RID: 186703 RVA: 0x0063D6E2 File Offset: 0x0063B8E2
		// (set) Token: 0x0602D950 RID: 186704 RVA: 0x0063D6EA File Offset: 0x0063B8EA
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x0602D951 RID: 186705 RVA: 0x0063D6F3 File Offset: 0x0063B8F3
		public IEnableSceneInteractionOperationT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
