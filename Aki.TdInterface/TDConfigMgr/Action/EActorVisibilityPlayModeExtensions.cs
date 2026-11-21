using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002502 RID: 9474
	public static class EActorVisibilityPlayModeExtensions
	{
		// Token: 0x0600CDE3 RID: 52707 RVA: 0x001DD858 File Offset: 0x001DBA58
		public static string ToEnumString(this EActorVisibilityPlayMode value)
		{
			string result;
			if (value != EActorVisibilityPlayMode.FadeIn)
			{
				if (value != EActorVisibilityPlayMode.FadeOut)
				{
					result = value.ToString();
				}
				else
				{
					result = "FadeOut";
				}
			}
			else
			{
				result = "FadeIn";
			}
			return result;
		}

		// Token: 0x0600CDE4 RID: 52708 RVA: 0x001DD890 File Offset: 0x001DBA90
		public static EActorVisibilityPlayMode FromString(string name)
		{
			EActorVisibilityPlayMode result;
			if (!EActorVisibilityPlayModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorVisibilityPlayMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDE5 RID: 52709 RVA: 0x001DD8B9 File Offset: 0x001DBAB9
		public static bool TryFromString(string name, out EActorVisibilityPlayMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return false;
			}
			if (name == "FadeIn")
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return true;
			}
			if (!(name == "FadeOut"))
			{
				value = EActorVisibilityPlayMode.FadeIn;
				return false;
			}
			value = EActorVisibilityPlayMode.FadeOut;
			return true;
		}

		// Token: 0x0600CDE6 RID: 52710 RVA: 0x001DD8F2 File Offset: 0x001DBAF2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FadeIn",
				"FadeOut"
			};
		}

		// Token: 0x0600CDE7 RID: 52711 RVA: 0x001DD90A File Offset: 0x001DBB0A
		public static EActorVisibilityPlayMode[] GetValues()
		{
			return new EActorVisibilityPlayMode[]
			{
				EActorVisibilityPlayMode.FadeIn,
				EActorVisibilityPlayMode.FadeOut
			};
		}

		// Token: 0x0600CDE8 RID: 52712 RVA: 0x001DD916 File Offset: 0x001DBB16
		public static string[] GetNames()
		{
			return new string[]
			{
				"FadeIn",
				"FadeOut"
			};
		}
	}
}
