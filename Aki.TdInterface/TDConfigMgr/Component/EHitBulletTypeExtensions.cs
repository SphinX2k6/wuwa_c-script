using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A13 RID: 2579
	public static class EHitBulletTypeExtensions
	{
		// Token: 0x06003968 RID: 14696 RVA: 0x00094494 File Offset: 0x00092694
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

		// Token: 0x06003969 RID: 14697 RVA: 0x00094500 File Offset: 0x00092700
		public static EHitBulletType FromString(string name)
		{
			EHitBulletType result;
			if (!EHitBulletTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHitBulletType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x0009452C File Offset: 0x0009272C
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

		// Token: 0x0600396B RID: 14699 RVA: 0x000945B8 File Offset: 0x000927B8
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

		// Token: 0x0600396C RID: 14700 RVA: 0x000945F0 File Offset: 0x000927F0
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

		// Token: 0x0600396D RID: 14701 RVA: 0x00094603 File Offset: 0x00092803
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
