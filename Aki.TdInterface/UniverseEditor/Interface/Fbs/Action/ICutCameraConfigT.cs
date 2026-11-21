using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8B RID: 27531
	public class ICutCameraConfigT
	{
		// Token: 0x1700CA0A RID: 51722
		// (get) Token: 0x0602F615 RID: 194069 RVA: 0x0067703A File Offset: 0x0067523A
		// (set) Token: 0x0602F616 RID: 194070 RVA: 0x00677042 File Offset: 0x00675242
		public ICameraParamsT CameraParams { get; set; }

		// Token: 0x1700CA0B RID: 51723
		// (get) Token: 0x0602F617 RID: 194071 RVA: 0x0067704B File Offset: 0x0067524B
		// (set) Token: 0x0602F618 RID: 194072 RVA: 0x00677053 File Offset: 0x00675253
		public IPlayFlowT CutFlow { get; set; }

		// Token: 0x1700CA0C RID: 51724
		// (get) Token: 0x0602F619 RID: 194073 RVA: 0x0067705C File Offset: 0x0067525C
		// (set) Token: 0x0602F61A RID: 194074 RVA: 0x00677064 File Offset: 0x00675264
		public ICutCameraTimeParamsT CutTimeParams { get; set; }

		// Token: 0x0602F61B RID: 194075 RVA: 0x0067706D File Offset: 0x0067526D
		public ICutCameraConfigT()
		{
			this.CameraParams = null;
			this.CutFlow = null;
			this.CutTimeParams = null;
		}
	}
}
