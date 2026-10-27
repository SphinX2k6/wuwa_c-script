using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006353 RID: 25427
	public class ICharacterMoveToPointT
	{
		// Token: 0x1700BDB4 RID: 48564
		// (get) Token: 0x0602BFC1 RID: 180161 RVA: 0x0060B6A9 File Offset: 0x006098A9
		// (set) Token: 0x0602BFC2 RID: 180162 RVA: 0x0060B6B1 File Offset: 0x006098B1
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700BDB5 RID: 48565
		// (get) Token: 0x0602BFC3 RID: 180163 RVA: 0x0060B6BA File Offset: 0x006098BA
		// (set) Token: 0x0602BFC4 RID: 180164 RVA: 0x0060B6C2 File Offset: 0x006098C2
		public IVectorInfoT Pos { get; set; }

		// Token: 0x1700BDB6 RID: 48566
		// (get) Token: 0x0602BFC5 RID: 180165 RVA: 0x0060B6CB File Offset: 0x006098CB
		// (set) Token: 0x0602BFC6 RID: 180166 RVA: 0x0060B6D3 File Offset: 0x006098D3
		public ECharacterMoveToPointType MoveType { get; set; }

		// Token: 0x0602BFC7 RID: 180167 RVA: 0x0060B6DC File Offset: 0x006098DC
		public ICharacterMoveToPointT()
		{
			this.Target = null;
			this.Pos = null;
			this.MoveType = ECharacterMoveToPointType.Walk;
		}
	}
}
