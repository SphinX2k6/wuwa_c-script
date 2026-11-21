using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200269A RID: 9882
	public static class ESceneUiSubtitleStyleTypeExtensions
	{
		// Token: 0x0600D50F RID: 54543 RVA: 0x001EF0DC File Offset: 0x001ED2DC
		public static string ToEnumString(this ESceneUiSubtitleStyleType value)
		{
			string result;
			if (value != ESceneUiSubtitleStyleType.SceneUiSubtitleScatter)
			{
				if (value != ESceneUiSubtitleStyleType.SceneUiSubtitleAppear)
				{
					result = value.ToString();
				}
				else
				{
					result = "SceneUiSubtitleAppear";
				}
			}
			else
			{
				result = "SceneUiSubtitleScatter";
			}
			return result;
		}

		// Token: 0x0600D510 RID: 54544 RVA: 0x001EF114 File Offset: 0x001ED314
		public static ESceneUiSubtitleStyleType FromString(string name)
		{
			ESceneUiSubtitleStyleType result;
			if (!ESceneUiSubtitleStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneUiSubtitleStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D511 RID: 54545 RVA: 0x001EF13D File Offset: 0x001ED33D
		public static bool TryFromString(string name, out ESceneUiSubtitleStyleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
				return false;
			}
			if (name == "SceneUiSubtitleScatter")
			{
				value = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
				return true;
			}
			if (!(name == "SceneUiSubtitleAppear"))
			{
				value = ESceneUiSubtitleStyleType.SceneUiSubtitleScatter;
				return false;
			}
			value = ESceneUiSubtitleStyleType.SceneUiSubtitleAppear;
			return true;
		}

		// Token: 0x0600D512 RID: 54546 RVA: 0x001EF176 File Offset: 0x001ED376
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SceneUiSubtitleScatter",
				"SceneUiSubtitleAppear"
			};
		}

		// Token: 0x0600D513 RID: 54547 RVA: 0x001EF18E File Offset: 0x001ED38E
		public static ESceneUiSubtitleStyleType[] GetValues()
		{
			return new ESceneUiSubtitleStyleType[]
			{
				ESceneUiSubtitleStyleType.SceneUiSubtitleScatter,
				ESceneUiSubtitleStyleType.SceneUiSubtitleAppear
			};
		}

		// Token: 0x0600D514 RID: 54548 RVA: 0x001EF19A File Offset: 0x001ED39A
		public static string[] GetNames()
		{
			return new string[]
			{
				"SceneUiSubtitleScatter",
				"SceneUiSubtitleAppear"
			};
		}
	}
}
