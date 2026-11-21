using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003550 RID: 13648
	public class UiAudioCoverState
	{
		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06022B26 RID: 142118 RVA: 0x009DE806 File Offset: 0x009DCA06
		// (set) Token: 0x06022B27 RID: 142119 RVA: 0x009DE822 File Offset: 0x009DCA22
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

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06022B28 RID: 142120 RVA: 0x009DE82B File Offset: 0x009DCA2B
		// (set) Token: 0x06022B29 RID: 142121 RVA: 0x009DE847 File Offset: 0x009DCA47
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

		// Token: 0x0401338F RID: 78735
		private float AlphaInternal;

		// Token: 0x04013390 RID: 78736
		private float LevelInternal;
	}
}
