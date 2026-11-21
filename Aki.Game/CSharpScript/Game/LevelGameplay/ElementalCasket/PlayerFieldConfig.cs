using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x0200600B RID: 24587
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFieldConfig
	{
		// Token: 0x0603B13C RID: 241980 RVA: 0x010B589E File Offset: 0x010B3A9E
		public PlayerFieldConfig(List<long> UnopenedFieldGameplayCueList, List<long> OpenedFieldGameplayCueList)
		{
			this.UnopenedFieldGameplayCueList = UnopenedFieldGameplayCueList;
			this.OpenedFieldGameplayCueList = OpenedFieldGameplayCueList;
		}

		// Token: 0x0401F145 RID: 127301
		public readonly List<long> UnopenedFieldGameplayCueList;

		// Token: 0x0401F146 RID: 127302
		public readonly List<long> OpenedFieldGameplayCueList;
	}
}
