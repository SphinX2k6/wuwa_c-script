using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EF RID: 9199
	public static class EResetPosTypeExtensions
	{
		// Token: 0x0600C832 RID: 51250 RVA: 0x001D4E58 File Offset: 0x001D3058
		public static string ToEnumString(this EResetPosType value)
		{
			string result;
			if (value != EResetPosType.PosEntity)
			{
				if (value != EResetPosType.ResetPoint)
				{
					result = value.ToString();
				}
				else
				{
					result = "ResetPoint";
				}
			}
			else
			{
				result = "PosEntity";
			}
			return result;
		}

		// Token: 0x0600C833 RID: 51251 RVA: 0x001D4E90 File Offset: 0x001D3090
		public static EResetPosType FromString(string name)
		{
			EResetPosType result;
			if (!EResetPosTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPosType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C834 RID: 51252 RVA: 0x001D4EB9 File Offset: 0x001D30B9
		public static bool TryFromString(string name, out EResetPosType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetPosType.PosEntity;
				return false;
			}
			if (name == "PosEntity")
			{
				value = EResetPosType.PosEntity;
				return true;
			}
			if (!(name == "ResetPoint"))
			{
				value = EResetPosType.PosEntity;
				return false;
			}
			value = EResetPosType.ResetPoint;
			return true;
		}

		// Token: 0x0600C835 RID: 51253 RVA: 0x001D4EF2 File Offset: 0x001D30F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PosEntity",
				"ResetPoint"
			};
		}

		// Token: 0x0600C836 RID: 51254 RVA: 0x001D4F0A File Offset: 0x001D310A
		public static EResetPosType[] GetValues()
		{
			return new EResetPosType[]
			{
				EResetPosType.PosEntity,
				EResetPosType.ResetPoint
			};
		}

		// Token: 0x0600C837 RID: 51255 RVA: 0x001D4F16 File Offset: 0x001D3116
		public static string[] GetNames()
		{
			return new string[]
			{
				"PosEntity",
				"ResetPoint"
			};
		}
	}
}
