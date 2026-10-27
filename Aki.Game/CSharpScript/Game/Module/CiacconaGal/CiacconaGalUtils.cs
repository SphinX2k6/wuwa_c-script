using System;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCB RID: 23499
	public class CiacconaGalUtils
	{
		// Token: 0x0603B673 RID: 243315 RVA: 0x00E2B06C File Offset: 0x00E2926C
		public static float GetAvgSkippingTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgSkippingTime").GetValueOrDefault(1f);
		}

		// Token: 0x0603B674 RID: 243316 RVA: 0x00E2B090 File Offset: 0x00E29290
		public static float GetAvgCoolDownTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgCoolDownTime").GetValueOrDefault(1f);
		}

		// Token: 0x0603B675 RID: 243317 RVA: 0x00E2B0B4 File Offset: 0x00E292B4
		public static float GetAvgTextAnimShortenTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgTextAnimShortenTime").GetValueOrDefault(1f);
		}

		// Token: 0x0603B676 RID: 243318 RVA: 0x00E2B0D8 File Offset: 0x00E292D8
		public static float GetAvgSubEndingDelayTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgSubEndingDelay").GetValueOrDefault(1f);
		}

		// Token: 0x0603B677 RID: 243319 RVA: 0x00E2B0FC File Offset: 0x00E292FC
		public static float GetAvgChoiceProtectingTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgChoiceProtectingTime").GetValueOrDefault(1f);
		}
	}
}
