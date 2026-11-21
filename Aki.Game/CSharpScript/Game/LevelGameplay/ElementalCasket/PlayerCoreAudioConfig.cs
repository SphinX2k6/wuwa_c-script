using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x0200600C RID: 24588
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerCoreAudioConfig
	{
		// Token: 0x0603B13D RID: 241981 RVA: 0x010B58B4 File Offset: 0x010B3AB4
		public PlayerCoreAudioConfig(string WhooshEventName, string LoopEventName)
		{
			this.WhooshEventName = WhooshEventName;
			this.LoopEventName = LoopEventName;
		}

		// Token: 0x0401F147 RID: 127303
		public readonly string WhooshEventName;

		// Token: 0x0401F148 RID: 127304
		public readonly string LoopEventName;
	}
}
