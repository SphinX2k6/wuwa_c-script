using System;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050F8 RID: 20728
	public static class EAttachmentTypeExtensions
	{
		// Token: 0x06034FDE RID: 217054 RVA: 0x00C8D2C8 File Offset: 0x00C8B4C8
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

		// Token: 0x06034FDF RID: 217055 RVA: 0x00C8D310 File Offset: 0x00C8B510
		public static EAttachmentType FromString(string name)
		{
			EAttachmentType result;
			if (!EAttachmentTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAttachmentType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06034FE0 RID: 217056 RVA: 0x00C8D33C File Offset: 0x00C8B53C
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

		// Token: 0x06034FE1 RID: 217057 RVA: 0x00C8D392 File Offset: 0x00C8B592
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Image",
				"Spine",
				"Mp4"
			};
		}

		// Token: 0x06034FE2 RID: 217058 RVA: 0x00C8D3B2 File Offset: 0x00C8B5B2
		public static EAttachmentType[] GetValues()
		{
			return new EAttachmentType[]
			{
				EAttachmentType.Image,
				EAttachmentType.Spine,
				EAttachmentType.Mp4
			};
		}

		// Token: 0x06034FE3 RID: 217059 RVA: 0x00C8D3C2 File Offset: 0x00C8B5C2
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
