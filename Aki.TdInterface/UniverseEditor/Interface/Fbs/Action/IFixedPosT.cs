using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CF RID: 26575
	public class IFixedPosT
	{
		// Token: 0x1700C54C RID: 50508
		// (get) Token: 0x0602E441 RID: 189505 RVA: 0x006516EF File Offset: 0x0064F8EF
		// (set) Token: 0x0602E442 RID: 189506 RVA: 0x006516F7 File Offset: 0x0064F8F7
		public ETeleportType Type { get; set; }

		// Token: 0x1700C54D RID: 50509
		// (get) Token: 0x0602E443 RID: 189507 RVA: 0x00651700 File Offset: 0x0064F900
		// (set) Token: 0x0602E444 RID: 189508 RVA: 0x00651708 File Offset: 0x0064F908
		public IPosAT TargetPos { get; set; }

		// Token: 0x0602E445 RID: 189509 RVA: 0x00651711 File Offset: 0x0064F911
		public IFixedPosT()
		{
			this.Type = ETeleportType.FixedPos;
			this.TargetPos = null;
		}
	}
}
