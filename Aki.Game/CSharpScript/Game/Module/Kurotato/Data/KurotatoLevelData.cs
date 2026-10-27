using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579D RID: 22429
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoLevelData
	{
		// Token: 0x06038FC2 RID: 233410 RVA: 0x00D8BD83 File Offset: 0x00D89F83
		public KurotatoLevelData(KurotatoLevel config, int activityId)
		{
			this.Config = config;
			this.ActivityId = activityId;
		}

		// Token: 0x1700889B RID: 34971
		// (get) Token: 0x06038FC3 RID: 233411 RVA: 0x00D8BD99 File Offset: 0x00D89F99
		// (set) Token: 0x06038FC4 RID: 233412 RVA: 0x00D8BDA1 File Offset: 0x00D89FA1
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

		// Token: 0x06038FC5 RID: 233413 RVA: 0x00D8BDAC File Offset: 0x00D89FAC
		public bool IsReachUnlockTime()
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.UnlockTimeInternal == 0L || (double)this.UnlockTime < serverTime;
		}

		// Token: 0x1700889C RID: 34972
		// (get) Token: 0x06038FC6 RID: 233414 RVA: 0x00D8BDD8 File Offset: 0x00D89FD8
		// (set) Token: 0x06038FC7 RID: 233415 RVA: 0x00D8BDEA File Offset: 0x00D89FEA
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

		// Token: 0x1700889D RID: 34973
		// (get) Token: 0x06038FC8 RID: 233416 RVA: 0x00D8BDF3 File Offset: 0x00D89FF3
		// (set) Token: 0x06038FC9 RID: 233417 RVA: 0x00D8BDFB File Offset: 0x00D89FFB
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

		// Token: 0x1700889E RID: 34974
		// (get) Token: 0x06038FCA RID: 233418 RVA: 0x00D8BE04 File Offset: 0x00D8A004
		// (set) Token: 0x06038FCB RID: 233419 RVA: 0x00D8BE0C File Offset: 0x00D8A00C
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

		// Token: 0x1700889F RID: 34975
		// (get) Token: 0x06038FCC RID: 233420 RVA: 0x00D8BE15 File Offset: 0x00D8A015
		// (set) Token: 0x06038FCD RID: 233421 RVA: 0x00D8BE1D File Offset: 0x00D8A01D
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

		// Token: 0x170088A0 RID: 34976
		// (get) Token: 0x06038FCE RID: 233422 RVA: 0x00D8BE26 File Offset: 0x00D8A026
		// (set) Token: 0x06038FCF RID: 233423 RVA: 0x00D8BE2E File Offset: 0x00D8A02E
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

		// Token: 0x170088A1 RID: 34977
		// (get) Token: 0x06038FD0 RID: 233424 RVA: 0x00D8BE37 File Offset: 0x00D8A037
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

		// Token: 0x170088A2 RID: 34978
		// (get) Token: 0x06038FD1 RID: 233425 RVA: 0x00D8BE4A File Offset: 0x00D8A04A
		public bool IsArchiveSpecialWave
		{
			get
			{
				KurotatoInstInfo archivedDataInternal = this.ArchivedDataInternal;
				return archivedDataInternal != null && archivedDataInternal.WaveType == 1;
			}
		}

		// Token: 0x170088A3 RID: 34979
		// (get) Token: 0x06038FD2 RID: 233426 RVA: 0x00D8BE60 File Offset: 0x00D8A060
		// (set) Token: 0x06038FD3 RID: 233427 RVA: 0x00D8BE68 File Offset: 0x00D8A068
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

		// Token: 0x170088A4 RID: 34980
		// (get) Token: 0x06038FD4 RID: 233428 RVA: 0x00D8BE71 File Offset: 0x00D8A071
		public bool HasArchivedData
		{
			get
			{
				return this.ArchivedDataInternal != null;
			}
		}

		// Token: 0x170088A5 RID: 34981
		// (get) Token: 0x06038FD5 RID: 233429 RVA: 0x00D8BE7C File Offset: 0x00D8A07C
		public bool HasHistory
		{
			get
			{
				return this.HistoryRoleIdInternal != 0;
			}
		}

		// Token: 0x170088A6 RID: 34982
		// (get) Token: 0x06038FD6 RID: 233430 RVA: 0x00D8BE87 File Offset: 0x00D8A087
		public bool HasRedDot
		{
			get
			{
				return this.IsUnLock && ActivityModel.Instance.GetActivityCacheData(this.ActivityId, 0, 4, this.Id, 0) == 0;
			}
		}

		// Token: 0x06038FD7 RID: 233431 RVA: 0x00D8BEB0 File Offset: 0x00D8A0B0
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

		// Token: 0x170088A7 RID: 34983
		// (get) Token: 0x06038FD8 RID: 233432 RVA: 0x00D8BF00 File Offset: 0x00D8A100
		public int Id
		{
			get
			{
				return this.Config.Id;
			}
		}

		// Token: 0x170088A8 RID: 34984
		// (get) Token: 0x06038FD9 RID: 233433 RVA: 0x00D8BF1C File Offset: 0x00D8A11C
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x170088A9 RID: 34985
		// (get) Token: 0x06038FDA RID: 233434 RVA: 0x00D8BF38 File Offset: 0x00D8A138
		public int PreId
		{
			get
			{
				return this.Config.PerId;
			}
		}

		// Token: 0x170088AA RID: 34986
		// (get) Token: 0x06038FDB RID: 233435 RVA: 0x00D8BF54 File Offset: 0x00D8A154
		public string Number
		{
			get
			{
				return this.Config.Number;
			}
		}

		// Token: 0x170088AB RID: 34987
		// (get) Token: 0x06038FDC RID: 233436 RVA: 0x00D8BF70 File Offset: 0x00D8A170
		public bool IsEndless
		{
			get
			{
				return this.Config.LevelGroup == 3;
			}
		}

		// Token: 0x170088AC RID: 34988
		// (get) Token: 0x06038FDD RID: 233437 RVA: 0x00D8BF90 File Offset: 0x00D8A190
		public int TotalWave
		{
			get
			{
				return this.Config.TotalWave;
			}
		}

		// Token: 0x170088AD RID: 34989
		// (get) Token: 0x06038FDE RID: 233438 RVA: 0x00D8BFAC File Offset: 0x00D8A1AC
		public int SortId
		{
			get
			{
				return this.Config.SortId;
			}
		}

		// Token: 0x170088AE RID: 34990
		// (get) Token: 0x06038FDF RID: 233439 RVA: 0x00D8BFC8 File Offset: 0x00D8A1C8
		public int LevelGroup
		{
			get
			{
				return this.Config.LevelGroup;
			}
		}

		// Token: 0x170088AF RID: 34991
		// (get) Token: 0x06038FE0 RID: 233440 RVA: 0x00D8BFE4 File Offset: 0x00D8A1E4
		public int Difficulty
		{
			get
			{
				return this.Config.Difficulty;
			}
		}

		// Token: 0x0401DDBB RID: 122299
		private readonly KurotatoLevel Config;

		// Token: 0x0401DDBC RID: 122300
		private readonly int ActivityId;

		// Token: 0x0401DDBD RID: 122301
		private bool IsUnLockInternal;

		// Token: 0x0401DDBE RID: 122302
		private bool IsFinishedInternal;

		// Token: 0x0401DDBF RID: 122303
		private long UnlockTimeInternal;

		// Token: 0x0401DDC0 RID: 122304
		private int HistoryWaveInternal;

		// Token: 0x0401DDC1 RID: 122305
		private int HistoryKillNumInternal;

		// Token: 0x0401DDC2 RID: 122306
		private int HistoryRoleIdInternal;

		// Token: 0x0401DDC3 RID: 122307
		[Nullable(2)]
		private KurotatoInstInfo ArchivedDataInternal;
	}
}
