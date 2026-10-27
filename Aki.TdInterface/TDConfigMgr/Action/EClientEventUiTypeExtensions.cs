using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E1 RID: 8929
	public static class EClientEventUiTypeExtensions
	{
		// Token: 0x0600C373 RID: 50035 RVA: 0x001C8E4C File Offset: 0x001C704C
		public static string ToEnumString(this EClientEventUiType value)
		{
			string result;
			if (value != EClientEventUiType.PlayPiano)
			{
				if (value != EClientEventUiType.FlyingFlower)
				{
					result = value.ToString();
				}
				else
				{
					result = "FlyingFlower";
				}
			}
			else
			{
				result = "PlayPiano";
			}
			return result;
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x001C8E84 File Offset: 0x001C7084
		public static EClientEventUiType FromString(string name)
		{
			EClientEventUiType result;
			if (!EClientEventUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x001C8EAD File Offset: 0x001C70AD
		public static bool TryFromString(string name, out EClientEventUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EClientEventUiType.PlayPiano;
				return false;
			}
			if (name == "PlayPiano")
			{
				value = EClientEventUiType.PlayPiano;
				return true;
			}
			if (!(name == "FlyingFlower"))
			{
				value = EClientEventUiType.PlayPiano;
				return false;
			}
			value = EClientEventUiType.FlyingFlower;
			return true;
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x001C8EE6 File Offset: 0x001C70E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayPiano",
				"FlyingFlower"
			};
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x001C8EFE File Offset: 0x001C70FE
		public static EClientEventUiType[] GetValues()
		{
			return new EClientEventUiType[]
			{
				EClientEventUiType.PlayPiano,
				EClientEventUiType.FlyingFlower
			};
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x001C8F0A File Offset: 0x001C710A
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayPiano",
				"FlyingFlower"
			};
		}
	}
}
