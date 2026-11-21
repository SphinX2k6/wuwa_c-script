using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Monster.Common;
using AkiClient.Game.Aki.Data.Condition.Enum;
using AkiClient.Game.Aki.Protocol;
using UnrealEngine;

// Token: 0x020000DB RID: 219
[NullableContext(1)]
[Nullable(0)]
public class AiConditions
{
	// Token: 0x06000CEF RID: 3311 RVA: 0x00045770 File Offset: 0x00043970
	public AiConditions(SAiConditions aiConditions)
	{
		this.Logic = (SConditionGroupType)aiConditions.Logic;
		this.Tags.EnsureCapacity(aiConditions.Tags.Num());
		foreach (KeyValuePair<FGameplayTag, FFloatRange> keyValuePair in aiConditions.Tags)
		{
			FGameplayTag fgameplayTag;
			FFloatRange ffloatRange;
			keyValuePair.Deconstruct(out fgameplayTag, out ffloatRange);
			FGameplayTag tag = fgameplayTag;
			FFloatRange ffloatRange2 = ffloatRange;
			this.Tags[tag.TagId()] = new TsFloatRange(ffloatRange2.LowerBound.Type == 0, ffloatRange2.LowerBound.Value, ffloatRange2.UpperBound.Value);
		}
		this.Attributes.EnsureCapacity(aiConditions.Attributes.Num());
		foreach (KeyValuePair<TEnumAsByte<AkiClient.Game.Aki.Protocol.EAttributeType>, FFloatRange> keyValuePair2 in aiConditions.Attributes)
		{
			FFloatRange ffloatRange;
			TEnumAsByte<AkiClient.Game.Aki.Protocol.EAttributeType> tenumAsByte;
			keyValuePair2.Deconstruct(out tenumAsByte, out ffloatRange);
			TEnumAsByte<AkiClient.Game.Aki.Protocol.EAttributeType> value = tenumAsByte;
			FFloatRange ffloatRange3 = ffloatRange;
			this.Attributes[(Aki.Protocol.EAttributeType)value] = new TsFloatRange(ffloatRange3.LowerBound.Type == 0, ffloatRange3.LowerBound.Value, ffloatRange3.UpperBound.Value);
		}
		int num = aiConditions.AttributeRates.Num();
		this.AttributeRates.EnsureCapacity(num);
		for (int i = 0; i < num; i++)
		{
			AiAttributeRate aiAttributeRate = new AiAttributeRate(aiConditions.AttributeRates.Get(i));
			this.AttributeRates.Add(aiAttributeRate);
			List<int> list;
			if (!this.AttributeRateDenominatorMap.TryGetValue(aiAttributeRate.Denominator, out list))
			{
				list = (this.AttributeRateDenominatorMap[aiAttributeRate.Denominator] = new List<int>());
			}
			list.Add(i);
			if (!this.AttributeRateNumeratorMap.TryGetValue(aiAttributeRate.Numerator, out list))
			{
				list = (this.AttributeRateNumeratorMap[aiAttributeRate.Numerator] = new List<int>());
			}
			list.Add(i);
		}
	}

	// Token: 0x04000A4B RID: 2635
	public Dictionary<int, TsFloatRange> Tags = new Dictionary<int, TsFloatRange>();

	// Token: 0x04000A4C RID: 2636
	public Dictionary<Aki.Protocol.EAttributeType, TsFloatRange> Attributes = new Dictionary<Aki.Protocol.EAttributeType, TsFloatRange>();

	// Token: 0x04000A4D RID: 2637
	public List<AiAttributeRate> AttributeRates = new List<AiAttributeRate>();

	// Token: 0x04000A4E RID: 2638
	public Dictionary<Aki.Protocol.EAttributeType, List<int>> AttributeRateDenominatorMap = new Dictionary<Aki.Protocol.EAttributeType, List<int>>();

	// Token: 0x04000A4F RID: 2639
	public Dictionary<Aki.Protocol.EAttributeType, List<int>> AttributeRateNumeratorMap = new Dictionary<Aki.Protocol.EAttributeType, List<int>>();

	// Token: 0x04000A50 RID: 2640
	public SConditionGroupType Logic;
}
