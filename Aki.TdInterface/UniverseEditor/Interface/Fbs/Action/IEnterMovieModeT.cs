using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B5 RID: 26293
	public class IEnterMovieModeT
	{
		// Token: 0x1700C35C RID: 50012
		// (get) Token: 0x0602DB4A RID: 187210 RVA: 0x00640F24 File Offset: 0x0063F124
		// (set) Token: 0x0602DB4B RID: 187211 RVA: 0x00640F2C File Offset: 0x0063F12C
		public IMovieCameraConfigT MovieCameraConfig { get; set; }

		// Token: 0x1700C35D RID: 50013
		// (get) Token: 0x0602DB4C RID: 187212 RVA: 0x00640F35 File Offset: 0x0063F135
		// (set) Token: 0x0602DB4D RID: 187213 RVA: 0x00640F3D File Offset: 0x0063F13D
		public IEnableFuncConfigT EnableFuncConfig { get; set; }

		// Token: 0x1700C35E RID: 50014
		// (get) Token: 0x0602DB4E RID: 187214 RVA: 0x00640F46 File Offset: 0x0063F146
		// (set) Token: 0x0602DB4F RID: 187215 RVA: 0x00640F4E File Offset: 0x0063F14E
		public float BorderAnimDuration { get; set; }

		// Token: 0x1700C35F RID: 50015
		// (get) Token: 0x0602DB50 RID: 187216 RVA: 0x00640F57 File Offset: 0x0063F157
		// (set) Token: 0x0602DB51 RID: 187217 RVA: 0x00640F5F File Offset: 0x0063F15F
		public TEnterMovieModeDurationTypeUnion DurationType { get; set; }

		// Token: 0x1700C360 RID: 50016
		// (get) Token: 0x0602DB52 RID: 187218 RVA: 0x00640F68 File Offset: 0x0063F168
		// (set) Token: 0x0602DB53 RID: 187219 RVA: 0x00640F70 File Offset: 0x0063F170
		public bool AutoExitInFlow { get; set; }

		// Token: 0x1700C361 RID: 50017
		// (get) Token: 0x0602DB54 RID: 187220 RVA: 0x00640F79 File Offset: 0x0063F179
		// (set) Token: 0x0602DB55 RID: 187221 RVA: 0x00640F81 File Offset: 0x0063F181
		public byte NullMask { get; set; }

		// Token: 0x0602DB56 RID: 187222 RVA: 0x00640F8A File Offset: 0x0063F18A
		public IEnterMovieModeT()
		{
			this.MovieCameraConfig = null;
			this.EnableFuncConfig = null;
			this.BorderAnimDuration = 0f;
			this.DurationType = null;
			this.AutoExitInFlow = false;
			this.NullMask = 0;
		}
	}
}
