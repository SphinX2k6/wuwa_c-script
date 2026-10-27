using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A21 RID: 27169
	public class ILimitPlayerMoveNewT
	{
		// Token: 0x1700C98D RID: 51597
		// (get) Token: 0x0602F8B5 RID: 194741 RVA: 0x00678F72 File Offset: 0x00677172
		// (set) Token: 0x0602F8B6 RID: 194742 RVA: 0x00678F7A File Offset: 0x0067717A
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x1700C98E RID: 51598
		// (get) Token: 0x0602F8B7 RID: 194743 RVA: 0x00678F83 File Offset: 0x00677183
		// (set) Token: 0x0602F8B8 RID: 194744 RVA: 0x00678F8B File Offset: 0x0067718B
		public bool Forward { get; set; }

		// Token: 0x1700C98F RID: 51599
		// (get) Token: 0x0602F8B9 RID: 194745 RVA: 0x00678F94 File Offset: 0x00677194
		// (set) Token: 0x0602F8BA RID: 194746 RVA: 0x00678F9C File Offset: 0x0067719C
		public bool Back { get; set; }

		// Token: 0x1700C990 RID: 51600
		// (get) Token: 0x0602F8BB RID: 194747 RVA: 0x00678FA5 File Offset: 0x006771A5
		// (set) Token: 0x0602F8BC RID: 194748 RVA: 0x00678FAD File Offset: 0x006771AD
		public bool Left { get; set; }

		// Token: 0x1700C991 RID: 51601
		// (get) Token: 0x0602F8BD RID: 194749 RVA: 0x00678FB6 File Offset: 0x006771B6
		// (set) Token: 0x0602F8BE RID: 194750 RVA: 0x00678FBE File Offset: 0x006771BE
		public bool Right { get; set; }

		// Token: 0x0602F8BF RID: 194751 RVA: 0x00678FC7 File Offset: 0x006771C7
		public ILimitPlayerMoveNewT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
			this.Forward = false;
			this.Back = false;
			this.Left = false;
			this.Right = false;
		}
	}
}
