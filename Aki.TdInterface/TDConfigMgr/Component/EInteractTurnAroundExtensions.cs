using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097C RID: 2428
	public static class EInteractTurnAroundExtensions
	{
		// Token: 0x0600365F RID: 13919 RVA: 0x0008DBCC File Offset: 0x0008BDCC
		public static string ToEnumString(this EInteractTurnAround value)
		{
			string result;
			switch (value)
			{
			case EInteractTurnAround.FaceEachOther:
				result = "FaceEachOther";
				break;
			case EInteractTurnAround.FaceEachOtherWithRecoveryImmediately:
				result = "FaceEachOtherWithRecoveryImmediately";
				break;
			case EInteractTurnAround.PlayerTurnToInteractor:
				result = "PlayerTurnToInteractor";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0008DC14 File Offset: 0x0008BE14
		public static EInteractTurnAround FromString(string name)
		{
			EInteractTurnAround result;
			if (!EInteractTurnAroundExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractTurnAround 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x0008DC40 File Offset: 0x0008BE40
		public static bool TryFromString(string name, out EInteractTurnAround value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractTurnAround.FaceEachOther;
				return false;
			}
			if (name == "FaceEachOther")
			{
				value = EInteractTurnAround.FaceEachOther;
				return true;
			}
			if (name == "FaceEachOtherWithRecoveryImmediately")
			{
				value = EInteractTurnAround.FaceEachOtherWithRecoveryImmediately;
				return true;
			}
			if (!(name == "PlayerTurnToInteractor"))
			{
				value = EInteractTurnAround.FaceEachOther;
				return false;
			}
			value = EInteractTurnAround.PlayerTurnToInteractor;
			return true;
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0008DC96 File Offset: 0x0008BE96
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FaceEachOther",
				"FaceEachOtherWithRecoveryImmediately",
				"PlayerTurnToInteractor"
			};
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0008DCB6 File Offset: 0x0008BEB6
		public static EInteractTurnAround[] GetValues()
		{
			return new EInteractTurnAround[]
			{
				EInteractTurnAround.FaceEachOther,
				EInteractTurnAround.FaceEachOtherWithRecoveryImmediately,
				EInteractTurnAround.PlayerTurnToInteractor
			};
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0008DCC6 File Offset: 0x0008BEC6
		public static string[] GetNames()
		{
			return new string[]
			{
				"FaceEachOther",
				"FaceEachOtherWithRecoveryImmediately",
				"PlayerTurnToInteractor"
			};
		}
	}
}
