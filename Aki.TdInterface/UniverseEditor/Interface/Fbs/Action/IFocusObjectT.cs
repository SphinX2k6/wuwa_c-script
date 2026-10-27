using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006838 RID: 26680
	public class IFocusObjectT
	{
		// Token: 0x1700C633 RID: 50739
		// (get) Token: 0x0602E849 RID: 190537 RVA: 0x00658FD7 File Offset: 0x006571D7
		// (set) Token: 0x0602E84A RID: 190538 RVA: 0x00658FDF File Offset: 0x006571DF
		public IFocusObjectRotationConfigT RotationConfig { get; set; }

		// Token: 0x1700C634 RID: 50740
		// (get) Token: 0x0602E84B RID: 190539 RVA: 0x00658FE8 File Offset: 0x006571E8
		// (set) Token: 0x0602E84C RID: 190540 RVA: 0x00658FF0 File Offset: 0x006571F0
		public IFocusObjectCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700C635 RID: 50741
		// (get) Token: 0x0602E84D RID: 190541 RVA: 0x00658FF9 File Offset: 0x006571F9
		// (set) Token: 0x0602E84E RID: 190542 RVA: 0x00659001 File Offset: 0x00657201
		public int LeaveIndex { get; set; }

		// Token: 0x1700C636 RID: 50742
		// (get) Token: 0x0602E84F RID: 190543 RVA: 0x0065900A File Offset: 0x0065720A
		// (set) Token: 0x0602E850 RID: 190544 RVA: 0x00659012 File Offset: 0x00657212
		public byte NullMask { get; set; }

		// Token: 0x0602E851 RID: 190545 RVA: 0x0065901B File Offset: 0x0065721B
		public IFocusObjectT()
		{
			this.RotationConfig = null;
			this.CameraConfig = null;
			this.LeaveIndex = 0;
			this.NullMask = 0;
		}
	}
}
