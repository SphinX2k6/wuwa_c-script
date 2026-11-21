using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F4 RID: 9716
	public static class ELiveLikeStateExtensions
	{
		// Token: 0x0600D224 RID: 53796 RVA: 0x001E8CF4 File Offset: 0x001E6EF4
		public static string ToEnumString(this ELiveLikeState value)
		{
			string result;
			if (value != ELiveLikeState.Enable)
			{
				if (value != ELiveLikeState.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x001E8D2C File Offset: 0x001E6F2C
		public static ELiveLikeState FromString(string name)
		{
			ELiveLikeState result;
			if (!ELiveLikeStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveLikeState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x001E8D55 File Offset: 0x001E6F55
		public static bool TryFromString(string name, out ELiveLikeState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveLikeState.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = ELiveLikeState.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = ELiveLikeState.Enable;
				return false;
			}
			value = ELiveLikeState.Disable;
			return true;
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x001E8D8E File Offset: 0x001E6F8E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x001E8DA6 File Offset: 0x001E6FA6
		public static ELiveLikeState[] GetValues()
		{
			return new ELiveLikeState[]
			{
				ELiveLikeState.Enable,
				ELiveLikeState.Disable
			};
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x001E8DB2 File Offset: 0x001E6FB2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
