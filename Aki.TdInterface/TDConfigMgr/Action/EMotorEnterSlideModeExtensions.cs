using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238F RID: 9103
	public static class EMotorEnterSlideModeExtensions
	{
		// Token: 0x0600C682 RID: 50818 RVA: 0x001D1348 File Offset: 0x001CF548
		public static string ToEnumString(this EMotorEnterSlideMode value)
		{
			string result;
			if (value != EMotorEnterSlideMode.Jump)
			{
				if (value != EMotorEnterSlideMode.Direct)
				{
					result = value.ToString();
				}
				else
				{
					result = "Direct";
				}
			}
			else
			{
				result = "Jump";
			}
			return result;
		}

		// Token: 0x0600C683 RID: 50819 RVA: 0x001D1380 File Offset: 0x001CF580
		public static EMotorEnterSlideMode FromString(string name)
		{
			EMotorEnterSlideMode result;
			if (!EMotorEnterSlideModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorEnterSlideMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C684 RID: 50820 RVA: 0x001D13A9 File Offset: 0x001CF5A9
		public static bool TryFromString(string name, out EMotorEnterSlideMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorEnterSlideMode.Jump;
				return false;
			}
			if (name == "Jump")
			{
				value = EMotorEnterSlideMode.Jump;
				return true;
			}
			if (!(name == "Direct"))
			{
				value = EMotorEnterSlideMode.Jump;
				return false;
			}
			value = EMotorEnterSlideMode.Direct;
			return true;
		}

		// Token: 0x0600C685 RID: 50821 RVA: 0x001D13E2 File Offset: 0x001CF5E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Jump",
				"Direct"
			};
		}

		// Token: 0x0600C686 RID: 50822 RVA: 0x001D13FA File Offset: 0x001CF5FA
		public static EMotorEnterSlideMode[] GetValues()
		{
			return new EMotorEnterSlideMode[]
			{
				EMotorEnterSlideMode.Jump,
				EMotorEnterSlideMode.Direct
			};
		}

		// Token: 0x0600C687 RID: 50823 RVA: 0x001D1406 File Offset: 0x001CF606
		public static string[] GetNames()
		{
			return new string[]
			{
				"Jump",
				"Direct"
			};
		}
	}
}
