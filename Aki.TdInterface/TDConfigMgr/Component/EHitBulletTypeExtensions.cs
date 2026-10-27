using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000960 RID: 2400
	public static class EHitBulletTypeExtensions
	{
		// Token: 0x060035E1 RID: 13793 RVA: 0x0008C540 File Offset: 0x0008A740
		public static string ToEnumString(this EHitBulletType value)
		{
			string result;
			switch (value)
			{
			case EHitBulletType.OnlyDropAttack:
				result = "OnlyDropAttack";
				break;
			case EHitBulletType.CrystalAttack:
				result = "CrystalAttack";
				break;
			case EHitBulletType.PlayerAttack:
				result = "PlayerAttack";
				break;
			case EHitBulletType.FixedBulletId:
				result = "FixedBulletId";
				break;
			case EHitBulletType.AllCharacterAttack:
				result = "AllCharacterAttack";
				break;
			case EHitBulletType.PlayerOrThrenodianAttack:
				result = "PlayerOrThrenodianAttack";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0008C5AC File Offset: 0x0008A7AC
		public static EHitBulletType FromString(string name)
		{
			EHitBulletType result;
			if (!EHitBulletTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHitBulletType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		public static bool TryFromString(string name, out EHitBulletType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHitBulletType.OnlyDropAttack;
				return false;
			}
			if (name == "OnlyDropAttack")
			{
				value = EHitBulletType.OnlyDropAttack;
				return true;
			}
			if (name == "CrystalAttack")
			{
				value = EHitBulletType.CrystalAttack;
				return true;
			}
			if (name == "PlayerAttack")
			{
				value = EHitBulletType.PlayerAttack;
				return true;
			}
			if (name == "FixedBulletId")
			{
				value = EHitBulletType.FixedBulletId;
				return true;
			}
			if (name == "AllCharacterAttack")
			{
				value = EHitBulletType.AllCharacterAttack;
				return true;
			}
			if (!(name == "PlayerOrThrenodianAttack"))
			{
				value = EHitBulletType.OnlyDropAttack;
				return false;
			}
			value = EHitBulletType.PlayerOrThrenodianAttack;
			return true;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0008C664 File Offset: 0x0008A864
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnlyDropAttack",
				"CrystalAttack",
				"PlayerAttack",
				"FixedBulletId",
				"AllCharacterAttack",
				"PlayerOrThrenodianAttack"
			};
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0008C69C File Offset: 0x0008A89C
		public static EHitBulletType[] GetValues()
		{
			return new EHitBulletType[]
			{
				EHitBulletType.OnlyDropAttack,
				EHitBulletType.CrystalAttack,
				EHitBulletType.PlayerAttack,
				EHitBulletType.FixedBulletId,
				EHitBulletType.AllCharacterAttack,
				EHitBulletType.PlayerOrThrenodianAttack
			};
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0008C6AF File Offset: 0x0008A8AF
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnlyDropAttack",
				"CrystalAttack",
				"PlayerAttack",
				"FixedBulletId",
				"AllCharacterAttack",
				"PlayerOrThrenodianAttack"
			};
		}
	}
}
