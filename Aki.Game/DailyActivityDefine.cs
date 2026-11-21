using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000EAC RID: 3756
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityDefine
{
	// Token: 0x04005A31 RID: 23089
	public const int DAILY_ACTIVITY_HELP = 27;

	// Token: 0x04005A32 RID: 23090
	public const string REWARD_BACKGROUND_COLOR_UNFINISHED = "00000033";

	// Token: 0x04005A33 RID: 23091
	public const string REWARD_BACKGROUND_COLOR_FINISHED = "F3EAAB1E";

	// Token: 0x04005A34 RID: 23092
	public const int WEEKLY_REFRESH_TIME_STORAGE_KEY = 999;

	// Token: 0x020070AE RID: 28846
	[NullableContext(0)]
	public class RewardTuple
	{
		// Token: 0x04024B9D RID: 150429
		public int Id;

		// Token: 0x04024B9E RID: 150430
		public int Num;

		// Token: 0x04024B9F RID: 150431
		public bool Received;

		// Token: 0x04024BA0 RID: 150432
		public bool IsDoubleRewardVisible;
	}

	// Token: 0x020070AF RID: 28847
	public interface IActivityGoalData
	{
		// Token: 0x170077F2 RID: 30706
		// (get) Token: 0x060400D7 RID: 262359
		// (set) Token: 0x060400D8 RID: 262360
		int Id { get; set; }

		// Token: 0x170077F3 RID: 30707
		// (get) Token: 0x060400D9 RID: 262361
		// (set) Token: 0x060400DA RID: 262362
		int Goal { get; set; }

		// Token: 0x170077F4 RID: 30708
		// (get) Token: 0x060400DB RID: 262363
		// (set) Token: 0x060400DC RID: 262364
		List<TItem> Rewards { get; set; }

		// Token: 0x170077F5 RID: 30709
		// (get) Token: 0x060400DD RID: 262365
		// (set) Token: 0x060400DE RID: 262366
		bool Achieved { get; set; }

		// Token: 0x170077F6 RID: 30710
		// (get) Token: 0x060400DF RID: 262367
		// (set) Token: 0x060400E0 RID: 262368
		EDailyActiveState State { get; set; }
	}

	// Token: 0x020070B0 RID: 28848
	[Nullable(0)]
	public class ActivityGoalData
	{
		// Token: 0x170077F7 RID: 30711
		// (get) Token: 0x060400E1 RID: 262369 RVA: 0x012C1CFE File Offset: 0x012BFEFE
		// (set) Token: 0x060400E2 RID: 262370 RVA: 0x012C1D06 File Offset: 0x012BFF06
		public int Id { get; set; }

		// Token: 0x170077F8 RID: 30712
		// (get) Token: 0x060400E3 RID: 262371 RVA: 0x012C1D0F File Offset: 0x012BFF0F
		// (set) Token: 0x060400E4 RID: 262372 RVA: 0x012C1D17 File Offset: 0x012BFF17
		public int Goal { get; set; }

		// Token: 0x170077F9 RID: 30713
		// (get) Token: 0x060400E5 RID: 262373 RVA: 0x012C1D20 File Offset: 0x012BFF20
		// (set) Token: 0x060400E6 RID: 262374 RVA: 0x012C1D28 File Offset: 0x012BFF28
		public List<TItem> Rewards { get; set; }

		// Token: 0x170077FA RID: 30714
		// (get) Token: 0x060400E7 RID: 262375 RVA: 0x012C1D31 File Offset: 0x012BFF31
		// (set) Token: 0x060400E8 RID: 262376 RVA: 0x012C1D39 File Offset: 0x012BFF39
		public bool Achieved { get; set; }

		// Token: 0x170077FB RID: 30715
		// (get) Token: 0x060400E9 RID: 262377 RVA: 0x012C1D42 File Offset: 0x012BFF42
		// (set) Token: 0x060400EA RID: 262378 RVA: 0x012C1D4A File Offset: 0x012BFF4A
		public EDailyActiveState State { get; set; }
	}

	// Token: 0x020070B1 RID: 28849
	[NullableContext(0)]
	public enum EDailyActivityMainTab
	{
		// Token: 0x04024BA7 RID: 150439
		Daily = 1,
		// Token: 0x04024BA8 RID: 150440
		Weekly
	}

	// Token: 0x020070B2 RID: 28850
	public interface IDailyActivityMainTabData
	{
		// Token: 0x170077FC RID: 30716
		// (get) Token: 0x060400EC RID: 262380
		// (set) Token: 0x060400ED RID: 262381
		DailyActivityDefine.EDailyActivityMainTab TabType { get; set; }

		// Token: 0x170077FD RID: 30717
		// (get) Token: 0x060400EE RID: 262382
		// (set) Token: 0x060400EF RID: 262383
		bool IsFinished { get; set; }
	}

	// Token: 0x020070B3 RID: 28851
	[NullableContext(0)]
	public class DailyActivityMainTabData : DailyActivityDefine.IDailyActivityMainTabData
	{
		// Token: 0x170077FE RID: 30718
		// (get) Token: 0x060400F0 RID: 262384 RVA: 0x012C1D5B File Offset: 0x012BFF5B
		// (set) Token: 0x060400F1 RID: 262385 RVA: 0x012C1D63 File Offset: 0x012BFF63
		public DailyActivityDefine.EDailyActivityMainTab TabType { get; set; }

		// Token: 0x170077FF RID: 30719
		// (get) Token: 0x060400F2 RID: 262386 RVA: 0x012C1D6C File Offset: 0x012BFF6C
		// (set) Token: 0x060400F3 RID: 262387 RVA: 0x012C1D74 File Offset: 0x012BFF74
		public bool IsFinished { get; set; }
	}

	// Token: 0x020070B4 RID: 28852
	public interface IActivityRewardPanelDataAdapter
	{
		// Token: 0x17007800 RID: 30720
		// (get) Token: 0x060400F5 RID: 262389
		double CurrentValue { get; }

		// Token: 0x17007801 RID: 30721
		// (get) Token: 0x060400F6 RID: 262390
		double MaxValue { get; }

		// Token: 0x17007802 RID: 30722
		// (get) Token: 0x060400F7 RID: 262391
		IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap { get; }

		// Token: 0x060400F8 RID: 262392
		List<int> GetCanRewardIdList();

		// Token: 0x060400F9 RID: 262393
		void RequestReward(List<int> idList, Action onClose);

		// Token: 0x060400FA RID: 262394
		List<TItem> GetRewardById(int id);
	}
}
