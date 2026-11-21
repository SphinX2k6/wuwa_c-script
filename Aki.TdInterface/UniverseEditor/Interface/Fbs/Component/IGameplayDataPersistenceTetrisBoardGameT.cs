using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586C RID: 22636
	public class IGameplayDataPersistenceTetrisBoardGameT
	{
		// Token: 0x1700A3FC RID: 41980
		// (get) Token: 0x06024B10 RID: 150288 RVA: 0x0050A5F3 File Offset: 0x005087F3
		// (set) Token: 0x06024B11 RID: 150289 RVA: 0x0050A5FB File Offset: 0x005087FB
		public EDataPersistenceGameplayType Type { get; set; }

		// Token: 0x1700A3FD RID: 41981
		// (get) Token: 0x06024B12 RID: 150290 RVA: 0x0050A604 File Offset: 0x00508804
		// (set) Token: 0x06024B13 RID: 150291 RVA: 0x0050A60C File Offset: 0x0050880C
		public TVarRefUnion HighestScoreSyncVar { get; set; }

		// Token: 0x06024B14 RID: 150292 RVA: 0x0050A615 File Offset: 0x00508815
		public IGameplayDataPersistenceTetrisBoardGameT()
		{
			this.Type = EDataPersistenceGameplayType.TetrisBoardGame;
			this.HighestScoreSyncVar = null;
		}
	}
}
