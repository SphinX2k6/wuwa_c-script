using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258E RID: 9614
	public static class EEnterMovieModeDurationTypeExtensions
	{
		// Token: 0x0600D059 RID: 53337 RVA: 0x001E2E90 File Offset: 0x001E1090
		public static string ToEnumString(this EEnterMovieModeDurationType value)
		{
			string result;
			if (value != EEnterMovieModeDurationType.BorderAnimFinished)
			{
				if (value != EEnterMovieModeDurationType.FixedTime)
				{
					result = value.ToString();
				}
				else
				{
					result = "FixedTime";
				}
			}
			else
			{
				result = "BorderAnimFinished";
			}
			return result;
		}

		// Token: 0x0600D05A RID: 53338 RVA: 0x001E2EC8 File Offset: 0x001E10C8
		public static EEnterMovieModeDurationType FromString(string name)
		{
			EEnterMovieModeDurationType result;
			if (!EEnterMovieModeDurationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnterMovieModeDurationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D05B RID: 53339 RVA: 0x001E2EF1 File Offset: 0x001E10F1
		public static bool TryFromString(string name, out EEnterMovieModeDurationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnterMovieModeDurationType.BorderAnimFinished;
				return false;
			}
			if (name == "BorderAnimFinished")
			{
				value = EEnterMovieModeDurationType.BorderAnimFinished;
				return true;
			}
			if (!(name == "FixedTime"))
			{
				value = EEnterMovieModeDurationType.BorderAnimFinished;
				return false;
			}
			value = EEnterMovieModeDurationType.FixedTime;
			return true;
		}

		// Token: 0x0600D05C RID: 53340 RVA: 0x001E2F2A File Offset: 0x001E112A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BorderAnimFinished",
				"FixedTime"
			};
		}

		// Token: 0x0600D05D RID: 53341 RVA: 0x001E2F42 File Offset: 0x001E1142
		public static EEnterMovieModeDurationType[] GetValues()
		{
			return new EEnterMovieModeDurationType[]
			{
				EEnterMovieModeDurationType.BorderAnimFinished,
				EEnterMovieModeDurationType.FixedTime
			};
		}

		// Token: 0x0600D05E RID: 53342 RVA: 0x001E2F4E File Offset: 0x001E114E
		public static string[] GetNames()
		{
			return new string[]
			{
				"BorderAnimFinished",
				"FixedTime"
			};
		}
	}
}
