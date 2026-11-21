using System;

namespace CSharpScript.Game.Module.Skin
{
	// Token: 0x02003B93 RID: 15251
	public static class ESkinSpinePreviewParamExtensions
	{
		// Token: 0x0602715E RID: 160094 RVA: 0x00AEF9F0 File Offset: 0x00AEDBF0
		public static string ToEnumString(this ESkinSpinePreviewParam value)
		{
			string result;
			switch (value)
			{
			case ESkinSpinePreviewParam.ReboundTime:
				result = "SkinSpinePreviewReboundTime";
				break;
			case ESkinSpinePreviewParam.ElasticDistance:
				result = "SkinSpinePreviewElasticDistance";
				break;
			case ESkinSpinePreviewParam.DragRatio:
				result = "SkinSpinePreviewDragRatio";
				break;
			case ESkinSpinePreviewParam.GamepadDragSpeed:
				result = "SkinSpinePreviewGamepadDragSpeed";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0602715F RID: 160095 RVA: 0x00AEFA44 File Offset: 0x00AEDC44
		public static ESkinSpinePreviewParam FromString(string name)
		{
			ESkinSpinePreviewParam result;
			if (!ESkinSpinePreviewParamExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkinSpinePreviewParam 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06027160 RID: 160096 RVA: 0x00AEFA70 File Offset: 0x00AEDC70
		public static bool TryFromString(string name, out ESkinSpinePreviewParam value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkinSpinePreviewParam.ReboundTime;
				return false;
			}
			if (name == "SkinSpinePreviewReboundTime")
			{
				value = ESkinSpinePreviewParam.ReboundTime;
				return true;
			}
			if (name == "SkinSpinePreviewElasticDistance")
			{
				value = ESkinSpinePreviewParam.ElasticDistance;
				return true;
			}
			if (name == "SkinSpinePreviewDragRatio")
			{
				value = ESkinSpinePreviewParam.DragRatio;
				return true;
			}
			if (!(name == "SkinSpinePreviewGamepadDragSpeed"))
			{
				value = ESkinSpinePreviewParam.ReboundTime;
				return false;
			}
			value = ESkinSpinePreviewParam.GamepadDragSpeed;
			return true;
		}

		// Token: 0x06027161 RID: 160097 RVA: 0x00AEFAD8 File Offset: 0x00AEDCD8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SkinSpinePreviewReboundTime",
				"SkinSpinePreviewElasticDistance",
				"SkinSpinePreviewDragRatio",
				"SkinSpinePreviewGamepadDragSpeed"
			};
		}

		// Token: 0x06027162 RID: 160098 RVA: 0x00AEFB00 File Offset: 0x00AEDD00
		public static ESkinSpinePreviewParam[] GetValues()
		{
			return new ESkinSpinePreviewParam[]
			{
				ESkinSpinePreviewParam.ReboundTime,
				ESkinSpinePreviewParam.ElasticDistance,
				ESkinSpinePreviewParam.DragRatio,
				ESkinSpinePreviewParam.GamepadDragSpeed
			};
		}

		// Token: 0x06027163 RID: 160099 RVA: 0x00AEFB13 File Offset: 0x00AEDD13
		public static string[] GetNames()
		{
			return new string[]
			{
				"ReboundTime",
				"ElasticDistance",
				"DragRatio",
				"GamepadDragSpeed"
			};
		}
	}
}
