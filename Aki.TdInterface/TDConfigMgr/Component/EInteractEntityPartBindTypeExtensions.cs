using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A27 RID: 2599
	public static class EInteractEntityPartBindTypeExtensions
	{
		// Token: 0x060039C2 RID: 14786 RVA: 0x00095720 File Offset: 0x00093920
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

		// Token: 0x060039C3 RID: 14787 RVA: 0x00095758 File Offset: 0x00093958
		public static EInteractEntityPartBindType FromString(string name)
		{
			EInteractEntityPartBindType result;
			if (!EInteractEntityPartBindTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractEntityPartBindType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039C4 RID: 14788 RVA: 0x00095781 File Offset: 0x00093981
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

		// Token: 0x060039C5 RID: 14789 RVA: 0x000957BA File Offset: 0x000939BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Prefab",
				"Model"
			};
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x000957D2 File Offset: 0x000939D2
		public static EInteractEntityPartBindType[] GetValues()
		{
			return new EInteractEntityPartBindType[]
			{
				EInteractEntityPartBindType.Prefab,
				EInteractEntityPartBindType.Model
			};
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x000957DE File Offset: 0x000939DE
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
