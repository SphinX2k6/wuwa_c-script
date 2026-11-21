using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026D2 RID: 9938
	public static class EStopSceneItemMoveTypeExtensions
	{
		// Token: 0x0600D60B RID: 54795 RVA: 0x001F1AE0 File Offset: 0x001EFCE0
		public static string ToEnumString(this EStopSceneItemMoveType value)
		{
			string result;
			if (value != EStopSceneItemMoveType.StopAtCurrentPos)
			{
				if (value != EStopSceneItemMoveType.StopAtNextPos)
				{
					result = value.ToString();
				}
				else
				{
					result = "StopAtNextPos";
				}
			}
			else
			{
				result = "StopAtCurrentPos";
			}
			return result;
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x001F1B18 File Offset: 0x001EFD18
		public static EStopSceneItemMoveType FromString(string name)
		{
			EStopSceneItemMoveType result;
			if (!EStopSceneItemMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStopSceneItemMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x001F1B41 File Offset: 0x001EFD41
		public static bool TryFromString(string name, out EStopSceneItemMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EStopSceneItemMoveType.StopAtCurrentPos;
				return false;
			}
			if (name == "StopAtCurrentPos")
			{
				value = EStopSceneItemMoveType.StopAtCurrentPos;
				return true;
			}
			if (!(name == "StopAtNextPos"))
			{
				value = EStopSceneItemMoveType.StopAtCurrentPos;
				return false;
			}
			value = EStopSceneItemMoveType.StopAtNextPos;
			return true;
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x001F1B7A File Offset: 0x001EFD7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StopAtCurrentPos",
				"StopAtNextPos"
			};
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x001F1B92 File Offset: 0x001EFD92
		public static EStopSceneItemMoveType[] GetValues()
		{
			return new EStopSceneItemMoveType[]
			{
				EStopSceneItemMoveType.StopAtCurrentPos,
				EStopSceneItemMoveType.StopAtNextPos
			};
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x001F1B9E File Offset: 0x001EFD9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"StopAtCurrentPos",
				"StopAtNextPos"
			};
		}
	}
}
