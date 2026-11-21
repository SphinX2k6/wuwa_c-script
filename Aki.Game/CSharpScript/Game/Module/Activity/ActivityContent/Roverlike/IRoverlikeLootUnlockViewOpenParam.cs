using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510E RID: 20750
	[NullableContext(1)]
	public interface IRoverlikeLootUnlockViewOpenParam
	{
		// Token: 0x17006552 RID: 25938
		// (get) Token: 0x06033E8A RID: 212618
		// (set) Token: 0x06033E8B RID: 212619
		List<RoverRogueGainEntry> Loots { get; set; }

		// Token: 0x17006553 RID: 25939
		// (get) Token: 0x06033E8C RID: 212620
		// (set) Token: 0x06033E8D RID: 212621
		[Nullable(2)]
		Action OnClosed { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
