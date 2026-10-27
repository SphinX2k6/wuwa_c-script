using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CC RID: 2508
	public static class EPetalGrabHandTypeExtensions
	{
		// Token: 0x060037C7 RID: 14279 RVA: 0x00090E0C File Offset: 0x0008F00C
		public static string ToEnumString(this EPetalGrabHandType value)
		{
			string result;
			switch (value)
			{
			case EPetalGrabHandType.LeftHand:
				result = "LeftHand";
				break;
			case EPetalGrabHandType.RightHand:
				result = "RightHand";
				break;
			case EPetalGrabHandType.BothHands:
				result = "BothHands";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00090E54 File Offset: 0x0008F054
		public static EPetalGrabHandType FromString(string name)
		{
			EPetalGrabHandType result;
			if (!EPetalGrabHandTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPetalGrabHandType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00090E80 File Offset: 0x0008F080
		public static bool TryFromString(string name, out EPetalGrabHandType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPetalGrabHandType.LeftHand;
				return false;
			}
			if (name == "LeftHand")
			{
				value = EPetalGrabHandType.LeftHand;
				return true;
			}
			if (name == "RightHand")
			{
				value = EPetalGrabHandType.RightHand;
				return true;
			}
			if (!(name == "BothHands"))
			{
				value = EPetalGrabHandType.LeftHand;
				return false;
			}
			value = EPetalGrabHandType.BothHands;
			return true;
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00090ED6 File Offset: 0x0008F0D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LeftHand",
				"RightHand",
				"BothHands"
			};
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x00090EF6 File Offset: 0x0008F0F6
		public static EPetalGrabHandType[] GetValues()
		{
			return new EPetalGrabHandType[]
			{
				EPetalGrabHandType.LeftHand,
				EPetalGrabHandType.RightHand,
				EPetalGrabHandType.BothHands
			};
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x00090F06 File Offset: 0x0008F106
		public static string[] GetNames()
		{
			return new string[]
			{
				"LeftHand",
				"RightHand",
				"BothHands"
			};
		}
	}
}
