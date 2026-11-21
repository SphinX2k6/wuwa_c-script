using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D4E RID: 15694
	public class RoguelikeEntryData
	{
		// Token: 0x06028342 RID: 164674 RVA: 0x00B42CF8 File Offset: 0x00B40EF8
		public RogueHotEntry GetConfig()
		{
			return RoguelikeConfig.Instance.GetRogueHotEntryConfig(this.Id).Value;
		}

		// Token: 0x04015D76 RID: 89462
		public int Id;

		// Token: 0x04015D77 RID: 89463
		public int GroupId;

		// Token: 0x04015D78 RID: 89464
		public ERoguelikeEntryType Type = ERoguelikeEntryType.Type1;

		// Token: 0x04015D79 RID: 89465
		public int OverviewId;

		// Token: 0x04015D7A RID: 89466
		[Nullable(1)]
		public List<int> OverviewParam = new List<int>();

		// Token: 0x04015D7B RID: 89467
		[Nullable(2)]
		public Action<bool, bool> SetEntryToggleState;
	}
}
