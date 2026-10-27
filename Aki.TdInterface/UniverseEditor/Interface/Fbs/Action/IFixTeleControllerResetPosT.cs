using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E1 RID: 26593
	public class IFixTeleControllerResetPosT
	{
		// Token: 0x1700C55F RID: 50527
		// (get) Token: 0x0602E4BB RID: 189627 RVA: 0x006522CA File Offset: 0x006504CA
		// (set) Token: 0x0602E4BC RID: 189628 RVA: 0x006522D2 File Offset: 0x006504D2
		public int PositionEntityId { get; set; }

		// Token: 0x0602E4BD RID: 189629 RVA: 0x006522DB File Offset: 0x006504DB
		public IFixTeleControllerResetPosT()
		{
			this.PositionEntityId = 0;
		}
	}
}
