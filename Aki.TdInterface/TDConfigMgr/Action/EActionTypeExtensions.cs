using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002289 RID: 8841
	public static class EActionTypeExtensions
	{
		// Token: 0x0600C1E7 RID: 49639 RVA: 0x001C4F70 File Offset: 0x001C3170
		public static string ToEnumString(this EActionType value)
		{
			string result;
			switch (value)
			{
			case EActionType.Entity:
				result = "Entity";
				break;
			case EActionType.Flow:
				result = "Flow";
				break;
			case EActionType.Quest:
				result = "Quest";
				break;
			case EActionType.LevelPlay:
				result = "LevelPlay";
				break;
			case EActionType.Gm:
				result = "Gm";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x001C4FD0 File Offset: 0x001C31D0
		public static EActionType FromString(string name)
		{
			EActionType result;
			if (!EActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1E9 RID: 49641 RVA: 0x001C4FFC File Offset: 0x001C31FC
		public static bool TryFromString(string name, out EActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActionType.Entity;
				return false;
			}
			if (name == "Entity")
			{
				value = EActionType.Entity;
				return true;
			}
			if (name == "Flow")
			{
				value = EActionType.Flow;
				return true;
			}
			if (name == "Quest")
			{
				value = EActionType.Quest;
				return true;
			}
			if (name == "LevelPlay")
			{
				value = EActionType.LevelPlay;
				return true;
			}
			if (!(name == "Gm"))
			{
				value = EActionType.Entity;
				return false;
			}
			value = EActionType.Gm;
			return true;
		}

		// Token: 0x0600C1EA RID: 49642 RVA: 0x001C5076 File Offset: 0x001C3276
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Entity",
				"Flow",
				"Quest",
				"LevelPlay",
				"Gm"
			};
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x001C50A6 File Offset: 0x001C32A6
		public static EActionType[] GetValues()
		{
			return new EActionType[]
			{
				EActionType.Entity,
				EActionType.Flow,
				EActionType.Quest,
				EActionType.LevelPlay,
				EActionType.Gm
			};
		}

		// Token: 0x0600C1EC RID: 49644 RVA: 0x001C50B9 File Offset: 0x001C32B9
		public static string[] GetNames()
		{
			return new string[]
			{
				"Entity",
				"Flow",
				"Quest",
				"LevelPlay",
				"Gm"
			};
		}
	}
}
