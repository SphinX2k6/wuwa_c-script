using System;
using System.Runtime.CompilerServices;

// Token: 0x02001122 RID: 4386
[NullableContext(1)]
[Nullable(0)]
public static class GachaAccumulateContentFactory
{
	// Token: 0x0600AF3B RID: 44859 RVA: 0x00339E58 File Offset: 0x00338058
	public static GachaAccumulateBonusContentBase CreateBonusContent(int accumulateId)
	{
		EGachaAccumulateShowType showType = GachaAccumulateConfig.Instance.GetShowType(accumulateId);
		if (showType != EGachaAccumulateShowType.Default && showType == EGachaAccumulateShowType.Stage)
		{
			return new GachaAccumulateBonusViewContentStage();
		}
		return new GachaAccumulateBonusViewContent();
	}

	// Token: 0x0600AF3C RID: 44860 RVA: 0x00339E84 File Offset: 0x00338084
	public static GachaAccumulateTipsContentBase CreateTipsContent(int accumulateId)
	{
		EGachaAccumulateShowType showType = GachaAccumulateConfig.Instance.GetShowType(accumulateId);
		if (showType != EGachaAccumulateShowType.Default && showType == EGachaAccumulateShowType.Stage)
		{
			return new GachaAccumulateTipsItemContentStage();
		}
		return new GachaAccumulateTipsItemContent();
	}
}
