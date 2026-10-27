using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E9 RID: 21225
	public class IGameplayDataPersistenceTetrisBoardGameT
	{
		// Token: 0x17009BCB RID: 39883
		// (get) Token: 0x06022A76 RID: 141942 RVA: 0x004CDAC7 File Offset: 0x004CBCC7
		// (set) Token: 0x06022A77 RID: 141943 RVA: 0x004CDACF File Offset: 0x004CBCCF
		public EDataPersistenceGameplayType Type { get; set; }

		// Token: 0x17009BCC RID: 39884
		// (get) Token: 0x06022A78 RID: 141944 RVA: 0x004CDAD8 File Offset: 0x004CBCD8
		// (set) Token: 0x06022A79 RID: 141945 RVA: 0x004CDAE0 File Offset: 0x004CBCE0
		public TVarRefUnion HighestScoreSyncVar { get; set; }

		// Token: 0x06022A7A RID: 141946 RVA: 0x004CDAE9 File Offset: 0x004CBCE9
		public IGameplayDataPersistenceTetrisBoardGameT()
		{
			this.Type = EDataPersistenceGameplayType.TetrisBoardGame;
			this.HighestScoreSyncVar = null;
		}
	}
}
