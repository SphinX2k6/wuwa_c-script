using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002379 RID: 9081
	public static class ELoopStateTypeExtensions
	{
		// Token: 0x0600C61F RID: 50719 RVA: 0x001D065C File Offset: 0x001CE85C
		public static string ToEnumString(this ELoopStateType value)
		{
			string result;
			if (value != ELoopStateType.Prev)
			{
				if (value != ELoopStateType.Next)
				{
					result = value.ToString();
				}
				else
				{
					result = "Next";
				}
			}
			else
			{
				result = "Prev";
			}
			return result;
		}

		// Token: 0x0600C620 RID: 50720 RVA: 0x001D0694 File Offset: 0x001CE894
		public static ELoopStateType FromString(string name)
		{
			ELoopStateType result;
			if (!ELoopStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELoopStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x001D06BD File Offset: 0x001CE8BD
		public static bool TryFromString(string name, out ELoopStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELoopStateType.Prev;
				return false;
			}
			if (name == "Prev")
			{
				value = ELoopStateType.Prev;
				return true;
			}
			if (!(name == "Next"))
			{
				value = ELoopStateType.Prev;
				return false;
			}
			value = ELoopStateType.Next;
			return true;
		}

		// Token: 0x0600C622 RID: 50722 RVA: 0x001D06F6 File Offset: 0x001CE8F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prev",
				"Next"
			};
		}

		// Token: 0x0600C623 RID: 50723 RVA: 0x001D070E File Offset: 0x001CE90E
		public static ELoopStateType[] GetValues()
		{
			return new ELoopStateType[]
			{
				ELoopStateType.Prev,
				ELoopStateType.Next
			};
		}

		// Token: 0x0600C624 RID: 50724 RVA: 0x001D071A File Offset: 0x001CE91A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Prev",
				"Next"
			};
		}
	}
}
