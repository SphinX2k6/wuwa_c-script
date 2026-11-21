using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001376 RID: 4982
	public static class EDetectTargetExtensions
	{
		// Token: 0x06006FED RID: 28653 RVA: 0x0010A8CC File Offset: 0x00108ACC
		public static string ToEnumString(this EDetectTarget value)
		{
			string result;
			if (value == EDetectTarget.ControlledRole)
			{
				result = "ControlledRole";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x0010A8F4 File Offset: 0x00108AF4
		public static EDetectTarget FromString(string name)
		{
			EDetectTarget result;
			if (!EDetectTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x0010A91D File Offset: 0x00108B1D
		public static bool TryFromString(string name, out EDetectTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDetectTarget.ControlledRole;
				return false;
			}
			if (name == "ControlledRole")
			{
				value = EDetectTarget.ControlledRole;
				return true;
			}
			value = EDetectTarget.ControlledRole;
			return false;
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x0010A942 File Offset: 0x00108B42
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ControlledRole"
			};
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x0010A952 File Offset: 0x00108B52
		public static EDetectTarget[] GetValues()
		{
			return new EDetectTarget[1];
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x0010A95A File Offset: 0x00108B5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ControlledRole"
			};
		}
	}
}
