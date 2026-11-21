using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006042 RID: 24642
	public class DollGrabMachineClawDirection : IClear
	{
		// Token: 0x17006FE5 RID: 28645
		// (get) Token: 0x0603B25C RID: 242268 RVA: 0x010B8F2A File Offset: 0x010B712A
		// (set) Token: 0x0603B25D RID: 242269 RVA: 0x010B8F32 File Offset: 0x010B7132
		public float X { get; set; }

		// Token: 0x17006FE6 RID: 28646
		// (get) Token: 0x0603B25E RID: 242270 RVA: 0x010B8F3B File Offset: 0x010B713B
		// (set) Token: 0x0603B25F RID: 242271 RVA: 0x010B8F43 File Offset: 0x010B7143
		public float Y { get; set; }

		// Token: 0x0603B260 RID: 242272 RVA: 0x010B8F4C File Offset: 0x010B714C
		public DollGrabMachineClawDirection(float x = 0f, float y = 0f)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x0603B261 RID: 242273 RVA: 0x010B8F62 File Offset: 0x010B7162
		public bool ClearObject()
		{
			return true;
		}
	}
}
