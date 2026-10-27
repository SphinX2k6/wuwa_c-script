using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000974 RID: 2420
	public static class EInteractEntityPartBindTypeExtensions
	{
		// Token: 0x0600363B RID: 13883 RVA: 0x0008D7B4 File Offset: 0x0008B9B4
		public static string ToEnumString(this EInteractEntityPartBindType value)
		{
			string result;
			if (value != EInteractEntityPartBindType.Prefab)
			{
				if (value != EInteractEntityPartBindType.Model)
				{
					result = value.ToString();
				}
				else
				{
					result = "Model";
				}
			}
			else
			{
				result = "Prefab";
			}
			return result;
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0008D7EC File Offset: 0x0008B9EC
		public static EInteractEntityPartBindType FromString(string name)
		{
			EInteractEntityPartBindType result;
			if (!EInteractEntityPartBindTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractEntityPartBindType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0008D815 File Offset: 0x0008BA15
		public static bool TryFromString(string name, out EInteractEntityPartBindType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractEntityPartBindType.Prefab;
				return false;
			}
			if (name == "Prefab")
			{
				value = EInteractEntityPartBindType.Prefab;
				return true;
			}
			if (!(name == "Model"))
			{
				value = EInteractEntityPartBindType.Prefab;
				return false;
			}
			value = EInteractEntityPartBindType.Model;
			return true;
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0008D84E File Offset: 0x0008BA4E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prefab",
				"Model"
			};
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0008D866 File Offset: 0x0008BA66
		public static EInteractEntityPartBindType[] GetValues()
		{
			return new EInteractEntityPartBindType[]
			{
				EInteractEntityPartBindType.Prefab,
				EInteractEntityPartBindType.Model
			};
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0008D872 File Offset: 0x0008BA72
		public static string[] GetNames()
		{
			return new string[]
			{
				"Prefab",
				"Model"
			};
		}
	}
}
