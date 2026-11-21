using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200252E RID: 9518
	public static class EBlendAnimTargetExtensions
	{
		// Token: 0x0600CEA9 RID: 52905 RVA: 0x001DF6AC File Offset: 0x001DD8AC
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

		// Token: 0x0600CEAA RID: 52906 RVA: 0x001DF6D4 File Offset: 0x001DD8D4
		public static EBlendAnimTarget FromString(string name)
		{
			EBlendAnimTarget result;
			if (!EBlendAnimTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBlendAnimTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x001DF6FD File Offset: 0x001DD8FD
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

		// Token: 0x0600CEAC RID: 52908 RVA: 0x001DF722 File Offset: 0x001DD922
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player"
			};
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x001DF732 File Offset: 0x001DD932
		public static EBlendAnimTarget[] GetValues()
		{
			return new EBlendAnimTarget[1];
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x001DF73A File Offset: 0x001DD93A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player"
			};
		}
	}
}
