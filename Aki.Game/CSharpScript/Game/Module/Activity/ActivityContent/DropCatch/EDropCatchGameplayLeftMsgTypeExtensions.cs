using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D6 RID: 26326
	public static class EDropCatchGameplayLeftMsgTypeExtensions
	{
		// Token: 0x06041D16 RID: 269590 RVA: 0x00FF68CC File Offset: 0x00FF4ACC
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

		// Token: 0x06041D17 RID: 269591 RVA: 0x00FF6904 File Offset: 0x00FF4B04
		public static EDropCatchGameplayLeftMsgType FromString(string name)
		{
			EDropCatchGameplayLeftMsgType result;
			if (!EDropCatchGameplayLeftMsgTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchGameplayLeftMsgType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041D18 RID: 269592 RVA: 0x00FF692D File Offset: 0x00FF4B2D
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

		// Token: 0x06041D19 RID: 269593 RVA: 0x00FF6966 File Offset: 0x00FF4B66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gameplay",
				"DropItem"
			};
		}

		// Token: 0x06041D1A RID: 269594 RVA: 0x00FF697E File Offset: 0x00FF4B7E
		public static EDropCatchGameplayLeftMsgType[] GetValues()
		{
			return new EDropCatchGameplayLeftMsgType[]
			{
				EDropCatchGameplayLeftMsgType.Gameplay,
				EDropCatchGameplayLeftMsgType.DropItem
			};
		}

		// Token: 0x06041D1B RID: 269595 RVA: 0x00FF698A File Offset: 0x00FF4B8A
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
