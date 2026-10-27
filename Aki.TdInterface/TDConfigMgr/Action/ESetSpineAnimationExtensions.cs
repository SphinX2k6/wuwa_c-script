using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240D RID: 9229
	public static class ESetSpineAnimationExtensions
	{
		// Token: 0x0600C8B9 RID: 51385 RVA: 0x001D5EAC File Offset: 0x001D40AC
		public static string ToEnumString(this ESetSpineAnimation value)
		{
			string result;
			if (value == ESetSpineAnimation.Play)
			{
				result = "Play";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C8BA RID: 51386 RVA: 0x001D5ED4 File Offset: 0x001D40D4
		public static ESetSpineAnimation FromString(string name)
		{
			ESetSpineAnimation result;
			if (!ESetSpineAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetSpineAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8BB RID: 51387 RVA: 0x001D5EFD File Offset: 0x001D40FD
		public static bool TryFromString(string name, out ESetSpineAnimation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetSpineAnimation.Play;
				return false;
			}
			if (name == "Play")
			{
				value = ESetSpineAnimation.Play;
				return true;
			}
			value = ESetSpineAnimation.Play;
			return false;
		}

		// Token: 0x0600C8BC RID: 51388 RVA: 0x001D5F22 File Offset: 0x001D4122
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play"
			};
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x001D5F32 File Offset: 0x001D4132
		public static ESetSpineAnimation[] GetValues()
		{
			return new ESetSpineAnimation[1];
		}

		// Token: 0x0600C8BE RID: 51390 RVA: 0x001D5F3A File Offset: 0x001D413A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play"
			};
		}
	}
}
