using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BB0 RID: 19376
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalEndingData
	{
		// Token: 0x060305FD RID: 198141 RVA: 0x00D7BAA0 File Offset: 0x00D79CA0
		public CiacconaGalEndingData(CiacconaGalEnding config)
		{
			this.Config = config;
			this.IsFinishedInternal = false;
			this.IsRewardedInternal = false;
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x060305FE RID: 198142 RVA: 0x00D7BAC0 File Offset: 0x00D79CC0
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x060305FF RID: 198143 RVA: 0x00D7BADC File Offset: 0x00D79CDC
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x06030600 RID: 198144 RVA: 0x00D7BAF8 File Offset: 0x00D79CF8
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x06030601 RID: 198145 RVA: 0x00D7BB14 File Offset: 0x00D79D14
		public string ImagePath
		{
			get
			{
				return this.Config.BackgroundImage;
			}
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x06030602 RID: 198146 RVA: 0x00D7BB30 File Offset: 0x00D79D30
		public string DetailImagePath
		{
			get
			{
				return this.Config.DetailBackgroundImage;
			}
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x06030603 RID: 198147 RVA: 0x00D7BB4C File Offset: 0x00D79D4C
		public ECiacconaGalEndingType Type
		{
			get
			{
				return (ECiacconaGalEndingType)this.Config.Type;
			}
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x06030604 RID: 198148 RVA: 0x00D7BB68 File Offset: 0x00D79D68
		public int RewardId
		{
			get
			{
				return this.Config.Reward;
			}
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x06030605 RID: 198149 RVA: 0x00D7BB83 File Offset: 0x00D79D83
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x06030606 RID: 198150 RVA: 0x00D7BB8B File Offset: 0x00D79D8B
		public bool IsRewarded
		{
			get
			{
				return this.IsRewardedInternal;
			}
		}

		// Token: 0x06030607 RID: 198151 RVA: 0x00D7BB93 File Offset: 0x00D79D93
		public void UpdateByServerData(CiacconaActivityResultPbData data)
		{
			this.IsFinishedInternal = true;
			this.IsRewardedInternal = data.TakeReward;
		}

		// Token: 0x04019A22 RID: 104994
		private bool IsFinishedInternal;

		// Token: 0x04019A23 RID: 104995
		private bool IsRewardedInternal;

		// Token: 0x04019A24 RID: 104996
		private readonly CiacconaGalEnding Config;
	}
}
