using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A83 RID: 27267
	public class IMechEscortPointT
	{
		// Token: 0x1700CA6E RID: 51822
		// (get) Token: 0x0602FC84 RID: 195716 RVA: 0x00680935 File Offset: 0x0067EB35
		// (set) Token: 0x0602FC85 RID: 195717 RVA: 0x0068093D File Offset: 0x0067EB3D
		public int SplinePointIndex { get; set; }

		// Token: 0x1700CA6F RID: 51823
		// (get) Token: 0x0602FC86 RID: 195718 RVA: 0x00680946 File Offset: 0x0067EB46
		// (set) Token: 0x0602FC87 RID: 195719 RVA: 0x0068094E File Offset: 0x0067EB4E
		public float ForwardOffset { get; set; }

		// Token: 0x1700CA70 RID: 51824
		// (get) Token: 0x0602FC88 RID: 195720 RVA: 0x00680957 File Offset: 0x0067EB57
		// (set) Token: 0x0602FC89 RID: 195721 RVA: 0x0068095F File Offset: 0x0067EB5F
		public float Radius { get; set; }

		// Token: 0x1700CA71 RID: 51825
		// (get) Token: 0x0602FC8A RID: 195722 RVA: 0x00680968 File Offset: 0x0067EB68
		// (set) Token: 0x0602FC8B RID: 195723 RVA: 0x00680970 File Offset: 0x0067EB70
		public float Angle { get; set; }

		// Token: 0x1700CA72 RID: 51826
		// (get) Token: 0x0602FC8C RID: 195724 RVA: 0x00680979 File Offset: 0x0067EB79
		// (set) Token: 0x0602FC8D RID: 195725 RVA: 0x00680981 File Offset: 0x0067EB81
		public TEnterMovieCameraTypeUnion MovieCamera { get; set; }

		// Token: 0x0602FC8E RID: 195726 RVA: 0x0068098A File Offset: 0x0067EB8A
		public IMechEscortPointT()
		{
			this.SplinePointIndex = 0;
			this.ForwardOffset = 0f;
			this.Radius = 0f;
			this.Angle = 0f;
			this.MovieCamera = null;
		}
	}
}
