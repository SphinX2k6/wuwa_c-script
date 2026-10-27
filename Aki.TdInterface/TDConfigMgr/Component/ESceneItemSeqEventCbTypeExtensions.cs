using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A02 RID: 2562
	public static class ESceneItemSeqEventCbTypeExtensions
	{
		// Token: 0x060038BA RID: 14522 RVA: 0x00092B80 File Offset: 0x00090D80
		public static string ToEnumString(this ESceneItemSeqEventCbType value)
		{
			string result;
			if (value != ESceneItemSeqEventCbType.ANS)
			{
				if (value != ESceneItemSeqEventCbType.AN)
				{
					result = value.ToString();
				}
				else
				{
					result = "AN";
				}
			}
			else
			{
				result = "ANS";
			}
			return result;
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00092BB8 File Offset: 0x00090DB8
		public static ESceneItemSeqEventCbType FromString(string name)
		{
			ESceneItemSeqEventCbType result;
			if (!ESceneItemSeqEventCbTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneItemSeqEventCbType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x00092BE1 File Offset: 0x00090DE1
		public static bool TryFromString(string name, out ESceneItemSeqEventCbType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneItemSeqEventCbType.ANS;
				return false;
			}
			if (name == "ANS")
			{
				value = ESceneItemSeqEventCbType.ANS;
				return true;
			}
			if (!(name == "AN"))
			{
				value = ESceneItemSeqEventCbType.ANS;
				return false;
			}
			value = ESceneItemSeqEventCbType.AN;
			return true;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00092C1A File Offset: 0x00090E1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ANS",
				"AN"
			};
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x00092C32 File Offset: 0x00090E32
		public static ESceneItemSeqEventCbType[] GetValues()
		{
			return new ESceneItemSeqEventCbType[]
			{
				ESceneItemSeqEventCbType.ANS,
				ESceneItemSeqEventCbType.AN
			};
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x00092C3E File Offset: 0x00090E3E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ANS",
				"AN"
			};
		}
	}
}
