using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Personal;

// Token: 0x02001708 RID: 5896
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BirthdayModel : ModelBase
{
	// Token: 0x0600A90F RID: 43279 RVA: 0x00260A14 File Offset: 0x0025EC14
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

	// Token: 0x0600A910 RID: 43280 RVA: 0x00260AF0 File Offset: 0x0025ECF0
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

	// Token: 0x0600A911 RID: 43281 RVA: 0x00260B48 File Offset: 0x0025ED48
	public double CalculateDayGapBetweenNow(DateTime birthdayDate)
	{
		double num = (TimeUtil.Instance.GetServerTimeStamp() - birthdayDate.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds) / (double)TimeUtil.Instance.InverseMillisecond;
		double num2 = 86400.0;
		return num / num2;
	}

	// Token: 0x0600A912 RID: 43282 RVA: 0x00260B94 File Offset: 0x0025ED94
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

	// Token: 0x0600A913 RID: 43283 RVA: 0x00260C3C File Offset: 0x0025EE3C
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

	// Token: 0x0600A914 RID: 43284 RVA: 0x00260CD0 File Offset: 0x0025EED0
	public void ResetBirthday()
	{
		this.IsReset = true;
		if (this.IsDuringBirthday())
		{
			BirthdayController.Instance.TryOpenBirthdayView(false);
		}
	}

	// Token: 0x0600A915 RID: 43285 RVA: 0x00260CEC File Offset: 0x0025EEEC
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

	// Token: 0x0600A916 RID: 43286 RVA: 0x00260D4C File Offset: 0x0025EF4C
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

	// Token: 0x0600A917 RID: 43287 RVA: 0x00260DA8 File Offset: 0x0025EFA8
	public int? GetSelectedRoleId(int year)
	{
		int value;
		if (this.BirthdayRoleMap.TryGetValue(year, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x0600A918 RID: 43288 RVA: 0x00260DD5 File Offset: 0x0025EFD5
	public bool GetBirthdayRedDotState()
	{
		return FunctionModel.Instance.IsOpen(10084) && !this.IsReset;
	}

	// Token: 0x0600A919 RID: 43289 RVA: 0x00260DF3 File Offset: 0x0025EFF3
	public bool GetBirthdayIsReset()
	{
		return this.IsReset;
	}

	// Token: 0x0600A91A RID: 43290 RVA: 0x00260DFB File Offset: 0x0025EFFB
	public void SetIsReceiveBirthdayReward(bool isReceiveBirthdayReward)
	{
		this.IsReceiveBirthdayReward = isReceiveBirthdayReward;
	}

	// Token: 0x0600A91B RID: 43291 RVA: 0x00260E04 File Offset: 0x0025F004
	public void SetSelectedRole(int roleId, int year)
	{
		this.BirthdayRoleMap[year] = roleId;
	}

	// Token: 0x0600A91C RID: 43292 RVA: 0x00260E13 File Offset: 0x0025F013
	public void SyncTsResetState(bool isReset)
	{
		this.IsReset = isReset;
		EventSystem.Instance.Emit(EEventName.OnBirthChange);
	}

	// Token: 0x0600A91D RID: 43293 RVA: 0x00260E2C File Offset: 0x0025F02C
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

	// Token: 0x0600A91E RID: 43294 RVA: 0x00260E74 File Offset: 0x0025F074
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

	// Token: 0x0600A91F RID: 43295 RVA: 0x00260EBC File Offset: 0x0025F0BC
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

	// Token: 0x0600A920 RID: 43296 RVA: 0x00260F04 File Offset: 0x0025F104
	public string GetLetterViewBgm(int year)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 1);
		defaultInterpolatedStringHandler.AppendLiteral("BirthdayLetterBGM20");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return ConfigCommonParamById.GetStringConfig(defaultInterpolatedStringHandler.ToStringAndClear()) ?? "";
	}

	// Token: 0x0600A921 RID: 43297 RVA: 0x00260F4C File Offset: 0x0025F14C
	public EConfirmBoxConfigId GetLetterExitConfirmId(int year)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
		defaultInterpolatedStringHandler.AppendLiteral("BirthdayLetterExitConfirmId20");
		defaultInterpolatedStringHandler.AppendFormatted<int>(year % 2000);
		return (EConfirmBoxConfigId)ConfigCommonParamById.GetIntConfig(defaultInterpolatedStringHandler.ToStringAndClear()).GetValueOrDefault(302);
	}

	// Token: 0x0600A922 RID: 43298 RVA: 0x00260F98 File Offset: 0x0025F198
	public float GetPlayTimeOffset()
	{
		return ConfigCommonParamById.GetFloatConfig("BirthdayTextPlayTimeOffset").GetValueOrDefault();
	}

	// Token: 0x17000DFF RID: 3583
	// (get) Token: 0x0600A923 RID: 43299 RVA: 0x00260FB7 File Offset: 0x0025F1B7
	public static BirthdayModel Instance
	{
		get
		{
			return BirthdayModel._Instance;
		}
	}

	// Token: 0x0600A924 RID: 43300 RVA: 0x00260FBE File Offset: 0x0025F1BE
	public static BirthdayModel GetOrCreateInstance()
	{
		if (BirthdayModel._Instance == null)
		{
			BirthdayModel.CreateInstance();
		}
		return BirthdayModel._Instance;
	}

	// Token: 0x0600A925 RID: 43301 RVA: 0x00260FD2 File Offset: 0x0025F1D2
	public static bool CreateInstance()
	{
		if (BirthdayModel._Instance != null)
		{
			return true;
		}
		BirthdayModel._Instance = new BirthdayModel();
		return true;
	}

	// Token: 0x0600A926 RID: 43302 RVA: 0x00260FE8 File Offset: 0x0025F1E8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600A927 RID: 43303 RVA: 0x00260FEA File Offset: 0x0025F1EA
	public static void ResetStaticDefaultValue()
	{
		BirthdayModel._Instance = null;
	}

	// Token: 0x0600A928 RID: 43304 RVA: 0x00260FF2 File Offset: 0x0025F1F2
	static BirthdayModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BirthdayModel.CreateStaticDefaultValue), new Action(BirthdayModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D1A RID: 19738
	private bool IsReset;

	// Token: 0x04004D1B RID: 19739
	public int ResetYear;

	// Token: 0x04004D1C RID: 19740
	private readonly Dictionary<int, int> BirthdayRoleMap = new Dictionary<int, int>();

	// Token: 0x04004D1D RID: 19741
	public int ThisBirthdayYear;

	// Token: 0x04004D1E RID: 19742
	public bool IsReceiveBirthdayReward;

	// Token: 0x04004D1F RID: 19743
	private const int DefaultYear = 2025;

	// Token: 0x04004D20 RID: 19744
	private const int TwoThousand = 2000;

	// Token: 0x04004D21 RID: 19745
	[Nullable(2)]
	private static BirthdayModel _Instance;
}
