using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006844 RID: 26692
	public class IFocusOnMapMarkT
	{
		// Token: 0x1700C64A RID: 50762
		// (get) Token: 0x0602E8A9 RID: 190633 RVA: 0x006599EA File Offset: 0x00657BEA
		// (set) Token: 0x0602E8AA RID: 190634 RVA: 0x006599F2 File Offset: 0x00657BF2
		public EMapMarkType Type { get; set; }

		// Token: 0x0602E8AB RID: 190635 RVA: 0x006599FB File Offset: 0x00657BFB
		public IFocusOnMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
		}
	}
}
