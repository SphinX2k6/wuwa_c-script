using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001286 RID: 4742
	public static class ERollBlockInteractTypeExtensions
	{
		// Token: 0x06006B02 RID: 27394 RVA: 0x00100B7C File Offset: 0x000FED7C
		public static string ToEnumString(this ERollBlockInteractType value)
		{
			string result;
			switch (value)
			{
			case ERollBlockInteractType.Normal:
				result = "Normal";
				break;
			case ERollBlockInteractType.Attack:
				result = "Attack";
				break;
			case ERollBlockInteractType.Trigger:
				result = "Trigger";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00100BC4 File Offset: 0x000FEDC4
		public static ERollBlockInteractType FromString(string name)
		{
			ERollBlockInteractType result;
			if (!ERollBlockInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERollBlockInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00100BF0 File Offset: 0x000FEDF0
		public static bool TryFromString(string name, out ERollBlockInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERollBlockInteractType.Normal;
				return false;
			}
			if (name == "Normal")
			{
				value = ERollBlockInteractType.Normal;
				return true;
			}
			if (name == "Attack")
			{
				value = ERollBlockInteractType.Attack;
				return true;
			}
			if (!(name == "Trigger"))
			{
				value = ERollBlockInteractType.Normal;
				return false;
			}
			value = ERollBlockInteractType.Trigger;
			return true;
		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00100C46 File Offset: 0x000FEE46
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Attack",
				"Trigger"
			};
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x00100C66 File Offset: 0x000FEE66
		public static ERollBlockInteractType[] GetValues()
		{
			return new ERollBlockInteractType[]
			{
				ERollBlockInteractType.Normal,
				ERollBlockInteractType.Attack,
				ERollBlockInteractType.Trigger
			};
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x00100C76 File Offset: 0x000FEE76
		public static string[] GetNames()
		{
			return new string[]
			{
				"Normal",
				"Attack",
				"Trigger"
			};
		}
	}
}
