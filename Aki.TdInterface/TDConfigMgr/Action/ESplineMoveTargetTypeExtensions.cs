using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026CC RID: 9932
	public static class ESplineMoveTargetTypeExtensions
	{
		// Token: 0x0600D5F0 RID: 54768 RVA: 0x001F1678 File Offset: 0x001EF878
		public static string ToEnumString(this ESplineMoveTargetType value)
		{
			string result;
			switch (value)
			{
			case ESplineMoveTargetType.Entity:
				result = "Entity";
				break;
			case ESplineMoveTargetType.Player:
				result = "Player";
				break;
			case ESplineMoveTargetType.AssistCharacter:
				result = "AssistCharacter";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x001F16C0 File Offset: 0x001EF8C0
		public static ESplineMoveTargetType FromString(string name)
		{
			ESplineMoveTargetType result;
			if (!ESplineMoveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x001F16EC File Offset: 0x001EF8EC
		public static bool TryFromString(string name, out ESplineMoveTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMoveTargetType.Entity;
				return false;
			}
			if (name == "Entity")
			{
				value = ESplineMoveTargetType.Entity;
				return true;
			}
			if (name == "Player")
			{
				value = ESplineMoveTargetType.Player;
				return true;
			}
			if (!(name == "AssistCharacter"))
			{
				value = ESplineMoveTargetType.Entity;
				return false;
			}
			value = ESplineMoveTargetType.AssistCharacter;
			return true;
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x001F1742 File Offset: 0x001EF942
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Player",
				"AssistCharacter"
			};
		}

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x001F1762 File Offset: 0x001EF962
		public static ESplineMoveTargetType[] GetValues()
		{
			return new ESplineMoveTargetType[]
			{
				ESplineMoveTargetType.Entity,
				ESplineMoveTargetType.Player,
				ESplineMoveTargetType.AssistCharacter
			};
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x001F1772 File Offset: 0x001EF972
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"Player",
				"AssistCharacter"
			};
		}
	}
}
