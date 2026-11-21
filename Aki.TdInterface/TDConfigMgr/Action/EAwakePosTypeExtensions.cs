using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002524 RID: 9508
	public static class EAwakePosTypeExtensions
	{
		// Token: 0x0600CE7C RID: 52860 RVA: 0x001DF0D0 File Offset: 0x001DD2D0
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

		// Token: 0x0600CE7D RID: 52861 RVA: 0x001DF0F8 File Offset: 0x001DD2F8
		public static EAwakePosType FromString(string name)
		{
			EAwakePosType result;
			if (!EAwakePosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAwakePosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE7E RID: 52862 RVA: 0x001DF121 File Offset: 0x001DD321
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

		// Token: 0x0600CE7F RID: 52863 RVA: 0x001DF146 File Offset: 0x001DD346
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TransformVar"
			};
		}

		// Token: 0x0600CE80 RID: 52864 RVA: 0x001DF156 File Offset: 0x001DD356
		public static EAwakePosType[] GetValues()
		{
			return new EAwakePosType[1];
		}

		// Token: 0x0600CE81 RID: 52865 RVA: 0x001DF15E File Offset: 0x001DD35E
		public static string[] GetNames()
		{
			return new string[]
			{
				"TransformVar"
			};
		}
	}
}
