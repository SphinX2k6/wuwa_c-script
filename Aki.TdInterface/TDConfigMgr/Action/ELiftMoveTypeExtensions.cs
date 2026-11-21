using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025E4 RID: 9700
	public static class ELiftMoveTypeExtensions
	{
		// Token: 0x0600D1DC RID: 53724 RVA: 0x001E81D8 File Offset: 0x001E63D8
		public static string ToEnumString(this ELiftMoveType value)
		{
			string result;
			switch (value)
			{
			case ELiftMoveType.Default:
				result = "Default";
				break;
			case ELiftMoveType.Teleport:
				result = "Teleport";
				break;
			case ELiftMoveType.CustomSpeed:
				result = "CustomSpeed";
				break;
			case ELiftMoveType.Circular:
				result = "Circular";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x001E822C File Offset: 0x001E642C
		public static ELiftMoveType FromString(string name)
		{
			ELiftMoveType result;
			if (!ELiftMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiftMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x001E8258 File Offset: 0x001E6458
		public static bool TryFromString(string name, out ELiftMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiftMoveType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = ELiftMoveType.Default;
				return true;
			}
			if (name == "Teleport")
			{
				value = ELiftMoveType.Teleport;
				return true;
			}
			if (name == "CustomSpeed")
			{
				value = ELiftMoveType.CustomSpeed;
				return true;
			}
			if (!(name == "Circular"))
			{
				value = ELiftMoveType.Default;
				return false;
			}
			value = ELiftMoveType.Circular;
			return true;
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x001E82C0 File Offset: 0x001E64C0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Teleport",
				"CustomSpeed",
				"Circular"
			};
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x001E82E8 File Offset: 0x001E64E8
		public static ELiftMoveType[] GetValues()
		{
			return new ELiftMoveType[]
			{
				ELiftMoveType.Default,
				ELiftMoveType.Teleport,
				ELiftMoveType.CustomSpeed,
				ELiftMoveType.Circular
			};
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x001E82FB File Offset: 0x001E64FB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Teleport",
				"CustomSpeed",
				"Circular"
			};
		}
	}
}
