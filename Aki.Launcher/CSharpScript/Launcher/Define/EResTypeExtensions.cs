using System;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200024A RID: 586
	public static class EResTypeExtensions
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x000568E4 File Offset: 0x00054AE4
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

		// Token: 0x06000EBE RID: 3774 RVA: 0x00056944 File Offset: 0x00054B44
		public static EResType FromString(string name)
		{
			EResType result;
			if (!EResTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00056970 File Offset: 0x00054B70
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

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000569EA File Offset: 0x00054BEA
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

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00056A1A File Offset: 0x00054C1A
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

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00056A2D File Offset: 0x00054C2D
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
