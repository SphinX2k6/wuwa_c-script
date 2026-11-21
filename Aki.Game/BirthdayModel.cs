using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x02000BC0 RID: 3008
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BirthdayModel : ModelBase
{
	// Token: 0x06007CEF RID: 31983 RVA: 0x0026AE30 File Offset: 0x00269030
	public bool IsDuringBirthday()
	{
		if (!this.IsReset)
		{
			return false;
		}
		int year = new DateTime(1970, 1, 1).AddSeconds(TimeUtil.Instance.GetServerTimeStamp() / (double)TimeUtil.Instance.InverseMillisecond).Year;
		this.ThisBirthdayYear = year;
		int num = ConfigBirthDayByYear.GetConfig(year, true).Value.ValidDay + 1;
		double num2;
		if (year - 1 >= this.ResetYear)
		{
			DateTime birthdayDate = this.GetBirthdayDate(year - 1);
			num2 = this.CalculateDayGapBetweenNow(birthdayDate);
			if (0.0 <= num2 && num2 <= (double)num)
			{
				this.ThisBirthdayYear = year - 1;
				return true;
			}
		}
		DateTime birthdayDate2 = this.GetBirthdayDate(year);
		num2 = this.CalculateDayGapBetweenNow(birthdayDate2);
		return 0.0 <= num2 && num2 <= (double)num;
	}

	// Token: 0x06007CF0 RID: 31984 RVA: 0x0026AF0C File Offset: 0x0026910C
	public DateTime GetBirthdayDate(int year)
	{
		int birthday = PersonalModel.Instance.GetBirthday();
		int num = birthday / 100;
		int num2 = birthday % 100;
		if (!DateTime.IsLeapYear(year) && num == 2 && num2 == 29)
		{
			num2 = 28;
		}
		DateTime result = new DateTime(year, 1, 1);
		result = result.AddMonths(num - 1);
		result = result.AddDays((double)(num2 - 1));
		return result;
	}

	// Token: 0x06007CF1 RID: 31985 RVA: 0x0026AF64 File Offset: 0x00269164
	public double CalculateDayGapBetweenNow(DateTime birthdayDate)
	{
		double num = (TimeUtil.Instance.GetServerTimeStamp() - birthdayDate.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds) / (double)TimeUtil.Instance.InverseMillisecond;
		double num2 = 86400.0;
		return num / num2;
	}

	// Token: 0x06007CF2 RID: 31986 RVA: 0x0026AFB0 File Offset: 0x002691B0
	public void UpdateBirthdayInfo(BirthDayInfoNotify notify)
	{
		this.IsReset = notify.BirthDayReset;
		if (!notify.BirthDayReset)
		{
			return;
		}
		foreach (BirthRoleSelect birthRoleSelect in notify.Roles)
		{
			this.BirthdayRoleMap[birthRoleSelect.Year] = birthRoleSelect.Role;
		}
		bool flag = this.IsDuringBirthday();
		if (notify.RecentRewardTime == this.ThisBirthdayYear)
		{
			this.IsReceiveBirthdayReward = true;
		}
		if (!this.IsReceiveBirthdayReward && flag)
		{
			BirthdayController.Instance.TryOpenBirthdayView(false);
		}
	}

	// Token: 0x06007CF3 RID: 31987 RVA: 0x0026B058 File Offset: 0x00269258
	public List<int> GetRoleIdList()
	{
		List<int> list = new List<int>();
		List<RoleBirthday> list2 = new List<RoleBirthday>(ConfigRoleBirthdayAll.GetConfigList(true) ?? new List<RoleBirthday>());
		list2.Sort(delegate(RoleBirthday roleBirthdayA, RoleBirthday roleBirthdayB)
		{
			int roleId = roleBirthdayA.RoleId;
			int roleId2 = roleBirthdayB.RoleId;
			int num = roleBirthdayB.Priority - roleBirthdayA.Priority;
			if (num != 0)
			{
				return num;
			}
			return roleId - roleId2;
		});
		foreach (RoleBirthday roleBirthday in list2)
		{
			list.Add(roleBirthday.RoleId);
		}
		return list;
	}

	// Token: 0x06007CF4 RID: 31988 RVA: 0x0026B0EC File Offset: 0x002692EC
	public void ResetBirthday()
	{
		this.IsReset = true;
		if (this.IsDuringBirthday())
		{
			BirthdayController.Instance.TryOpenBirthdayView(false);
		}
	}

	// Token: 0x06007CF5 RID: 31989 RVA: 0x0026B108 File Offset: 0x00269308
	public bool IsRoleSelected(int roleId)
	{
		foreach (KeyValuePair<int, int> keyValuePair in this.BirthdayRoleMap)
		{
			int value = keyValuePair.Value;
			if (roleId == value)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007CF6 RID: 31990 RVA: 0x0026B168 File Offset: 0x00269368
	public int GetBirthdayCount()
	{
		int num = 0;
		foreach (KeyValuePair<int, int> keyValuePair in this.BirthdayRoleMap)
		{
			if (keyValuePair.Value != 0)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06007CF7 RID: 31991 RVA: 0x0026B1C4 File Offset: 0x002693C4
	public int? GetSelectedRoleId(int year)
	{
		int value;
		if (this.BirthdayRoleMap.TryGetValue(year, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06007CF8 RID: 31992 RVA: 0x0026B1F1 File Offset: 0x002693F1
	public bool GetBirthdayRedDotState()
	{
		return FunctionModel.Instance.IsOpen(10084) && !this.IsReset;
	}

	// Token: 0x06007CF9 RID: 31993 RVA: 0x0026B20F File Offset: 0x0026940F
	public bool GetBirthdayIsReset()
	{
		return this.IsReset;
	}

	// Token: 0x06007CFA RID: 31994 RVA: 0x0026B217 File Offset: 0x00269417
	public void SetIsReceiveBirthdayReward(bool isReceiveBirthdayReward)
	{
		this.IsReceiveBirthdayReward = isReceiveBirthdayReward;
	}

	// Token: 0x06007CFB RID: 31995 RVA: 0x0026B220 File Offset: 0x00269420
	public void SetSelectedRole(int roleId, int year)
	{
		this.BirthdayRoleMap[year] = roleId;
	}

	// Token: 0x06007CFC RID: 31996 RVA: 0x0026B22F File Offset: 0x0026942F
	public void SyncTsResetState(bool isReset)
	{
		this.IsReset = isReset;
		EventSystem.Instance.Emit(EEventName.OnBirthChange);
	}

	// Token: 0x06007CFD RID: 31997 RVA: 0x0026B248 File Offset: 0x00269448
	public string GetLetterViewResource(int year)
	{
		if (year == 2025)
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
		defaultInterpolatedStringHandler.AppendLiteral("UiView_BirthdayLetter");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06007CFE RID: 31998 RVA: 0x0026B290 File Offset: 0x00269490
	public string GetRoleSelectViewResource(int year)
	{
		if (year == 2025)
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("UiView_BirthdayRole");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06007CFF RID: 31999 RVA: 0x0026B2D8 File Offset: 0x002694D8
	public string GetSelectConfirmViewResource(int year)
	{
		if (year == 2025)
		{
			return "";
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
		defaultInterpolatedStringHandler.AppendLiteral("UiView_BirthdayConfirm");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06007D00 RID: 32000 RVA: 0x0026B320 File Offset: 0x00269520
	public string GetLetterViewBgm(int year)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("BirthdayLetterBGM20");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return ConfigCommonParamById.GetStringConfig(defaultInterpolatedStringHandler.ToStringAndClear()) ?? "";
	}

	// Token: 0x06007D01 RID: 32001 RVA: 0x0026B368 File Offset: 0x00269568
	public EConfirmBoxConfigId GetLetterExitConfirmId(int year)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
		defaultInterpolatedStringHandler.AppendLiteral("BirthdayLetterExitConfirmId20");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return (EConfirmBoxConfigId)ConfigCommonParamById.GetIntConfig(defaultInterpolatedStringHandler.ToStringAndClear()).GetValueOrDefault(302);
	}

	// Token: 0x06007D02 RID: 32002 RVA: 0x0026B3B4 File Offset: 0x002695B4
	public float GetPlayTimeOffset()
	{
		return ConfigCommonParamById.GetFloatConfig("BirthdayTextPlayTimeOffset").GetValueOrDefault();
	}

	// Token: 0x17000E20 RID: 3616
	// (get) Token: 0x06007D03 RID: 32003 RVA: 0x0026B3D3 File Offset: 0x002695D3
	public static BirthdayModel Instance
	{
		get
		{
			return BirthdayModel._Instance;
		}
	}

	// Token: 0x06007D04 RID: 32004 RVA: 0x0026B3DA File Offset: 0x002695DA
	public static BirthdayModel GetOrCreateInstance()
	{
		if (BirthdayModel._Instance == null)
		{
			BirthdayModel.CreateInstance();
		}
		return BirthdayModel._Instance;
	}

	// Token: 0x06007D05 RID: 32005 RVA: 0x0026B3EE File Offset: 0x002695EE
	public static bool CreateInstance()
	{
		if (BirthdayModel._Instance != null)
		{
			return true;
		}
		BirthdayModel._Instance = new BirthdayModel();
		return true;
	}

	// Token: 0x06007D06 RID: 32006 RVA: 0x0026B404 File Offset: 0x00269604
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007D07 RID: 32007 RVA: 0x0026B406 File Offset: 0x00269606
	public static void ResetStaticDefaultValue()
	{
		BirthdayModel._Instance = null;
	}

	// Token: 0x06007D08 RID: 32008 RVA: 0x0026B40E File Offset: 0x0026960E
	static BirthdayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BirthdayModel.CreateStaticDefaultValue), new Action(BirthdayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004DC1 RID: 19905
	private bool IsReset;

	// Token: 0x04004DC2 RID: 19906
	public int ResetYear;

	// Token: 0x04004DC3 RID: 19907
	private readonly Dictionary<int, int> BirthdayRoleMap = new Dictionary<int, int>();

	// Token: 0x04004DC4 RID: 19908
	public int ThisBirthdayYear;

	// Token: 0x04004DC5 RID: 19909
	public bool IsReceiveBirthdayReward;

	// Token: 0x04004DC6 RID: 19910
	private const int DefaultYear = 2025;

	// Token: 0x04004DC7 RID: 19911
	private const int TwoThousand = 2000;

	// Token: 0x04004DC8 RID: 19912
	[Nullable(2)]
	private static BirthdayModel _Instance;
}
