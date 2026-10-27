using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067CF RID: 26575
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelData
	{
		// Token: 0x060422D7 RID: 271063 RVA: 0x0100C764 File Offset: 0x0100A964
		public DangoBrawlLevelData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x060422D8 RID: 271064 RVA: 0x0100C773 File Offset: 0x0100A973
		private DangoBrawlChallenge? GetConfig()
		{
			return DangoBrawlConfig.Instance.GetChallengeConfigById(this.ConfigId);
		}

		// Token: 0x060422D9 RID: 271065 RVA: 0x0100C788 File Offset: 0x0100A988
		public void UpdateData(DangoBrawlChallengeInfo data)
		{
			EDangoBrawlLevelState stateInternal;
			switch (data.State)
			{
			case DangoBrawlChallengeState.Locked:
				stateInternal = EDangoBrawlLevelState.Locked;
				break;
			case DangoBrawlChallengeState.Unlocked:
				stateInternal = EDangoBrawlLevelState.Unlocked;
				break;
			case DangoBrawlChallengeState.Passed:
				stateInternal = EDangoBrawlLevelState.Passed;
				break;
			default:
				stateInternal = EDangoBrawlLevelState.Locked;
				break;
			}
			this.StateInternal = stateInternal;
			this.RetryCountInternal = data.RetryCount;
		}

		// Token: 0x170096CB RID: 38603
		// (get) Token: 0x060422DA RID: 271066 RVA: 0x0100C7D1 File Offset: 0x0100A9D1
		public bool IsPassed
		{
			get
			{
				return this.StateInternal == EDangoBrawlLevelState.Passed;
			}
		}

		// Token: 0x170096CC RID: 38604
		// (get) Token: 0x060422DB RID: 271067 RVA: 0x0100C7DC File Offset: 0x0100A9DC
		public bool IsLocked
		{
			get
			{
				return this.StateInternal == EDangoBrawlLevelState.Locked;
			}
		}

		// Token: 0x170096CD RID: 38605
		// (get) Token: 0x060422DC RID: 271068 RVA: 0x0100C7E7 File Offset: 0x0100A9E7
		public int RetryCount
		{
			get
			{
				return this.RetryCountInternal;
			}
		}

		// Token: 0x170096CE RID: 38606
		// (get) Token: 0x060422DD RID: 271069 RVA: 0x0100C7EF File Offset: 0x0100A9EF
		// (set) Token: 0x060422DE RID: 271070 RVA: 0x0100C7F7 File Offset: 0x0100A9F7
		public bool IsNew { get; set; }

		// Token: 0x170096CF RID: 38607
		// (get) Token: 0x060422DF RID: 271071 RVA: 0x0100C800 File Offset: 0x0100AA00
		// (set) Token: 0x060422E0 RID: 271072 RVA: 0x0100C808 File Offset: 0x0100AA08
		public bool IsLast { get; set; }

		// Token: 0x170096D0 RID: 38608
		// (get) Token: 0x060422E1 RID: 271073 RVA: 0x0100C811 File Offset: 0x0100AA11
		public int Id
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x170096D1 RID: 38609
		// (get) Token: 0x060422E2 RID: 271074 RVA: 0x0100C819 File Offset: 0x0100AA19
		public bool IsNormalMode
		{
			get
			{
				return this.Mode == EDangoBrawlLevelMode.Normal;
			}
		}

		// Token: 0x170096D2 RID: 38610
		// (get) Token: 0x060422E3 RID: 271075 RVA: 0x0100C824 File Offset: 0x0100AA24
		public EDangoBrawlLevelMode Mode
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return (EDangoBrawlLevelMode)0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return (EDangoBrawlLevelMode)dangoBrawlChallenge.GetValueOrDefault().Mode;
			}
		}

		// Token: 0x170096D3 RID: 38611
		// (get) Token: 0x060422E4 RID: 271076 RVA: 0x0100C854 File Offset: 0x0100AA54
		public EDangoBrawlLevelBgStyle BgStyle
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return (EDangoBrawlLevelBgStyle)0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return (EDangoBrawlLevelBgStyle)dangoBrawlChallenge.GetValueOrDefault().BgStyle;
			}
		}

		// Token: 0x170096D4 RID: 38612
		// (get) Token: 0x060422E5 RID: 271077 RVA: 0x0100C884 File Offset: 0x0100AA84
		public int MaxRetryCount
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().HpCount;
			}
		}

		// Token: 0x170096D5 RID: 38613
		// (get) Token: 0x060422E6 RID: 271078 RVA: 0x0100C8B4 File Offset: 0x0100AAB4
		public int WinCount
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().WinCount;
			}
		}

		// Token: 0x170096D6 RID: 38614
		// (get) Token: 0x060422E7 RID: 271079 RVA: 0x0100C8E4 File Offset: 0x0100AAE4
		public int AdditionRound
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().AdditionRound;
			}
		}

		// Token: 0x170096D7 RID: 38615
		// (get) Token: 0x060422E8 RID: 271080 RVA: 0x0100C914 File Offset: 0x0100AB14
		public string SimpleName
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SimpleName : null) ?? "";
			}
		}

		// Token: 0x170096D8 RID: 38616
		// (get) Token: 0x060422E9 RID: 271081 RVA: 0x0100C94C File Offset: 0x0100AB4C
		public string Name
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Name : null) ?? "";
			}
		}

		// Token: 0x170096D9 RID: 38617
		// (get) Token: 0x060422EA RID: 271082 RVA: 0x0100C984 File Offset: 0x0100AB84
		public string Icon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Icon : null) ?? "";
			}
		}

		// Token: 0x170096DA RID: 38618
		// (get) Token: 0x060422EB RID: 271083 RVA: 0x0100C9BC File Offset: 0x0100ABBC
		public string SelIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SelIcon : null) ?? "";
			}
		}

		// Token: 0x170096DB RID: 38619
		// (get) Token: 0x060422EC RID: 271084 RVA: 0x0100C9F4 File Offset: 0x0100ABF4
		public string Desc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Desc : null) ?? "";
			}
		}

		// Token: 0x170096DC RID: 38620
		// (get) Token: 0x060422ED RID: 271085 RVA: 0x0100CA2C File Offset: 0x0100AC2C
		public string BgNumIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().BgNumIcon : null) ?? "";
			}
		}

		// Token: 0x170096DD RID: 38621
		// (get) Token: 0x060422EE RID: 271086 RVA: 0x0100CA64 File Offset: 0x0100AC64
		public string EnvironmentDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().EnvirDesc : null) ?? "";
			}
		}

		// Token: 0x170096DE RID: 38622
		// (get) Token: 0x060422EF RID: 271087 RVA: 0x0100CA9C File Offset: 0x0100AC9C
		public string PassConditionDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().PassCondDesc : null) ?? "";
			}
		}

		// Token: 0x170096DF RID: 38623
		// (get) Token: 0x060422F0 RID: 271088 RVA: 0x0100CAD4 File Offset: 0x0100ACD4
		public string UnlockConditionDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().UnlockCondDesc : null) ?? "";
			}
		}

		// Token: 0x170096E0 RID: 38624
		// (get) Token: 0x060422F1 RID: 271089 RVA: 0x0100CB0C File Offset: 0x0100AD0C
		public int FirstClearDropId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().FirstClearDropId;
			}
		}

		// Token: 0x170096E1 RID: 38625
		// (get) Token: 0x060422F2 RID: 271090 RVA: 0x0100CB3C File Offset: 0x0100AD3C
		public int FirstUnlockRoleId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().UnlockRoleId(0);
			}
		}

		// Token: 0x170096E2 RID: 38626
		// (get) Token: 0x060422F3 RID: 271091 RVA: 0x0100CB6C File Offset: 0x0100AD6C
		public int[] UnlockRoleIdList
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().GetUnlockRoleIdArray() : null) ?? Array.Empty<int>();
			}
		}

		// Token: 0x170096E3 RID: 38627
		// (get) Token: 0x060422F4 RID: 271092 RVA: 0x0100CBA4 File Offset: 0x0100ADA4
		public int DefaultRoleId
		{
			get
			{
				if (this.GetConfig() == null)
				{
					return 0;
				}
				DangoBrawlChallenge? dangoBrawlChallenge;
				return dangoBrawlChallenge.GetValueOrDefault().DefaultRoleId;
			}
		}

		// Token: 0x170096E4 RID: 38628
		// (get) Token: 0x060422F5 RID: 271093 RVA: 0x0100CBD4 File Offset: 0x0100ADD4
		public string AdventureLeftIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().AdventureRoleIcon1 : null) ?? "";
			}
		}

		// Token: 0x170096E5 RID: 38629
		// (get) Token: 0x060422F6 RID: 271094 RVA: 0x0100CC0C File Offset: 0x0100AE0C
		public string AdventureRightIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().AdventureRoleIcon2 : null) ?? "";
			}
		}

		// Token: 0x170096E6 RID: 38630
		// (get) Token: 0x060422F7 RID: 271095 RVA: 0x0100CC44 File Offset: 0x0100AE44
		public string FirstSpineAtlasPath
		{
			get
			{
				DangoBrawlChallenge? config = this.GetConfig();
				if (config == null || config.Value.SpineAtlasPathsLength <= 0)
				{
					return "";
				}
				return config.Value.SpineAtlasPaths(0) ?? "";
			}
		}

		// Token: 0x170096E7 RID: 38631
		// (get) Token: 0x060422F8 RID: 271096 RVA: 0x0100CC94 File Offset: 0x0100AE94
		public string FirstSpineSkeletonDataPath
		{
			get
			{
				DangoBrawlChallenge? config = this.GetConfig();
				if (config == null || config.Value.SpineSkeletonDataPathsLength <= 0)
				{
					return "";
				}
				return config.Value.SpineSkeletonDataPaths(0) ?? "";
			}
		}

		// Token: 0x170096E8 RID: 38632
		// (get) Token: 0x060422F9 RID: 271097 RVA: 0x0100CCE4 File Offset: 0x0100AEE4
		public string SecondSpineAtlasPath
		{
			get
			{
				DangoBrawlChallenge? config = this.GetConfig();
				if (config == null || config.Value.SpineAtlasPathsLength <= 1)
				{
					return "";
				}
				return config.Value.SpineAtlasPaths(1) ?? "";
			}
		}

		// Token: 0x170096E9 RID: 38633
		// (get) Token: 0x060422FA RID: 271098 RVA: 0x0100CD34 File Offset: 0x0100AF34
		public string SecondSpineSkeletonDataPath
		{
			get
			{
				DangoBrawlChallenge? config = this.GetConfig();
				if (config == null || config.Value.SpineSkeletonDataPathsLength <= 1)
				{
					return "";
				}
				return config.Value.SpineSkeletonDataPaths(1) ?? "";
			}
		}

		// Token: 0x170096EA RID: 38634
		// (get) Token: 0x060422FB RID: 271099 RVA: 0x0100CD84 File Offset: 0x0100AF84
		public string FirstSpineAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineNormalAnims(0) : null) ?? "";
			}
		}

		// Token: 0x170096EB RID: 38635
		// (get) Token: 0x060422FC RID: 271100 RVA: 0x0100CDC0 File Offset: 0x0100AFC0
		public string FirstSpineLoopAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineLoopAnims(0) : null) ?? "";
			}
		}

		// Token: 0x170096EC RID: 38636
		// (get) Token: 0x060422FD RID: 271101 RVA: 0x0100CDFC File Offset: 0x0100AFFC
		public string SecondSpineAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineNormalAnims(1) : null) ?? "";
			}
		}

		// Token: 0x170096ED RID: 38637
		// (get) Token: 0x060422FE RID: 271102 RVA: 0x0100CE38 File Offset: 0x0100B038
		public string SecondSpineLoopAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineLoopAnims(1) : null) ?? "";
			}
		}

		// Token: 0x040228C9 RID: 141513
		private readonly int ConfigId;

		// Token: 0x040228CA RID: 141514
		private EDangoBrawlLevelState StateInternal;

		// Token: 0x040228CB RID: 141515
		private int RetryCountInternal;
	}
}
