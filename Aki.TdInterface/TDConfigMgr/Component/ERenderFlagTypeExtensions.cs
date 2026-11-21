using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB7 RID: 2743
	public static class ERenderFlagTypeExtensions
	{
		// Token: 0x06003C4A RID: 15434 RVA: 0x0009AB3C File Offset: 0x00098D3C
		public static string ToEnumString(this ERenderFlagType value)
		{
			string result;
			switch (value)
			{
			case ERenderFlagType.Fog:
				result = "Fog";
				break;
			case ERenderFlagType.Atmosphere:
				result = "Atmosphere";
				break;
			case ERenderFlagType.InstancedFoliage:
				result = "InstancedFoliage";
				break;
			case ERenderFlagType.InstancedGrass:
				result = "InstancedGrass";
				break;
			case ERenderFlagType.VolumetricFog:
				result = "VolumetricFog";
				break;
			case ERenderFlagType.PostProcessing:
				result = "PostProcessing";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x0009ABA8 File Offset: 0x00098DA8
		public static ERenderFlagType FromString(string name)
		{
			ERenderFlagType result;
			if (!ERenderFlagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERenderFlagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x0009ABD4 File Offset: 0x00098DD4
		public static bool TryFromString(string name, out ERenderFlagType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERenderFlagType.Fog;
				return false;
			}
			if (name == "Fog")
			{
				value = ERenderFlagType.Fog;
				return true;
			}
			if (name == "Atmosphere")
			{
				value = ERenderFlagType.Atmosphere;
				return true;
			}
			if (name == "InstancedFoliage")
			{
				value = ERenderFlagType.InstancedFoliage;
				return true;
			}
			if (name == "InstancedGrass")
			{
				value = ERenderFlagType.InstancedGrass;
				return true;
			}
			if (name == "VolumetricFog")
			{
				value = ERenderFlagType.VolumetricFog;
				return true;
			}
			if (!(name == "PostProcessing"))
			{
				value = ERenderFlagType.Fog;
				return false;
			}
			value = ERenderFlagType.PostProcessing;
			return true;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x0009AC60 File Offset: 0x00098E60
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fog",
				"Atmosphere",
				"InstancedFoliage",
				"InstancedGrass",
				"VolumetricFog",
				"PostProcessing"
			};
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x0009AC98 File Offset: 0x00098E98
		public static ERenderFlagType[] GetValues()
		{
			return new ERenderFlagType[]
			{
				ERenderFlagType.Fog,
				ERenderFlagType.Atmosphere,
				ERenderFlagType.InstancedFoliage,
				ERenderFlagType.InstancedGrass,
				ERenderFlagType.VolumetricFog,
				ERenderFlagType.PostProcessing
			};
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x0009ACAB File Offset: 0x00098EAB
		public static string[] GetNames()
		{
			return new string[]
			{
				"Fog",
				"Atmosphere",
				"InstancedFoliage",
				"InstancedGrass",
				"VolumetricFog",
				"PostProcessing"
			};
		}
	}
}
