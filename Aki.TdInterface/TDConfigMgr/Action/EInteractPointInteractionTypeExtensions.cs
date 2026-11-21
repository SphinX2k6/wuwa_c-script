using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D8 RID: 9688
	public static class EInteractPointInteractionTypeExtensions
	{
		// Token: 0x0600D1A6 RID: 53670 RVA: 0x001E6CD4 File Offset: 0x001E4ED4
		public static string ToEnumString(this EInteractPointInteractionType value)
		{
			string result;
			if (value == EInteractPointInteractionType.Drag)
			{
				result = "Drag";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x001E6CFC File Offset: 0x001E4EFC
		public static EInteractPointInteractionType FromString(string name)
		{
			EInteractPointInteractionType result;
			if (!EInteractPointInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractPointInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D1A8 RID: 53672 RVA: 0x001E6D25 File Offset: 0x001E4F25
		public static bool TryFromString(string name, out EInteractPointInteractionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractPointInteractionType.Drag;
				return false;
			}
			if (name == "Drag")
			{
				value = EInteractPointInteractionType.Drag;
				return true;
			}
			value = EInteractPointInteractionType.Drag;
			return false;
		}

		// Token: 0x0600D1A9 RID: 53673 RVA: 0x001E6D4A File Offset: 0x001E4F4A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Drag"
			};
		}

		// Token: 0x0600D1AA RID: 53674 RVA: 0x001E6D5A File Offset: 0x001E4F5A
		public static EInteractPointInteractionType[] GetValues()
		{
			return new EInteractPointInteractionType[1];
		}

		// Token: 0x0600D1AB RID: 53675 RVA: 0x001E6D62 File Offset: 0x001E4F62
		public static string[] GetNames()
		{
			return new string[]
			{
				"Drag"
			};
		}
	}
}
