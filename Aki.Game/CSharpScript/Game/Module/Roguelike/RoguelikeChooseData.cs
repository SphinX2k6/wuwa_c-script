using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D55 RID: 15701
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeChooseData
	{
		// Token: 0x0602835A RID: 164698 RVA: 0x00B43554 File Offset: 0x00B41754
		public RoguelikeChooseData(RoguelikeChooseData roguelikeChooseData)
		{
			this.Index = roguelikeChooseData.Index;
			this.RoguelikeGainDataType = new RoguelikeGainDataType?(roguelikeChooseData.Type);
			this.MaxTime = new int?(roguelikeChooseData.MaxTime);
			this.UseTime = new int?(roguelikeChooseData.UseTime);
			this.EventId = new int?(roguelikeChooseData.EventId);
			this.Layer = new int?(roguelikeChooseData.Layer);
			this.IsSelect = new bool?(roguelikeChooseData.IsSelect);
			this.RogueGainEntryList = new List<RogueGainEntry>();
			if (roguelikeChooseData.RogueGainEntryList != null)
			{
				foreach (RogueGainEntry rogueGainEntry in roguelikeChooseData.RogueGainEntryList)
				{
					this.RogueGainEntryList.Add(new RogueGainEntry(rogueGainEntry, new int?(this.Index)));
				}
			}
			this.CostCurrency = roguelikeChooseData.NumItems;
		}

		// Token: 0x04015D9F RID: 89503
		public int Index;

		// Token: 0x04015DA0 RID: 89504
		public RoguelikeGainDataType? RoguelikeGainDataType;

		// Token: 0x04015DA1 RID: 89505
		public int? MaxTime;

		// Token: 0x04015DA2 RID: 89506
		public int? UseTime;

		// Token: 0x04015DA3 RID: 89507
		public int? EventId;

		// Token: 0x04015DA4 RID: 89508
		public int? Layer;

		// Token: 0x04015DA5 RID: 89509
		public bool? IsSelect;

		// Token: 0x04015DA6 RID: 89510
		public List<RogueGainEntry> RogueGainEntryList;

		// Token: 0x04015DA7 RID: 89511
		public IReadOnlyList<NumItem> CostCurrency;

		// Token: 0x04015DA8 RID: 89512
		[Nullable(2)]
		public Action CallBack;
	}
}
