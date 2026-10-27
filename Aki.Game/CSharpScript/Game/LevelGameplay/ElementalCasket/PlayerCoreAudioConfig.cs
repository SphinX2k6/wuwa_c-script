using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E8B RID: 28299
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerCoreAudioConfig
	{
		// Token: 0x06044F89 RID: 282505 RVA: 0x0110B458 File Offset: 0x01109658
		public PlayerCoreAudioConfig(string WhooshEventName, string LoopEventName)
		{
			this.WhooshEventName = WhooshEventName;
			this.LoopEventName = LoopEventName;
		}

		// Token: 0x04023E8F RID: 147087
		public readonly string WhooshEventName;

		// Token: 0x04023E90 RID: 147088
		public readonly string LoopEventName;
	}
}
