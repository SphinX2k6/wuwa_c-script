using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AD RID: 2477
	public static class EBuffProducerModeExtensions
	{
		// Token: 0x0600379D RID: 14237 RVA: 0x0008CFBC File Offset: 0x0008B1BC
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

		// Token: 0x0600379E RID: 14238 RVA: 0x0008D004 File Offset: 0x0008B204
		public static EBuffProducerMode FromString(string name)
		{
			EBuffProducerMode result;
			if (!EBuffProducerModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBuffProducerMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0008D030 File Offset: 0x0008B230
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

		// Token: 0x060037A0 RID: 14240 RVA: 0x0008D086 File Offset: 0x0008B286
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Immediate",
				"Adsorb",
				"FireBullet"
			};
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0008D0A6 File Offset: 0x0008B2A6
		public static EBuffProducerMode[] GetValues()
		{
			return new EBuffProducerMode[]
			{
				EBuffProducerMode.Immediate,
				EBuffProducerMode.Adsorb,
				EBuffProducerMode.FireBullet
			};
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0008D0B6 File Offset: 0x0008B2B6
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
