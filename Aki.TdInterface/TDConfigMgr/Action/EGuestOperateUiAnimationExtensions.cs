using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234D RID: 9037
	public static class EGuestOperateUiAnimationExtensions
	{
		// Token: 0x0600C559 RID: 50521 RVA: 0x001CCE28 File Offset: 0x001CB028
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

		// Token: 0x0600C55A RID: 50522 RVA: 0x001CCE60 File Offset: 0x001CB060
		public static EGuestOperateUiAnimation FromString(string name)
		{
			EGuestOperateUiAnimation result;
			if (!EGuestOperateUiAnimationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuestOperateUiAnimation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C55B RID: 50523 RVA: 0x001CCE89 File Offset: 0x001CB089
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

		// Token: 0x0600C55C RID: 50524 RVA: 0x001CCEC2 File Offset: 0x001CB0C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600C55D RID: 50525 RVA: 0x001CCEDA File Offset: 0x001CB0DA
		public static EGuestOperateUiAnimation[] GetValues()
		{
			return new EGuestOperateUiAnimation[]
			{
				EGuestOperateUiAnimation.Play,
				EGuestOperateUiAnimation.Stop
			};
		}

		// Token: 0x0600C55E RID: 50526 RVA: 0x001CCEE6 File Offset: 0x001CB0E6
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
