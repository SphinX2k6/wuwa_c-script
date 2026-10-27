using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A3 RID: 27043
	public class IInteractPointInteractionT
	{
		// Token: 0x1700C8A2 RID: 51362
		// (get) Token: 0x0602F409 RID: 193545 RVA: 0x0066FC4A File Offset: 0x0066DE4A
		// (set) Token: 0x0602F40A RID: 193546 RVA: 0x0066FC52 File Offset: 0x0066DE52
		public EInteractPointInteractionType Type { get; set; }

		// Token: 0x0602F40B RID: 193547 RVA: 0x0066FC5B File Offset: 0x0066DE5B
		public IInteractPointInteractionT()
		{
			this.Type = EInteractPointInteractionType.Drag;
		}
	}
}
