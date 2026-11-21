using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200271A RID: 10010
	public static class EToggleDragActorPlayTypeExtensions
	{
		// Token: 0x0600D74F RID: 55119 RVA: 0x001F7438 File Offset: 0x001F5638
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

		// Token: 0x0600D750 RID: 55120 RVA: 0x001F7470 File Offset: 0x001F5670
		public static EToggleDragActorPlayType FromString(string name)
		{
			EToggleDragActorPlayType result;
			if (!EToggleDragActorPlayTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EToggleDragActorPlayType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D751 RID: 55121 RVA: 0x001F7499 File Offset: 0x001F5699
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

		// Token: 0x0600D752 RID: 55122 RVA: 0x001F74D2 File Offset: 0x001F56D2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable"
			};
		}

		// Token: 0x0600D753 RID: 55123 RVA: 0x001F74EA File Offset: 0x001F56EA
		public static EToggleDragActorPlayType[] GetValues()
		{
			return new EToggleDragActorPlayType[]
			{
				EToggleDragActorPlayType.Enable,
				EToggleDragActorPlayType.Disable
			};
		}

		// Token: 0x0600D754 RID: 55124 RVA: 0x001F74F6 File Offset: 0x001F56F6
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
