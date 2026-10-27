using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A1 RID: 24993
	public class IAssistCharacterNavigationMoveT
	{
		// Token: 0x1700BA4A RID: 47690
		// (get) Token: 0x0602B0CA RID: 176330 RVA: 0x005EFF65 File Offset: 0x005EE165
		// (set) Token: 0x0602B0CB RID: 176331 RVA: 0x005EFF6D File Offset: 0x005EE16D
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700BA4B RID: 47691
		// (get) Token: 0x0602B0CC RID: 176332 RVA: 0x005EFF76 File Offset: 0x005EE176
		// (set) Token: 0x0602B0CD RID: 176333 RVA: 0x005EFF7E File Offset: 0x005EE17E
		public IPosAT Destination { get; set; }

		// Token: 0x1700BA4C RID: 47692
		// (get) Token: 0x0602B0CE RID: 176334 RVA: 0x005EFF87 File Offset: 0x005EE187
		// (set) Token: 0x0602B0CF RID: 176335 RVA: 0x005EFF8F File Offset: 0x005EE18F
		public EMoveState MoveState { get; set; }

		// Token: 0x0602B0D0 RID: 176336 RVA: 0x005EFF98 File Offset: 0x005EE198
		public IAssistCharacterNavigationMoveT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
			this.Destination = null;
			this.MoveState = EMoveState.None;
		}
	}
}
