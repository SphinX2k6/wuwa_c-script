using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006190 RID: 24976
	[NullableContext(1)]
	public interface IRoverlikeLootUnlockViewOpenParam
	{
		// Token: 0x170091F0 RID: 37360
		// (get) Token: 0x0603F1CA RID: 258506
		// (set) Token: 0x0603F1CB RID: 258507
		List<RoverRogueGainEntry> Loots { get; set; }

		// Token: 0x170091F1 RID: 37361
		// (get) Token: 0x0603F1CC RID: 258508
		// (set) Token: 0x0603F1CD RID: 258509
		[Nullable(2)]
		Action OnClosed { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
