using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E3 RID: 8931
	public static class EClientFollowShooterLeisureInteractTypeExtensions
	{
		// Token: 0x0600C37C RID: 50044 RVA: 0x001C8F60 File Offset: 0x001C7160
		public static string ToEnumString(this EClientFollowShooterLeisureInteractType value)
		{
			string result;
			if (value != EClientFollowShooterLeisureInteractType.ResetToPlayer)
			{
				if (value != EClientFollowShooterLeisureInteractType.PlayAnimation)
				{
					result = value.ToString();
				}
				else
				{
					result = "PlayAnimation";
				}
			}
			else
			{
				result = "ResetToPlayer";
			}
			return result;
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x001C8F98 File Offset: 0x001C7198
		public static EClientFollowShooterLeisureInteractType FromString(string name)
		{
			EClientFollowShooterLeisureInteractType result;
			if (!EClientFollowShooterLeisureInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientFollowShooterLeisureInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x001C8FC1 File Offset: 0x001C71C1
		public static bool TryFromString(string name, out EClientFollowShooterLeisureInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientFollowShooterLeisureInteractType.ResetToPlayer;
				return false;
			}
			if (name == "ResetToPlayer")
			{
				value = EClientFollowShooterLeisureInteractType.ResetToPlayer;
				return true;
			}
			if (!(name == "PlayAnimation"))
			{
				value = EClientFollowShooterLeisureInteractType.ResetToPlayer;
				return false;
			}
			value = EClientFollowShooterLeisureInteractType.PlayAnimation;
			return true;
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x001C8FFA File Offset: 0x001C71FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ResetToPlayer",
				"PlayAnimation"
			};
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x001C9012 File Offset: 0x001C7212
		public static EClientFollowShooterLeisureInteractType[] GetValues()
		{
			return new EClientFollowShooterLeisureInteractType[]
			{
				EClientFollowShooterLeisureInteractType.ResetToPlayer,
				EClientFollowShooterLeisureInteractType.PlayAnimation
			};
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x001C901E File Offset: 0x001C721E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ResetToPlayer",
				"PlayAnimation"
			};
		}
	}
}
