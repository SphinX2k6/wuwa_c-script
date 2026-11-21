using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002698 RID: 9880
	public static class ESceneUiSubtitlePositionTypeExtensions
	{
		// Token: 0x0600D506 RID: 54534 RVA: 0x001EEFC8 File Offset: 0x001ED1C8
		public static string ToEnumString(this ESceneUiSubtitlePositionType value)
		{
			string result;
			if (value != ESceneUiSubtitlePositionType.Position)
			{
				if (value != ESceneUiSubtitlePositionType.Entity)
				{
					result = value.ToString();
				}
				else
				{
					result = "Entity";
				}
			}
			else
			{
				result = "Position";
			}
			return result;
		}

		// Token: 0x0600D507 RID: 54535 RVA: 0x001EF000 File Offset: 0x001ED200
		public static ESceneUiSubtitlePositionType FromString(string name)
		{
			ESceneUiSubtitlePositionType result;
			if (!ESceneUiSubtitlePositionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESceneUiSubtitlePositionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D508 RID: 54536 RVA: 0x001EF029 File Offset: 0x001ED229
		public static bool TryFromString(string name, out ESceneUiSubtitlePositionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESceneUiSubtitlePositionType.Position;
				return false;
			}
			if (name == "Position")
			{
				value = ESceneUiSubtitlePositionType.Position;
				return true;
			}
			if (!(name == "Entity"))
			{
				value = ESceneUiSubtitlePositionType.Position;
				return false;
			}
			value = ESceneUiSubtitlePositionType.Entity;
			return true;
		}

		// Token: 0x0600D509 RID: 54537 RVA: 0x001EF062 File Offset: 0x001ED262
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Position",
				"Entity"
			};
		}

		// Token: 0x0600D50A RID: 54538 RVA: 0x001EF07A File Offset: 0x001ED27A
		public static ESceneUiSubtitlePositionType[] GetValues()
		{
			return new ESceneUiSubtitlePositionType[]
			{
				ESceneUiSubtitlePositionType.Position,
				ESceneUiSubtitlePositionType.Entity
			};
		}

		// Token: 0x0600D50B RID: 54539 RVA: 0x001EF086 File Offset: 0x001ED286
		public static string[] GetNames()
		{
			return new string[]
			{
				"Position",
				"Entity"
			};
		}
	}
}
