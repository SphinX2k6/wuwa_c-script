using System;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAB RID: 19371
	public class CiacconaGalUtils
	{
		// Token: 0x060305BF RID: 198079 RVA: 0x00D7B360 File Offset: 0x00D79560
		public static float GetAvgSkippingTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgSkippingTime").GetValueOrDefault(1f);
		}

		// Token: 0x060305C0 RID: 198080 RVA: 0x00D7B384 File Offset: 0x00D79584
		public static float GetAvgCoolDownTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgCoolDownTime").GetValueOrDefault(1f);
		}

		// Token: 0x060305C1 RID: 198081 RVA: 0x00D7B3A8 File Offset: 0x00D795A8
		public static float GetAvgTextAnimShortenTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgTextAnimShortenTime").GetValueOrDefault(1f);
		}

		// Token: 0x060305C2 RID: 198082 RVA: 0x00D7B3CC File Offset: 0x00D795CC
		public static float GetAvgSubEndingDelayTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgSubEndingDelay").GetValueOrDefault(1f);
		}

		// Token: 0x060305C3 RID: 198083 RVA: 0x00D7B3F0 File Offset: 0x00D795F0
		public static float GetAvgChoiceProtectingTime()
		{
			return ConfigCommonParamById.GetFloatConfig("CiacconaAvgChoiceProtectingTime").GetValueOrDefault(1f);
		}
	}
}
