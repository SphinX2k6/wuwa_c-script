using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002604 RID: 9732
	public static class EMainCharacterSkinExtensions
	{
		// Token: 0x0600D26C RID: 53868 RVA: 0x001E9744 File Offset: 0x001E7944
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

		// Token: 0x0600D26D RID: 53869 RVA: 0x001E976C File Offset: 0x001E796C
		public static EMainCharacterSkin FromString(string name)
		{
			EMainCharacterSkin result;
			if (!EMainCharacterSkinExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMainCharacterSkin 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x001E9795 File Offset: 0x001E7995
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

		// Token: 0x0600D26F RID: 53871 RVA: 0x001E97BA File Offset: 0x001E79BA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Uniform"
			};
		}

		// Token: 0x0600D270 RID: 53872 RVA: 0x001E97CA File Offset: 0x001E79CA
		public static EMainCharacterSkin[] GetValues()
		{
			return new EMainCharacterSkin[1];
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x001E97D2 File Offset: 0x001E79D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Uniform"
			};
		}
	}
}
