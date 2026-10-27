using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF4 RID: 27892
	public class IPlayerHandInHandInitiatorT
	{
		// Token: 0x1700CFBD RID: 53181
		// (get) Token: 0x060312F5 RID: 201461 RVA: 0x006AC426 File Offset: 0x006AA626
		// (set) Token: 0x060312F6 RID: 201462 RVA: 0x006AC42E File Offset: 0x006AA62E
		public EHandInHandInitiatorType Type { get; set; }

		// Token: 0x060312F7 RID: 201463 RVA: 0x006AC437 File Offset: 0x006AA637
		public IPlayerHandInHandInitiatorT()
		{
			this.Type = EHandInHandInitiatorType.Player;
		}
	}
}
