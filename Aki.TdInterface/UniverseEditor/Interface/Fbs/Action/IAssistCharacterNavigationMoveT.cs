using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680C RID: 26636
	public class IAssistCharacterNavigationMoveT
	{
		// Token: 0x1700C3C8 RID: 50120
		// (get) Token: 0x0602D7FB RID: 186363 RVA: 0x0063A7D9 File Offset: 0x006389D9
		// (set) Token: 0x0602D7FC RID: 186364 RVA: 0x0063A7E1 File Offset: 0x006389E1
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700C3C9 RID: 50121
		// (get) Token: 0x0602D7FD RID: 186365 RVA: 0x0063A7EA File Offset: 0x006389EA
		// (set) Token: 0x0602D7FE RID: 186366 RVA: 0x0063A7F2 File Offset: 0x006389F2
		public IPosAT Destination { get; set; }

		// Token: 0x1700C3CA RID: 50122
		// (get) Token: 0x0602D7FF RID: 186367 RVA: 0x0063A7FB File Offset: 0x006389FB
		// (set) Token: 0x0602D800 RID: 186368 RVA: 0x0063A803 File Offset: 0x00638A03
		public EMoveState MoveState { get; set; }

		// Token: 0x0602D801 RID: 186369 RVA: 0x0063A80C File Offset: 0x00638A0C
		public IAssistCharacterNavigationMoveT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
			this.Destination = null;
			this.MoveState = EMoveState.None;
		}
	}
}
