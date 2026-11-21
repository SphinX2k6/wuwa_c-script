using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF6 RID: 27894
	public class IEnableSceneInteractionOperationT
	{
		// Token: 0x1700CC93 RID: 52371
		// (get) Token: 0x0603016C RID: 196972 RVA: 0x0068A996 File Offset: 0x00688B96
		// (set) Token: 0x0603016D RID: 196973 RVA: 0x0068A99E File Offset: 0x00688B9E
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x0603016E RID: 196974 RVA: 0x0068A9A7 File Offset: 0x00688BA7
		public IEnableSceneInteractionOperationT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
