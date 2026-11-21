using System;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x0200014B RID: 331
	public static class EPackageExtensions
	{
		// Token: 0x06000BDB RID: 3035 RVA: 0x0003833C File Offset: 0x0003653C
		public static string ToEnumString(this EPackage value)
		{
			string result;
			switch (value)
			{
			case EPackage.Message:
				result = "M";
				break;
			case EPackage.Connect:
				result = "C";
				break;
			case EPackage.ConnectAck:
				result = "CA";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00038384 File Offset: 0x00036584
		public static EPackage FromString(string name)
		{
			EPackage result;
			if (!EPackageExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPackage 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000383B0 File Offset: 0x000365B0
		public static bool TryFromString(string name, out EPackage value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPackage.Message;
				return false;
			}
			if (name == "M")
			{
				value = EPackage.Message;
				return true;
			}
			if (name == "C")
			{
				value = EPackage.Connect;
				return true;
			}
			if (!(name == "CA"))
			{
				value = EPackage.Message;
				return false;
			}
			value = EPackage.ConnectAck;
			return true;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00038406 File Offset: 0x00036606
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"M",
				"C",
				"CA"
			};
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00038426 File Offset: 0x00036626
		public static EPackage[] GetValues()
		{
			return new EPackage[]
			{
				EPackage.Message,
				EPackage.Connect,
				EPackage.ConnectAck
			};
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x00038436 File Offset: 0x00036636
		public static string[] GetNames()
		{
			return new string[]
			{
				"Message",
				"Connect",
				"ConnectAck"
			};
		}
	}
}
