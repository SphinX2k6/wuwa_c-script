using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025B2 RID: 9650
	public static class EFollowShooterLeisureInteractTypeExtensions
	{
		// Token: 0x0600D0FB RID: 53499 RVA: 0x001E46D0 File Offset: 0x001E28D0
		public static string ToEnumString(this EFollowShooterLeisureInteractType value)
		{
			string result;
			if (value != EFollowShooterLeisureInteractType.ResetToPlayer)
			{
				if (value != EFollowShooterLeisureInteractType.LeaveThrowInteractionPoint)
				{
					result = value.ToString();
				}
				else
				{
					result = "LeaveThrowInteractionPoint";
				}
			}
			else
			{
				result = "ResetToPlayer";
			}
			return result;
		}

		// Token: 0x0600D0FC RID: 53500 RVA: 0x001E4708 File Offset: 0x001E2908
		public static EFollowShooterLeisureInteractType FromString(string name)
		{
			EFollowShooterLeisureInteractType result;
			if (!EFollowShooterLeisureInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFollowShooterLeisureInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0FD RID: 53501 RVA: 0x001E4731 File Offset: 0x001E2931
		public static bool TryFromString(string name, out EFollowShooterLeisureInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFollowShooterLeisureInteractType.ResetToPlayer;
				return false;
			}
			if (name == "ResetToPlayer")
			{
				value = EFollowShooterLeisureInteractType.ResetToPlayer;
				return true;
			}
			if (!(name == "LeaveThrowInteractionPoint"))
			{
				value = EFollowShooterLeisureInteractType.ResetToPlayer;
				return false;
			}
			value = EFollowShooterLeisureInteractType.LeaveThrowInteractionPoint;
			return true;
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x001E476A File Offset: 0x001E296A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResetToPlayer",
				"LeaveThrowInteractionPoint"
			};
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x001E4782 File Offset: 0x001E2982
		public static EFollowShooterLeisureInteractType[] GetValues()
		{
			return new EFollowShooterLeisureInteractType[]
			{
				EFollowShooterLeisureInteractType.ResetToPlayer,
				EFollowShooterLeisureInteractType.LeaveThrowInteractionPoint
			};
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x001E478E File Offset: 0x001E298E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ResetToPlayer",
				"LeaveThrowInteractionPoint"
			};
		}
	}
}
