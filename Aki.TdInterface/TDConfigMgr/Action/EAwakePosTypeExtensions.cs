using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B5 RID: 8885
	public static class EAwakePosTypeExtensions
	{
		// Token: 0x0600C2AD RID: 49837 RVA: 0x001C72C8 File Offset: 0x001C54C8
		public static string ToEnumString(this EAwakePosType value)
		{
			string result;
			if (value == EAwakePosType.TransformVar)
			{
				result = "TransformVar";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C2AE RID: 49838 RVA: 0x001C72F0 File Offset: 0x001C54F0
		public static EAwakePosType FromString(string name)
		{
			EAwakePosType result;
			if (!EAwakePosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAwakePosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x001C7319 File Offset: 0x001C5519
		public static bool TryFromString(string name, out EAwakePosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAwakePosType.TransformVar;
				return false;
			}
			if (name == "TransformVar")
			{
				value = EAwakePosType.TransformVar;
				return true;
			}
			value = EAwakePosType.TransformVar;
			return false;
		}

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x001C733E File Offset: 0x001C553E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TransformVar"
			};
		}

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x001C734E File Offset: 0x001C554E
		public static EAwakePosType[] GetValues()
		{
			return new EAwakePosType[1];
		}

		// Token: 0x0600C2B2 RID: 49842 RVA: 0x001C7356 File Offset: 0x001C5556
		public static string[] GetNames()
		{
			return new string[]
			{
				"TransformVar"
			};
		}
	}
}
