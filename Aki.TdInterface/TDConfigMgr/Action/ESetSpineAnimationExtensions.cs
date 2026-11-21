using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026AC RID: 9900
	public static class ESetSpineAnimationExtensions
	{
		// Token: 0x0600D560 RID: 54624 RVA: 0x001EFAA8 File Offset: 0x001EDCA8
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

		// Token: 0x0600D561 RID: 54625 RVA: 0x001EFAD0 File Offset: 0x001EDCD0
		public static ESetSpineAnimation FromString(string name)
		{
			ESetSpineAnimation result;
			if (!ESetSpineAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetSpineAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x001EFAF9 File Offset: 0x001EDCF9
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

		// Token: 0x0600D563 RID: 54627 RVA: 0x001EFB1E File Offset: 0x001EDD1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play"
			};
		}

		// Token: 0x0600D564 RID: 54628 RVA: 0x001EFB2E File Offset: 0x001EDD2E
		public static ESetSpineAnimation[] GetValues()
		{
			return new ESetSpineAnimation[1];
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x001EFB36 File Offset: 0x001EDD36
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play"
			};
		}
	}
}
