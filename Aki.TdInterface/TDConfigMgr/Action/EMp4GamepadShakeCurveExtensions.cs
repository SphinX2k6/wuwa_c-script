using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A7 RID: 9127
	public static class EMp4GamepadShakeCurveExtensions
	{
		// Token: 0x0600C6EE RID: 50926 RVA: 0x001D20FC File Offset: 0x001D02FC
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

		// Token: 0x0600C6EF RID: 50927 RVA: 0x001D2144 File Offset: 0x001D0344
		public static EMp4GamepadShakeCurve FromString(string name)
		{
			EMp4GamepadShakeCurve result;
			if (!EMp4GamepadShakeCurveExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMp4GamepadShakeCurve 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x001D2170 File Offset: 0x001D0370
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

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x001D21C6 File Offset: 0x001D03C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Linear",
				"Insine",
				"Outsine"
			};
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x001D21E6 File Offset: 0x001D03E6
		public static EMp4GamepadShakeCurve[] GetValues()
		{
			return new EMp4GamepadShakeCurve[]
			{
				EMp4GamepadShakeCurve.Linear,
				EMp4GamepadShakeCurve.InSine,
				EMp4GamepadShakeCurve.OutSine
			};
		}

		// Token: 0x0600C6F3 RID: 50931 RVA: 0x001D21F6 File Offset: 0x001D03F6
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
