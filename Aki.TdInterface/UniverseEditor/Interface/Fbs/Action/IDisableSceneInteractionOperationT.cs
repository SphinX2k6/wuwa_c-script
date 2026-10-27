using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065EF RID: 26095
	public class IDisableSceneInteractionOperationT
	{
		// Token: 0x1700C1D8 RID: 49624
		// (get) Token: 0x0602D4B3 RID: 185523 RVA: 0x00635396 File Offset: 0x00633596
		// (set) Token: 0x0602D4B4 RID: 185524 RVA: 0x0063539E File Offset: 0x0063359E
		public ESceneInteractionOperationType Type { get; set; }

		// Token: 0x0602D4B5 RID: 185525 RVA: 0x006353A7 File Offset: 0x006335A7
		public IDisableSceneInteractionOperationT()
		{
			this.Type = ESceneInteractionOperationType.Enable;
		}
	}
}
