using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200627C RID: 25212
	public class ICameraGazeT
	{
		// Token: 0x1700BBED RID: 48109
		// (get) Token: 0x0602B85F RID: 178271 RVA: 0x005FE17A File Offset: 0x005FC37A
		// (set) Token: 0x0602B860 RID: 178272 RVA: 0x005FE182 File Offset: 0x005FC382
		public float FadeInTime { get; set; }

		// Token: 0x1700BBEE RID: 48110
		// (get) Token: 0x0602B861 RID: 178273 RVA: 0x005FE18B File Offset: 0x005FC38B
		// (set) Token: 0x0602B862 RID: 178274 RVA: 0x005FE193 File Offset: 0x005FC393
		public float StayTime { get; set; }

		// Token: 0x1700BBEF RID: 48111
		// (get) Token: 0x0602B863 RID: 178275 RVA: 0x005FE19C File Offset: 0x005FC39C
		// (set) Token: 0x0602B864 RID: 178276 RVA: 0x005FE1A4 File Offset: 0x005FC3A4
		public float FadeOutTime { get; set; }

		// Token: 0x1700BBF0 RID: 48112
		// (get) Token: 0x0602B865 RID: 178277 RVA: 0x005FE1AD File Offset: 0x005FC3AD
		// (set) Token: 0x0602B866 RID: 178278 RVA: 0x005FE1B5 File Offset: 0x005FC3B5
		public bool LockCamera { get; set; }

		// Token: 0x1700BBF1 RID: 48113
		// (get) Token: 0x0602B867 RID: 178279 RVA: 0x005FE1BE File Offset: 0x005FC3BE
		// (set) Token: 0x0602B868 RID: 178280 RVA: 0x005FE1C6 File Offset: 0x005FC3C6
		public int LockPriority { get; set; }

		// Token: 0x1700BBF2 RID: 48114
		// (get) Token: 0x0602B869 RID: 178281 RVA: 0x005FE1CF File Offset: 0x005FC3CF
		// (set) Token: 0x0602B86A RID: 178282 RVA: 0x005FE1D7 File Offset: 0x005FC3D7
		public bool GazeInHook { get; set; }

		// Token: 0x1700BBF3 RID: 48115
		// (get) Token: 0x0602B86B RID: 178283 RVA: 0x005FE1E0 File Offset: 0x005FC3E0
		// (set) Token: 0x0602B86C RID: 178284 RVA: 0x005FE1E8 File Offset: 0x005FC3E8
		public byte NullMask { get; set; }

		// Token: 0x0602B86D RID: 178285 RVA: 0x005FE1F4 File Offset: 0x005FC3F4
		public ICameraGazeT()
		{
			this.FadeInTime = 0f;
			this.StayTime = 0f;
			this.FadeOutTime = 0f;
			this.LockCamera = false;
			this.LockPriority = 0;
			this.GazeInHook = false;
			this.NullMask = 0;
		}
	}
}
