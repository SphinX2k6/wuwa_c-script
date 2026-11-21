using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CAE RID: 31918
	public class IUniformMotionT
	{
		// Token: 0x1700EEFA RID: 61178
		// (get) Token: 0x0603994B RID: 235851 RVA: 0x007C53DC File Offset: 0x007C35DC
		// (set) Token: 0x0603994C RID: 235852 RVA: 0x007C53E4 File Offset: 0x007C35E4
		public EMoveMotion Type { get; set; }

		// Token: 0x1700EEFB RID: 61179
		// (get) Token: 0x0603994D RID: 235853 RVA: 0x007C53ED File Offset: 0x007C35ED
		// (set) Token: 0x0603994E RID: 235854 RVA: 0x007C53F5 File Offset: 0x007C35F5
		public float Time { get; set; }

		// Token: 0x0603994F RID: 235855 RVA: 0x007C53FE File Offset: 0x007C35FE
		public IUniformMotionT()
		{
			this.Type = EMoveMotion.UniformMotion;
			this.Time = 0f;
		}
	}
}
