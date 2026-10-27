using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C63 RID: 7267
[NullableContext(1)]
[Nullable(0)]
public static class GachaAccumulateContentFactory
{
	// Token: 0x0600DB25 RID: 56101 RVA: 0x0032EA0C File Offset: 0x0032CC0C
	public static GachaAccumulateBonusContentBase CreateBonusContent(int accumulateId)
	{
		EGachaAccumulateShowType showType = GachaAccumulateConfig.Instance.GetShowType(accumulateId);
		if (showType != EGachaAccumulateShowType.Default && showType == EGachaAccumulateShowType.Stage)
		{
			return new GachaAccumulateBonusViewContentStage();
		}
		return new GachaAccumulateBonusViewContent();
	}

	// Token: 0x0600DB26 RID: 56102 RVA: 0x0032EA38 File Offset: 0x0032CC38
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
