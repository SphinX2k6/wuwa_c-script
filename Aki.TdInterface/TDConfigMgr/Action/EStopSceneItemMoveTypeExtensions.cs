using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002431 RID: 9265
	public static class EStopSceneItemMoveTypeExtensions
	{
		// Token: 0x0600C95B RID: 51547 RVA: 0x001D7C18 File Offset: 0x001D5E18
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

		// Token: 0x0600C95C RID: 51548 RVA: 0x001D7C50 File Offset: 0x001D5E50
		public static EStopSceneItemMoveType FromString(string name)
		{
			EStopSceneItemMoveType result;
			if (!EStopSceneItemMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStopSceneItemMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C95D RID: 51549 RVA: 0x001D7C79 File Offset: 0x001D5E79
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

		// Token: 0x0600C95E RID: 51550 RVA: 0x001D7CB2 File Offset: 0x001D5EB2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StopAtCurrentPos",
				"StopAtNextPos"
			};
		}

		// Token: 0x0600C95F RID: 51551 RVA: 0x001D7CCA File Offset: 0x001D5ECA
		public static EStopSceneItemMoveType[] GetValues()
		{
			return new EStopSceneItemMoveType[]
			{
				EStopSceneItemMoveType.StopAtCurrentPos,
				EStopSceneItemMoveType.StopAtNextPos
			};
		}

		// Token: 0x0600C960 RID: 51552 RVA: 0x001D7CD6 File Offset: 0x001D5ED6
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
