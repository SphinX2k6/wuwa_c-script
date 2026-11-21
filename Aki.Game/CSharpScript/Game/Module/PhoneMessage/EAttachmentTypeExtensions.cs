using System;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040C8 RID: 16584
	public static class EAttachmentTypeExtensions
	{
		// Token: 0x06029ED7 RID: 171735 RVA: 0x00BDA5A4 File Offset: 0x00BD87A4
		public static string ToEnumString(this EAttachmentType value)
		{
			string result;
			switch (value)
			{
			case EAttachmentType.Image:
				result = "Image";
				break;
			case EAttachmentType.Spine:
				result = "Spine";
				break;
			case EAttachmentType.Mp4:
				result = "Mp4";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06029ED8 RID: 171736 RVA: 0x00BDA5EC File Offset: 0x00BD87EC
		public static EAttachmentType FromString(string name)
		{
			EAttachmentType result;
			if (!EAttachmentTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachmentType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06029ED9 RID: 171737 RVA: 0x00BDA618 File Offset: 0x00BD8818
		public static bool TryFromString(string name, out EAttachmentType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAttachmentType.Image;
				return false;
			}
			if (name == "Image")
			{
				value = EAttachmentType.Image;
				return true;
			}
			if (name == "Spine")
			{
				value = EAttachmentType.Spine;
				return true;
			}
			if (!(name == "Mp4"))
			{
				value = EAttachmentType.Image;
				return false;
			}
			value = EAttachmentType.Mp4;
			return true;
		}

		// Token: 0x06029EDA RID: 171738 RVA: 0x00BDA66E File Offset: 0x00BD886E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Image",
				"Spine",
				"Mp4"
			};
		}

		// Token: 0x06029EDB RID: 171739 RVA: 0x00BDA68E File Offset: 0x00BD888E
		public static EAttachmentType[] GetValues()
		{
			return new EAttachmentType[]
			{
				EAttachmentType.Image,
				EAttachmentType.Spine,
				EAttachmentType.Mp4
			};
		}

		// Token: 0x06029EDC RID: 171740 RVA: 0x00BDA69E File Offset: 0x00BD889E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Image",
				"Spine",
				"Mp4"
			};
		}
	}
}
