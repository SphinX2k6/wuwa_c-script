using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200234E RID: 9038
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class MonthCardModel : ModelBase
{
	// Token: 0x06011FDB RID: 73691 RVA: 0x0046930C File Offset: 0x0046750C
	protected override bool OnInit()
	{
		MonthCardContent? config = MonthCardConfig.Instance.GetConfig(1);
		this.LocalOnceReward = new TItem?(new TItem(new InventoryDefine.GetItemData(config.Value.ItemId, 0), config.Value.Count));
		this.LocalDailyReward = new TItem?(new TItem(new InventoryDefine.GetItemData(ConfigCommonParamById.GetIntConfig("MonthCardDailyItemId").Value, 0), ConfigCommonParamById.GetIntConfig("MonthCardDailyItemCount").Value));
		this.RedDotRefreshType = ConfigCommonParamById.GetIntConfig("MonthCardRedDotRefreshTime").Value;
		return true;
	}

	// Token: 0x06011FDC RID: 73692 RVA: 0x004693AC File Offset: 0x004675AC
	public int GetRemainDays()
	{
		return this.MonthCardRemainDays;
	}

	// Token: 0x06011FDD RID: 73693 RVA: 0x004693B4 File Offset: 0x004675B4
	public void SetRemainDays(int value)
	{
		this.MonthCardRemainDays = value;
	}

	// Token: 0x06011FDE RID: 73694 RVA: 0x004693C0 File Offset: 0x004675C0
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

	// Token: 0x06011FDF RID: 73695 RVA: 0x004694B4 File Offset: 0x004676B4
	public bool IsRemainDayInMaxLimit()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardMaxDays");
		int remainDays = this.GetRemainDays();
		int? num = intConfig;
		return remainDays <= num.GetValueOrDefault() & num != null;
	}

	// Token: 0x06011FE0 RID: 73696 RVA: 0x004694E8 File Offset: 0x004676E8
	public bool CheckMonthCardIfCanBuy()
	{
		int remainDays = MonthCardModel.Instance.GetRemainDays();
		int? intConfig = ConfigCommonParamById.GetIntConfig("MonthCardMaxDays");
		int? num = intConfig;
		return !(remainDays > num.GetValueOrDefault() & num != null);
	}

	// Token: 0x06011FE1 RID: 73697 RVA: 0x00469524 File Offset: 0x00467724
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

	// Token: 0x06011FE2 RID: 73698 RVA: 0x004695A8 File Offset: 0x004677A8
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

	// Token: 0x06011FE3 RID: 73699 RVA: 0x00469744 File Offset: 0x00467944
	protected override bool OnClear()
	{
		this.CanShowDailyRewardView = false;
		return true;
	}

	// Token: 0x1700178B RID: 6027
	// (get) Token: 0x06011FE4 RID: 73700 RVA: 0x0046974E File Offset: 0x0046794E
	public static MonthCardModel Instance
	{
		get
		{
			return MonthCardModel._Instance;
		}
	}

	// Token: 0x06011FE5 RID: 73701 RVA: 0x00469755 File Offset: 0x00467955
	public static MonthCardModel GetOrCreateInstance()
	{
		if (MonthCardModel._Instance == null)
		{
			MonthCardModel.CreateInstance();
		}
		return MonthCardModel._Instance;
	}

	// Token: 0x06011FE6 RID: 73702 RVA: 0x00469769 File Offset: 0x00467969
	public static bool CreateInstance()
	{
		if (MonthCardModel._Instance != null)
		{
			return true;
		}
		MonthCardModel._Instance = new MonthCardModel();
		return true;
	}

	// Token: 0x06011FE7 RID: 73703 RVA: 0x0046977F File Offset: 0x0046797F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011FE8 RID: 73704 RVA: 0x00469781 File Offset: 0x00467981
	public static void ResetStaticDefaultValue()
	{
		MonthCardModel._Instance = null;
	}

	// Token: 0x06011FE9 RID: 73705 RVA: 0x00469789 File Offset: 0x00467989
	static MonthCardModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MonthCardModel.CreateStaticDefaultValue), new Action(MonthCardModel.ResetStaticDefaultValue));
	}

	// Token: 0x040087E6 RID: 34790
	private int MonthCardRemainDays = -1;

	// Token: 0x040087E7 RID: 34791
	public bool CanShowDailyRewardView;

	// Token: 0x040087E8 RID: 34792
	public TItem? ServerOnceReward;

	// Token: 0x040087E9 RID: 34793
	public TItem? ServerDailyReward;

	// Token: 0x040087EA RID: 34794
	public TItem? LocalOnceReward;

	// Token: 0x040087EB RID: 34795
	public TItem? LocalDailyReward;

	// Token: 0x040087EC RID: 34796
	public long? NextShowPayButtonRedDotTime;

	// Token: 0x040087ED RID: 34797
	public int RedDotRefreshType = 1;

	// Token: 0x040087EE RID: 34798
	[Nullable(2)]
	private static MonthCardModel _Instance;
}
