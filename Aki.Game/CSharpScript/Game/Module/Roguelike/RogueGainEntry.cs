using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D54 RID: 15700
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueGainEntry
	{
		// Token: 0x06028356 RID: 164694 RVA: 0x00B4324F File Offset: 0x00B4144F
		public RogueGainEntry()
		{
		}

		// Token: 0x06028357 RID: 164695 RVA: 0x00B43258 File Offset: 0x00B41458
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

		// Token: 0x06028358 RID: 164696 RVA: 0x00B43474 File Offset: 0x00B41674
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

		// Token: 0x06028359 RID: 164697 RVA: 0x00B43524 File Offset: 0x00B41724
		public bool IsDiscounted()
		{
			int? currentPrice = this.CurrentPrice;
			int originalPrice = this.OriginalPrice;
			return !(currentPrice.GetValueOrDefault() == originalPrice & currentPrice != null);
		}

		// Token: 0x04015D8E RID: 89486
		public RoguelikeGainDataType? RoguelikeGainDataType;

		// Token: 0x04015D8F RID: 89487
		public int ConfigId;

		// Token: 0x04015D90 RID: 89488
		public int IncId;

		// Token: 0x04015D91 RID: 89489
		[Nullable(2)]
		public Dictionary<int, int> ElementDict;

		// Token: 0x04015D92 RID: 89490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<AffixEntry> AffixEntryList;

		// Token: 0x04015D93 RID: 89491
		public int OriginalPrice;

		// Token: 0x04015D94 RID: 89492
		public int? CurrentPrice;

		// Token: 0x04015D95 RID: 89493
		public int? Index;

		// Token: 0x04015D96 RID: 89494
		public int ShopItemCoinId;

		// Token: 0x04015D97 RID: 89495
		public bool? IsSell;

		// Token: 0x04015D98 RID: 89496
		public bool IsSelect;

		// Token: 0x04015D99 RID: 89497
		public bool IsNew;

		// Token: 0x04015D9A RID: 89498
		public int Discounted;

		// Token: 0x04015D9B RID: 89499
		public int Cost;

		// Token: 0x04015D9C RID: 89500
		public int? BindId;

		// Token: 0x04015D9D RID: 89501
		public int RestCount;

		// Token: 0x04015D9E RID: 89502
		public bool IsValid;
	}
}
