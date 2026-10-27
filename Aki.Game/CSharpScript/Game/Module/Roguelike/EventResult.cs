using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D89 RID: 19849
	[NullableContext(2)]
	[Nullable(0)]
	public class EventResult
	{
		// Token: 0x060334E5 RID: 210149 RVA: 0x00BF9B25 File Offset: 0x00BF7D25
		public EventResult([Nullable(new byte[]
		{
			2,
			1
		})] List<RogueGainEntry> rogueGainEntryArray, Action<bool?> callback = null)
		{
			this.RogueGainEntryArray = rogueGainEntryArray;
			this.Callback = callback;
		}

		// Token: 0x0401B3B2 RID: 111538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RogueGainEntry> RogueGainEntryArray;

		// Token: 0x0401B3B3 RID: 111539
		public Action<bool?> Callback;
	}
}
