using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024BB RID: 9403
	public static class EVisualNovelUiShakeTypeExtensions
	{
		// Token: 0x0600CBC8 RID: 52168 RVA: 0x001E0128 File Offset: 0x001DE328
		public static string ToEnumString(this EVisualNovelUiShakeType value)
		{
			string result;
			switch (value)
			{
			case EVisualNovelUiShakeType.Random:
				result = "Random";
				break;
			case EVisualNovelUiShakeType.Horizontal:
				result = "Horizontal";
				break;
			case EVisualNovelUiShakeType.Vertical:
				result = "Vertical";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x001E0170 File Offset: 0x001DE370
		public static EVisualNovelUiShakeType FromString(string name)
		{
			EVisualNovelUiShakeType result;
			if (!EVisualNovelUiShakeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelUiShakeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x001E019C File Offset: 0x001DE39C
		public static bool TryFromString(string name, out EVisualNovelUiShakeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelUiShakeType.Random;
				return false;
			}
			if (name == "Random")
			{
				value = EVisualNovelUiShakeType.Random;
				return true;
			}
			if (name == "Horizontal")
			{
				value = EVisualNovelUiShakeType.Horizontal;
				return true;
			}
			if (!(name == "Vertical"))
			{
				value = EVisualNovelUiShakeType.Random;
				return false;
			}
			value = EVisualNovelUiShakeType.Vertical;
			return true;
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x001E01F2 File Offset: 0x001DE3F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Random",
				"Horizontal",
				"Vertical"
			};
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x001E0212 File Offset: 0x001DE412
		public static EVisualNovelUiShakeType[] GetValues()
		{
			return new EVisualNovelUiShakeType[]
			{
				EVisualNovelUiShakeType.Random,
				EVisualNovelUiShakeType.Horizontal,
				EVisualNovelUiShakeType.Vertical
			};
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x001E0222 File Offset: 0x001DE422
		public static string[] GetNames()
		{
			return new string[]
			{
				"Random",
				"Horizontal",
				"Vertical"
			};
		}
	}
}
