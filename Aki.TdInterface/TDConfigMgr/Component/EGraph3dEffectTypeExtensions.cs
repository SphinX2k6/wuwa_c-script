using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A05 RID: 2565
	public static class EGraph3dEffectTypeExtensions
	{
		// Token: 0x06003929 RID: 14633 RVA: 0x00093D6C File Offset: 0x00091F6C
		public static string ToEnumString(this EGraph3dEffectType value)
		{
			string result;
			if (value == EGraph3dEffectType.FireBoxFish)
			{
				result = "FireBoxFish";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00093D94 File Offset: 0x00091F94
		public static EGraph3dEffectType FromString(string name)
		{
			EGraph3dEffectType result;
			if (!EGraph3dEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGraph3dEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00093DBD File Offset: 0x00091FBD
		public static bool TryFromString(string name, out EGraph3dEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGraph3dEffectType.FireBoxFish;
				return false;
			}
			if (name == "FireBoxFish")
			{
				value = EGraph3dEffectType.FireBoxFish;
				return true;
			}
			value = EGraph3dEffectType.FireBoxFish;
			return false;
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00093DE2 File Offset: 0x00091FE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FireBoxFish"
			};
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00093DF2 File Offset: 0x00091FF2
		public static EGraph3dEffectType[] GetValues()
		{
			return new EGraph3dEffectType[1];
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x00093DFA File Offset: 0x00091FFA
		public static string[] GetNames()
		{
			return new string[]
			{
				"FireBoxFish"
			};
		}
	}
}
