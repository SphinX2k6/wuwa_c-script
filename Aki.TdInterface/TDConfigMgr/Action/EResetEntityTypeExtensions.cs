using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002682 RID: 9858
	public static class EResetEntityTypeExtensions
	{
		// Token: 0x0600D4A3 RID: 54435 RVA: 0x001EE3DC File Offset: 0x001EC5DC
		public static string ToEnumString(this EResetEntityType value)
		{
			string result;
			if (value != EResetEntityType.TeleControl)
			{
				if (value != EResetEntityType.JigsawItem)
				{
					result = value.ToString();
				}
				else
				{
					result = "JigsawItem";
				}
			}
			else
			{
				result = "TeleControl";
			}
			return result;
		}

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x001EE414 File Offset: 0x001EC614
		public static EResetEntityType FromString(string name)
		{
			EResetEntityType result;
			if (!EResetEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x001EE43D File Offset: 0x001EC63D
		public static bool TryFromString(string name, out EResetEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetEntityType.TeleControl;
				return false;
			}
			if (name == "TeleControl")
			{
				value = EResetEntityType.TeleControl;
				return true;
			}
			if (!(name == "JigsawItem"))
			{
				value = EResetEntityType.TeleControl;
				return false;
			}
			value = EResetEntityType.JigsawItem;
			return true;
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x001EE476 File Offset: 0x001EC676
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleControl",
				"JigsawItem"
			};
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x001EE48E File Offset: 0x001EC68E
		public static EResetEntityType[] GetValues()
		{
			return new EResetEntityType[]
			{
				EResetEntityType.TeleControl,
				EResetEntityType.JigsawItem
			};
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x001EE49A File Offset: 0x001EC69A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TeleControl",
				"JigsawItem"
			};
		}
	}
}
