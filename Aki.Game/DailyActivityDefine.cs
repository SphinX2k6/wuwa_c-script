using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020019ED RID: 6637
[NullableContext(1)]
[Nullable(0)]
public class DailyActivityDefine
{
	// Token: 0x04005962 RID: 22882
	public const int DAILY_ACTIVITY_HELP = 27;

	// Token: 0x04005963 RID: 22883
	public const string REWARD_BACKGROUND_COLOR_UNFINISHED = "00000033";

	// Token: 0x04005964 RID: 22884
	public const string REWARD_BACKGROUND_COLOR_FINISHED = "F3EAAB1E";

	// Token: 0x04005965 RID: 22885
	public const int WEEKLY_REFRESH_TIME_STORAGE_KEY = 999;

	// Token: 0x02007F1F RID: 32543
	[NullableContext(0)]
	public class RewardTuple
	{
		// Token: 0x04029860 RID: 170080
		public int Id;

		// Token: 0x04029861 RID: 170081
		public int Num;

		// Token: 0x04029862 RID: 170082
		public bool Received;

		// Token: 0x04029863 RID: 170083
		public bool IsDoubleRewardVisible;
	}

	// Token: 0x02007F20 RID: 32544
	public interface IActivityGoalData
	{
		// Token: 0x1700A054 RID: 41044
		// (get) Token: 0x06049CB9 RID: 302265
		// (set) Token: 0x06049CBA RID: 302266
		int Id { get; set; }

		// Token: 0x1700A055 RID: 41045
		// (get) Token: 0x06049CBB RID: 302267
		// (set) Token: 0x06049CBC RID: 302268
		int Goal { get; set; }

		// Token: 0x1700A056 RID: 41046
		// (get) Token: 0x06049CBD RID: 302269
		// (set) Token: 0x06049CBE RID: 302270
		List<TItem> Rewards { get; set; }

		// Token: 0x1700A057 RID: 41047
		// (get) Token: 0x06049CBF RID: 302271
		// (set) Token: 0x06049CC0 RID: 302272
		bool Achieved { get; set; }

		// Token: 0x1700A058 RID: 41048
		// (get) Token: 0x06049CC1 RID: 302273
		// (set) Token: 0x06049CC2 RID: 302274
		EDailyActiveState State { get; set; }
	}

	// Token: 0x02007F21 RID: 32545
	[Nullable(0)]
	public class ActivityGoalData
	{
		// Token: 0x1700A059 RID: 41049
		// (get) Token: 0x06049CC3 RID: 302275 RVA: 0x0131E802 File Offset: 0x0131CA02
		// (set) Token: 0x06049CC4 RID: 302276 RVA: 0x0131E80A File Offset: 0x0131CA0A
		public int Id { get; set; }

		// Token: 0x1700A05A RID: 41050
		// (get) Token: 0x06049CC5 RID: 302277 RVA: 0x0131E813 File Offset: 0x0131CA13
		// (set) Token: 0x06049CC6 RID: 302278 RVA: 0x0131E81B File Offset: 0x0131CA1B
		public int Goal { get; set; }

		// Token: 0x1700A05B RID: 41051
		// (get) Token: 0x06049CC7 RID: 302279 RVA: 0x0131E824 File Offset: 0x0131CA24
		// (set) Token: 0x06049CC8 RID: 302280 RVA: 0x0131E82C File Offset: 0x0131CA2C
		public List<TItem> Rewards { get; set; }

		// Token: 0x1700A05C RID: 41052
		// (get) Token: 0x06049CC9 RID: 302281 RVA: 0x0131E835 File Offset: 0x0131CA35
		// (set) Token: 0x06049CCA RID: 302282 RVA: 0x0131E83D File Offset: 0x0131CA3D
		public bool Achieved { get; set; }

		// Token: 0x1700A05D RID: 41053
		// (get) Token: 0x06049CCB RID: 302283 RVA: 0x0131E846 File Offset: 0x0131CA46
		// (set) Token: 0x06049CCC RID: 302284 RVA: 0x0131E84E File Offset: 0x0131CA4E
		public EDailyActiveState State { get; set; }
	}

	// Token: 0x02007F22 RID: 32546
	[NullableContext(0)]
	public enum EDailyActivityMainTab
	{
		// Token: 0x0402986A RID: 170090
		Daily = 1,
		// Token: 0x0402986B RID: 170091
		Weekly
	}

	// Token: 0x02007F23 RID: 32547
	public interface IDailyActivityMainTabData
	{
		// Token: 0x1700A05E RID: 41054
		// (get) Token: 0x06049CCE RID: 302286
		// (set) Token: 0x06049CCF RID: 302287
		DailyActivityDefine.EDailyActivityMainTab TabType { get; set; }

		// Token: 0x1700A05F RID: 41055
		// (get) Token: 0x06049CD0 RID: 302288
		// (set) Token: 0x06049CD1 RID: 302289
		bool IsFinished { get; set; }
	}

	// Token: 0x02007F24 RID: 32548
	[NullableContext(0)]
	public class DailyActivityMainTabData : DailyActivityDefine.IDailyActivityMainTabData
	{
		// Token: 0x1700A060 RID: 41056
		// (get) Token: 0x06049CD2 RID: 302290 RVA: 0x0131E85F File Offset: 0x0131CA5F
		// (set) Token: 0x06049CD3 RID: 302291 RVA: 0x0131E867 File Offset: 0x0131CA67
		public DailyActivityDefine.EDailyActivityMainTab TabType { get; set; }

		// Token: 0x1700A061 RID: 41057
		// (get) Token: 0x06049CD4 RID: 302292 RVA: 0x0131E870 File Offset: 0x0131CA70
		// (set) Token: 0x06049CD5 RID: 302293 RVA: 0x0131E878 File Offset: 0x0131CA78
		public bool IsFinished { get; set; }
	}

	// Token: 0x02007F25 RID: 32549
	public interface IActivityRewardPanelDataAdapter
	{
		// Token: 0x1700A062 RID: 41058
		// (get) Token: 0x06049CD7 RID: 302295
		double CurrentValue { get; }

		// Token: 0x1700A063 RID: 41059
		// (get) Token: 0x06049CD8 RID: 302296
		double MaxValue { get; }

		// Token: 0x1700A064 RID: 41060
		// (get) Token: 0x06049CD9 RID: 302297
		IReadOnlyDictionary<int, DailyActivityDefine.IActivityGoalData> GoalMap { get; }

		// Token: 0x06049CDA RID: 302298
		List<int> GetCanRewardIdList();

		// Token: 0x06049CDB RID: 302299
		void RequestReward(List<int> idList, Action onClose);

		// Token: 0x06049CDC RID: 302300
		List<TItem> GetRewardById(int id);
	}
}
