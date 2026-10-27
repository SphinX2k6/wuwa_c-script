using System;

namespace CSharpScript.Core.Define.TdConfigExtensions
{
	// Token: 0x02000147 RID: 327
	public static class EPackageExtensions
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0003776C File Offset: 0x0003596C
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

		// Token: 0x06000B80 RID: 2944 RVA: 0x000377B4 File Offset: 0x000359B4
		public static EPackage FromString(string name)
		{
			EPackage result;
			if (!EPackageExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPackage 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x000377E0 File Offset: 0x000359E0
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

		// Token: 0x06000B82 RID: 2946 RVA: 0x00037836 File Offset: 0x00035A36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"M",
				"C",
				"CA"
			};
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00037856 File Offset: 0x00035A56
		public static EPackage[] GetValues()
		{
			return new EPackage[]
			{
				EPackage.Message,
				EPackage.Connect,
				EPackage.ConnectAck
			};
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00037866 File Offset: 0x00035A66
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
