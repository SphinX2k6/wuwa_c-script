using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA9 RID: 2729
	public static class EPullingFoundationExtensions
	{
		// Token: 0x06003C0B RID: 15371 RVA: 0x0009A44C File Offset: 0x0009864C
		public static string ToEnumString(this EPullingFoundation value)
		{
			string result;
			if (value == EPullingFoundation.CategoryMatching)
			{
				result = "CategoryMatching";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x0009A474 File Offset: 0x00098674
		public static EPullingFoundation FromString(string name)
		{
			EPullingFoundation result;
			if (!EPullingFoundationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPullingFoundation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x0009A49D File Offset: 0x0009869D
		public static bool TryFromString(string name, out EPullingFoundation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPullingFoundation.CategoryMatching;
				return false;
			}
			if (name == "CategoryMatching")
			{
				value = EPullingFoundation.CategoryMatching;
				return true;
			}
			value = EPullingFoundation.CategoryMatching;
			return false;
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x0009A4C2 File Offset: 0x000986C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CategoryMatching"
			};
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x0009A4D2 File Offset: 0x000986D2
		public static EPullingFoundation[] GetValues()
		{
			return new EPullingFoundation[1];
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x0009A4DA File Offset: 0x000986DA
		public static string[] GetNames()
		{
			return new string[]
			{
				"CategoryMatching"
			};
		}
	}
}
