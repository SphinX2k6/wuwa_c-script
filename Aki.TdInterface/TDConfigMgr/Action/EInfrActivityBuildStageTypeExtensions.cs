using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D0 RID: 9680
	public static class EInfrActivityBuildStageTypeExtensions
	{
		// Token: 0x0600D182 RID: 53634 RVA: 0x001E590C File Offset: 0x001E3B0C
		public static string ToEnumString(this EInfrActivityBuildStageType value)
		{
			string result;
			if (value != EInfrActivityBuildStageType.Infrastructure)
			{
				if (value != EInfrActivityBuildStageType.Road)
				{
					result = value.ToString();
				}
				else
				{
					result = "Road";
				}
			}
			else
			{
				result = "Infrastructure";
			}
			return result;
		}

		// Token: 0x0600D183 RID: 53635 RVA: 0x001E5944 File Offset: 0x001E3B44
		public static EInfrActivityBuildStageType FromString(string name)
		{
			EInfrActivityBuildStageType result;
			if (!EInfrActivityBuildStageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInfrActivityBuildStageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D184 RID: 53636 RVA: 0x001E596D File Offset: 0x001E3B6D
		public static bool TryFromString(string name, out EInfrActivityBuildStageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return false;
			}
			if (name == "Infrastructure")
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return true;
			}
			if (!(name == "Road"))
			{
				value = EInfrActivityBuildStageType.Infrastructure;
				return false;
			}
			value = EInfrActivityBuildStageType.Road;
			return true;
		}

		// Token: 0x0600D185 RID: 53637 RVA: 0x001E59A6 File Offset: 0x001E3BA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Infrastructure",
				"Road"
			};
		}

		// Token: 0x0600D186 RID: 53638 RVA: 0x001E59BE File Offset: 0x001E3BBE
		public static EInfrActivityBuildStageType[] GetValues()
		{
			return new EInfrActivityBuildStageType[]
			{
				EInfrActivityBuildStageType.Infrastructure,
				EInfrActivityBuildStageType.Road
			};
		}

		// Token: 0x0600D187 RID: 53639 RVA: 0x001E59CA File Offset: 0x001E3BCA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Infrastructure",
				"Road"
			};
		}
	}
}
