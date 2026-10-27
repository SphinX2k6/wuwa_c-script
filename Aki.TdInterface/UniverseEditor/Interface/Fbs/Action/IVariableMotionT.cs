using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074F7 RID: 29943
	public class IVariableMotionT
	{
		// Token: 0x1700E333 RID: 58163
		// (get) Token: 0x0603672F RID: 223023 RVA: 0x00765AEE File Offset: 0x00763CEE
		// (set) Token: 0x06036730 RID: 223024 RVA: 0x00765AF6 File Offset: 0x00763CF6
		public EMoveMotion Type { get; set; }

		// Token: 0x1700E334 RID: 58164
		// (get) Token: 0x06036731 RID: 223025 RVA: 0x00765AFF File Offset: 0x00763CFF
		// (set) Token: 0x06036732 RID: 223026 RVA: 0x00765B07 File Offset: 0x00763D07
		public float Acceleration { get; set; }

		// Token: 0x1700E335 RID: 58165
		// (get) Token: 0x06036733 RID: 223027 RVA: 0x00765B10 File Offset: 0x00763D10
		// (set) Token: 0x06036734 RID: 223028 RVA: 0x00765B18 File Offset: 0x00763D18
		public float MaxSpeed { get; set; }

		// Token: 0x06036735 RID: 223029 RVA: 0x00765B21 File Offset: 0x00763D21
		public IVariableMotionT()
		{
			this.Type = EMoveMotion.UniformMotion;
			this.Acceleration = 0f;
			this.MaxSpeed = 0f;
		}
	}
}
