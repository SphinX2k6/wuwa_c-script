using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006400 RID: 25600
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelData
	{
		// Token: 0x0604064F RID: 263759 RVA: 0x00F9456F File Offset: 0x00F9276F
		public MotorFightLevelData(MotorFightLevel config)
		{
			this.Config = config;
		}

		// Token: 0x1700943D RID: 37949
		// (get) Token: 0x06040651 RID: 263761 RVA: 0x00F94593 File Offset: 0x00F92793
		// (set) Token: 0x06040650 RID: 263760 RVA: 0x00F9457E File Offset: 0x00F9277E
		public long UnlockTime
		{
			get
			{
				return this.UnlockTimeInterval;
			}
			set
			{
				this.UnlockTimeInterval = value / (long)TimeUtil.Instance.InverseMillisecond;
			}
		}

		// Token: 0x06040652 RID: 263762 RVA: 0x00F9459C File Offset: 0x00F9279C
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x06040653 RID: 263763 RVA: 0x00F945C8 File Offset: 0x00F927C8
		public bool IsPreLevelFinished()
		{
			return this.PreMotorFightLevelData == null || this.PreMotorFightLevelData.IsFinished;
		}

		// Token: 0x1700943E RID: 37950
		// (get) Token: 0x06040654 RID: 263764 RVA: 0x00F945DF File Offset: 0x00F927DF
		public bool IsUnLock
		{
			get
			{
				return this.IsPreLevelFinished() && this.IsReachUnlockTime();
			}
		}

		// Token: 0x1700943F RID: 37951
		// (get) Token: 0x06040656 RID: 263766 RVA: 0x00F945FA File Offset: 0x00F927FA
		// (set) Token: 0x06040655 RID: 263765 RVA: 0x00F945F1 File Offset: 0x00F927F1
		public int BestScore
		{
			get
			{
				return this.BestScoreInterval;
			}
			set
			{
				this.BestScoreInterval = value;
			}
		}

		// Token: 0x17009440 RID: 37952
		// (get) Token: 0x06040658 RID: 263768 RVA: 0x00F9460B File Offset: 0x00F9280B
		// (set) Token: 0x06040657 RID: 263767 RVA: 0x00F94602 File Offset: 0x00F92802
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInterval;
			}
			set
			{
				this.IsFinishedInterval = value;
			}
		}

		// Token: 0x17009441 RID: 37953
		// (get) Token: 0x0604065A RID: 263770 RVA: 0x00F9461C File Offset: 0x00F9281C
		// (set) Token: 0x06040659 RID: 263769 RVA: 0x00F94613 File Offset: 0x00F92813
		public int RoleId
		{
			get
			{
				return this.RoleIdInterval;
			}
			set
			{
				this.RoleIdInterval = value;
			}
		}

		// Token: 0x17009442 RID: 37954
		// (get) Token: 0x0604065B RID: 263771 RVA: 0x00F94624 File Offset: 0x00F92824
		public bool HasLevelRedDot
		{
			get
			{
				if (!this.IsUnLock || this.IsFinished)
				{
					return false;
				}
				HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightLevelClicked, null);
				return player == null || !player.Contains(this.Id);
			}
		}

		// Token: 0x0604065C RID: 263772 RVA: 0x00F94664 File Offset: 0x00F92864
		public void ReadLevelRedDot()
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightLevelClicked, null);
			if (player != null)
			{
				player.Add(this.Id);
				LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightLevelClicked, player);
				return;
			}
			HashSet<int> value = new HashSet<int>
			{
				this.Id
			};
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.MotorFightLevelClicked, value);
		}

		// Token: 0x17009443 RID: 37955
		// (get) Token: 0x0604065D RID: 263773 RVA: 0x00F946B9 File Offset: 0x00F928B9
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17009444 RID: 37956
		// (get) Token: 0x0604065E RID: 263774 RVA: 0x00F946C6 File Offset: 0x00F928C6
		public string LevelName
		{
			get
			{
				return this.Config.LevelName;
			}
		}

		// Token: 0x17009445 RID: 37957
		// (get) Token: 0x0604065F RID: 263775 RVA: 0x00F946D3 File Offset: 0x00F928D3
		public string LevelDesc
		{
			get
			{
				return this.Config.LevelDesc;
			}
		}

		// Token: 0x17009446 RID: 37958
		// (get) Token: 0x06040660 RID: 263776 RVA: 0x00F946E0 File Offset: 0x00F928E0
		public string Number
		{
			get
			{
				return this.Config.SerialNumber;
			}
		}

		// Token: 0x17009447 RID: 37959
		// (get) Token: 0x06040661 RID: 263777 RVA: 0x00F946ED File Offset: 0x00F928ED
		public int RewardId
		{
			get
			{
				return this.Config.RewardId;
			}
		}

		// Token: 0x17009448 RID: 37960
		// (get) Token: 0x06040662 RID: 263778 RVA: 0x00F946FA File Offset: 0x00F928FA
		public List<int> RecommendRoleIds
		{
			get
			{
				return this.Config.RecommnedRoleListIter().ToList<int>();
			}
		}

		// Token: 0x17009449 RID: 37961
		// (get) Token: 0x06040663 RID: 263779 RVA: 0x00F9470C File Offset: 0x00F9290C
		public EMotorFightLevelType Type
		{
			get
			{
				return (EMotorFightLevelType)this.Config.InstType;
			}
		}

		// Token: 0x1700944A RID: 37962
		// (get) Token: 0x06040664 RID: 263780 RVA: 0x00F94719 File Offset: 0x00F92919
		public string LevelTexture
		{
			get
			{
				return this.Config.LevelTexture;
			}
		}

		// Token: 0x1700944B RID: 37963
		// (get) Token: 0x06040665 RID: 263781 RVA: 0x00F94726 File Offset: 0x00F92926
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x1700944C RID: 37964
		// (get) Token: 0x06040666 RID: 263782 RVA: 0x00F94733 File Offset: 0x00F92933
		public int Column
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x1700944D RID: 37965
		// (get) Token: 0x06040667 RID: 263783 RVA: 0x00F94740 File Offset: 0x00F92940
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x1700944E RID: 37966
		// (get) Token: 0x06040668 RID: 263784 RVA: 0x00F9474D File Offset: 0x00F9294D
		public List<int> PreLevelIds
		{
			get
			{
				return this.Config.PreId().ToList<int>();
			}
		}

		// Token: 0x1700944F RID: 37967
		// (get) Token: 0x06040669 RID: 263785 RVA: 0x00F9475F File Offset: 0x00F9295F
		public string LevelBg
		{
			get
			{
				return this.Config.LevelBg;
			}
		}

		// Token: 0x040217CC RID: 137164
		private MotorFightLevel Config;

		// Token: 0x040217CD RID: 137165
		[Nullable(2)]
		public MotorFightLevelData PreMotorFightLevelData;

		// Token: 0x040217CE RID: 137166
		private long UnlockTimeInterval;

		// Token: 0x040217CF RID: 137167
		private int BestScoreInterval;

		// Token: 0x040217D0 RID: 137168
		private int RoleIdInterval;

		// Token: 0x040217D1 RID: 137169
		private bool IsFinishedInterval;
	}
}
