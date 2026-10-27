using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D2 RID: 26322
	public static class EDropCatchModifierTypeExtensions
	{
		// Token: 0x06041D04 RID: 269572 RVA: 0x00FF6698 File Offset: 0x00FF4898
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

		// Token: 0x06041D05 RID: 269573 RVA: 0x00FF66E0 File Offset: 0x00FF48E0
		public static EDropCatchModifierType FromString(string name)
		{
			EDropCatchModifierType result;
			if (!EDropCatchModifierTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchModifierType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041D06 RID: 269574 RVA: 0x00FF670C File Offset: 0x00FF490C
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

		// Token: 0x06041D07 RID: 269575 RVA: 0x00FF6762 File Offset: 0x00FF4962
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Override",
				"Rate",
				"Offset"
			};
		}

		// Token: 0x06041D08 RID: 269576 RVA: 0x00FF6782 File Offset: 0x00FF4982
		public static EDropCatchModifierType[] GetValues()
		{
			return new EDropCatchModifierType[]
			{
				EDropCatchModifierType.Override,
				EDropCatchModifierType.Rate,
				EDropCatchModifierType.Offset
			};
		}

		// Token: 0x06041D09 RID: 269577 RVA: 0x00FF6792 File Offset: 0x00FF4992
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
