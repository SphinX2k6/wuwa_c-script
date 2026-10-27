using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000994 RID: 2452
	public static class ELookAtRotateModeExtensions
	{
		// Token: 0x060036CB RID: 14027 RVA: 0x0008EA30 File Offset: 0x0008CC30
		public static string ToEnumString(this ELookAtRotateMode value)
		{
			string result;
			if (value != ELookAtRotateMode.KeepInitialPitchRoll)
			{
				if (value != ELookAtRotateMode.AllAxisLookAt)
				{
					result = value.ToString();
				}
				else
				{
					result = "AllAxisLookAt";
				}
			}
			else
			{
				result = "KeepInitialPitchRoll";
			}
			return result;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x0008EA68 File Offset: 0x0008CC68
		public static ELookAtRotateMode FromString(string name)
		{
			ELookAtRotateMode result;
			if (!ELookAtRotateModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELookAtRotateMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x0008EA91 File Offset: 0x0008CC91
		public static bool TryFromString(string name, out ELookAtRotateMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return false;
			}
			if (name == "KeepInitialPitchRoll")
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return true;
			}
			if (!(name == "AllAxisLookAt"))
			{
				value = ELookAtRotateMode.KeepInitialPitchRoll;
				return false;
			}
			value = ELookAtRotateMode.AllAxisLookAt;
			return true;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x0008EACA File Offset: 0x0008CCCA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KeepInitialPitchRoll",
				"AllAxisLookAt"
			};
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x0008EAE2 File Offset: 0x0008CCE2
		public static ELookAtRotateMode[] GetValues()
		{
			return new ELookAtRotateMode[]
			{
				ELookAtRotateMode.KeepInitialPitchRoll,
				ELookAtRotateMode.AllAxisLookAt
			};
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x0008EAEE File Offset: 0x0008CCEE
		public static string[] GetNames()
		{
			return new string[]
			{
				"KeepInitialPitchRoll",
				"AllAxisLookAt"
			};
		}
	}
}
