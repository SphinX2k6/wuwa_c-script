using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E3 RID: 21219
	public class IGameplayDataPersistenceT
	{
		// Token: 0x17009BC0 RID: 39872
		// (get) Token: 0x06022A41 RID: 141889 RVA: 0x004CD376 File Offset: 0x004CB576
		// (set) Token: 0x06022A42 RID: 141890 RVA: 0x004CD37E File Offset: 0x004CB57E
		public EDataPersistenceGameplayType Type { get; set; }

		// Token: 0x06022A43 RID: 141891 RVA: 0x004CD387 File Offset: 0x004CB587
		public IGameplayDataPersistenceT()
		{
			this.Type = EDataPersistenceGameplayType.TetrisBoardGame;
		}
	}
}
