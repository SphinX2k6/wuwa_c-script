using System;
using System.Runtime.CompilerServices;

// Token: 0x02001C98 RID: 7320
[NullableContext(2)]
[Nullable(0)]
public class EffectiveGachaButtonInfo
{
	// Token: 0x0600DCF4 RID: 56564 RVA: 0x00339008 File Offset: 0x00337208
	public GachaTagInfo GetCustomTag()
	{
		if (!string.IsNullOrEmpty(this.TagCustomText))
		{
			return new GachaTagInfo(EGachaTagKind.Custom, this.TagCustomText, null);
		}
		return null;
	}

	// Token: 0x0600DCF5 RID: 56565 RVA: 0x0033903C File Offset: 0x0033723C
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

	// Token: 0x0600DCF6 RID: 56566 RVA: 0x003390BE File Offset: 0x003372BE
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

	// Token: 0x0600DCF7 RID: 56567 RVA: 0x003390ED File Offset: 0x003372ED
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

	// Token: 0x04006556 RID: 25942
	public int Times;

	// Token: 0x04006557 RID: 25943
	public int Consume;

	// Token: 0x04006558 RID: 25944
	public bool IsDiscount;

	// Token: 0x04006559 RID: 25945
	public int? OriginConsume;

	// Token: 0x0400655A RID: 25946
	public string TagCustomText;
}
