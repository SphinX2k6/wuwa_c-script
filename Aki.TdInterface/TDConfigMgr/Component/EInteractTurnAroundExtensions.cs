using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2F RID: 2607
	public static class EInteractTurnAroundExtensions
	{
		// Token: 0x060039E6 RID: 14822 RVA: 0x00095B38 File Offset: 0x00093D38
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

		// Token: 0x060039E7 RID: 14823 RVA: 0x00095B80 File Offset: 0x00093D80
		public static EInteractTurnAround FromString(string name)
		{
			EInteractTurnAround result;
			if (!EInteractTurnAroundExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractTurnAround 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x00095BAC File Offset: 0x00093DAC
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

		// Token: 0x060039E9 RID: 14825 RVA: 0x00095C02 File Offset: 0x00093E02
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FaceEachOther",
				"FaceEachOtherWithRecoveryImmediately",
				"PlayerTurnToInteractor"
			};
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00095C22 File Offset: 0x00093E22
		public static EInteractTurnAround[] GetValues()
		{
			return new EInteractTurnAround[]
			{
				EInteractTurnAround.FaceEachOther,
				EInteractTurnAround.FaceEachOtherWithRecoveryImmediately,
				EInteractTurnAround.PlayerTurnToInteractor
			};
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x00095C32 File Offset: 0x00093E32
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
