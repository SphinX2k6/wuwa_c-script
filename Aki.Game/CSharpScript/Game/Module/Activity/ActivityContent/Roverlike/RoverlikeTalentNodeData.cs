using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005060 RID: 20576
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentNodeData
	{
		// Token: 0x060337FA RID: 210938 RVA: 0x00E6BED5 File Offset: 0x00E6A0D5
		public RoverlikeTalentNodeData(List<RoverRogueTalentTree> levelConfigs)
		{
			this.LevelConfigsInternal = levelConfigs;
		}

		// Token: 0x17006490 RID: 25744
		// (get) Token: 0x060337FB RID: 210939 RVA: 0x00E6BEF6 File Offset: 0x00E6A0F6
		public IReadOnlyList<RoverRogueTalentTree> LevelConfigs
		{
			get
			{
				return this.LevelConfigsInternal;
			}
		}

		// Token: 0x17006491 RID: 25745
		// (get) Token: 0x060337FC RID: 210940 RVA: 0x00E6BEFE File Offset: 0x00E6A0FE
		public RoverRogueTalentTree HeadConfig
		{
			get
			{
				return this.LevelConfigsInternal[0];
			}
		}

		// Token: 0x17006492 RID: 25746
		// (get) Token: 0x060337FD RID: 210941 RVA: 0x00E6BF0C File Offset: 0x00E6A10C
		public int MaxLevel
		{
			get
			{
				return this.LevelConfigsInternal.Count;
			}
		}

		// Token: 0x17006493 RID: 25747
		// (get) Token: 0x060337FE RID: 210942 RVA: 0x00E6BF19 File Offset: 0x00E6A119
		// (set) Token: 0x060337FF RID: 210943 RVA: 0x00E6BF21 File Offset: 0x00E6A121
		public int CurLevel
		{
			get
			{
				return this.CurLevelInternal;
			}
			set
			{
				if (value < 0)
				{
					this.CurLevelInternal = 0;
					return;
				}
				if (value > this.MaxLevel)
				{
					this.CurLevelInternal = this.MaxLevel;
					return;
				}
				this.CurLevelInternal = value;
			}
		}

		// Token: 0x17006494 RID: 25748
		// (get) Token: 0x06033800 RID: 210944 RVA: 0x00E6BF4C File Offset: 0x00E6A14C
		public bool IsUnLock
		{
			get
			{
				return this.IsServerUnlockedInternal;
			}
		}

		// Token: 0x17006495 RID: 25749
		// (get) Token: 0x06033801 RID: 210945 RVA: 0x00E6BF54 File Offset: 0x00E6A154
		// (set) Token: 0x06033802 RID: 210946 RVA: 0x00E6BF5C File Offset: 0x00E6A15C
		public bool IsServerUnlocked
		{
			get
			{
				return this.IsServerUnlockedInternal;
			}
			set
			{
				this.IsServerUnlockedInternal = value;
			}
		}

		// Token: 0x17006496 RID: 25750
		// (get) Token: 0x06033803 RID: 210947 RVA: 0x00E6BF65 File Offset: 0x00E6A165
		// (set) Token: 0x06033804 RID: 210948 RVA: 0x00E6BF6D File Offset: 0x00E6A16D
		public int ActiveLevel
		{
			get
			{
				return this.ActiveLevelInternal;
			}
			set
			{
				this.ActiveLevelInternal = Math.Max(0, value);
			}
		}

		// Token: 0x17006497 RID: 25751
		// (get) Token: 0x06033805 RID: 210949 RVA: 0x00E6BF7C File Offset: 0x00E6A17C
		public int Row
		{
			get
			{
				return this.HeadConfig.Row;
			}
		}

		// Token: 0x17006498 RID: 25752
		// (get) Token: 0x06033806 RID: 210950 RVA: 0x00E6BF98 File Offset: 0x00E6A198
		public int Index
		{
			get
			{
				return this.HeadConfig.Column - 1;
			}
		}

		// Token: 0x17006499 RID: 25753
		// (get) Token: 0x06033807 RID: 210951 RVA: 0x00E6BFB5 File Offset: 0x00E6A1B5
		public ERoverlikeTalentNodeState State
		{
			get
			{
				if (!this.IsUnLock)
				{
					return ERoverlikeTalentNodeState.Lock;
				}
				if (this.IsMaxLevel)
				{
					return ERoverlikeTalentNodeState.Full;
				}
				return ERoverlikeTalentNodeState.Unlock;
			}
		}

		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x06033808 RID: 210952 RVA: 0x00E6BFCC File Offset: 0x00E6A1CC
		public bool IsMaxLevel
		{
			get
			{
				return this.CurLevelInternal >= this.MaxLevel;
			}
		}

		// Token: 0x1700649B RID: 25755
		// (get) Token: 0x06033809 RID: 210953 RVA: 0x00E6BFDF File Offset: 0x00E6A1DF
		// (set) Token: 0x0603380A RID: 210954 RVA: 0x00E6BFE7 File Offset: 0x00E6A1E7
		public bool IsFinishPreCondition
		{
			get
			{
				return this.IsFinishPreConditionInternal;
			}
			set
			{
				this.IsFinishPreConditionInternal = value;
			}
		}

		// Token: 0x1700649C RID: 25756
		// (get) Token: 0x0603380B RID: 210955 RVA: 0x00E6BFF0 File Offset: 0x00E6A1F0
		public RoverRogueTalentTree? CurrentLevelConfig
		{
			get
			{
				if (!this.IsUnLock)
				{
					return null;
				}
				int num = this.CurLevelInternal - 1;
				if (num < 0 || num >= this.LevelConfigsInternal.Count)
				{
					return null;
				}
				return new RoverRogueTalentTree?(this.LevelConfigsInternal[num]);
			}
		}

		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x0603380C RID: 210956 RVA: 0x00E6C048 File Offset: 0x00E6A248
		public RoverRogueTalentTree? NextLevelConfig
		{
			get
			{
				if (this.IsMaxLevel)
				{
					return null;
				}
				return new RoverRogueTalentTree?(this.LevelConfigsInternal[this.CurLevelInternal]);
			}
		}

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x0603380D RID: 210957 RVA: 0x00E6C080 File Offset: 0x00E6A280
		public int NextLevelCost
		{
			get
			{
				if (this.NextLevelConfig == null)
				{
					return 0;
				}
				RoverRogueTalentTree? roverRogueTalentTree;
				return roverRogueTalentTree.GetValueOrDefault().Consule;
			}
		}

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x0603380E RID: 210958 RVA: 0x00E6C0B0 File Offset: 0x00E6A2B0
		public int NextLevelId
		{
			get
			{
				if (this.NextLevelConfig == null)
				{
					return 0;
				}
				RoverRogueTalentTree? roverRogueTalentTree;
				return roverRogueTalentTree.GetValueOrDefault().Id;
			}
		}

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x0603380F RID: 210959 RVA: 0x00E6C0E0 File Offset: 0x00E6A2E0
		public string CurrentDescTextId
		{
			get
			{
				return (this.CurrentLevelConfig ?? this.HeadConfig).Desc;
			}
		}

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x06033810 RID: 210960 RVA: 0x00E6C114 File Offset: 0x00E6A314
		public List<string> CurrentDescParams
		{
			get
			{
				return RoverlikeTalentNodeData.GetConfigParams(this.CurrentLevelConfig ?? this.HeadConfig);
			}
		}

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x06033811 RID: 210961 RVA: 0x00E6C148 File Offset: 0x00E6A348
		public string NextLevelDescTextId
		{
			get
			{
				RoverRogueTalentTree? roverRogueTalentTree;
				return ((this.NextLevelConfig != null) ? roverRogueTalentTree.GetValueOrDefault().Desc : null) ?? "";
			}
		}

		// Token: 0x170064A3 RID: 25763
		// (get) Token: 0x06033812 RID: 210962 RVA: 0x00E6C180 File Offset: 0x00E6A380
		public List<string> NextLevelDescParams
		{
			get
			{
				RoverRogueTalentTree? nextLevelConfig = this.NextLevelConfig;
				if (nextLevelConfig == null)
				{
					return new List<string>();
				}
				return RoverlikeTalentNodeData.GetConfigParams(nextLevelConfig.Value);
			}
		}

		// Token: 0x06033813 RID: 210963 RVA: 0x00E6C1B0 File Offset: 0x00E6A3B0
		private static List<string> GetConfigParams(RoverRogueTalentTree config)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < config.ParamsLength; i++)
			{
				list.Add(config.Params(i));
			}
			return list;
		}

		// Token: 0x0401B5A0 RID: 112032
		private readonly List<RoverRogueTalentTree> LevelConfigsInternal = new List<RoverRogueTalentTree>();

		// Token: 0x0401B5A1 RID: 112033
		private bool IsFinishPreConditionInternal = true;

		// Token: 0x0401B5A2 RID: 112034
		private int CurLevelInternal;

		// Token: 0x0401B5A3 RID: 112035
		private bool IsServerUnlockedInternal;

		// Token: 0x0401B5A4 RID: 112036
		private int ActiveLevelInternal;

		// Token: 0x0401B5A5 RID: 112037
		[Nullable(2)]
		public Action<bool, bool> SetNodeToggleState;
	}
}
