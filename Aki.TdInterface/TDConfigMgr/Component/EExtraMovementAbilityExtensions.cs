using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009EF RID: 2543
	public static class EExtraMovementAbilityExtensions
	{
		// Token: 0x060038C6 RID: 14534 RVA: 0x00093234 File Offset: 0x00091434
		public static string ToEnumString(this EExtraMovementAbility value)
		{
			string result;
			if (value == EExtraMovementAbility.Diving)
			{
				result = "Diving";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0009325C File Offset: 0x0009145C
		public static EExtraMovementAbility FromString(string name)
		{
			EExtraMovementAbility result;
			if (!EExtraMovementAbilityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExtraMovementAbility 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x00093285 File Offset: 0x00091485
		public static bool TryFromString(string name, out EExtraMovementAbility value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExtraMovementAbility.Diving;
				return false;
			}
			if (name == "Diving")
			{
				value = EExtraMovementAbility.Diving;
				return true;
			}
			value = EExtraMovementAbility.Diving;
			return false;
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x000932AA File Offset: 0x000914AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Diving"
			};
		}

		// Token: 0x060038CA RID: 14538 RVA: 0x000932BA File Offset: 0x000914BA
		public static EExtraMovementAbility[] GetValues()
		{
			return new EExtraMovementAbility[1];
		}

		// Token: 0x060038CB RID: 14539 RVA: 0x000932C2 File Offset: 0x000914C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Diving"
			};
		}
	}
}
