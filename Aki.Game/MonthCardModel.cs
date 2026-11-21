using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001833 RID: 6195
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MonthCardModel : ModelBase
{
	// Token: 0x0600F48B RID: 62603 RVA: 0x004763D4 File Offset: 0x004745D4
	protected override bool OnInit()
	{
		MonthCardContent? config = MonthCardConfig.Instance.GetConfig(1);
		this.LocalOnceReward = new TItem?(new TItem(new InventoryDefine.GetItemData(config.Value.ItemId, 0), config.Value.Count));
		this.LocalDailyReward = new TItem?(new TItem(new InventoryDefine.GetItemData(ConfigCommonParamById.GetIntConfig("MonthCardDailyItemId").Value, 0), ConfigCommonParamById.GetIntConfig("MonthCardDailyItemCount").Value));
		this.RedDotRefreshType = ConfigCommonParamById.GetIntConfig("MonthCardRedDotRefreshTime").Value;
		return true;
	}

	// Token: 0x0600F48C RID: 62604 RVA: 0x00476474 File Offset: 0x00474674
	public int GetRemainDays()
	{
		return this.MonthCardRemainDays;
	}

	// Token: 0x0600F48D RID: 62605 RVA: 0x0047647C File Offset: 0x0047467C
	public void SetRemainDays(int value)
	{
		this.MonthCardRemainDays = value;
	}

	// Token: 0x0600F48E RID: 62606 RVA: 0x00476488 File Offset: 0x00474688
	public string GetRemainDayText([Nullable(2)] string colorTag = null)
	{
		int remainDays = MonthCardModel.Instance.GetRemainDays();
		if (remainDays < 0)
		{
			return "";
		}
		if (remainDays == 0)
		{
			string textById = TextConfig.Instance.GetTextById("MonthCardLeftTimeText_2");
			if (colorTag != null)
			{
				return StringUtils.Format(textById, new string[]
				{
					"<color=#" + colorTag + ">1</color>"
				});
			}
			return StringUtils.Format(textById, new string[]
			{
				"1"
			});
		}
		else
		{
			string textById2 = TextConfig.Instance.GetTextById("MonthCardLeftTimeText_1");
			if (colorTag != null)
			{
				string inString = textById2;
				string[] array = new string[1];
				int num = 0;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 2);
				defaultInterpolatedStringHandler.AppendLiteral("<color=#");
				defaultInterpolatedStringHandler.AppendFormatted(colorTag);
				defaultInterpolatedStringHandler.AppendLiteral(">");
				defaultInterpolatedStringHandler.AppendFormatted(remainDays.ToString());
				defaultInterpolatedStringHandler.AppendLiteral("</color>");
				array[num] = defaultInterpolatedStringHandler.ToStringAndClear();
				return StringUtils.Format(inString, array);
			}
			return StringUtils.Format(textById2, new string[]
			{
				remainDays.ToString()
			});
		}
	}

	// Token: 0x0600F48F RID: 62607 RVA: 0x0047657C File Offset: 0x0047477C
	public bool IsRemainDayInMaxLimit()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardMaxDays");
		int remainDays = this.GetRemainDays();
		int? num = intConfig;
		return remainDays <= num.GetValueOrDefault() & num != null;
	}

	// Token: 0x0600F490 RID: 62608 RVA: 0x004765B0 File Offset: 0x004747B0
	public bool CheckMonthCardIfCanBuy()
	{
		int remainDays = MonthCardModel.Instance.GetRemainDays();
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardMaxDays");
		int? num = intConfig;
		return !(remainDays > num.GetValueOrDefault() & num != null);
	}

	// Token: 0x0600F491 RID: 62609 RVA: 0x004765EC File Offset: 0x004747EC
	public bool GetPayButtonRedDotState()
	{
		if (this.NextShowPayButtonRedDotTime == null)
		{
			this.NextShowPayButtonRedDotTime = new long?(LocalStorage.GetPlayer<long>(ELocalStoragePlayerKey.MonthCardNextShowRedDotTime, 0L));
		}
		double serverTimeStamp = Time.Instance.ServerTimeStamp;
		long? nextShowPayButtonRedDotTime = this.NextShowPayButtonRedDotTime;
		double? num = (nextShowPayButtonRedDotTime != null) ? new double?((double)nextShowPayButtonRedDotTime.GetValueOrDefault()) : null;
		double num2 = serverTimeStamp;
		return (num.GetValueOrDefault() < num2 & num != null) && this.GetRemainDays() < 0;
	}

	// Token: 0x0600F492 RID: 62610 RVA: 0x00476670 File Offset: 0x00474870
	public void RefreshNextShowPayButtonRedDotTime()
	{
		if (this.RedDotRefreshType == 1)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Time.Instance.ServerTimeStamp);
			dateTime = dateTime.AddMonths(1);
			dateTime = new DateTime(dateTime.Year, dateTime.Month, 1, 4, 0, 0, DateTimeKind.Utc);
			double totalMilliseconds = dateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
			long? nextShowPayButtonRedDotTime = this.NextShowPayButtonRedDotTime;
			long num = (long)totalMilliseconds;
			if (!(nextShowPayButtonRedDotTime.GetValueOrDefault() == num & nextShowPayButtonRedDotTime != null))
			{
				this.NextShowPayButtonRedDotTime = new long?((long)totalMilliseconds);
				LocalStorage.SetPlayer<long>(ELocalStoragePlayerKey.MonthCardNextShowRedDotTime, (long)totalMilliseconds);
			}
		}
		else if (this.RedDotRefreshType == 2)
		{
			DateTime dateTime2 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(Time.Instance.ServerTimeStamp);
			dateTime2 = new DateTime(dateTime2.Year, dateTime2.Month, dateTime2.Day, 4, 0, 0, DateTimeKind.Utc);
			int num2 = (int)(((DayOfWeek)8 - (int)dateTime2.DayOfWeek) % (DayOfWeek)7);
			if (num2 == 0)
			{
				num2 = 7;
			}
			double totalMilliseconds2 = dateTime2.AddDays((double)num2).Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
			long? nextShowPayButtonRedDotTime = this.NextShowPayButtonRedDotTime;
			long num = (long)totalMilliseconds2;
			if (!(nextShowPayButtonRedDotTime.GetValueOrDefault() == num & nextShowPayButtonRedDotTime != null))
			{
				this.NextShowPayButtonRedDotTime = new long?((long)totalMilliseconds2);
				LocalStorage.SetPlayer<long>(ELocalStoragePlayerKey.MonthCardNextShowRedDotTime, (long)totalMilliseconds2);
			}
		}
		EventSystem.Instance.Emit(EEventName.PayShopGoodsBuy);
	}

	// Token: 0x0600F493 RID: 62611 RVA: 0x0047680C File Offset: 0x00474A0C
	protected override bool OnClear()
	{
		this.CanShowDailyRewardView = false;
		return true;
	}

	// Token: 0x170017C5 RID: 6085
	// (get) Token: 0x0600F494 RID: 62612 RVA: 0x00476816 File Offset: 0x00474A16
	public static MonthCardModel Instance
	{
		get
		{
			return MonthCardModel._Instance;
		}
	}

	// Token: 0x0600F495 RID: 62613 RVA: 0x0047681D File Offset: 0x00474A1D
	public static MonthCardModel GetOrCreateInstance()
	{
		if (MonthCardModel._Instance == null)
		{
			MonthCardModel.CreateInstance();
		}
		return MonthCardModel._Instance;
	}

	// Token: 0x0600F496 RID: 62614 RVA: 0x00476831 File Offset: 0x00474A31
	public static bool CreateInstance()
	{
		if (MonthCardModel._Instance != null)
		{
			return true;
		}
		MonthCardModel._Instance = new MonthCardModel();
		return true;
	}

	// Token: 0x0600F497 RID: 62615 RVA: 0x00476847 File Offset: 0x00474A47
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F498 RID: 62616 RVA: 0x00476849 File Offset: 0x00474A49
	public static void ResetStaticDefaultValue()
	{
		MonthCardModel._Instance = null;
	}

	// Token: 0x0600F499 RID: 62617 RVA: 0x00476851 File Offset: 0x00474A51
	static MonthCardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardModel.CreateStaticDefaultValue), new Action(MonthCardModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008929 RID: 35113
	private int MonthCardRemainDays = -1;

	// Token: 0x0400892A RID: 35114
	public bool CanShowDailyRewardView;

	// Token: 0x0400892B RID: 35115
	public TItem? ServerOnceReward;

	// Token: 0x0400892C RID: 35116
	public TItem? ServerDailyReward;

	// Token: 0x0400892D RID: 35117
	public TItem? LocalOnceReward;

	// Token: 0x0400892E RID: 35118
	public TItem? LocalDailyReward;

	// Token: 0x0400892F RID: 35119
	public long? NextShowPayButtonRedDotTime;

	// Token: 0x04008930 RID: 35120
	public int RedDotRefreshType = 1;

	// Token: 0x04008931 RID: 35121
	[Nullable(2)]
	private static MonthCardModel _Instance;
}
