using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006191 RID: 24977
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeLootUnlockViewOpenParam : IRoverlikeLootUnlockViewOpenParam
	{
		// Token: 0x170091F2 RID: 37362
		// (get) Token: 0x0603F1CE RID: 258510 RVA: 0x00F3F267 File Offset: 0x00F3D467
		// (set) Token: 0x0603F1CF RID: 258511 RVA: 0x00F3F26F File Offset: 0x00F3D46F
		public List<RoverRogueGainEntry> Loots { get; set; } = new List<RoverRogueGainEntry>();

		// Token: 0x170091F3 RID: 37363
		// (get) Token: 0x0603F1D0 RID: 258512 RVA: 0x00F3F278 File Offset: 0x00F3D478
		// (set) Token: 0x0603F1D1 RID: 258513 RVA: 0x00F3F280 File Offset: 0x00F3D480
		[Nullable(2)]
		public Action OnClosed { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
