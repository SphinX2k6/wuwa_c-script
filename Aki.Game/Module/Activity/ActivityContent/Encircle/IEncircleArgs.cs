using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02003009 RID: 12297
	[NullableContext(1)]
	public interface IEncircleArgs
	{
		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0601D2E9 RID: 119529
		// (set) Token: 0x0601D2EA RID: 119530
		Dictionary<int, IHexData> Hexes { get; set; }

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0601D2EB RID: 119531
		// (set) Token: 0x0601D2EC RID: 119532
		int Height { get; set; }

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0601D2ED RID: 119533
		// (set) Token: 0x0601D2EE RID: 119534
		int Width { get; set; }
	}
}
