using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006029 RID: 24617
	public static class EComboTexturePathExtensions
	{
		// Token: 0x0603E4EE RID: 255214 RVA: 0x00F0C6CC File Offset: 0x00F0A8CC
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

		// Token: 0x0603E4EF RID: 255215 RVA: 0x00F0C72C File Offset: 0x00F0A92C
		public static EComboTexturePath FromString(string name)
		{
			EComboTexturePath result;
			if (!EComboTexturePathExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EComboTexturePath 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603E4F0 RID: 255216 RVA: 0x00F0C758 File Offset: 0x00F0A958
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

		// Token: 0x0603E4F1 RID: 255217 RVA: 0x00F0C7D2 File Offset: 0x00F0A9D2
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

		// Token: 0x0603E4F2 RID: 255218 RVA: 0x00F0C802 File Offset: 0x00F0AA02
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

		// Token: 0x0603E4F3 RID: 255219 RVA: 0x00F0C815 File Offset: 0x00F0AA15
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
