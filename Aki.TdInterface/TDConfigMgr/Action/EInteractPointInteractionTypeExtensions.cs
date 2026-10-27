using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002363 RID: 9059
	public static class EInteractPointInteractionTypeExtensions
	{
		// Token: 0x0600C5BC RID: 50620 RVA: 0x001CE9F4 File Offset: 0x001CCBF4
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

		// Token: 0x0600C5BD RID: 50621 RVA: 0x001CEA1C File Offset: 0x001CCC1C
		public static EInteractPointInteractionType FromString(string name)
		{
			EInteractPointInteractionType result;
			if (!EInteractPointInteractionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractPointInteractionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x001CEA45 File Offset: 0x001CCC45
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

		// Token: 0x0600C5BF RID: 50623 RVA: 0x001CEA6A File Offset: 0x001CCC6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Drag"
			};
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x001CEA7A File Offset: 0x001CCC7A
		public static EInteractPointInteractionType[] GetValues()
		{
			return new EInteractPointInteractionType[1];
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x001CEA82 File Offset: 0x001CCC82
		public static string[] GetNames()
		{
			return new string[]
			{
				"Drag"
			};
		}
	}
}
