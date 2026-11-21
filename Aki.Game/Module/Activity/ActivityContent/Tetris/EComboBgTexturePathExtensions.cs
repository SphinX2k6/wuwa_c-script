using System;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBD RID: 12221
	public static class EComboBgTexturePathExtensions
	{
		// Token: 0x0601D03A RID: 118842 RVA: 0x008DBECC File Offset: 0x008DA0CC
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

		// Token: 0x0601D03B RID: 118843 RVA: 0x008DBF38 File Offset: 0x008DA138
		public static EComboBgTexturePath FromString(string name)
		{
			EComboBgTexturePath result;
			if (!EComboBgTexturePathExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboBgTexturePath 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0601D03C RID: 118844 RVA: 0x008DBF64 File Offset: 0x008DA164
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

		// Token: 0x0601D03D RID: 118845 RVA: 0x008DBFF0 File Offset: 0x008DA1F0
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

		// Token: 0x0601D03E RID: 118846 RVA: 0x008DC028 File Offset: 0x008DA228
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

		// Token: 0x0601D03F RID: 118847 RVA: 0x008DC03B File Offset: 0x008DA23B
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
