using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232F RID: 9007
	public static class EFaceExpressionConfigTypeExtensions
	{
		// Token: 0x0600C4D2 RID: 50386 RVA: 0x001CBC10 File Offset: 0x001C9E10
		public static string ToEnumString(this EFaceExpressionConfigType value)
		{
			string result;
			switch (value)
			{
			case EFaceExpressionConfigType.Morph:
				result = "Morph";
				break;
			case EFaceExpressionConfigType.Texture:
				result = "Texture";
				break;
			case EFaceExpressionConfigType.AnimSequence:
				result = "AnimSequence";
				break;
			case EFaceExpressionConfigType.TextureMultiSlot:
				result = "TextureMultiSlot";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x001CBC64 File Offset: 0x001C9E64
		public static EFaceExpressionConfigType FromString(string name)
		{
			EFaceExpressionConfigType result;
			if (!EFaceExpressionConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFaceExpressionConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4D4 RID: 50388 RVA: 0x001CBC90 File Offset: 0x001C9E90
		public static bool TryFromString(string name, out EFaceExpressionConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFaceExpressionConfigType.Morph;
				return false;
			}
			if (name == "Morph")
			{
				value = EFaceExpressionConfigType.Morph;
				return true;
			}
			if (name == "Texture")
			{
				value = EFaceExpressionConfigType.Texture;
				return true;
			}
			if (name == "AnimSequence")
			{
				value = EFaceExpressionConfigType.AnimSequence;
				return true;
			}
			if (!(name == "TextureMultiSlot"))
			{
				value = EFaceExpressionConfigType.Morph;
				return false;
			}
			value = EFaceExpressionConfigType.TextureMultiSlot;
			return true;
		}

		// Token: 0x0600C4D5 RID: 50389 RVA: 0x001CBCF8 File Offset: 0x001C9EF8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Morph",
				"Texture",
				"AnimSequence",
				"TextureMultiSlot"
			};
		}

		// Token: 0x0600C4D6 RID: 50390 RVA: 0x001CBD20 File Offset: 0x001C9F20
		public static EFaceExpressionConfigType[] GetValues()
		{
			return new EFaceExpressionConfigType[]
			{
				EFaceExpressionConfigType.Morph,
				EFaceExpressionConfigType.Texture,
				EFaceExpressionConfigType.AnimSequence,
				EFaceExpressionConfigType.TextureMultiSlot
			};
		}

		// Token: 0x0600C4D7 RID: 50391 RVA: 0x001CBD33 File Offset: 0x001C9F33
		public static string[] GetNames()
		{
			return new string[]
			{
				"Morph",
				"Texture",
				"AnimSequence",
				"TextureMultiSlot"
			};
		}
	}
}
