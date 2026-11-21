using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002602 RID: 9730
	public static class ELoopStateTypeExtensions
	{
		// Token: 0x0600D263 RID: 53859 RVA: 0x001E9630 File Offset: 0x001E7830
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

		// Token: 0x0600D264 RID: 53860 RVA: 0x001E9668 File Offset: 0x001E7868
		public static ELoopStateType FromString(string name)
		{
			ELoopStateType result;
			if (!ELoopStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELoopStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D265 RID: 53861 RVA: 0x001E9691 File Offset: 0x001E7891
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

		// Token: 0x0600D266 RID: 53862 RVA: 0x001E96CA File Offset: 0x001E78CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prev",
				"Next"
			};
		}

		// Token: 0x0600D267 RID: 53863 RVA: 0x001E96E2 File Offset: 0x001E78E2
		public static ELoopStateType[] GetValues()
		{
			return new ELoopStateType[]
			{
				ELoopStateType.Prev,
				ELoopStateType.Next
			};
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x001E96EE File Offset: 0x001E78EE
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
