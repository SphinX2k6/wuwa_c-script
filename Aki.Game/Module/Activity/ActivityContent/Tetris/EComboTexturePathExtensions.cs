using System;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBB RID: 12219
	public static class EComboTexturePathExtensions
	{
		// Token: 0x0601D031 RID: 118833 RVA: 0x008DBD14 File Offset: 0x008D9F14
		public static string ToEnumString(this EComboTexturePath value)
		{
			string result;
			switch (value)
			{
			case EComboTexturePath.Good:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGood.T_FloatGood";
				break;
			case EComboTexturePath.Great:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreat.T_FloatGreat";
				break;
			case EComboTexturePath.Excellent:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellent.T_FloatExcellent";
				break;
			case EComboTexturePath.Unbelievable:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievable.T_FloatUnbelievable";
				break;
			case EComboTexturePath.Combo:
				result = "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatCombo.T_FloatCombo";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0601D032 RID: 118834 RVA: 0x008DBD74 File Offset: 0x008D9F74
		public static EComboTexturePath FromString(string name)
		{
			EComboTexturePath result;
			if (!EComboTexturePathExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboTexturePath 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0601D033 RID: 118835 RVA: 0x008DBDA0 File Offset: 0x008D9FA0
		public static bool TryFromString(string name, out EComboTexturePath value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EComboTexturePath.Good;
				return false;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGood.T_FloatGood")
			{
				value = EComboTexturePath.Good;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreat.T_FloatGreat")
			{
				value = EComboTexturePath.Great;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellent.T_FloatExcellent")
			{
				value = EComboTexturePath.Excellent;
				return true;
			}
			if (name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievable.T_FloatUnbelievable")
			{
				value = EComboTexturePath.Unbelievable;
				return true;
			}
			if (!(name == "/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatCombo.T_FloatCombo"))
			{
				value = EComboTexturePath.Good;
				return false;
			}
			value = EComboTexturePath.Combo;
			return true;
		}

		// Token: 0x0601D034 RID: 118836 RVA: 0x008DBE1A File Offset: 0x008DA01A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGood.T_FloatGood",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatGreat.T_FloatGreat",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatExcellent.T_FloatExcellent",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatUnbelievable.T_FloatUnbelievable",
				"/Game/Aki/UI/UIResources/UiActivity/Image/Activity32/Cube/Main/T_FloatCombo.T_FloatCombo"
			};
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x008DBE4A File Offset: 0x008DA04A
		public static EComboTexturePath[] GetValues()
		{
			return new EComboTexturePath[]
			{
				EComboTexturePath.Good,
				EComboTexturePath.Great,
				EComboTexturePath.Excellent,
				EComboTexturePath.Unbelievable,
				EComboTexturePath.Combo
			};
		}

		// Token: 0x0601D036 RID: 118838 RVA: 0x008DBE5D File Offset: 0x008DA05D
		public static string[] GetNames()
		{
			return new string[]
			{
				"Good",
				"Great",
				"Excellent",
				"Unbelievable",
				"Combo"
			};
		}
	}
}
