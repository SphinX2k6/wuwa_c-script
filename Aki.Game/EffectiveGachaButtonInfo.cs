using System;
using System.Runtime.CompilerServices;

// Token: 0x02001157 RID: 4439
[NullableContext(2)]
[Nullable(0)]
public class EffectiveGachaButtonInfo
{
	// Token: 0x0600B10A RID: 45322 RVA: 0x00344550 File Offset: 0x00342750
	public GachaTagInfo GetCustomTag()
	{
		if (!string.IsNullOrEmpty(this.TagCustomText))
		{
			return new GachaTagInfo(EGachaTagKind.Custom, this.TagCustomText, null);
		}
		return null;
	}

	// Token: 0x0600B10B RID: 45323 RVA: 0x00344584 File Offset: 0x00342784
	public GachaTagInfo GetDiscountTag()
	{
		if (this.Consume == 0)
		{
			return new GachaTagInfo(EGachaTagKind.Free, null, null);
		}
		if (this.IsDiscount && this.OriginConsume != null && this.OriginConsume.Value > 0)
		{
			int value = (int)Math.Floor((double)((this.OriginConsume.Value - this.Consume) * 100) / (double)this.OriginConsume.Value);
			return new GachaTagInfo(EGachaTagKind.Discount, null, new int?(value));
		}
		return null;
	}

	// Token: 0x0600B10C RID: 45324 RVA: 0x00344606 File Offset: 0x00342806
	[NullableContext(1)]
	public static EffectiveGachaButtonInfo MakeDiscount(int times, int consume, int originConsume, [Nullable(2)] string tagCustomText)
	{
		return new EffectiveGachaButtonInfo
		{
			Times = times,
			Consume = consume,
			IsDiscount = true,
			OriginConsume = new int?(originConsume),
			TagCustomText = tagCustomText
		};
	}

	// Token: 0x0600B10D RID: 45325 RVA: 0x00344635 File Offset: 0x00342835
	[NullableContext(1)]
	public static EffectiveGachaButtonInfo MakePlain(int times, int consume, [Nullable(2)] string tagCustomText)
	{
		return new EffectiveGachaButtonInfo
		{
			Times = times,
			Consume = consume,
			TagCustomText = tagCustomText
		};
	}

	// Token: 0x04006628 RID: 26152
	public int Times;

	// Token: 0x04006629 RID: 26153
	public int Consume;

	// Token: 0x0400662A RID: 26154
	public bool IsDiscount;

	// Token: 0x0400662B RID: 26155
	public int? OriginConsume;

	// Token: 0x0400662C RID: 26156
	public string TagCustomText;
}
