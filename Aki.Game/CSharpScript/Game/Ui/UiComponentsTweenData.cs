using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004630 RID: 17968
	internal class UiComponentsTweenData
	{
		// Token: 0x0602E481 RID: 189569 RVA: 0x00AB3010 File Offset: 0x00AB1210
		public UiComponentsTweenData(float alpha, float size, float time)
		{
			this.TargetAlpha = alpha;
			this.TargetSize = size;
			this.Time = time;
		}

		// Token: 0x04018D6B RID: 101739
		public float TargetAlpha;

		// Token: 0x04018D6C RID: 101740
		public float TargetSize;

		// Token: 0x04018D6D RID: 101741
		public float Time;
	}
}
