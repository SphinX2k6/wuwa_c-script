using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002556 RID: 9558
	public static class EClientModifyTargetTypeExtensions
	{
		// Token: 0x0600CF5D RID: 53085 RVA: 0x001E0F9C File Offset: 0x001DF19C
		public static string ToEnumString(this EClientModifyTargetType value)
		{
			string result;
			if (value != EClientModifyTargetType.Self)
			{
				if (value != EClientModifyTargetType.Player)
				{
					result = value.ToString();
				}
				else
				{
					result = "Player";
				}
			}
			else
			{
				result = "Self";
			}
			return result;
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x001E0FD4 File Offset: 0x001DF1D4
		public static EClientModifyTargetType FromString(string name)
		{
			EClientModifyTargetType result;
			if (!EClientModifyTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientModifyTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x001E0FFD File Offset: 0x001DF1FD
		public static bool TryFromString(string name, out EClientModifyTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientModifyTargetType.Self;
				return false;
			}
			if (name == "Self")
			{
				value = EClientModifyTargetType.Self;
				return true;
			}
			if (!(name == "Player"))
			{
				value = EClientModifyTargetType.Self;
				return false;
			}
			value = EClientModifyTargetType.Player;
			return true;
		}

		// Token: 0x0600CF60 RID: 53088 RVA: 0x001E1036 File Offset: 0x001DF236
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Player"
			};
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x001E104E File Offset: 0x001DF24E
		public static EClientModifyTargetType[] GetValues()
		{
			return new EClientModifyTargetType[]
			{
				EClientModifyTargetType.Self,
				EClientModifyTargetType.Player
			};
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x001E105A File Offset: 0x001DF25A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Self",
				"Player"
			};
		}
	}
}
