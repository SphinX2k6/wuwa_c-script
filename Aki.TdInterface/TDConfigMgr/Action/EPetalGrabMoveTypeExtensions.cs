using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002652 RID: 9810
	public static class EPetalGrabMoveTypeExtensions
	{
		// Token: 0x0600D3CB RID: 54219 RVA: 0x001EC528 File Offset: 0x001EA728
		public static string ToEnumString(this EPetalGrabMoveType value)
		{
			string result;
			if (value == EPetalGrabMoveType.Linear)
			{
				result = "Linear";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D3CC RID: 54220 RVA: 0x001EC550 File Offset: 0x001EA750
		public static EPetalGrabMoveType FromString(string name)
		{
			EPetalGrabMoveType result;
			if (!EPetalGrabMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPetalGrabMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3CD RID: 54221 RVA: 0x001EC579 File Offset: 0x001EA779
		public static bool TryFromString(string name, out EPetalGrabMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPetalGrabMoveType.Linear;
				return false;
			}
			if (name == "Linear")
			{
				value = EPetalGrabMoveType.Linear;
				return true;
			}
			value = EPetalGrabMoveType.Linear;
			return false;
		}

		// Token: 0x0600D3CE RID: 54222 RVA: 0x001EC59E File Offset: 0x001EA79E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Linear"
			};
		}

		// Token: 0x0600D3CF RID: 54223 RVA: 0x001EC5AE File Offset: 0x001EA7AE
		public static EPetalGrabMoveType[] GetValues()
		{
			return new EPetalGrabMoveType[1];
		}

		// Token: 0x0600D3D0 RID: 54224 RVA: 0x001EC5B6 File Offset: 0x001EA7B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Linear"
			};
		}
	}
}
