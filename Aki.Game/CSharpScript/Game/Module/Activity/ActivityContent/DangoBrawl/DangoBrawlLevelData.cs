using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200571F RID: 22303
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelData
	{
		// Token: 0x06036E2D RID: 224813 RVA: 0x00F4DB30 File Offset: 0x00F4BD30
		public DangoBrawlLevelData(int configId)
		{
			this.ConfigId = configId;
		}

		// Token: 0x06036E2E RID: 224814 RVA: 0x00F4DB3F File Offset: 0x00F4BD3F
		private DangoBrawlChallenge? GetConfig()
		{
			return DangoBrawlConfig.Instance.GetChallengeConfigById(this.ConfigId);
		}

		// Token: 0x06036E2F RID: 224815 RVA: 0x00F4DB54 File Offset: 0x00F4BD54
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

		// Token: 0x17006A0C RID: 27148
		// (get) Token: 0x06036E30 RID: 224816 RVA: 0x00F4DB9D File Offset: 0x00F4BD9D
		public bool IsPassed
		{
			get
			{
				return this.StateInternal == EDangoBrawlLevelState.Passed;
			}
		}

		// Token: 0x17006A0D RID: 27149
		// (get) Token: 0x06036E31 RID: 224817 RVA: 0x00F4DBA8 File Offset: 0x00F4BDA8
		public bool IsLocked
		{
			get
			{
				return this.StateInternal == EDangoBrawlLevelState.Locked;
			}
		}

		// Token: 0x17006A0E RID: 27150
		// (get) Token: 0x06036E32 RID: 224818 RVA: 0x00F4DBB3 File Offset: 0x00F4BDB3
		public int RetryCount
		{
			get
			{
				return this.RetryCountInternal;
			}
		}

		// Token: 0x17006A0F RID: 27151
		// (get) Token: 0x06036E33 RID: 224819 RVA: 0x00F4DBBB File Offset: 0x00F4BDBB
		// (set) Token: 0x06036E34 RID: 224820 RVA: 0x00F4DBC3 File Offset: 0x00F4BDC3
		public bool IsNew { get; set; }

		// Token: 0x17006A10 RID: 27152
		// (get) Token: 0x06036E35 RID: 224821 RVA: 0x00F4DBCC File Offset: 0x00F4BDCC
		// (set) Token: 0x06036E36 RID: 224822 RVA: 0x00F4DBD4 File Offset: 0x00F4BDD4
		public bool IsLast { get; set; }

		// Token: 0x17006A11 RID: 27153
		// (get) Token: 0x06036E37 RID: 224823 RVA: 0x00F4DBDD File Offset: 0x00F4BDDD
		public int Id
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x17006A12 RID: 27154
		// (get) Token: 0x06036E38 RID: 224824 RVA: 0x00F4DBE5 File Offset: 0x00F4BDE5
		public bool IsNormalMode
		{
			get
			{
				return this.Mode == EDangoBrawlLevelMode.Normal;
			}
		}

		// Token: 0x17006A13 RID: 27155
		// (get) Token: 0x06036E39 RID: 224825 RVA: 0x00F4DBF0 File Offset: 0x00F4BDF0
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

		// Token: 0x17006A14 RID: 27156
		// (get) Token: 0x06036E3A RID: 224826 RVA: 0x00F4DC20 File Offset: 0x00F4BE20
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

		// Token: 0x17006A15 RID: 27157
		// (get) Token: 0x06036E3B RID: 224827 RVA: 0x00F4DC50 File Offset: 0x00F4BE50
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

		// Token: 0x17006A16 RID: 27158
		// (get) Token: 0x06036E3C RID: 224828 RVA: 0x00F4DC80 File Offset: 0x00F4BE80
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

		// Token: 0x17006A17 RID: 27159
		// (get) Token: 0x06036E3D RID: 224829 RVA: 0x00F4DCB0 File Offset: 0x00F4BEB0
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

		// Token: 0x17006A18 RID: 27160
		// (get) Token: 0x06036E3E RID: 224830 RVA: 0x00F4DCE0 File Offset: 0x00F4BEE0
		public string SimpleName
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SimpleName : null) ?? "";
			}
		}

		// Token: 0x17006A19 RID: 27161
		// (get) Token: 0x06036E3F RID: 224831 RVA: 0x00F4DD18 File Offset: 0x00F4BF18
		public string Name
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Name : null) ?? "";
			}
		}

		// Token: 0x17006A1A RID: 27162
		// (get) Token: 0x06036E40 RID: 224832 RVA: 0x00F4DD50 File Offset: 0x00F4BF50
		public string Icon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Icon : null) ?? "";
			}
		}

		// Token: 0x17006A1B RID: 27163
		// (get) Token: 0x06036E41 RID: 224833 RVA: 0x00F4DD88 File Offset: 0x00F4BF88
		public string SelIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SelIcon : null) ?? "";
			}
		}

		// Token: 0x17006A1C RID: 27164
		// (get) Token: 0x06036E42 RID: 224834 RVA: 0x00F4DDC0 File Offset: 0x00F4BFC0
		public string Desc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().Desc : null) ?? "";
			}
		}

		// Token: 0x17006A1D RID: 27165
		// (get) Token: 0x06036E43 RID: 224835 RVA: 0x00F4DDF8 File Offset: 0x00F4BFF8
		public string BgNumIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().BgNumIcon : null) ?? "";
			}
		}

		// Token: 0x17006A1E RID: 27166
		// (get) Token: 0x06036E44 RID: 224836 RVA: 0x00F4DE30 File Offset: 0x00F4C030
		public string EnvironmentDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().EnvirDesc : null) ?? "";
			}
		}

		// Token: 0x17006A1F RID: 27167
		// (get) Token: 0x06036E45 RID: 224837 RVA: 0x00F4DE68 File Offset: 0x00F4C068
		public string PassConditionDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().PassCondDesc : null) ?? "";
			}
		}

		// Token: 0x17006A20 RID: 27168
		// (get) Token: 0x06036E46 RID: 224838 RVA: 0x00F4DEA0 File Offset: 0x00F4C0A0
		public string UnlockConditionDesc
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().UnlockCondDesc : null) ?? "";
			}
		}

		// Token: 0x17006A21 RID: 27169
		// (get) Token: 0x06036E47 RID: 224839 RVA: 0x00F4DED8 File Offset: 0x00F4C0D8
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

		// Token: 0x17006A22 RID: 27170
		// (get) Token: 0x06036E48 RID: 224840 RVA: 0x00F4DF08 File Offset: 0x00F4C108
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

		// Token: 0x17006A23 RID: 27171
		// (get) Token: 0x06036E49 RID: 224841 RVA: 0x00F4DF38 File Offset: 0x00F4C138
		public int[] UnlockRoleIdList
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().GetUnlockRoleIdArray() : null) ?? Array.Empty<int>();
			}
		}

		// Token: 0x17006A24 RID: 27172
		// (get) Token: 0x06036E4A RID: 224842 RVA: 0x00F4DF70 File Offset: 0x00F4C170
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

		// Token: 0x17006A25 RID: 27173
		// (get) Token: 0x06036E4B RID: 224843 RVA: 0x00F4DFA0 File Offset: 0x00F4C1A0
		public string AdventureLeftIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().AdventureRoleIcon1 : null) ?? "";
			}
		}

		// Token: 0x17006A26 RID: 27174
		// (get) Token: 0x06036E4C RID: 224844 RVA: 0x00F4DFD8 File Offset: 0x00F4C1D8
		public string AdventureRightIcon
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().AdventureRoleIcon2 : null) ?? "";
			}
		}

		// Token: 0x17006A27 RID: 27175
		// (get) Token: 0x06036E4D RID: 224845 RVA: 0x00F4E010 File Offset: 0x00F4C210
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

		// Token: 0x17006A28 RID: 27176
		// (get) Token: 0x06036E4E RID: 224846 RVA: 0x00F4E060 File Offset: 0x00F4C260
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

		// Token: 0x17006A29 RID: 27177
		// (get) Token: 0x06036E4F RID: 224847 RVA: 0x00F4E0B0 File Offset: 0x00F4C2B0
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

		// Token: 0x17006A2A RID: 27178
		// (get) Token: 0x06036E50 RID: 224848 RVA: 0x00F4E100 File Offset: 0x00F4C300
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

		// Token: 0x17006A2B RID: 27179
		// (get) Token: 0x06036E51 RID: 224849 RVA: 0x00F4E150 File Offset: 0x00F4C350
		public string FirstSpineAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineNormalAnims(0) : null) ?? "";
			}
		}

		// Token: 0x17006A2C RID: 27180
		// (get) Token: 0x06036E52 RID: 224850 RVA: 0x00F4E18C File Offset: 0x00F4C38C
		public string FirstSpineLoopAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineLoopAnims(0) : null) ?? "";
			}
		}

		// Token: 0x17006A2D RID: 27181
		// (get) Token: 0x06036E53 RID: 224851 RVA: 0x00F4E1C8 File Offset: 0x00F4C3C8
		public string SecondSpineAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineNormalAnims(1) : null) ?? "";
			}
		}

		// Token: 0x17006A2E RID: 27182
		// (get) Token: 0x06036E54 RID: 224852 RVA: 0x00F4E204 File Offset: 0x00F4C404
		public string SecondSpineLoopAnim
		{
			get
			{
				DangoBrawlChallenge? dangoBrawlChallenge;
				return ((this.GetConfig() != null) ? dangoBrawlChallenge.GetValueOrDefault().SpineLoopAnims(1) : null) ?? "";
			}
		}

		// Token: 0x0401D126 RID: 119078
		private readonly int ConfigId;

		// Token: 0x0401D127 RID: 119079
		private EDangoBrawlLevelState StateInternal;

		// Token: 0x0401D128 RID: 119080
		private int RetryCountInternal;
	}
}
