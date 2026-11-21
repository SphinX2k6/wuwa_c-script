using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200260E RID: 9742
	public static class EModifyActorMediaTypeExtensions
	{
		// Token: 0x0600D299 RID: 53913 RVA: 0x001E9D84 File Offset: 0x001E7F84
		public static string ToEnumString(this EModifyActorMediaType value)
		{
			string result;
			if (value == EModifyActorMediaType.ChangeMediaPlayDA)
			{
				result = "ChangeMediaPlayDA";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x001E9DAC File Offset: 0x001E7FAC
		public static EModifyActorMediaType FromString(string name)
		{
			EModifyActorMediaType result;
			if (!EModifyActorMediaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModifyActorMediaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x001E9DD5 File Offset: 0x001E7FD5
		public static bool TryFromString(string name, out EModifyActorMediaType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EModifyActorMediaType.ChangeMediaPlayDA;
				return false;
			}
			if (name == "ChangeMediaPlayDA")
			{
				value = EModifyActorMediaType.ChangeMediaPlayDA;
				return true;
			}
			value = EModifyActorMediaType.ChangeMediaPlayDA;
			return false;
		}

		// Token: 0x0600D29C RID: 53916 RVA: 0x001E9DFA File Offset: 0x001E7FFA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeMediaPlayDA"
			};
		}

		// Token: 0x0600D29D RID: 53917 RVA: 0x001E9E0A File Offset: 0x001E800A
		public static EModifyActorMediaType[] GetValues()
		{
			return new EModifyActorMediaType[1];
		}

		// Token: 0x0600D29E RID: 53918 RVA: 0x001E9E12 File Offset: 0x001E8012
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeMediaPlayDA"
			};
		}
	}
}
