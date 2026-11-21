using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200537E RID: 21374
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightLevelData
	{
		// Token: 0x06035310 RID: 217872 RVA: 0x00EDB50F File Offset: 0x00ED970F
		public MotorFightLevelData(MotorFightLevel config)
		{
			this.Config = config;
		}

		// Token: 0x1700679F RID: 26527
		// (get) Token: 0x06035312 RID: 217874 RVA: 0x00EDB533 File Offset: 0x00ED9733
		// (set) Token: 0x06035311 RID: 217873 RVA: 0x00EDB51E File Offset: 0x00ED971E
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

		// Token: 0x06035313 RID: 217875 RVA: 0x00EDB53C File Offset: 0x00ED973C
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInterval == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x06035314 RID: 217876 RVA: 0x00EDB568 File Offset: 0x00ED9768
		public bool IsPreLevelFinished()
		{
			return this.PreMotorFightLevelData == null || this.PreMotorFightLevelData.IsFinished;
		}

		// Token: 0x170067A0 RID: 26528
		// (get) Token: 0x06035315 RID: 217877 RVA: 0x00EDB57F File Offset: 0x00ED977F
		public bool IsUnLock
		{
			get
			{
				return this.IsPreLevelFinished() && this.IsReachUnlockTime();
			}
		}

		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x06035317 RID: 217879 RVA: 0x00EDB59A File Offset: 0x00ED979A
		// (set) Token: 0x06035316 RID: 217878 RVA: 0x00EDB591 File Offset: 0x00ED9791
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

		// Token: 0x170067A2 RID: 26530
		// (get) Token: 0x06035319 RID: 217881 RVA: 0x00EDB5AB File Offset: 0x00ED97AB
		// (set) Token: 0x06035318 RID: 217880 RVA: 0x00EDB5A2 File Offset: 0x00ED97A2
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

		// Token: 0x170067A3 RID: 26531
		// (get) Token: 0x0603531B RID: 217883 RVA: 0x00EDB5BC File Offset: 0x00ED97BC
		// (set) Token: 0x0603531A RID: 217882 RVA: 0x00EDB5B3 File Offset: 0x00ED97B3
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

		// Token: 0x170067A4 RID: 26532
		// (get) Token: 0x0603531C RID: 217884 RVA: 0x00EDB5C4 File Offset: 0x00ED97C4
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

		// Token: 0x0603531D RID: 217885 RVA: 0x00EDB604 File Offset: 0x00ED9804
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

		// Token: 0x170067A5 RID: 26533
		// (get) Token: 0x0603531E RID: 217886 RVA: 0x00EDB659 File Offset: 0x00ED9859
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170067A6 RID: 26534
		// (get) Token: 0x0603531F RID: 217887 RVA: 0x00EDB666 File Offset: 0x00ED9866
		public string LevelName
		{
			get
			{
				return this.Config.LevelName;
			}
		}

		// Token: 0x170067A7 RID: 26535
		// (get) Token: 0x06035320 RID: 217888 RVA: 0x00EDB673 File Offset: 0x00ED9873
		public string LevelDesc
		{
			get
			{
				return this.Config.LevelDesc;
			}
		}

		// Token: 0x170067A8 RID: 26536
		// (get) Token: 0x06035321 RID: 217889 RVA: 0x00EDB680 File Offset: 0x00ED9880
		public string Number
		{
			get
			{
				return this.Config.SerialNumber;
			}
		}

		// Token: 0x170067A9 RID: 26537
		// (get) Token: 0x06035322 RID: 217890 RVA: 0x00EDB68D File Offset: 0x00ED988D
		public int RewardId
		{
			get
			{
				return this.Config.RewardId;
			}
		}

		// Token: 0x170067AA RID: 26538
		// (get) Token: 0x06035323 RID: 217891 RVA: 0x00EDB69A File Offset: 0x00ED989A
		public List<int> RecommendRoleIds
		{
			get
			{
				return new List<int>(this.Config.RecommnedRoleListIter());
			}
		}

		// Token: 0x170067AB RID: 26539
		// (get) Token: 0x06035324 RID: 217892 RVA: 0x00EDB6AC File Offset: 0x00ED98AC
		public EMotorFightLevelType Type
		{
			get
			{
				return (EMotorFightLevelType)this.Config.InstType;
			}
		}

		// Token: 0x170067AC RID: 26540
		// (get) Token: 0x06035325 RID: 217893 RVA: 0x00EDB6B9 File Offset: 0x00ED98B9
		public string LevelTexture
		{
			get
			{
				return this.Config.LevelTexture;
			}
		}

		// Token: 0x170067AD RID: 26541
		// (get) Token: 0x06035326 RID: 217894 RVA: 0x00EDB6C6 File Offset: 0x00ED98C6
		public int ActivityId
		{
			get
			{
				return this.Config.ActivityId;
			}
		}

		// Token: 0x170067AE RID: 26542
		// (get) Token: 0x06035327 RID: 217895 RVA: 0x00EDB6D3 File Offset: 0x00ED98D3
		public int Column
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x170067AF RID: 26543
		// (get) Token: 0x06035328 RID: 217896 RVA: 0x00EDB6E0 File Offset: 0x00ED98E0
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x170067B0 RID: 26544
		// (get) Token: 0x06035329 RID: 217897 RVA: 0x00EDB6ED File Offset: 0x00ED98ED
		public List<int> PreLevelIds
		{
			get
			{
				return new List<int>(this.Config.PreId());
			}
		}

		// Token: 0x170067B1 RID: 26545
		// (get) Token: 0x0603532A RID: 217898 RVA: 0x00EDB6FF File Offset: 0x00ED98FF
		public string LevelBg
		{
			get
			{
				return this.Config.LevelBg;
			}
		}

		// Token: 0x0401C0FB RID: 114939
		private MotorFightLevel Config;

		// Token: 0x0401C0FC RID: 114940
		[Nullable(2)]
		public MotorFightLevelData PreMotorFightLevelData;

		// Token: 0x0401C0FD RID: 114941
		private long UnlockTimeInterval;

		// Token: 0x0401C0FE RID: 114942
		private int BestScoreInterval;

		// Token: 0x0401C0FF RID: 114943
		private int RoleIdInterval;

		// Token: 0x0401C100 RID: 114944
		private bool IsFinishedInterval;
	}
}
