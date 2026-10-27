using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1E RID: 27166
	public class ILimitPlayerMoveT
	{
		// Token: 0x1700C984 RID: 51588
		// (get) Token: 0x0602F897 RID: 194711 RVA: 0x00678C0E File Offset: 0x00676E0E
		// (set) Token: 0x0602F898 RID: 194712 RVA: 0x00678C16 File Offset: 0x00676E16
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x1700C985 RID: 51589
		// (get) Token: 0x0602F899 RID: 194713 RVA: 0x00678C1F File Offset: 0x00676E1F
		// (set) Token: 0x0602F89A RID: 194714 RVA: 0x00678C27 File Offset: 0x00676E27
		public bool IsOnlyForward { get; set; }

		// Token: 0x1700C986 RID: 51590
		// (get) Token: 0x0602F89B RID: 194715 RVA: 0x00678C30 File Offset: 0x00676E30
		// (set) Token: 0x0602F89C RID: 194716 RVA: 0x00678C38 File Offset: 0x00676E38
		public byte NullMask { get; set; }

		// Token: 0x0602F89D RID: 194717 RVA: 0x00678C41 File Offset: 0x00676E41
		public ILimitPlayerMoveT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
			this.IsOnlyForward = false;
			this.NullMask = 0;
		}
	}
}
