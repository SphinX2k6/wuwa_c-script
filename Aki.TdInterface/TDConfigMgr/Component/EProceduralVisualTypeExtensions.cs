using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA5 RID: 2725
	public static class EProceduralVisualTypeExtensions
	{
		// Token: 0x06003BF9 RID: 15353 RVA: 0x0009A180 File Offset: 0x00098380
		public static string ToEnumString(this EProceduralVisualType value)
		{
			string result;
			if (value != EProceduralVisualType.LookAt)
			{
				if (value != EProceduralVisualType.SearchlightRotate)
				{
					result = value.ToString();
				}
				else
				{
					result = "SearchlightRotate";
				}
			}
			else
			{
				result = "LookAt";
			}
			return result;
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x0009A1B8 File Offset: 0x000983B8
		public static EProceduralVisualType FromString(string name)
		{
			EProceduralVisualType result;
			if (!EProceduralVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProceduralVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BFB RID: 15355 RVA: 0x0009A1E1 File Offset: 0x000983E1
		public static bool TryFromString(string name, out EProceduralVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProceduralVisualType.LookAt;
				return false;
			}
			if (name == "LookAt")
			{
				value = EProceduralVisualType.LookAt;
				return true;
			}
			if (!(name == "SearchlightRotate"))
			{
				value = EProceduralVisualType.LookAt;
				return false;
			}
			value = EProceduralVisualType.SearchlightRotate;
			return true;
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x0009A21A File Offset: 0x0009841A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LookAt",
				"SearchlightRotate"
			};
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x0009A232 File Offset: 0x00098432
		public static EProceduralVisualType[] GetValues()
		{
			return new EProceduralVisualType[]
			{
				EProceduralVisualType.LookAt,
				EProceduralVisualType.SearchlightRotate
			};
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x0009A23E File Offset: 0x0009843E
		public static string[] GetNames()
		{
			return new string[]
			{
				"LookAt",
				"SearchlightRotate"
			};
		}
	}
}
