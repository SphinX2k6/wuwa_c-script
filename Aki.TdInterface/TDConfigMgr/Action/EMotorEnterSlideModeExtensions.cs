using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002618 RID: 9752
	public static class EMotorEnterSlideModeExtensions
	{
		// Token: 0x0600D2C6 RID: 53958 RVA: 0x001EA31C File Offset: 0x001E851C
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

		// Token: 0x0600D2C7 RID: 53959 RVA: 0x001EA354 File Offset: 0x001E8554
		public static EMotorEnterSlideMode FromString(string name)
		{
			EMotorEnterSlideMode result;
			if (!EMotorEnterSlideModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorEnterSlideMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2C8 RID: 53960 RVA: 0x001EA37D File Offset: 0x001E857D
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

		// Token: 0x0600D2C9 RID: 53961 RVA: 0x001EA3B6 File Offset: 0x001E85B6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Jump",
				"Direct"
			};
		}

		// Token: 0x0600D2CA RID: 53962 RVA: 0x001EA3CE File Offset: 0x001E85CE
		public static EMotorEnterSlideMode[] GetValues()
		{
			return new EMotorEnterSlideMode[]
			{
				EMotorEnterSlideMode.Jump,
				EMotorEnterSlideMode.Direct
			};
		}

		// Token: 0x0600D2CB RID: 53963 RVA: 0x001EA3DA File Offset: 0x001E85DA
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
