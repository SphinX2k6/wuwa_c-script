using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BB RID: 30395
	public class ISceneInteractionOperationTypeT
	{
		// Token: 0x1700DEF5 RID: 57077
		// (get) Token: 0x06035525 RID: 218405 RVA: 0x00727302 File Offset: 0x00725502
		// (set) Token: 0x06035526 RID: 218406 RVA: 0x0072730A File Offset: 0x0072550A
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x06035527 RID: 218407 RVA: 0x00727313 File Offset: 0x00725513
		public ISceneInteractionOperationTypeT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
