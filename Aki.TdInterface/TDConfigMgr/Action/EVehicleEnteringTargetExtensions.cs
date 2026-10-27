using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249B RID: 9371
	public static class EVehicleEnteringTargetExtensions
	{
		// Token: 0x0600CB38 RID: 52024 RVA: 0x001DEAC4 File Offset: 0x001DCCC4
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

		// Token: 0x0600CB39 RID: 52025 RVA: 0x001DEAFC File Offset: 0x001DCCFC
		public static EVehicleEnteringTarget FromString(string name)
		{
			EVehicleEnteringTarget result;
			if (!EVehicleEnteringTargetExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleEnteringTarget 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x001DEB25 File Offset: 0x001DCD25
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

		// Token: 0x0600CB3B RID: 52027 RVA: 0x001DEB5E File Offset: 0x001DCD5E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"Npc"
			};
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x001DEB76 File Offset: 0x001DCD76
		public static EVehicleEnteringTarget[] GetValues()
		{
			return new EVehicleEnteringTarget[]
			{
				EVehicleEnteringTarget.Player,
				EVehicleEnteringTarget.Npc
			};
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x001DEB82 File Offset: 0x001DCD82
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
