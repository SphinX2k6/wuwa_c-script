using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005078 RID: 20600
	[NullableContext(1)]
	public interface IRoverlikeBlessingSuitSelectParam
	{
		// Token: 0x170064BB RID: 25787
		// (get) Token: 0x0603392F RID: 211247
		// (set) Token: 0x06033930 RID: 211248
		List<IRoverlikeBlessingSuitData> SuitDataList { get; set; }

		// Token: 0x170064BC RID: 25788
		// (get) Token: 0x06033931 RID: 211249
		// (set) Token: 0x06033932 RID: 211250
		int SelectedIndex { get; set; }
	}
}
