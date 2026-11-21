using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200355A RID: 13658
	internal class UiComponentsTweenData
	{
		// Token: 0x06022B94 RID: 142228 RVA: 0x009DFDA0 File Offset: 0x009DDFA0
		public UiComponentsTweenData(float alpha, float size, float time)
		{
			this.TargetAlpha = alpha;
			this.TargetSize = size;
			this.Time = time;
		}

		// Token: 0x040133B8 RID: 78776
		public float TargetAlpha;

		// Token: 0x040133B9 RID: 78777
		public float TargetSize;

		// Token: 0x040133BA RID: 78778
		public float Time;
	}
}
