using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F2 RID: 2546
	public static class ERenderFlagTypeExtensions
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x0009227C File Offset: 0x0009047C
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

		// Token: 0x06003873 RID: 14451 RVA: 0x000922E8 File Offset: 0x000904E8
		public static ERenderFlagType FromString(string name)
		{
			ERenderFlagType result;
			if (!ERenderFlagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERenderFlagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003874 RID: 14452 RVA: 0x00092314 File Offset: 0x00090514
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

		// Token: 0x06003875 RID: 14453 RVA: 0x000923A0 File Offset: 0x000905A0
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

		// Token: 0x06003876 RID: 14454 RVA: 0x000923D8 File Offset: 0x000905D8
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

		// Token: 0x06003877 RID: 14455 RVA: 0x000923EB File Offset: 0x000905EB
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
