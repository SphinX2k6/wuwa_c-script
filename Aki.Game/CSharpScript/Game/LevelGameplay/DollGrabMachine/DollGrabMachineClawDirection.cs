using System;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC2 RID: 28354
	public class DollGrabMachineClawDirection : IClear
	{
		// Token: 0x17009AAE RID: 39598
		// (get) Token: 0x060450BB RID: 282811 RVA: 0x0110EE4E File Offset: 0x0110D04E
		// (set) Token: 0x060450BC RID: 282812 RVA: 0x0110EE56 File Offset: 0x0110D056
		public float X { get; set; }

		// Token: 0x17009AAF RID: 39599
		// (get) Token: 0x060450BD RID: 282813 RVA: 0x0110EE5F File Offset: 0x0110D05F
		// (set) Token: 0x060450BE RID: 282814 RVA: 0x0110EE67 File Offset: 0x0110D067
		public float Y { get; set; }

		// Token: 0x060450BF RID: 282815 RVA: 0x0110EE70 File Offset: 0x0110D070
		public DollGrabMachineClawDirection(float x = 0f, float y = 0f)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x060450C0 RID: 282816 RVA: 0x0110EE86 File Offset: 0x0110D086
		public bool ClearObject()
		{
			return true;
		}
	}
}
