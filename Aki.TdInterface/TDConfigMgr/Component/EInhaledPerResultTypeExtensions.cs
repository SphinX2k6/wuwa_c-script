using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A21 RID: 2593
	public static class EInhaledPerResultTypeExtensions
	{
		// Token: 0x060039A7 RID: 14759 RVA: 0x00095378 File Offset: 0x00093578
		public static string ToEnumString(this EInhaledPerResultType value)
		{
			string result;
			if (value != EInhaledPerResultType.DestroySelf)
			{
				if (value != EInhaledPerResultType.ChangeSelfState)
				{
					result = value.ToString();
				}
				else
				{
					result = "ChangeSelfState";
				}
			}
			else
			{
				result = "DestroySelf";
			}
			return result;
		}

		// Token: 0x060039A8 RID: 14760 RVA: 0x000953B0 File Offset: 0x000935B0
		public static EInhaledPerResultType FromString(string name)
		{
			EInhaledPerResultType result;
			if (!EInhaledPerResultTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInhaledPerResultType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x000953D9 File Offset: 0x000935D9
		public static bool TryFromString(string name, out EInhaledPerResultType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInhaledPerResultType.DestroySelf;
				return false;
			}
			if (name == "DestroySelf")
			{
				value = EInhaledPerResultType.DestroySelf;
				return true;
			}
			if (!(name == "ChangeSelfState"))
			{
				value = EInhaledPerResultType.DestroySelf;
				return false;
			}
			value = EInhaledPerResultType.ChangeSelfState;
			return true;
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x00095412 File Offset: 0x00093612
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DestroySelf",
				"ChangeSelfState"
			};
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0009542A File Offset: 0x0009362A
		public static EInhaledPerResultType[] GetValues()
		{
			return new EInhaledPerResultType[]
			{
				EInhaledPerResultType.DestroySelf,
				EInhaledPerResultType.ChangeSelfState
			};
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x00095436 File Offset: 0x00093636
		public static string[] GetNames()
		{
			return new string[]
			{
				"DestroySelf",
				"ChangeSelfState"
			};
		}
	}
}
