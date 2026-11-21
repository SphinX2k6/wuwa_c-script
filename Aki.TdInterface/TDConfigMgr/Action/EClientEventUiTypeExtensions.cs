using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002550 RID: 9552
	public static class EClientEventUiTypeExtensions
	{
		// Token: 0x0600CF42 RID: 53058 RVA: 0x001E0C54 File Offset: 0x001DEE54
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

		// Token: 0x0600CF43 RID: 53059 RVA: 0x001E0C8C File Offset: 0x001DEE8C
		public static EClientEventUiType FromString(string name)
		{
			EClientEventUiType result;
			if (!EClientEventUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EClientEventUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF44 RID: 53060 RVA: 0x001E0CB5 File Offset: 0x001DEEB5
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

		// Token: 0x0600CF45 RID: 53061 RVA: 0x001E0CEE File Offset: 0x001DEEEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayPiano",
				"FlyingFlower"
			};
		}

		// Token: 0x0600CF46 RID: 53062 RVA: 0x001E0D06 File Offset: 0x001DEF06
		public static EClientEventUiType[] GetValues()
		{
			return new EClientEventUiType[]
			{
				EClientEventUiType.PlayPiano,
				EClientEventUiType.FlyingFlower
			};
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x001E0D12 File Offset: 0x001DEF12
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
