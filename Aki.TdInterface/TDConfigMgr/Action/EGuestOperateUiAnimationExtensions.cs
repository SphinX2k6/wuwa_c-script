using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C0 RID: 9664
	public static class EGuestOperateUiAnimationExtensions
	{
		// Token: 0x0600D13A RID: 53562 RVA: 0x001E4FF4 File Offset: 0x001E31F4
		public static string ToEnumString(this EGuestOperateUiAnimation value)
		{
			string result;
			if (value != EGuestOperateUiAnimation.Play)
			{
				if (value != EGuestOperateUiAnimation.Stop)
				{
					result = value.ToString();
				}
				else
				{
					result = "Stop";
				}
			}
			else
			{
				result = "Play";
			}
			return result;
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x001E502C File Offset: 0x001E322C
		public static EGuestOperateUiAnimation FromString(string name)
		{
			EGuestOperateUiAnimation result;
			if (!EGuestOperateUiAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuestOperateUiAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D13C RID: 53564 RVA: 0x001E5055 File Offset: 0x001E3255
		public static bool TryFromString(string name, out EGuestOperateUiAnimation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGuestOperateUiAnimation.Play;
				return false;
			}
			if (name == "Play")
			{
				value = EGuestOperateUiAnimation.Play;
				return true;
			}
			if (!(name == "Stop"))
			{
				value = EGuestOperateUiAnimation.Play;
				return false;
			}
			value = EGuestOperateUiAnimation.Stop;
			return true;
		}

		// Token: 0x0600D13D RID: 53565 RVA: 0x001E508E File Offset: 0x001E328E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600D13E RID: 53566 RVA: 0x001E50A6 File Offset: 0x001E32A6
		public static EGuestOperateUiAnimation[] GetValues()
		{
			return new EGuestOperateUiAnimation[]
			{
				EGuestOperateUiAnimation.Play,
				EGuestOperateUiAnimation.Stop
			};
		}

		// Token: 0x0600D13F RID: 53567 RVA: 0x001E50B2 File Offset: 0x001E32B2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}
	}
}
