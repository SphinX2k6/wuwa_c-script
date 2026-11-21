using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006977 RID: 26999
	public class IChangeLiftTargetT
	{
		// Token: 0x1700C6C6 RID: 50886
		// (get) Token: 0x0602E4D0 RID: 189648 RVA: 0x00652711 File Offset: 0x00650911
		// (set) Token: 0x0602E4D1 RID: 189649 RVA: 0x00652719 File Offset: 0x00650919
		public bool IsSelf { get; set; }

		// Token: 0x1700C6C7 RID: 50887
		// (get) Token: 0x0602E4D2 RID: 189650 RVA: 0x00652722 File Offset: 0x00650922
		// (set) Token: 0x0602E4D3 RID: 189651 RVA: 0x0065272A File Offset: 0x0065092A
		public TLiftMoveTypeUnion MoveType { get; set; }

		// Token: 0x1700C6C8 RID: 50888
		// (get) Token: 0x0602E4D4 RID: 189652 RVA: 0x00652733 File Offset: 0x00650933
		// (set) Token: 0x0602E4D5 RID: 189653 RVA: 0x0065273B File Offset: 0x0065093B
		public int EntityId { get; set; }

		// Token: 0x1700C6C9 RID: 50889
		// (get) Token: 0x0602E4D6 RID: 189654 RVA: 0x00652744 File Offset: 0x00650944
		// (set) Token: 0x0602E4D7 RID: 189655 RVA: 0x0065274C File Offset: 0x0065094C
		public int Location { get; set; }

		// Token: 0x1700C6CA RID: 50890
		// (get) Token: 0x0602E4D8 RID: 189656 RVA: 0x00652755 File Offset: 0x00650955
		// (set) Token: 0x0602E4D9 RID: 189657 RVA: 0x0065275D File Offset: 0x0065095D
		public byte NullMask { get; set; }

		// Token: 0x0602E4DA RID: 189658 RVA: 0x00652766 File Offset: 0x00650966
		public IChangeLiftTargetT()
		{
			this.IsSelf = false;
			this.MoveType = null;
			this.EntityId = 0;
			this.Location = 0;
			this.NullMask = 0;
		}
	}
}
