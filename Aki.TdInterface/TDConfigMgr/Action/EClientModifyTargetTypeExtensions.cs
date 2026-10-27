using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E5 RID: 8933
	public static class EClientModifyTargetTypeExtensions
	{
		// Token: 0x0600C385 RID: 50053 RVA: 0x001C9074 File Offset: 0x001C7274
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

		// Token: 0x0600C386 RID: 50054 RVA: 0x001C90AC File Offset: 0x001C72AC
		public static EClientModifyTargetType FromString(string name)
		{
			EClientModifyTargetType result;
			if (!EClientModifyTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientModifyTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x001C90D5 File Offset: 0x001C72D5
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

		// Token: 0x0600C388 RID: 50056 RVA: 0x001C910E File Offset: 0x001C730E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Self",
				"Player"
			};
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x001C9126 File Offset: 0x001C7326
		public static EClientModifyTargetType[] GetValues()
		{
			return new EClientModifyTargetType[]
			{
				EClientModifyTargetType.Self,
				EClientModifyTargetType.Player
			};
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x001C9132 File Offset: 0x001C7332
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
