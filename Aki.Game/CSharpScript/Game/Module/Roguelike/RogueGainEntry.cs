using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D8B RID: 19851
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueGainEntry
	{
		// Token: 0x060334E9 RID: 210153 RVA: 0x00BF9C53 File Offset: 0x00BF7E53
		public RogueGainEntry()
		{
		}

		// Token: 0x060334EA RID: 210154 RVA: 0x00BF9C5C File Offset: 0x00BF7E5C
		public RogueGainEntry(RogueGainEntry rogueGainEntry, int? bindId = null)
		{
			this.BindId = bindId;
			this.RoguelikeGainDataType = new RoguelikeGainDataType?(rogueGainEntry.Type);
			this.ConfigId = rogueGainEntry.ConfigId;
			this.Index = new int?(rogueGainEntry.Index);
			this.IncId = rogueGainEntry.IncId;
			this.IsSell = new bool?(rogueGainEntry.IsSell);
			this.ElementDict = new Dictionary<int, int>();
			this.IsSelect = rogueGainEntry.IsSelect;
			this.IsNew = rogueGainEntry.IsNew;
			this.Cost = rogueGainEntry.Cost;
			this.RestCount = rogueGainEntry.RestCount;
			this.IsValid = rogueGainEntry.IsValid;
			if (rogueGainEntry.ElementDict != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in rogueGainEntry.ElementDict)
				{
					int value = keyValuePair.Value;
					if (value != 0)
					{
						this.ElementDict.Add(keyValuePair.Key, value);
					}
				}
			}
			if (rogueGainEntry.AffixEntryList == null)
			{
				return;
			}
			this.AffixEntryList = new List<AffixEntry>();
			foreach (AffixEntry affixEntry in rogueGainEntry.AffixEntryList)
			{
				this.AffixEntryList.Add(new AffixEntry(affixEntry));
			}
			if (rogueGainEntry.DiscountInfo != null)
			{
				if (rogueGainEntry.DiscountInfo.BuffPrice != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair2 in rogueGainEntry.DiscountInfo.BuffPrice)
					{
						this.ShopItemCoinId = keyValuePair2.Key;
						this.OriginalPrice = keyValuePair2.Value;
					}
				}
				this.CurrentPrice = new int?(this.OriginalPrice - (int)Math.Floor((double)(this.OriginalPrice * rogueGainEntry.DiscountInfo.Discounted) * 0.01));
				this.Discounted = rogueGainEntry.DiscountInfo.Discounted;
			}
		}

		// Token: 0x060334EB RID: 210155 RVA: 0x00BF9E78 File Offset: 0x00BF8078
		public List<ElementInfo> GetSortElementInfoArrayByCount(bool bIgnoreTotal = false)
		{
			int num = 9;
			List<ElementInfo> list = new List<ElementInfo>();
			if (this.ElementDict != null)
			{
				foreach (KeyValuePair<int, int> keyValuePair in this.ElementDict)
				{
					int key = keyValuePair.Key;
					int value = keyValuePair.Value;
					if (!bIgnoreTotal || key != num)
					{
						list.Add(new ElementInfo(key, value, null));
					}
				}
			}
			list.Sort((ElementInfo a, ElementInfo b) => b.Count - a.Count);
			return list;
		}

		// Token: 0x060334EC RID: 210156 RVA: 0x00BF9F28 File Offset: 0x00BF8128
		public bool IsDiscounted()
		{
			int? currentPrice = this.CurrentPrice;
			int originalPrice = this.OriginalPrice;
			return !(currentPrice.GetValueOrDefault() == originalPrice & currentPrice != null);
		}

		// Token: 0x0401B3BB RID: 111547
		public RoguelikeGainDataType? RoguelikeGainDataType;

		// Token: 0x0401B3BC RID: 111548
		public int ConfigId;

		// Token: 0x0401B3BD RID: 111549
		public int IncId;

		// Token: 0x0401B3BE RID: 111550
		[Nullable(2)]
		public Dictionary<int, int> ElementDict;

		// Token: 0x0401B3BF RID: 111551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AffixEntry> AffixEntryList;

		// Token: 0x0401B3C0 RID: 111552
		public int OriginalPrice;

		// Token: 0x0401B3C1 RID: 111553
		public int? CurrentPrice;

		// Token: 0x0401B3C2 RID: 111554
		public int? Index;

		// Token: 0x0401B3C3 RID: 111555
		public int ShopItemCoinId;

		// Token: 0x0401B3C4 RID: 111556
		public bool? IsSell;

		// Token: 0x0401B3C5 RID: 111557
		public bool IsSelect;

		// Token: 0x0401B3C6 RID: 111558
		public bool IsNew;

		// Token: 0x0401B3C7 RID: 111559
		public int Discounted;

		// Token: 0x0401B3C8 RID: 111560
		public int Cost;

		// Token: 0x0401B3C9 RID: 111561
		public int? BindId;

		// Token: 0x0401B3CA RID: 111562
		public int RestCount;

		// Token: 0x0401B3CB RID: 111563
		public bool IsValid;
	}
}
