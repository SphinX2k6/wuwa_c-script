using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005626 RID: 22054
	public static class EDropCatchGameplayLeftMsgTypeExtensions
	{
		// Token: 0x06036862 RID: 223330 RVA: 0x00F37CD0 File Offset: 0x00F35ED0
		public static string ToEnumString(this EDropCatchGameplayLeftMsgType value)
		{
			string result;
			if (value != EDropCatchGameplayLeftMsgType.Gameplay)
			{
				if (value != EDropCatchGameplayLeftMsgType.DropItem)
				{
					result = value.ToString();
				}
				else
				{
					result = "DropItem";
				}
			}
			else
			{
				result = "Gameplay";
			}
			return result;
		}

		// Token: 0x06036863 RID: 223331 RVA: 0x00F37D08 File Offset: 0x00F35F08
		public static EDropCatchGameplayLeftMsgType FromString(string name)
		{
			EDropCatchGameplayLeftMsgType result;
			if (!EDropCatchGameplayLeftMsgTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchGameplayLeftMsgType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06036864 RID: 223332 RVA: 0x00F37D31 File Offset: 0x00F35F31
		public static bool TryFromString(string name, out EDropCatchGameplayLeftMsgType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchGameplayLeftMsgType.Gameplay;
				return false;
			}
			if (name == "Gameplay")
			{
				value = EDropCatchGameplayLeftMsgType.Gameplay;
				return true;
			}
			if (!(name == "DropItem"))
			{
				value = EDropCatchGameplayLeftMsgType.Gameplay;
				return false;
			}
			value = EDropCatchGameplayLeftMsgType.DropItem;
			return true;
		}

		// Token: 0x06036865 RID: 223333 RVA: 0x00F37D6A File Offset: 0x00F35F6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gameplay",
				"DropItem"
			};
		}

		// Token: 0x06036866 RID: 223334 RVA: 0x00F37D82 File Offset: 0x00F35F82
		public static EDropCatchGameplayLeftMsgType[] GetValues()
		{
			return new EDropCatchGameplayLeftMsgType[]
			{
				EDropCatchGameplayLeftMsgType.Gameplay,
				EDropCatchGameplayLeftMsgType.DropItem
			};
		}

		// Token: 0x06036867 RID: 223335 RVA: 0x00F37D8E File Offset: 0x00F35F8E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Gameplay",
				"DropItem"
			};
		}
	}
}
