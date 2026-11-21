using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200510F RID: 20751
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootUnlockViewOpenParam : IRoverlikeLootUnlockViewOpenParam
	{
		// Token: 0x17006554 RID: 25940
		// (get) Token: 0x06033E8E RID: 212622 RVA: 0x00E8612F File Offset: 0x00E8432F
		// (set) Token: 0x06033E8F RID: 212623 RVA: 0x00E86137 File Offset: 0x00E84337
		public List<RoverRogueGainEntry> Loots { get; set; } = new List<RoverRogueGainEntry>();

		// Token: 0x17006555 RID: 25941
		// (get) Token: 0x06033E90 RID: 212624 RVA: 0x00E86140 File Offset: 0x00E84340
		// (set) Token: 0x06033E91 RID: 212625 RVA: 0x00E86148 File Offset: 0x00E84348
		[Nullable(2)]
		public Action OnClosed { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
