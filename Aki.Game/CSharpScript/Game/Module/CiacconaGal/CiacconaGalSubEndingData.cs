using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB3 RID: 19379
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalSubEndingData
	{
		// Token: 0x06030624 RID: 198180 RVA: 0x00D7BF73 File Offset: 0x00D7A173
		public CiacconaGalSubEndingData(CiacconaGalSubEnding config)
		{
			this.Config = config;
		}

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x06030625 RID: 198181 RVA: 0x00D7BF84 File Offset: 0x00D7A184
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x06030626 RID: 198182 RVA: 0x00D7BFA0 File Offset: 0x00D7A1A0
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x06030627 RID: 198183 RVA: 0x00D7BFBC File Offset: 0x00D7A1BC
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x06030628 RID: 198184 RVA: 0x00D7BFD8 File Offset: 0x00D7A1D8
		public string ImagePath
		{
			get
			{
				return this.Config.BackgroundImage;
			}
		}

		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x06030629 RID: 198185 RVA: 0x00D7BFF4 File Offset: 0x00D7A1F4
		public ECiacconaGalSubEndingType Type
		{
			get
			{
				return (ECiacconaGalSubEndingType)this.Config.Type;
			}
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x0603062A RID: 198186 RVA: 0x00D7C010 File Offset: 0x00D7A210
		public int RewardId
		{
			get
			{
				return this.Config.Reward;
			}
		}

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x0603062B RID: 198187 RVA: 0x00D7C02B File Offset: 0x00D7A22B
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x0603062C RID: 198188 RVA: 0x00D7C033 File Offset: 0x00D7A233
		public bool IsRewarded
		{
			get
			{
				return this.IsRewardedInternal;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x0603062D RID: 198189 RVA: 0x00D7C03C File Offset: 0x00D7A23C
		public bool ShouldExitOnFirstFinish
		{
			get
			{
				return this.Config.ExitOnFinish;
			}
		}

		// Token: 0x1700612C RID: 24876
		// (get) Token: 0x0603062E RID: 198190 RVA: 0x00D7C057 File Offset: 0x00D7A257
		public bool IsFaked
		{
			get
			{
				return this.IsFakedInternal;
			}
		}

		// Token: 0x0603062F RID: 198191 RVA: 0x00D7C05F File Offset: 0x00D7A25F
		public void UpdateByServerData(CiacconaChapterResultPbData data)
		{
			this.IsFinishedInternal = data.Finish;
			this.IsRewardedInternal = data.TakeReward;
			this.IsFakedInternal = false;
		}

		// Token: 0x06030630 RID: 198192 RVA: 0x00D7C080 File Offset: 0x00D7A280
		public void ClientSetFinished(bool isFinished)
		{
			if (this.IsFinishedInternal == isFinished)
			{
				return;
			}
			this.IsFinishedInternal = isFinished;
			this.IsFakedInternal = true;
		}

		// Token: 0x04019A2A RID: 105002
		private bool IsFinishedInternal;

		// Token: 0x04019A2B RID: 105003
		private bool IsRewardedInternal;

		// Token: 0x04019A2C RID: 105004
		private bool IsFakedInternal;

		// Token: 0x04019A2D RID: 105005
		private readonly CiacconaGalSubEnding Config;
	}
}
