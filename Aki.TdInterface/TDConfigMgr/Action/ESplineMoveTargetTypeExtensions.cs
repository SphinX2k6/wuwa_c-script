using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200242B RID: 9259
	public static class ESplineMoveTargetTypeExtensions
	{
		// Token: 0x0600C940 RID: 51520 RVA: 0x001D7824 File Offset: 0x001D5A24
		public static string ToEnumString(this ESplineMoveTargetType value)
		{
			string result;
			if (value != ESplineMoveTargetType.Entity)
			{
				if (value != ESplineMoveTargetType.Player)
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
				result = "Entity";
			}
			return result;
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x001D785C File Offset: 0x001D5A5C
		public static ESplineMoveTargetType FromString(string name)
		{
			ESplineMoveTargetType result;
			if (!ESplineMoveTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x001D7885 File Offset: 0x001D5A85
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
			if (!(name == "Player"))
			{
				value = ESplineMoveTargetType.Entity;
				return false;
			}
			value = ESplineMoveTargetType.Player;
			return true;
		}

		// Token: 0x0600C943 RID: 51523 RVA: 0x001D78BE File Offset: 0x001D5ABE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Player"
			};
		}

		// Token: 0x0600C944 RID: 51524 RVA: 0x001D78D6 File Offset: 0x001D5AD6
		public static ESplineMoveTargetType[] GetValues()
		{
			return new ESplineMoveTargetType[]
			{
				ESplineMoveTargetType.Entity,
				ESplineMoveTargetType.Player
			};
		}

		// Token: 0x0600C945 RID: 51525 RVA: 0x001D78E2 File Offset: 0x001D5AE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"Player"
			};
		}
	}
}
