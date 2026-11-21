using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A91 RID: 2705
	public static class EPetalGrabHandTypeExtensions
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x000996CC File Offset: 0x000978CC
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

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00099714 File Offset: 0x00097914
		public static EPetalGrabHandType FromString(string name)
		{
			EPetalGrabHandType result;
			if (!EPetalGrabHandTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPetalGrabHandType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00099740 File Offset: 0x00097940
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

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00099796 File Offset: 0x00097996
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LeftHand",
				"RightHand",
				"BothHands"
			};
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x000997B6 File Offset: 0x000979B6
		public static EPetalGrabHandType[] GetValues()
		{
			return new EPetalGrabHandType[]
			{
				EPetalGrabHandType.LeftHand,
				EPetalGrabHandType.RightHand,
				EPetalGrabHandType.BothHands
			};
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x000997C6 File Offset: 0x000979C6
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
