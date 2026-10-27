using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000904 RID: 2308
	public static class EBuffProducerModeExtensions
	{
		// Token: 0x06003443 RID: 13379 RVA: 0x0008574C File Offset: 0x0008394C
		public static string ToEnumString(this EBuffProducerMode value)
		{
			string result;
			switch (value)
			{
			case EBuffProducerMode.Immediate:
				result = "Immediate";
				break;
			case EBuffProducerMode.Adsorb:
				result = "Adsorb";
				break;
			case EBuffProducerMode.FireBullet:
				result = "FireBullet";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x00085794 File Offset: 0x00083994
		public static EBuffProducerMode FromString(string name)
		{
			EBuffProducerMode result;
			if (!EBuffProducerModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBuffProducerMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x000857C0 File Offset: 0x000839C0
		public static bool TryFromString(string name, out EBuffProducerMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBuffProducerMode.Immediate;
				return false;
			}
			if (name == "Immediate")
			{
				value = EBuffProducerMode.Immediate;
				return true;
			}
			if (name == "Adsorb")
			{
				value = EBuffProducerMode.Adsorb;
				return true;
			}
			if (!(name == "FireBullet"))
			{
				value = EBuffProducerMode.Immediate;
				return false;
			}
			value = EBuffProducerMode.FireBullet;
			return true;
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00085816 File Offset: 0x00083A16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Immediate",
				"Adsorb",
				"FireBullet"
			};
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00085836 File Offset: 0x00083A36
		public static EBuffProducerMode[] GetValues()
		{
			return new EBuffProducerMode[]
			{
				EBuffProducerMode.Immediate,
				EBuffProducerMode.Adsorb,
				EBuffProducerMode.FireBullet
			};
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00085846 File Offset: 0x00083A46
		public static string[] GetNames()
		{
			return new string[]
			{
				"Immediate",
				"Adsorb",
				"FireBullet"
			};
		}
	}
}
