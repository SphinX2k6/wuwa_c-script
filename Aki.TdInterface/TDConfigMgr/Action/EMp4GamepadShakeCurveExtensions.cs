using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002632 RID: 9778
	public static class EMp4GamepadShakeCurveExtensions
	{
		// Token: 0x0600D33B RID: 54075 RVA: 0x001EB29C File Offset: 0x001E949C
		public static string ToEnumString(this EMp4GamepadShakeCurve value)
		{
			string result;
			switch (value)
			{
			case EMp4GamepadShakeCurve.Linear:
				result = "Linear";
				break;
			case EMp4GamepadShakeCurve.InSine:
				result = "Insine";
				break;
			case EMp4GamepadShakeCurve.OutSine:
				result = "Outsine";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D33C RID: 54076 RVA: 0x001EB2E4 File Offset: 0x001E94E4
		public static EMp4GamepadShakeCurve FromString(string name)
		{
			EMp4GamepadShakeCurve result;
			if (!EMp4GamepadShakeCurveExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMp4GamepadShakeCurve 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x001EB310 File Offset: 0x001E9510
		public static bool TryFromString(string name, out EMp4GamepadShakeCurve value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMp4GamepadShakeCurve.Linear;
				return false;
			}
			if (name == "Linear")
			{
				value = EMp4GamepadShakeCurve.Linear;
				return true;
			}
			if (name == "Insine")
			{
				value = EMp4GamepadShakeCurve.InSine;
				return true;
			}
			if (!(name == "Outsine"))
			{
				value = EMp4GamepadShakeCurve.Linear;
				return false;
			}
			value = EMp4GamepadShakeCurve.OutSine;
			return true;
		}

		// Token: 0x0600D33E RID: 54078 RVA: 0x001EB366 File Offset: 0x001E9566
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Linear",
				"Insine",
				"Outsine"
			};
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x001EB386 File Offset: 0x001E9586
		public static EMp4GamepadShakeCurve[] GetValues()
		{
			return new EMp4GamepadShakeCurve[]
			{
				EMp4GamepadShakeCurve.Linear,
				EMp4GamepadShakeCurve.InSine,
				EMp4GamepadShakeCurve.OutSine
			};
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x001EB396 File Offset: 0x001E9596
		public static string[] GetNames()
		{
			return new string[]
			{
				"Linear",
				"InSine",
				"OutSine"
			};
		}
	}
}
