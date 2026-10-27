using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD0 RID: 23504
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalEndingData
	{
		// Token: 0x0603B6B2 RID: 243378 RVA: 0x00E2B798 File Offset: 0x00E29998
		public CiacconaGalEndingData(CiacconaGalEnding config)
		{
			this.Config = config;
			this.IsFinishedInternal = false;
			this.IsRewardedInternal = false;
		}

		// Token: 0x17008D30 RID: 36144
		// (get) Token: 0x0603B6B3 RID: 243379 RVA: 0x00E2B7B8 File Offset: 0x00E299B8
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D31 RID: 36145
		// (get) Token: 0x0603B6B4 RID: 243380 RVA: 0x00E2B7D4 File Offset: 0x00E299D4
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17008D32 RID: 36146
		// (get) Token: 0x0603B6B5 RID: 243381 RVA: 0x00E2B7F0 File Offset: 0x00E299F0
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17008D33 RID: 36147
		// (get) Token: 0x0603B6B6 RID: 243382 RVA: 0x00E2B80C File Offset: 0x00E29A0C
		public string ImagePath
		{
			get
			{
				return this.Config.BackgroundImage;
			}
		}

		// Token: 0x17008D34 RID: 36148
		// (get) Token: 0x0603B6B7 RID: 243383 RVA: 0x00E2B828 File Offset: 0x00E29A28
		public string DetailImagePath
		{
			get
			{
				return this.Config.DetailBackgroundImage;
			}
		}

		// Token: 0x17008D35 RID: 36149
		// (get) Token: 0x0603B6B8 RID: 243384 RVA: 0x00E2B844 File Offset: 0x00E29A44
		public ECiacconaGalEndingType Type
		{
			get
			{
				return (ECiacconaGalEndingType)this.Config.Type;
			}
		}

		// Token: 0x17008D36 RID: 36150
		// (get) Token: 0x0603B6B9 RID: 243385 RVA: 0x00E2B860 File Offset: 0x00E29A60
		public int RewardId
		{
			get
			{
				return this.Config.Reward;
			}
		}

		// Token: 0x17008D37 RID: 36151
		// (get) Token: 0x0603B6BA RID: 243386 RVA: 0x00E2B87B File Offset: 0x00E29A7B
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x17008D38 RID: 36152
		// (get) Token: 0x0603B6BB RID: 243387 RVA: 0x00E2B883 File Offset: 0x00E29A83
		public bool IsRewarded
		{
			get
			{
				return this.IsRewardedInternal;
			}
		}

		// Token: 0x0603B6BC RID: 243388 RVA: 0x00E2B88B File Offset: 0x00E29A8B
		public void UpdateByServerData(CiacconaActivityResultPbData data)
		{
			this.IsFinishedInternal = true;
			this.IsRewardedInternal = data.TakeReward;
		}

		// Token: 0x0401EF71 RID: 126833
		private bool IsFinishedInternal;

		// Token: 0x0401EF72 RID: 126834
		private bool IsRewardedInternal;

		// Token: 0x0401EF73 RID: 126835
		private readonly CiacconaGalEnding Config;
	}
}
