using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D53 RID: 27987
	public class IEntityControlConfigT
	{
		// Token: 0x1700CD49 RID: 52553
		// (get) Token: 0x06030474 RID: 197748 RVA: 0x0068FC94 File Offset: 0x0068DE94
		// (set) Token: 0x06030475 RID: 197749 RVA: 0x0068FC9C File Offset: 0x0068DE9C
		public bool IsControlPlayer { get; set; }

		// Token: 0x1700CD4A RID: 52554
		// (get) Token: 0x06030476 RID: 197750 RVA: 0x0068FCA5 File Offset: 0x0068DEA5
		// (set) Token: 0x06030477 RID: 197751 RVA: 0x0068FCAD File Offset: 0x0068DEAD
		public bool HideSkipButton { get; set; }

		// Token: 0x1700CD4B RID: 52555
		// (get) Token: 0x06030478 RID: 197752 RVA: 0x0068FCB6 File Offset: 0x0068DEB6
		// (set) Token: 0x06030479 RID: 197753 RVA: 0x0068FCBE File Offset: 0x0068DEBE
		public EEntityControlCameraMode CameraMode { get; set; }

		// Token: 0x1700CD4C RID: 52556
		// (get) Token: 0x0603047A RID: 197754 RVA: 0x0068FCC7 File Offset: 0x0068DEC7
		// (set) Token: 0x0603047B RID: 197755 RVA: 0x0068FCCF File Offset: 0x0068DECF
		public byte NullMask { get; set; }

		// Token: 0x0603047C RID: 197756 RVA: 0x0068FCD8 File Offset: 0x0068DED8
		public IEntityControlConfigT()
		{
			this.IsControlPlayer = false;
			this.HideSkipButton = false;
			this.CameraMode = EEntityControlCameraMode.UseSequenceCamera;
			this.NullMask = 0;
		}
	}
}
