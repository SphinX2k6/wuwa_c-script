using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D85 RID: 19845
	public class RoguelikeEntryData
	{
		// Token: 0x060334D5 RID: 210133 RVA: 0x00BF96FC File Offset: 0x00BF78FC
		public RogueHotEntry GetConfig()
		{
			return RoguelikeConfig.Instance.GetRogueHotEntryConfig(this.Id).Value;
		}

		// Token: 0x0401B3A3 RID: 111523
		public int Id;

		// Token: 0x0401B3A4 RID: 111524
		public int GroupId;

		// Token: 0x0401B3A5 RID: 111525
		public ERoguelikeEntryType Type = ERoguelikeEntryType.Type1;

		// Token: 0x0401B3A6 RID: 111526
		public int OverviewId;

		// Token: 0x0401B3A7 RID: 111527
		[Nullable(1)]
		public List<int> OverviewParam = new List<int>();

		// Token: 0x0401B3A8 RID: 111528
		[Nullable(2)]
		public Action<bool, bool> SetEntryToggleState;
	}
}
