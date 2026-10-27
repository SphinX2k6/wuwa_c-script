using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200602B RID: 24619
	public static class EComboBgTexturePathExtensions
	{
		// Token: 0x0603E4F7 RID: 255223 RVA: 0x00F0C884 File Offset: 0x00F0AA84
		public static string ToEnumString(this EComboBgTexturePath value)
		{
			string result;
			switch (value)
			{
			case EComboBgTexturePath.Good:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGoodBg.T_FloatGoodBg";
				break;
			case EComboBgTexturePath.Great:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreatBg.T_FloatGreatBg";
				break;
			case EComboBgTexturePath.Excellent:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellentBg.T_FloatExcellentBg";
				break;
			case EComboBgTexturePath.Unbelievable:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievableBg.T_FloatUnbelievableBg";
				break;
			case EComboBgTexturePath.Combo:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatComboBg.T_FloatComboBg";
				break;
			case EComboBgTexturePath.Default:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatDefaultBg.T_FloatDefaultBg";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0603E4F8 RID: 255224 RVA: 0x00F0C8F0 File Offset: 0x00F0AAF0
		public static EComboBgTexturePath FromString(string name)
		{
			EComboBgTexturePath result;
			if (!EComboBgTexturePathExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboBgTexturePath 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603E4F9 RID: 255225 RVA: 0x00F0C91C File Offset: 0x00F0AB1C
		public static bool TryFromString(string name, out EComboBgTexturePath value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EComboBgTexturePath.Good;
				return false;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGoodBg.T_FloatGoodBg")
			{
				value = EComboBgTexturePath.Good;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreatBg.T_FloatGreatBg")
			{
				value = EComboBgTexturePath.Great;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellentBg.T_FloatExcellentBg")
			{
				value = EComboBgTexturePath.Excellent;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievableBg.T_FloatUnbelievableBg")
			{
				value = EComboBgTexturePath.Unbelievable;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatComboBg.T_FloatComboBg")
			{
				value = EComboBgTexturePath.Combo;
				return true;
			}
			if (!(name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatDefaultBg.T_FloatDefaultBg"))
			{
				value = EComboBgTexturePath.Good;
				return false;
			}
			value = EComboBgTexturePath.Default;
			return true;
		}

		// Token: 0x0603E4FA RID: 255226 RVA: 0x00F0C9A8 File Offset: 0x00F0ABA8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGoodBg.T_FloatGoodBg",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreatBg.T_FloatGreatBg",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellentBg.T_FloatExcellentBg",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievableBg.T_FloatUnbelievableBg",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatComboBg.T_FloatComboBg",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatDefaultBg.T_FloatDefaultBg"
			};
		}

		// Token: 0x0603E4FB RID: 255227 RVA: 0x00F0C9E0 File Offset: 0x00F0ABE0
		public static EComboBgTexturePath[] GetValues()
		{
			return new EComboBgTexturePath[]
			{
				EComboBgTexturePath.Good,
				EComboBgTexturePath.Great,
				EComboBgTexturePath.Excellent,
				EComboBgTexturePath.Unbelievable,
				EComboBgTexturePath.Combo,
				EComboBgTexturePath.Default
			};
		}

		// Token: 0x0603E4FC RID: 255228 RVA: 0x00F0C9F3 File Offset: 0x00F0ABF3
		public static string[] GetNames()
		{
			return new string[]
			{
				"Good",
				"Great",
				"Excellent",
				"Unbelievable",
				"Combo",
				"Default"
			};
		}
	}
}
