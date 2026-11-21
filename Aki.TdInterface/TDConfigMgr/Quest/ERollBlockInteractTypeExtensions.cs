using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C6 RID: 5062
	public static class ERollBlockInteractTypeExtensions
	{
		// Token: 0x06007155 RID: 29013 RVA: 0x0010E878 File Offset: 0x0010CA78
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

		// Token: 0x06007156 RID: 29014 RVA: 0x0010E8C0 File Offset: 0x0010CAC0
		public static ERollBlockInteractType FromString(string name)
		{
			ERollBlockInteractType result;
			if (!ERollBlockInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERollBlockInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007157 RID: 29015 RVA: 0x0010E8EC File Offset: 0x0010CAEC
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

		// Token: 0x06007158 RID: 29016 RVA: 0x0010E942 File Offset: 0x0010CB42
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Normal",
				"Attack",
				"Trigger"
			};
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x0010E962 File Offset: 0x0010CB62
		public static ERollBlockInteractType[] GetValues()
		{
			return new ERollBlockInteractType[]
			{
				ERollBlockInteractType.Normal,
				ERollBlockInteractType.Attack,
				ERollBlockInteractType.Trigger
			};
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x0010E972 File Offset: 0x0010CB72
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
