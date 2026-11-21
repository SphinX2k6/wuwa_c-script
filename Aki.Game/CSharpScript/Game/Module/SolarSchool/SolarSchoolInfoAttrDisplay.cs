using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B9 RID: 22969
	public static class SolarSchoolInfoAttrDisplay
	{
		// Token: 0x060389D1 RID: 231889 RVA: 0x00FD7454 File Offset: 0x00FD5654
		public static SolarSchoolInfoAttrData Build(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(attr);
			if (attrConfig == null)
			{
				int value = instance.IsInGamePlay ? instance.PlayerData.GetAttr(attr) : 0;
				return new SolarSchoolInfoAttrData(attr, null, null, null, value, 0f);
			}
			SolarSchoolAttr value2 = attrConfig.Value;
			int value3 = instance.IsInGamePlay ? instance.PlayerData.GetAttr(attr) : value2.InitValue;
			int num = SolarSchoolUtils.CalcAttrRankTier(value2, value3);
			return new SolarSchoolInfoAttrData(attr, SolarSchoolInfoAttrDisplay.NullIfEmpty(value2.Name), SolarSchoolInfoAttrDisplay.NullIfEmpty(value2.YellowIconSmall), (num < value2.RankIconLength) ? SolarSchoolInfoAttrDisplay.NullIfEmpty(value2.RankIcon(num)) : null, value3, SolarSchoolUtils.CalcAttrRankRatio(value2, value3));
		}

		// Token: 0x060389D2 RID: 231890 RVA: 0x00FD7513 File Offset: 0x00FD5713
		[NullableContext(2)]
		private static string NullIfEmpty(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				return value;
			}
			return null;
		}
	}
}
