using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004774 RID: 18292
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLevelData
	{
		// Token: 0x0602DED2 RID: 188114 RVA: 0x00CDAAFF File Offset: 0x00CD8CFF
		public KurotatoLevelData(KurotatoLevel config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x0602DED3 RID: 188115 RVA: 0x00CDAB15 File Offset: 0x00CD8D15
		// (set) Token: 0x0602DED4 RID: 188116 RVA: 0x00CDAB1D File Offset: 0x00CD8D1D
		public long UnlockTime
		{
			get
			{
				return this.UnlockTimeInternal;
			}
			set
			{
				this.UnlockTimeInternal = value;
			}
		}

		// Token: 0x0602DED5 RID: 188117 RVA: 0x00CDAB28 File Offset: 0x00CD8D28
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInternal == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x17005C64 RID: 23652
		// (get) Token: 0x0602DED6 RID: 188118 RVA: 0x00CDAB54 File Offset: 0x00CD8D54
		// (set) Token: 0x0602DED7 RID: 188119 RVA: 0x00CDAB66 File Offset: 0x00CD8D66
		public bool IsUnLock
		{
			get
			{
				return this.IsReachUnlockTime() && this.IsUnLockInternal;
			}
			set
			{
				this.IsUnLockInternal = value;
			}
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x0602DED8 RID: 188120 RVA: 0x00CDAB6F File Offset: 0x00CD8D6F
		// (set) Token: 0x0602DED9 RID: 188121 RVA: 0x00CDAB77 File Offset: 0x00CD8D77
		public bool IsFinished
		{
			get
			{
				return this.IsFinishedInternal;
			}
			set
			{
				this.IsFinishedInternal = value;
			}
		}

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x0602DEDA RID: 188122 RVA: 0x00CDAB80 File Offset: 0x00CD8D80
		// (set) Token: 0x0602DEDB RID: 188123 RVA: 0x00CDAB88 File Offset: 0x00CD8D88
		public int HistoryWave
		{
			get
			{
				return this.HistoryWaveInternal;
			}
			set
			{
				this.HistoryWaveInternal = value;
			}
		}

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x0602DEDC RID: 188124 RVA: 0x00CDAB91 File Offset: 0x00CD8D91
		// (set) Token: 0x0602DEDD RID: 188125 RVA: 0x00CDAB99 File Offset: 0x00CD8D99
		public int HistoryKillNum
		{
			get
			{
				return this.HistoryKillNumInternal;
			}
			set
			{
				this.HistoryKillNumInternal = value;
			}
		}

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x0602DEDE RID: 188126 RVA: 0x00CDABA2 File Offset: 0x00CD8DA2
		// (set) Token: 0x0602DEDF RID: 188127 RVA: 0x00CDABAA File Offset: 0x00CD8DAA
		public int HistoryRoleId
		{
			get
			{
				return this.HistoryRoleIdInternal;
			}
			set
			{
				this.HistoryRoleIdInternal = value;
			}
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x0602DEE0 RID: 188128 RVA: 0x00CDABB3 File Offset: 0x00CD8DB3
		public int ArchiveWave
		{
			get
			{
				KurotatoInstInfo archivedDataInternal = this.ArchivedDataInternal;
				if (archivedDataInternal == null)
				{
					return -1;
				}
				return archivedDataInternal.CurWave;
			}
		}

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x0602DEE1 RID: 188129 RVA: 0x00CDABC6 File Offset: 0x00CD8DC6
		public bool IsArchiveSpecialWave
		{
			get
			{
				KurotatoInstInfo archivedDataInternal = this.ArchivedDataInternal;
				return archivedDataInternal != null && archivedDataInternal.WaveType == 1;
			}
		}

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x0602DEE2 RID: 188130 RVA: 0x00CDABDC File Offset: 0x00CD8DDC
		// (set) Token: 0x0602DEE3 RID: 188131 RVA: 0x00CDABE4 File Offset: 0x00CD8DE4
		[Nullable(2)]
		public KurotatoInstInfo ArchivedData
		{
			[NullableContext(2)]
			get
			{
				return this.ArchivedDataInternal;
			}
			[NullableContext(2)]
			set
			{
				this.ArchivedDataInternal = value;
			}
		}

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x0602DEE4 RID: 188132 RVA: 0x00CDABED File Offset: 0x00CD8DED
		public bool HasArchivedData
		{
			get
			{
				return this.ArchivedDataInternal != null;
			}
		}

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x0602DEE5 RID: 188133 RVA: 0x00CDABF8 File Offset: 0x00CD8DF8
		public bool HasHistory
		{
			get
			{
				return this.HistoryRoleIdInternal != 0;
			}
		}

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x0602DEE6 RID: 188134 RVA: 0x00CDAC03 File Offset: 0x00CD8E03
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 4, this.Id, 0) == 0;
			}
		}

		// Token: 0x0602DEE7 RID: 188135 RVA: 0x00CDAC2C File Offset: 0x00CD8E2C
		public void ReadRedDot()
		{
			if (!this.IsUnLock)
			{
				return;
			}
			if (!this.HasRedDot)
			{
				return;
			}
			ActivityModel.Instance.SaveActivityData(this.ActivityId, 4, this.Id, 0, 1);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x0602DEE8 RID: 188136 RVA: 0x00CDAC7C File Offset: 0x00CD8E7C
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x0602DEE9 RID: 188137 RVA: 0x00CDAC98 File Offset: 0x00CD8E98
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x0602DEEA RID: 188138 RVA: 0x00CDACB4 File Offset: 0x00CD8EB4
		public int PreId
		{
			get
			{
				return this.Config.PerId;
			}
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x0602DEEB RID: 188139 RVA: 0x00CDACD0 File Offset: 0x00CD8ED0
		public string Number
		{
			get
			{
				return this.Config.Number;
			}
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x0602DEEC RID: 188140 RVA: 0x00CDACEC File Offset: 0x00CD8EEC
		public bool IsEndless
		{
			get
			{
				return this.Config.LevelGroup == 3;
			}
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x0602DEED RID: 188141 RVA: 0x00CDAD0C File Offset: 0x00CD8F0C
		public int TotalWave
		{
			get
			{
				return this.Config.TotalWave;
			}
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x0602DEEE RID: 188142 RVA: 0x00CDAD28 File Offset: 0x00CD8F28
		public int SortId
		{
			get
			{
				return this.Config.SortId;
			}
		}

		// Token: 0x17005C76 RID: 23670
		// (get) Token: 0x0602DEEF RID: 188143 RVA: 0x00CDAD44 File Offset: 0x00CD8F44
		public int LevelGroup
		{
			get
			{
				return this.Config.LevelGroup;
			}
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x0602DEF0 RID: 188144 RVA: 0x00CDAD60 File Offset: 0x00CD8F60
		public int Difficulty
		{
			get
			{
				return this.Config.Difficulty;
			}
		}

		// Token: 0x04018851 RID: 100433
		private readonly KurotatoLevel Config;

		// Token: 0x04018852 RID: 100434
		private readonly int ActivityId;

		// Token: 0x04018853 RID: 100435
		private bool IsUnLockInternal;

		// Token: 0x04018854 RID: 100436
		private bool IsFinishedInternal;

		// Token: 0x04018855 RID: 100437
		private long UnlockTimeInternal;

		// Token: 0x04018856 RID: 100438
		private int HistoryWaveInternal;

		// Token: 0x04018857 RID: 100439
		private int HistoryKillNumInternal;

		// Token: 0x04018858 RID: 100440
		private int HistoryRoleIdInternal;

		// Token: 0x04018859 RID: 100441
		[Nullable(2)]
		private KurotatoInstInfo ArchivedDataInternal;
	}
}
