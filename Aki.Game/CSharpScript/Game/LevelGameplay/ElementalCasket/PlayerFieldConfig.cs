using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E8A RID: 28298
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFieldConfig
	{
		// Token: 0x06044F88 RID: 282504 RVA: 0x0110B442 File Offset: 0x01109642
		public PlayerFieldConfig(List<long> UnopenedFieldGameplayCueList, List<long> OpenedFieldGameplayCueList)
		{
			this.UnopenedFieldGameplayCueList = UnopenedFieldGameplayCueList;
			this.OpenedFieldGameplayCueList = OpenedFieldGameplayCueList;
		}

		// Token: 0x04023E8D RID: 147085
		public readonly List<long> UnopenedFieldGameplayCueList;

		// Token: 0x04023E8E RID: 147086
		public readonly List<long> OpenedFieldGameplayCueList;
	}
}
