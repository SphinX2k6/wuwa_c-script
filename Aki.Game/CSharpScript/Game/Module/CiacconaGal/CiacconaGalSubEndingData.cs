using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD3 RID: 23507
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalSubEndingData
	{
		// Token: 0x0603B6D9 RID: 243417 RVA: 0x00E2BC6B File Offset: 0x00E29E6B
		public CiacconaGalSubEndingData(CiacconaGalSubEnding config)
		{
			this.Config = config;
		}

		// Token: 0x17008D51 RID: 36177
		// (get) Token: 0x0603B6DA RID: 243418 RVA: 0x00E2BC7C File Offset: 0x00E29E7C
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17008D52 RID: 36178
		// (get) Token: 0x0603B6DB RID: 243419 RVA: 0x00E2BC98 File Offset: 0x00E29E98
		public string Title
		{
			get
			{
				return this.Config.Title;
			}
		}

		// Token: 0x17008D53 RID: 36179
		// (get) Token: 0x0603B6DC RID: 243420 RVA: 0x00E2BCB4 File Offset: 0x00E29EB4
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17008D54 RID: 36180
		// (get) Token: 0x0603B6DD RID: 243421 RVA: 0x00E2BCD0 File Offset: 0x00E29ED0
		public string ImagePath
		{
			get
			{
				return this.Config.BackgroundImage;
			}
		}

		// Token: 0x17008D55 RID: 36181
		// (get) Token: 0x0603B6DE RID: 243422 RVA: 0x00E2BCEC File Offset: 0x00E29EEC
		public ECiacconaGalSubEndingType Type
		{
			get
			{
				return (ECiacconaGalSubEndingType)this.Config.Type;
			}
		}

		// Token: 0x17008D56 RID: 36182
		// (get) Token: 0x0603B6DF RID: 243423 RVA: 0x00E2BD08 File Offset: 0x00E29F08
		public int RewardId
		{
			get
			{
				return this.Config.Reward;
			}
		}

		// Token: 0x17008D57 RID: 36183
		// (get) Token: 0x0603B6E0 RID: 243424 RVA: 0x00E2BD23 File Offset: 0x00E29F23
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
		}

		// Token: 0x17008D58 RID: 36184
		// (get) Token: 0x0603B6E1 RID: 243425 RVA: 0x00E2BD2B File Offset: 0x00E29F2B
		public bool IsRewarded
		{
			get
			{
				return this.IsRewardedInternal;
			}
		}

		// Token: 0x17008D59 RID: 36185
		// (get) Token: 0x0603B6E2 RID: 243426 RVA: 0x00E2BD34 File Offset: 0x00E29F34
		public bool ShouldExitOnFirstFinish
		{
			get
			{
				return this.Config.ExitOnFinish;
			}
		}

		// Token: 0x17008D5A RID: 36186
		// (get) Token: 0x0603B6E3 RID: 243427 RVA: 0x00E2BD4F File Offset: 0x00E29F4F
		public bool IsFaked
		{
			get
			{
				return this.IsFakedInternal;
			}
		}

		// Token: 0x0603B6E4 RID: 243428 RVA: 0x00E2BD57 File Offset: 0x00E29F57
		public void UpdateByServerData(CiacconaChapterResultPbData data)
		{
			this.IsFinishedInternal = data.Finish;
			this.IsRewardedInternal = data.TakeReward;
			this.IsFakedInternal = false;
		}

		// Token: 0x0603B6E5 RID: 243429 RVA: 0x00E2BD78 File Offset: 0x00E29F78
		public void ClientSetFinished(bool isFinished)
		{
			if (this.IsFinishedInternal == isFinished)
			{
				return;
			}
			this.IsFinishedInternal = isFinished;
			this.IsFakedInternal = true;
		}

		// Token: 0x0401EF79 RID: 126841
		private bool IsFinishedInternal;

		// Token: 0x0401EF7A RID: 126842
		private bool IsRewardedInternal;

		// Token: 0x0401EF7B RID: 126843
		private bool IsFakedInternal;

		// Token: 0x0401EF7C RID: 126844
		private readonly CiacconaGalSubEnding Config;
	}
}
