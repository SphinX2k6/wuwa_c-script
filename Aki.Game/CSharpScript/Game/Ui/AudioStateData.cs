using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004627 RID: 17959
	public class AudioStateData
	{
		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x0602E431 RID: 189489 RVA: 0x00AB2112 File Offset: 0x00AB0312
		// (set) Token: 0x0602E432 RID: 189490 RVA: 0x00AB212E File Offset: 0x00AB032E
		public float Alpha
		{
			get
			{
				return MathUtils.Instance.Clamp(this.AlphaInternal, 0f, 1f);
			}
			set
			{
				this.AlphaInternal = value;
			}
		}

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x0602E433 RID: 189491 RVA: 0x00AB2137 File Offset: 0x00AB0337
		// (set) Token: 0x0602E434 RID: 189492 RVA: 0x00AB2153 File Offset: 0x00AB0353
		public float Level
		{
			get
			{
				return MathUtils.Instance.Clamp(this.LevelInternal, 0f, 1f);
			}
			set
			{
				this.LevelInternal = value;
			}
		}

		// Token: 0x04018D50 RID: 101712
		private float AlphaInternal;

		// Token: 0x04018D51 RID: 101713
		private float LevelInternal;
	}
}
