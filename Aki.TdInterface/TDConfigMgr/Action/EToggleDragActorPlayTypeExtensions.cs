using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002479 RID: 9337
	public static class EToggleDragActorPlayTypeExtensions
	{
		// Token: 0x0600CA9F RID: 51871 RVA: 0x001DD384 File Offset: 0x001DB584
		public static string ToEnumString(this EToggleDragActorPlayType value)
		{
			string result;
			if (value != EToggleDragActorPlayType.Enable)
			{
				if (value != EToggleDragActorPlayType.Disable)
				{
					result = value.ToString();
				}
				else
				{
					result = "Disable";
				}
			}
			else
			{
				result = "Enable";
			}
			return result;
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x001DD3BC File Offset: 0x001DB5BC
		public static EToggleDragActorPlayType FromString(string name)
		{
			EToggleDragActorPlayType result;
			if (!EToggleDragActorPlayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EToggleDragActorPlayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAA1 RID: 51873 RVA: 0x001DD3E5 File Offset: 0x001DB5E5
		public static bool TryFromString(string name, out EToggleDragActorPlayType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EToggleDragActorPlayType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = EToggleDragActorPlayType.Enable;
				return true;
			}
			if (!(name == "Disable"))
			{
				value = EToggleDragActorPlayType.Enable;
				return false;
			}
			value = EToggleDragActorPlayType.Disable;
			return true;
		}

		// Token: 0x0600CAA2 RID: 51874 RVA: 0x001DD41E File Offset: 0x001DB61E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600CAA3 RID: 51875 RVA: 0x001DD436 File Offset: 0x001DB636
		public static EToggleDragActorPlayType[] GetValues()
		{
			return new EToggleDragActorPlayType[]
			{
				EToggleDragActorPlayType.Enable,
				EToggleDragActorPlayType.Disable
			};
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x001DD442 File Offset: 0x001DB642
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}
	}
}
