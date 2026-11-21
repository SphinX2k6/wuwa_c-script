using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE8 RID: 31720
	public class IToggleDragActorPlayEnableT
	{
		// Token: 0x1700EDA0 RID: 60832
		// (get) Token: 0x060392DC RID: 234204 RVA: 0x007B9D5D File Offset: 0x007B7F5D
		// (set) Token: 0x060392DD RID: 234205 RVA: 0x007B9D65 File Offset: 0x007B7F65
		public EToggleDragActorPlayType Type { get; set; }

		// Token: 0x1700EDA1 RID: 60833
		// (get) Token: 0x060392DE RID: 234206 RVA: 0x007B9D6E File Offset: 0x007B7F6E
		// (set) Token: 0x060392DF RID: 234207 RVA: 0x007B9D76 File Offset: 0x007B7F76
		public IFixedCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700EDA2 RID: 60834
		// (get) Token: 0x060392E0 RID: 234208 RVA: 0x007B9D7F File Offset: 0x007B7F7F
		// (set) Token: 0x060392E1 RID: 234209 RVA: 0x007B9D87 File Offset: 0x007B7F87
		public string TidMainText { get; set; }

		// Token: 0x1700EDA3 RID: 60835
		// (get) Token: 0x060392E2 RID: 234210 RVA: 0x007B9D90 File Offset: 0x007B7F90
		// (set) Token: 0x060392E3 RID: 234211 RVA: 0x007B9D98 File Offset: 0x007B7F98
		public string TidSubText { get; set; }

		// Token: 0x1700EDA4 RID: 60836
		// (get) Token: 0x060392E4 RID: 234212 RVA: 0x007B9DA1 File Offset: 0x007B7FA1
		// (set) Token: 0x060392E5 RID: 234213 RVA: 0x007B9DA9 File Offset: 0x007B7FA9
		public string TidHintText { get; set; }

		// Token: 0x1700EDA5 RID: 60837
		// (get) Token: 0x060392E6 RID: 234214 RVA: 0x007B9DB2 File Offset: 0x007B7FB2
		// (set) Token: 0x060392E7 RID: 234215 RVA: 0x007B9DBA File Offset: 0x007B7FBA
		public bool KeepDialog { get; set; }

		// Token: 0x1700EDA6 RID: 60838
		// (get) Token: 0x060392E8 RID: 234216 RVA: 0x007B9DC3 File Offset: 0x007B7FC3
		// (set) Token: 0x060392E9 RID: 234217 RVA: 0x007B9DCB File Offset: 0x007B7FCB
		public bool DisableExit { get; set; }

		// Token: 0x1700EDA7 RID: 60839
		// (get) Token: 0x060392EA RID: 234218 RVA: 0x007B9DD4 File Offset: 0x007B7FD4
		// (set) Token: 0x060392EB RID: 234219 RVA: 0x007B9DDC File Offset: 0x007B7FDC
		public byte NullMask { get; set; }

		// Token: 0x060392EC RID: 234220 RVA: 0x007B9DE5 File Offset: 0x007B7FE5
		public IToggleDragActorPlayEnableT()
		{
			this.Type = EToggleDragActorPlayType.Enable;
			this.CameraConfig = null;
			this.TidMainText = null;
			this.TidSubText = null;
			this.TidHintText = null;
			this.KeepDialog = false;
			this.DisableExit = false;
			this.NullMask = 0;
		}
	}
}
