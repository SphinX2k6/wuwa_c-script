using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A0 RID: 9632
	public static class EFaceExpressionConfigTypeExtensions
	{
		// Token: 0x0600D0AA RID: 53418 RVA: 0x001E3CC8 File Offset: 0x001E1EC8
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

		// Token: 0x0600D0AB RID: 53419 RVA: 0x001E3D1C File Offset: 0x001E1F1C
		public static EFaceExpressionConfigType FromString(string name)
		{
			EFaceExpressionConfigType result;
			if (!EFaceExpressionConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFaceExpressionConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x001E3D48 File Offset: 0x001E1F48
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

		// Token: 0x0600D0AD RID: 53421 RVA: 0x001E3DB0 File Offset: 0x001E1FB0
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

		// Token: 0x0600D0AE RID: 53422 RVA: 0x001E3DD8 File Offset: 0x001E1FD8
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

		// Token: 0x0600D0AF RID: 53423 RVA: 0x001E3DEB File Offset: 0x001E1FEB
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
