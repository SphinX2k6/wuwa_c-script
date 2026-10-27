using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F51 RID: 16209
	public class INewHandInItemsBaseT
	{
		// Token: 0x170070B9 RID: 28857
		// (get) Token: 0x060170CE RID: 94414 RVA: 0x00352CA2 File Offset: 0x00350EA2
		// (set) Token: 0x060170CF RID: 94415 RVA: 0x00352CAA File Offset: 0x00350EAA
		public ENewHandInItemsType Type { get; set; }

		// Token: 0x060170D0 RID: 94416 RVA: 0x00352CB3 File Offset: 0x00350EB3
		public INewHandInItemsBaseT()
		{
			this.Type = ENewHandInItemsType.ProjectionMachine;
		}
	}
}
