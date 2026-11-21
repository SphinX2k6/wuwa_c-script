using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005076 RID: 20598
	[NullableContext(1)]
	public interface IRoverlikeBlessingSuitData
	{
		// Token: 0x170064B7 RID: 25783
		// (get) Token: 0x06033926 RID: 211238
		// (set) Token: 0x06033927 RID: 211239
		int SuitId { get; set; }

		// Token: 0x170064B8 RID: 25784
		// (get) Token: 0x06033928 RID: 211240
		// (set) Token: 0x06033929 RID: 211241
		List<int> BlessingIdList { get; set; }
	}
}
