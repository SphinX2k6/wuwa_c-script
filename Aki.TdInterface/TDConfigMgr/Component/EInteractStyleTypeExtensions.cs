using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097A RID: 2426
	public static class EInteractStyleTypeExtensions
	{
		// Token: 0x06003656 RID: 13910 RVA: 0x0008DAB8 File Offset: 0x0008BCB8
		public static string ToEnumString(this EInteractStyleType value)
		{
			string result;
			if (value != EInteractStyleType.Panorama)
			{
				if (value != EInteractStyleType.EntityPart)
				{
					result = value.ToString();
				}
				else
				{
					result = "EntityPart";
				}
			}
			else
			{
				result = "Panorama";
			}
			return result;
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0008DAF0 File Offset: 0x0008BCF0
		public static EInteractStyleType FromString(string name)
		{
			EInteractStyleType result;
			if (!EInteractStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0008DB19 File Offset: 0x0008BD19
		public static bool TryFromString(string name, out EInteractStyleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractStyleType.Panorama;
				return false;
			}
			if (name == "Panorama")
			{
				value = EInteractStyleType.Panorama;
				return true;
			}
			if (!(name == "EntityPart"))
			{
				value = EInteractStyleType.Panorama;
				return false;
			}
			value = EInteractStyleType.EntityPart;
			return true;
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x0008DB52 File Offset: 0x0008BD52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Panorama",
				"EntityPart"
			};
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0008DB6A File Offset: 0x0008BD6A
		public static EInteractStyleType[] GetValues()
		{
			return new EInteractStyleType[]
			{
				EInteractStyleType.Panorama,
				EInteractStyleType.EntityPart
			};
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0008DB76 File Offset: 0x0008BD76
		public static string[] GetNames()
		{
			return new string[]
			{
				"Panorama",
				"EntityPart"
			};
		}
	}
}
