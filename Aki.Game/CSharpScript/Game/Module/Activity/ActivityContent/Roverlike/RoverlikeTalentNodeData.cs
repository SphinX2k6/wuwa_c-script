using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020060E2 RID: 24802
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeTalentNodeData
	{
		// Token: 0x0603EB38 RID: 256824 RVA: 0x00F2507D File Offset: 0x00F2327D
		public RoverlikeTalentNodeData(List<RoverRogueTalentTree> levelConfigs)
		{
			this.LevelConfigsInternal = levelConfigs;
		}

		// Token: 0x1700912E RID: 37166
		// (get) Token: 0x0603EB39 RID: 256825 RVA: 0x00F2509E File Offset: 0x00F2329E
		public IReadOnlyList<RoverRogueTalentTree> LevelConfigs
		{
			get
			{
				return this.LevelConfigsInternal;
			}
		}

		// Token: 0x1700912F RID: 37167
		// (get) Token: 0x0603EB3A RID: 256826 RVA: 0x00F250A6 File Offset: 0x00F232A6
		public RoverRogueTalentTree HeadConfig
		{
			get
			{
				return this.LevelConfigsInternal[0];
			}
		}

		// Token: 0x17009130 RID: 37168
		// (get) Token: 0x0603EB3B RID: 256827 RVA: 0x00F250B4 File Offset: 0x00F232B4
		public int MaxLevel
		{
			get
			{
				return this.LevelConfigsInternal.Count;
			}
		}

		// Token: 0x17009131 RID: 37169
		// (get) Token: 0x0603EB3C RID: 256828 RVA: 0x00F250C1 File Offset: 0x00F232C1
		// (set) Token: 0x0603EB3D RID: 256829 RVA: 0x00F250C9 File Offset: 0x00F232C9
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

		// Token: 0x17009132 RID: 37170
		// (get) Token: 0x0603EB3E RID: 256830 RVA: 0x00F250F4 File Offset: 0x00F232F4
		public bool IsUnLock
		{
			get
			{
				return this.IsServerUnlockedInternal;
			}
		}

		// Token: 0x17009133 RID: 37171
		// (get) Token: 0x0603EB3F RID: 256831 RVA: 0x00F250FC File Offset: 0x00F232FC
		// (set) Token: 0x0603EB40 RID: 256832 RVA: 0x00F25104 File Offset: 0x00F23304
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

		// Token: 0x17009134 RID: 37172
		// (get) Token: 0x0603EB41 RID: 256833 RVA: 0x00F2510D File Offset: 0x00F2330D
		// (set) Token: 0x0603EB42 RID: 256834 RVA: 0x00F25115 File Offset: 0x00F23315
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

		// Token: 0x17009135 RID: 37173
		// (get) Token: 0x0603EB43 RID: 256835 RVA: 0x00F25124 File Offset: 0x00F23324
		public int Row
		{
			get
			{
				return this.HeadConfig.Row;
			}
		}

		// Token: 0x17009136 RID: 37174
		// (get) Token: 0x0603EB44 RID: 256836 RVA: 0x00F25140 File Offset: 0x00F23340
		public int Index
		{
			get
			{
				return this.HeadConfig.Column - 1;
			}
		}

		// Token: 0x17009137 RID: 37175
		// (get) Token: 0x0603EB45 RID: 256837 RVA: 0x00F2515D File Offset: 0x00F2335D
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

		// Token: 0x17009138 RID: 37176
		// (get) Token: 0x0603EB46 RID: 256838 RVA: 0x00F25174 File Offset: 0x00F23374
		public bool IsMaxLevel
		{
			get
			{
				return this.CurLevelInternal >= this.MaxLevel;
			}
		}

		// Token: 0x17009139 RID: 37177
		// (get) Token: 0x0603EB47 RID: 256839 RVA: 0x00F25187 File Offset: 0x00F23387
		// (set) Token: 0x0603EB48 RID: 256840 RVA: 0x00F2518F File Offset: 0x00F2338F
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

		// Token: 0x1700913A RID: 37178
		// (get) Token: 0x0603EB49 RID: 256841 RVA: 0x00F25198 File Offset: 0x00F23398
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

		// Token: 0x1700913B RID: 37179
		// (get) Token: 0x0603EB4A RID: 256842 RVA: 0x00F251F0 File Offset: 0x00F233F0
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

		// Token: 0x1700913C RID: 37180
		// (get) Token: 0x0603EB4B RID: 256843 RVA: 0x00F25228 File Offset: 0x00F23428
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

		// Token: 0x1700913D RID: 37181
		// (get) Token: 0x0603EB4C RID: 256844 RVA: 0x00F25258 File Offset: 0x00F23458
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

		// Token: 0x1700913E RID: 37182
		// (get) Token: 0x0603EB4D RID: 256845 RVA: 0x00F25288 File Offset: 0x00F23488
		public string CurrentDescTextId
		{
			get
			{
				return (this.CurrentLevelConfig ?? this.HeadConfig).Desc;
			}
		}

		// Token: 0x1700913F RID: 37183
		// (get) Token: 0x0603EB4E RID: 256846 RVA: 0x00F252BC File Offset: 0x00F234BC
		public List<string> CurrentDescParams
		{
			get
			{
				return RoverlikeTalentNodeData.GetConfigParams(this.CurrentLevelConfig ?? this.HeadConfig);
			}
		}

		// Token: 0x17009140 RID: 37184
		// (get) Token: 0x0603EB4F RID: 256847 RVA: 0x00F252F0 File Offset: 0x00F234F0
		public string NextLevelDescTextId
		{
			get
			{
				RoverRogueTalentTree? roverRogueTalentTree;
				return ((this.NextLevelConfig != null) ? roverRogueTalentTree.GetValueOrDefault().Desc : null) ?? "";
			}
		}

		// Token: 0x17009141 RID: 37185
		// (get) Token: 0x0603EB50 RID: 256848 RVA: 0x00F25328 File Offset: 0x00F23528
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

		// Token: 0x0603EB51 RID: 256849 RVA: 0x00F25358 File Offset: 0x00F23558
		private static List<string> GetConfigParams(RoverRogueTalentTree config)
		{
			List<string> list = new List<string>();
			for (int i = 0; i < config.ParamsLength; i++)
			{
				list.Add(config.Params(i));
			}
			return list;
		}

		// Token: 0x04020C73 RID: 134259
		private readonly List<RoverRogueTalentTree> LevelConfigsInternal = new List<RoverRogueTalentTree>();

		// Token: 0x04020C74 RID: 134260
		private bool IsFinishPreConditionInternal = true;

		// Token: 0x04020C75 RID: 134261
		private int CurLevelInternal;

		// Token: 0x04020C76 RID: 134262
		private bool IsServerUnlockedInternal;

		// Token: 0x04020C77 RID: 134263
		private int ActiveLevelInternal;

		// Token: 0x04020C78 RID: 134264
		[Nullable(2)]
		public Action<bool, bool> SetNodeToggleState;
	}
}
