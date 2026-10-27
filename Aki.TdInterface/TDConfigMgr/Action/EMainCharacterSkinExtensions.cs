using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237B RID: 9083
	public static class EMainCharacterSkinExtensions
	{
		// Token: 0x0600C628 RID: 50728 RVA: 0x001D0770 File Offset: 0x001CE970
		public static string ToEnumString(this EMainCharacterSkin value)
		{
			string result;
			if (value == EMainCharacterSkin.Uniform)
			{
				result = "Uniform";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x001D0798 File Offset: 0x001CE998
		public static EMainCharacterSkin FromString(string name)
		{
			EMainCharacterSkin result;
			if (!EMainCharacterSkinExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMainCharacterSkin 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C62A RID: 50730 RVA: 0x001D07C1 File Offset: 0x001CE9C1
		public static bool TryFromString(string name, out EMainCharacterSkin value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMainCharacterSkin.Uniform;
				return false;
			}
			if (name == "Uniform")
			{
				value = EMainCharacterSkin.Uniform;
				return true;
			}
			value = EMainCharacterSkin.Uniform;
			return false;
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x001D07E6 File Offset: 0x001CE9E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Uniform"
			};
		}

		// Token: 0x0600C62C RID: 50732 RVA: 0x001D07F6 File Offset: 0x001CE9F6
		public static EMainCharacterSkin[] GetValues()
		{
			return new EMainCharacterSkin[1];
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x001D07FE File Offset: 0x001CE9FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Uniform"
			};
		}
	}
}
