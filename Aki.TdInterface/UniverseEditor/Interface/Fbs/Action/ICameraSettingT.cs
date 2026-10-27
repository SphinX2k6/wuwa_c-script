using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A0 RID: 25248
	public class ICameraSettingT
	{
		// Token: 0x1700BC78 RID: 48248
		// (get) Token: 0x0602BA01 RID: 178689 RVA: 0x00601764 File Offset: 0x005FF964
		// (set) Token: 0x0602BA02 RID: 178690 RVA: 0x0060176C File Offset: 0x005FF96C
		public float Aperture { get; set; }

		// Token: 0x1700BC79 RID: 48249
		// (get) Token: 0x0602BA03 RID: 178691 RVA: 0x00601775 File Offset: 0x005FF975
		// (set) Token: 0x0602BA04 RID: 178692 RVA: 0x0060177D File Offset: 0x005FF97D
		public float FocalLength { get; set; }

		// Token: 0x1700BC7A RID: 48250
		// (get) Token: 0x0602BA05 RID: 178693 RVA: 0x00601786 File Offset: 0x005FF986
		// (set) Token: 0x0602BA06 RID: 178694 RVA: 0x0060178E File Offset: 0x005FF98E
		public float FocusDistance { get; set; }

		// Token: 0x1700BC7B RID: 48251
		// (get) Token: 0x0602BA07 RID: 178695 RVA: 0x00601797 File Offset: 0x005FF997
		// (set) Token: 0x0602BA08 RID: 178696 RVA: 0x0060179F File Offset: 0x005FF99F
		public float FocalRegion { get; set; }

		// Token: 0x1700BC7C RID: 48252
		// (get) Token: 0x0602BA09 RID: 178697 RVA: 0x006017A8 File Offset: 0x005FF9A8
		// (set) Token: 0x0602BA0A RID: 178698 RVA: 0x006017B0 File Offset: 0x005FF9B0
		public float Fov { get; set; }

		// Token: 0x1700BC7D RID: 48253
		// (get) Token: 0x0602BA0B RID: 178699 RVA: 0x006017B9 File Offset: 0x005FF9B9
		// (set) Token: 0x0602BA0C RID: 178700 RVA: 0x006017C1 File Offset: 0x005FF9C1
		public byte NullMask { get; set; }

		// Token: 0x0602BA0D RID: 178701 RVA: 0x006017CC File Offset: 0x005FF9CC
		public ICameraSettingT()
		{
			this.Aperture = 0f;
			this.FocalLength = 0f;
			this.FocusDistance = 0f;
			this.FocalRegion = 0f;
			this.Fov = 0f;
			this.NullMask = 0;
		}
	}
}
