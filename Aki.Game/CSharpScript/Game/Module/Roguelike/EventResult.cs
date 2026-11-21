using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D52 RID: 15698
	[NullableContext(2)]
	[Nullable(0)]
	public class EventResult
	{
		// Token: 0x06028352 RID: 164690 RVA: 0x00B43121 File Offset: 0x00B41321
		public EventResult([Nullable(new byte[]
		{
			2,
			1
		})] List<RogueGainEntry> rogueGainEntryArray, Action<bool?> callback = null)
		{
			this.RogueGainEntryArray = rogueGainEntryArray;
			this.Callback = callback;
		}

		// Token: 0x04015D85 RID: 89477
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<RogueGainEntry> RogueGainEntryArray;

		// Token: 0x04015D86 RID: 89478
		public Action<bool?> Callback;
	}
}
