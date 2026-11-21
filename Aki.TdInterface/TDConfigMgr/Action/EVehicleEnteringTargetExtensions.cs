using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200273E RID: 10046
	public static class EVehicleEnteringTargetExtensions
	{
		// Token: 0x0600D7F1 RID: 55281 RVA: 0x001F8C8C File Offset: 0x001F6E8C
		public static string ToEnumString(this EVehicleEnteringTarget value)
		{
			string result;
			if (value != EVehicleEnteringTarget.Player)
			{
				if (value != EVehicleEnteringTarget.Npc)
				{
					result = value.ToString();
				}
				else
				{
					result = "Npc";
				}
			}
			else
			{
				result = "Player";
			}
			return result;
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x001F8CC4 File Offset: 0x001F6EC4
		public static EVehicleEnteringTarget FromString(string name)
		{
			EVehicleEnteringTarget result;
			if (!EVehicleEnteringTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleEnteringTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7F3 RID: 55283 RVA: 0x001F8CED File Offset: 0x001F6EED
		public static bool TryFromString(string name, out EVehicleEnteringTarget value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVehicleEnteringTarget.Player;
				return false;
			}
			if (name == "Player")
			{
				value = EVehicleEnteringTarget.Player;
				return true;
			}
			if (!(name == "Npc"))
			{
				value = EVehicleEnteringTarget.Player;
				return false;
			}
			value = EVehicleEnteringTarget.Npc;
			return true;
		}

		// Token: 0x0600D7F4 RID: 55284 RVA: 0x001F8D26 File Offset: 0x001F6F26
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"Npc"
			};
		}

		// Token: 0x0600D7F5 RID: 55285 RVA: 0x001F8D3E File Offset: 0x001F6F3E
		public static EVehicleEnteringTarget[] GetValues()
		{
			return new EVehicleEnteringTarget[]
			{
				EVehicleEnteringTarget.Player,
				EVehicleEnteringTarget.Npc
			};
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x001F8D4A File Offset: 0x001F6F4A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"Npc"
			};
		}
	}
}
