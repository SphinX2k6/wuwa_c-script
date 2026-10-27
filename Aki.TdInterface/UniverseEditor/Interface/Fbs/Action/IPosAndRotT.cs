using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D66 RID: 28006
	public class IPosAndRotT
	{
		// Token: 0x1700D0E3 RID: 53475
		// (get) Token: 0x0603174C RID: 202572 RVA: 0x006B497E File Offset: 0x006B2B7E
		// (set) Token: 0x0603174D RID: 202573 RVA: 0x006B4986 File Offset: 0x006B2B86
		public float X { get; set; }

		// Token: 0x1700D0E4 RID: 53476
		// (get) Token: 0x0603174E RID: 202574 RVA: 0x006B498F File Offset: 0x006B2B8F
		// (set) Token: 0x0603174F RID: 202575 RVA: 0x006B4997 File Offset: 0x006B2B97
		public float Y { get; set; }

		// Token: 0x1700D0E5 RID: 53477
		// (get) Token: 0x06031750 RID: 202576 RVA: 0x006B49A0 File Offset: 0x006B2BA0
		// (set) Token: 0x06031751 RID: 202577 RVA: 0x006B49A8 File Offset: 0x006B2BA8
		public float Z { get; set; }

		// Token: 0x1700D0E6 RID: 53478
		// (get) Token: 0x06031752 RID: 202578 RVA: 0x006B49B1 File Offset: 0x006B2BB1
		// (set) Token: 0x06031753 RID: 202579 RVA: 0x006B49B9 File Offset: 0x006B2BB9
		public float A { get; set; }

		// Token: 0x1700D0E7 RID: 53479
		// (get) Token: 0x06031754 RID: 202580 RVA: 0x006B49C2 File Offset: 0x006B2BC2
		// (set) Token: 0x06031755 RID: 202581 RVA: 0x006B49CA File Offset: 0x006B2BCA
		public float Roll { get; set; }

		// Token: 0x1700D0E8 RID: 53480
		// (get) Token: 0x06031756 RID: 202582 RVA: 0x006B49D3 File Offset: 0x006B2BD3
		// (set) Token: 0x06031757 RID: 202583 RVA: 0x006B49DB File Offset: 0x006B2BDB
		public float Pitch { get; set; }

		// Token: 0x1700D0E9 RID: 53481
		// (get) Token: 0x06031758 RID: 202584 RVA: 0x006B49E4 File Offset: 0x006B2BE4
		// (set) Token: 0x06031759 RID: 202585 RVA: 0x006B49EC File Offset: 0x006B2BEC
		public byte NullMask { get; set; }

		// Token: 0x0603175A RID: 202586 RVA: 0x006B49F8 File Offset: 0x006B2BF8
		public IPosAndRotT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.Roll = 0f;
			this.Pitch = 0f;
			this.NullMask = 0;
		}
	}
}
