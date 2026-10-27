using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A20 RID: 18976
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffData
	{
		// Token: 0x0603143D RID: 201789 RVA: 0x00B6CE62 File Offset: 0x00B6B062
		public static TrapDefenseBdBuffData Create(TrapDefenseBdGroup config)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData = new TrapDefenseBdBuffData(config.Id);
			trapDefenseBdBuffData.Init(config);
			return trapDefenseBdBuffData;
		}

		// Token: 0x0603143E RID: 201790 RVA: 0x00B6CE77 File Offset: 0x00B6B077
		private TrapDefenseBdBuffData(int id)
		{
			this.Id = id;
			this.Level = 1;
			this.MaxLevel = 1;
		}

		// Token: 0x0603143F RID: 201791 RVA: 0x00B6CE94 File Offset: 0x00B6B094
		private void Init(TrapDefenseBdGroup config)
		{
			this.Config = config;
			this.MaxLevel = TrapDefenseConfig.Instance.GetBdBuffListByGroupId(config.Id).Count;
			this.UpdateBdBuffConfig();
		}

		// Token: 0x06031440 RID: 201792 RVA: 0x00B6CEC0 File Offset: 0x00B6B0C0
		private void UpdateBdBuffConfig()
		{
			int level = this.Level;
			int id = this.Config.Id;
			TrapDefenseBdBuff bdBuffConfig = this.BdBuffConfig;
			this.BdBuffConfig = TrapDefenseConfig.Instance.GetBdBuffByLevelAndGroup(level, id).GetValueOrDefault(bdBuffConfig);
		}

		// Token: 0x06031441 RID: 201793 RVA: 0x00B6CF02 File Offset: 0x00B6B102
		public void SetLevel(int level)
		{
			if (this.Level == level)
			{
				return;
			}
			if (level < 1)
			{
				return;
			}
			if (level > this.MaxLevel)
			{
				return;
			}
			this.Level = level;
			this.UpdateBdBuffConfig();
		}

		// Token: 0x06031442 RID: 201794 RVA: 0x00B6CF2A File Offset: 0x00B6B12A
		public void SetActive(bool active)
		{
			this.IsActive = active;
		}

		// Token: 0x06031443 RID: 201795 RVA: 0x00B6CF33 File Offset: 0x00B6B133
		public void SetUnlock(bool unlock)
		{
			this.IsUnlock = unlock;
		}

		// Token: 0x06031444 RID: 201796 RVA: 0x00B6CF3C File Offset: 0x00B6B13C
		public int GetActiveBdProgressNum()
		{
			if (!this.IsActive)
			{
				return 0;
			}
			return this.BdBuffConfig.Level;
		}

		// Token: 0x06031445 RID: 201797 RVA: 0x00B6CF53 File Offset: 0x00B6B153
		public bool IsStrengthenFinish()
		{
			return this.IsStrengthen(this.BdBuffConfig);
		}

		// Token: 0x06031446 RID: 201798 RVA: 0x00B6CF61 File Offset: 0x00B6B161
		public bool IsCanStrengthen()
		{
			return this.MaxLevel > 1;
		}

		// Token: 0x06031447 RID: 201799 RVA: 0x00B6CF6C File Offset: 0x00B6B16C
		public bool IsStrengthen(TrapDefenseBdBuff config)
		{
			return config.Level > 1;
		}

		// Token: 0x06031448 RID: 201800 RVA: 0x00B6CF78 File Offset: 0x00B6B178
		public TrapDefenseBdData GetBelongBdData()
		{
			int belongBd = this.Config.BelongBd;
			return TrapDefenseModel.Instance.RougeModeData.BdDataMap[belongBd];
		}

		// Token: 0x06031449 RID: 201801 RVA: 0x00B6CFA6 File Offset: 0x00B6B1A6
		public void SetIsShowStrengthen(bool show)
		{
			this.IsShowStrengthen = show;
		}

		// Token: 0x0603144A RID: 201802 RVA: 0x00B6CFB0 File Offset: 0x00B6B1B0
		public TrapDefenseBdBuff GetStrengthenConfig()
		{
			if (this.IsStrengthenFinish())
			{
				return this.BdBuffConfig;
			}
			if (!this.IsCanStrengthen())
			{
				return this.BdBuffConfig;
			}
			TrapDefenseBdBuff? bdBuffByLevelAndGroup = TrapDefenseConfig.Instance.GetBdBuffByLevelAndGroup(this.Level + 1, this.Config.Id);
			if (bdBuffByLevelAndGroup != null)
			{
				return bdBuffByLevelAndGroup.Value;
			}
			return this.BdBuffConfig;
		}

		// Token: 0x0603144B RID: 201803 RVA: 0x00B6D010 File Offset: 0x00B6B210
		public TrapDefenseBdBuff GetStrengthenBeforeConfig()
		{
			if (this.IsStrengthenFinish())
			{
				TrapDefenseBdBuff? bdBuffByLevelAndGroup = TrapDefenseConfig.Instance.GetBdBuffByLevelAndGroup(1, this.Config.Id);
				if (bdBuffByLevelAndGroup != null)
				{
					return bdBuffByLevelAndGroup.Value;
				}
			}
			return this.BdBuffConfig;
		}

		// Token: 0x0603144C RID: 201804 RVA: 0x00B6D053 File Offset: 0x00B6B253
		public TrapDefenseBdBuff GetShowBdBuffConfig(bool? isInst = null)
		{
			if (isInst != null && isInst.Value)
			{
				return this.BdBuffConfig;
			}
			if (this.IsShowStrengthen)
			{
				return this.GetStrengthenConfig();
			}
			return this.GetStrengthenBeforeConfig();
		}

		// Token: 0x0603144D RID: 201805 RVA: 0x00B6D083 File Offset: 0x00B6B283
		public bool IsCanSwitchStrengthen(bool? isInst = null)
		{
			return (isInst == null || !isInst.Value) && this.IsCanStrengthen() && this.IsUnlock;
		}

		// Token: 0x0603144E RID: 201806 RVA: 0x00B6D0A9 File Offset: 0x00B6B2A9
		public void ActiveAddBuff()
		{
			if (this.IsActive)
			{
				this.SetLevel(2);
				return;
			}
			this.SetActive(true);
		}

		// Token: 0x0603144F RID: 201807 RVA: 0x00B6D0C4 File Offset: 0x00B6B2C4
		public string GetShowActorLabelStr()
		{
			int id = this.Id;
			int quality = this.Config.Quality;
			int id2 = this.BdBuffConfig.Id;
			int level = this.BdBuffConfig.Level;
			bool isActive = this.IsActive;
			bool isUnlock = this.IsUnlock;
			int maxLevel = this.MaxLevel;
			return new StringBuilder().Append("BdBuff_").Append(id).Append("_Bid-").Append(id2).Append("_Quality-").Append(quality).Append("_Lv-").Append(level).Append("_Active-").Append(isActive).Append("_Unlock-").Append(isUnlock).Append("_MaxLv-").Append(maxLevel).ToString();
		}

		// Token: 0x0401A566 RID: 107878
		public int Id;

		// Token: 0x0401A567 RID: 107879
		public int Level;

		// Token: 0x0401A568 RID: 107880
		public TrapDefenseBdGroup Config;

		// Token: 0x0401A569 RID: 107881
		public TrapDefenseBdBuff BdBuffConfig;

		// Token: 0x0401A56A RID: 107882
		public bool IsShowStrengthen;

		// Token: 0x0401A56B RID: 107883
		public bool IsActive;

		// Token: 0x0401A56C RID: 107884
		public bool IsUnlock;

		// Token: 0x0401A56D RID: 107885
		public int MaxLevel;
	}
}
