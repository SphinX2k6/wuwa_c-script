using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D8C RID: 19852
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeChooseData
	{
		// Token: 0x060334ED RID: 210157 RVA: 0x00BF9F58 File Offset: 0x00BF8158
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

		// Token: 0x0401B3CC RID: 111564
		public int Index;

		// Token: 0x0401B3CD RID: 111565
		public RoguelikeGainDataType? RoguelikeGainDataType;

		// Token: 0x0401B3CE RID: 111566
		public int? MaxTime;

		// Token: 0x0401B3CF RID: 111567
		public int? UseTime;

		// Token: 0x0401B3D0 RID: 111568
		public int? EventId;

		// Token: 0x0401B3D1 RID: 111569
		public int? Layer;

		// Token: 0x0401B3D2 RID: 111570
		public bool? IsSelect;

		// Token: 0x0401B3D3 RID: 111571
		public List<RogueGainEntry> RogueGainEntryList;

		// Token: 0x0401B3D4 RID: 111572
		public IReadOnlyList<NumItem> CostCurrency;

		// Token: 0x0401B3D5 RID: 111573
		[Nullable(2)]
		public Action CallBack;
	}
}
