using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231F RID: 8991
	public static class EEnterMovieModeDurationTypeExtensions
	{
		// Token: 0x0600C48A RID: 50314 RVA: 0x001CAFC8 File Offset: 0x001C91C8
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

		// Token: 0x0600C48B RID: 50315 RVA: 0x001CB000 File Offset: 0x001C9200
		public static EEnterMovieModeDurationType FromString(string name)
		{
			EEnterMovieModeDurationType result;
			if (!EEnterMovieModeDurationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnterMovieModeDurationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C48C RID: 50316 RVA: 0x001CB029 File Offset: 0x001C9229
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

		// Token: 0x0600C48D RID: 50317 RVA: 0x001CB062 File Offset: 0x001C9262
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BorderAnimFinished",
				"FixedTime"
			};
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x001CB07A File Offset: 0x001C927A
		public static EEnterMovieModeDurationType[] GetValues()
		{
			return new EEnterMovieModeDurationType[]
			{
				EEnterMovieModeDurationType.BorderAnimFinished,
				EEnterMovieModeDurationType.FixedTime
			};
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x001CB086 File Offset: 0x001C9286
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
