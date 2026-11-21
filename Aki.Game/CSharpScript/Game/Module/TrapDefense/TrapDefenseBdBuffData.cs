using System;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C8 RID: 14792
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffData
	{
		// Token: 0x060261CD RID: 156109 RVA: 0x00AB0E5E File Offset: 0x00AAF05E
		public static TrapDefenseBdBuffData Create(TrapDefenseBdGroup config)
		{
			TrapDefenseBdBuffData trapDefenseBdBuffData = new TrapDefenseBdBuffData(config.Id);
			trapDefenseBdBuffData.Init(config);
			return trapDefenseBdBuffData;
		}

		// Token: 0x060261CE RID: 156110 RVA: 0x00AB0E73 File Offset: 0x00AAF073
		private TrapDefenseBdBuffData(int id)
		{
			this.Id = id;
			this.Level = 1;
			this.MaxLevel = 1;
		}

		// Token: 0x060261CF RID: 156111 RVA: 0x00AB0E90 File Offset: 0x00AAF090
		private void Init(TrapDefenseBdGroup config)
		{
			this.Config = config;
			this.MaxLevel = TrapDefenseConfig.Instance.GetBdBuffListByGroupId(config.Id).Count;
			this.UpdateBdBuffConfig();
		}

		// Token: 0x060261D0 RID: 156112 RVA: 0x00AB0EBC File Offset: 0x00AAF0BC
		private void UpdateBdBuffConfig()
		{
			int level = this.Level;
			int id = this.Config.Id;
			TrapDefenseBdBuff bdBuffConfig = this.BdBuffConfig;
			this.BdBuffConfig = TrapDefenseConfig.Instance.GetBdBuffByLevelAndGroup(level, id).GetValueOrDefault(bdBuffConfig);
		}

		// Token: 0x060261D1 RID: 156113 RVA: 0x00AB0EFE File Offset: 0x00AAF0FE
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

		// Token: 0x060261D2 RID: 156114 RVA: 0x00AB0F26 File Offset: 0x00AAF126
		public void SetActive(bool active)
		{
			this.IsActive = active;
		}

		// Token: 0x060261D3 RID: 156115 RVA: 0x00AB0F2F File Offset: 0x00AAF12F
		public void SetUnlock(bool unlock)
		{
			this.IsUnlock = unlock;
		}

		// Token: 0x060261D4 RID: 156116 RVA: 0x00AB0F38 File Offset: 0x00AAF138
		public int GetActiveBdProgressNum()
		{
			if (!this.IsActive)
			{
				return 0;
			}
			return this.BdBuffConfig.Level;
		}

		// Token: 0x060261D5 RID: 156117 RVA: 0x00AB0F4F File Offset: 0x00AAF14F
		public bool IsStrengthenFinish()
		{
			return this.IsStrengthen(this.BdBuffConfig);
		}

		// Token: 0x060261D6 RID: 156118 RVA: 0x00AB0F5D File Offset: 0x00AAF15D
		public bool IsCanStrengthen()
		{
			return this.MaxLevel > 1;
		}

		// Token: 0x060261D7 RID: 156119 RVA: 0x00AB0F68 File Offset: 0x00AAF168
		public bool IsStrengthen(TrapDefenseBdBuff config)
		{
			return config.Level > 1;
		}

		// Token: 0x060261D8 RID: 156120 RVA: 0x00AB0F74 File Offset: 0x00AAF174
		public TrapDefenseBdData GetBelongBdData()
		{
			int belongBd = this.Config.BelongBd;
			return TrapDefenseModel.Instance.RougeModeData.BdDataMap[belongBd];
		}

		// Token: 0x060261D9 RID: 156121 RVA: 0x00AB0FA2 File Offset: 0x00AAF1A2
		public void SetIsShowStrengthen(bool show)
		{
			this.IsShowStrengthen = show;
		}

		// Token: 0x060261DA RID: 156122 RVA: 0x00AB0FAC File Offset: 0x00AAF1AC
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

		// Token: 0x060261DB RID: 156123 RVA: 0x00AB100C File Offset: 0x00AAF20C
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

		// Token: 0x060261DC RID: 156124 RVA: 0x00AB104F File Offset: 0x00AAF24F
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

		// Token: 0x060261DD RID: 156125 RVA: 0x00AB107F File Offset: 0x00AAF27F
		public bool IsCanSwitchStrengthen(bool? isInst = null)
		{
			return (isInst == null || !isInst.Value) && this.IsCanStrengthen() && this.IsUnlock;
		}

		// Token: 0x060261DE RID: 156126 RVA: 0x00AB10A5 File Offset: 0x00AAF2A5
		public void ActiveAddBuff()
		{
			if (this.IsActive)
			{
				this.SetLevel(2);
				return;
			}
			this.SetActive(true);
		}

		// Token: 0x060261DF RID: 156127 RVA: 0x00AB10C0 File Offset: 0x00AAF2C0
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

		// Token: 0x04014EBD RID: 85693
		public int Id;

		// Token: 0x04014EBE RID: 85694
		public int Level;

		// Token: 0x04014EBF RID: 85695
		public TrapDefenseBdGroup Config;

		// Token: 0x04014EC0 RID: 85696
		public TrapDefenseBdBuff BdBuffConfig;

		// Token: 0x04014EC1 RID: 85697
		public bool IsShowStrengthen;

		// Token: 0x04014EC2 RID: 85698
		public bool IsActive;

		// Token: 0x04014EC3 RID: 85699
		public bool IsUnlock;

		// Token: 0x04014EC4 RID: 85700
		public int MaxLevel;
	}
}
