using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024F RID: 591
	public static class EResTypeExtensions
	{
		// Token: 0x06000EFE RID: 3838 RVA: 0x00059428 File Offset: 0x00057628
		public static string ToEnumString(this EResType value)
		{
			string result;
			switch (value)
			{
			case EResType.Launcher:
				result = "Launcher";
				break;
			case EResType.Resource:
				result = "Resource";
				break;
			case EResType.Lang:
				result = "Lang";
				break;
			case EResType.Video:
				result = "Video";
				break;
			case EResType.Optional:
				result = "Option";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00059488 File Offset: 0x00057688
		public static EResType FromString(string name)
		{
			EResType result;
			if (!EResTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000594B4 File Offset: 0x000576B4
		public static bool TryFromString(string name, out EResType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResType.Launcher;
				return false;
			}
			if (name == "Launcher")
			{
				value = EResType.Launcher;
				return true;
			}
			if (name == "Resource")
			{
				value = EResType.Resource;
				return true;
			}
			if (name == "Lang")
			{
				value = EResType.Lang;
				return true;
			}
			if (name == "Video")
			{
				value = EResType.Video;
				return true;
			}
			if (!(name == "Option"))
			{
				value = EResType.Launcher;
				return false;
			}
			value = EResType.Optional;
			return true;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0005952E File Offset: 0x0005772E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Launcher",
				"Resource",
				"Lang",
				"Video",
				"Option"
			};
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0005955E File Offset: 0x0005775E
		public static EResType[] GetValues()
		{
			return new EResType[]
			{
				EResType.Launcher,
				EResType.Resource,
				EResType.Lang,
				EResType.Video,
				EResType.Optional
			};
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00059571 File Offset: 0x00057771
		public static string[] GetNames()
		{
			return new string[]
			{
				"Launcher",
				"Resource",
				"Lang",
				"Video",
				"Optional"
			};
		}
	}
}
