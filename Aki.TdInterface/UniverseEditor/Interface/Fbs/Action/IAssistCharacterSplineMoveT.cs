using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061A4 RID: 24996
	public class IAssistCharacterSplineMoveT
	{
		// Token: 0x1700BA50 RID: 47696
		// (get) Token: 0x0602B0E2 RID: 176354 RVA: 0x005F01B0 File Offset: 0x005EE3B0
		// (set) Token: 0x0602B0E3 RID: 176355 RVA: 0x005F01B8 File Offset: 0x005EE3B8
		public EAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700BA51 RID: 47697
		// (get) Token: 0x0602B0E4 RID: 176356 RVA: 0x005F01C1 File Offset: 0x005EE3C1
		// (set) Token: 0x0602B0E5 RID: 176357 RVA: 0x005F01C9 File Offset: 0x005EE3C9
		public int SplineId { get; set; }

		// Token: 0x0602B0E6 RID: 176358 RVA: 0x005F01D2 File Offset: 0x005EE3D2
		public IAssistCharacterSplineMoveT()
		{
			this.Type = EAssistCharacterMoveType.Navigation;
			this.SplineId = 0;
		}
	}
}
