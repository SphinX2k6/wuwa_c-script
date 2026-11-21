using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005622 RID: 22050
	public static class EDropCatchModifierTypeExtensions
	{
		// Token: 0x06036850 RID: 223312 RVA: 0x00F37A9C File Offset: 0x00F35C9C
		public static string ToEnumString(this EDropCatchModifierType value)
		{
			string result;
			switch (value)
			{
			case EDropCatchModifierType.Override:
				result = "Override";
				break;
			case EDropCatchModifierType.Rate:
				result = "Rate";
				break;
			case EDropCatchModifierType.Offset:
				result = "Offset";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06036851 RID: 223313 RVA: 0x00F37AE4 File Offset: 0x00F35CE4
		public static EDropCatchModifierType FromString(string name)
		{
			EDropCatchModifierType result;
			if (!EDropCatchModifierTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchModifierType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06036852 RID: 223314 RVA: 0x00F37B10 File Offset: 0x00F35D10
		public static bool TryFromString(string name, out EDropCatchModifierType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchModifierType.Override;
				return false;
			}
			if (name == "Override")
			{
				value = EDropCatchModifierType.Override;
				return true;
			}
			if (name == "Rate")
			{
				value = EDropCatchModifierType.Rate;
				return true;
			}
			if (!(name == "Offset"))
			{
				value = EDropCatchModifierType.Override;
				return false;
			}
			value = EDropCatchModifierType.Offset;
			return true;
		}

		// Token: 0x06036853 RID: 223315 RVA: 0x00F37B66 File Offset: 0x00F35D66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Override",
				"Rate",
				"Offset"
			};
		}

		// Token: 0x06036854 RID: 223316 RVA: 0x00F37B86 File Offset: 0x00F35D86
		public static EDropCatchModifierType[] GetValues()
		{
			return new EDropCatchModifierType[]
			{
				EDropCatchModifierType.Override,
				EDropCatchModifierType.Rate,
				EDropCatchModifierType.Offset
			};
		}

		// Token: 0x06036855 RID: 223317 RVA: 0x00F37B96 File Offset: 0x00F35D96
		public static string[] GetNames()
		{
			return new string[]
			{
				"Override",
				"Rate",
				"Offset"
			};
		}
	}
}
