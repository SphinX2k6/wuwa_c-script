using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096E RID: 2414
	public static class EInhaledPerResultTypeExtensions
	{
		// Token: 0x06003620 RID: 13856 RVA: 0x0008D40C File Offset: 0x0008B60C
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

		// Token: 0x06003621 RID: 13857 RVA: 0x0008D444 File Offset: 0x0008B644
		public static EInhaledPerResultType FromString(string name)
		{
			EInhaledPerResultType result;
			if (!EInhaledPerResultTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInhaledPerResultType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0008D46D File Offset: 0x0008B66D
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

		// Token: 0x06003623 RID: 13859 RVA: 0x0008D4A6 File Offset: 0x0008B6A6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DestroySelf",
				"ChangeSelfState"
			};
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0008D4BE File Offset: 0x0008B6BE
		public static EInhaledPerResultType[] GetValues()
		{
			return new EInhaledPerResultType[]
			{
				EInhaledPerResultType.DestroySelf,
				EInhaledPerResultType.ChangeSelfState
			};
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x0008D4CA File Offset: 0x0008B6CA
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
