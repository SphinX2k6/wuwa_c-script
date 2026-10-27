using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022BF RID: 8895
	public static class EBlendAnimTargetExtensions
	{
		// Token: 0x0600C2DA RID: 49882 RVA: 0x001C78A4 File Offset: 0x001C5AA4
		public static string ToEnumString(this EBlendAnimTarget value)
		{
			string result;
			if (value == EBlendAnimTarget.Player)
			{
				result = "Player";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C2DB RID: 49883 RVA: 0x001C78CC File Offset: 0x001C5ACC
		public static EBlendAnimTarget FromString(string name)
		{
			EBlendAnimTarget result;
			if (!EBlendAnimTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x001C78F5 File Offset: 0x001C5AF5
		public static bool TryFromString(string name, out EBlendAnimTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBlendAnimTarget.Player;
				return false;
			}
			if (name == "Player")
			{
				value = EBlendAnimTarget.Player;
				return true;
			}
			value = EBlendAnimTarget.Player;
			return false;
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x001C791A File Offset: 0x001C5B1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player"
			};
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x001C792A File Offset: 0x001C5B2A
		public static EBlendAnimTarget[] GetValues()
		{
			return new EBlendAnimTarget[1];
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x001C7932 File Offset: 0x001C5B32
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player"
			};
		}
	}
}
