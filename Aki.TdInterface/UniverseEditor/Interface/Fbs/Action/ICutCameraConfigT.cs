using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651D RID: 25885
	public class ICutCameraConfigT
	{
		// Token: 0x1700C078 RID: 49272
		// (get) Token: 0x0602CE77 RID: 183927 RVA: 0x0062AB8E File Offset: 0x00628D8E
		// (set) Token: 0x0602CE78 RID: 183928 RVA: 0x0062AB96 File Offset: 0x00628D96
		public ICameraParamsT CameraParams { get; set; }

		// Token: 0x1700C079 RID: 49273
		// (get) Token: 0x0602CE79 RID: 183929 RVA: 0x0062AB9F File Offset: 0x00628D9F
		// (set) Token: 0x0602CE7A RID: 183930 RVA: 0x0062ABA7 File Offset: 0x00628DA7
		public IPlayFlowT CutFlow { get; set; }

		// Token: 0x1700C07A RID: 49274
		// (get) Token: 0x0602CE7B RID: 183931 RVA: 0x0062ABB0 File Offset: 0x00628DB0
		// (set) Token: 0x0602CE7C RID: 183932 RVA: 0x0062ABB8 File Offset: 0x00628DB8
		public ICutCameraTimeParamsT CutTimeParams { get; set; }

		// Token: 0x0602CE7D RID: 183933 RVA: 0x0062ABC1 File Offset: 0x00628DC1
		public ICutCameraConfigT()
		{
			this.CameraParams = null;
			this.CutFlow = null;
			this.CutTimeParams = null;
		}
	}
}
