using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005869 RID: 22633
	public class IGameplayDataPersistenceComponentT
	{
		// Token: 0x1700A3F6 RID: 41974
		// (get) Token: 0x06024AF1 RID: 150257 RVA: 0x0050A14D File Offset: 0x0050834D
		// (set) Token: 0x06024AF2 RID: 150258 RVA: 0x0050A155 File Offset: 0x00508355
		public bool Disabled { get; set; }

		// Token: 0x1700A3F7 RID: 41975
		// (get) Token: 0x06024AF3 RID: 150259 RVA: 0x0050A15E File Offset: 0x0050835E
		// (set) Token: 0x06024AF4 RID: 150260 RVA: 0x0050A166 File Offset: 0x00508366
		public IGameplayDataPersistenceTetrisBoardGameT DataPersistenceGameplay { get; set; }

		// Token: 0x1700A3F8 RID: 41976
		// (get) Token: 0x06024AF5 RID: 150261 RVA: 0x0050A16F File Offset: 0x0050836F
		// (set) Token: 0x06024AF6 RID: 150262 RVA: 0x0050A177 File Offset: 0x00508377
		public byte NullMask { get; set; }

		// Token: 0x06024AF7 RID: 150263 RVA: 0x0050A180 File Offset: 0x00508380
		public IGameplayDataPersistenceComponentT()
		{
			this.Disabled = false;
			this.DataPersistenceGameplay = null;
			this.NullMask = 0;
		}
	}
}
