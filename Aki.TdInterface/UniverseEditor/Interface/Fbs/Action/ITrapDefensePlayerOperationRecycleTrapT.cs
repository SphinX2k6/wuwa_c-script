using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C54 RID: 31828
	public class ITrapDefensePlayerOperationRecycleTrapT
	{
		// Token: 0x1700EE47 RID: 60999
		// (get) Token: 0x060395FB RID: 235003 RVA: 0x007BF0CA File Offset: 0x007BD2CA
		// (set) Token: 0x060395FC RID: 235004 RVA: 0x007BF0D2 File Offset: 0x007BD2D2
		public ETrapDefensePlayerOperationType Type { get; set; }

		// Token: 0x060395FD RID: 235005 RVA: 0x007BF0DB File Offset: 0x007BD2DB
		public ITrapDefensePlayerOperationRecycleTrapT()
		{
			this.Type = ETrapDefensePlayerOperationType.SpawnMonster;
		}
	}
}
