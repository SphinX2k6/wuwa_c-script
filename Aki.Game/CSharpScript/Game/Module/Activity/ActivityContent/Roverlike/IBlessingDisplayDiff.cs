using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C2 RID: 20674
	[NullableContext(1)]
	public interface IBlessingDisplayDiff
	{
		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x06033BD9 RID: 211929
		// (set) Token: 0x06033BDA RID: 211930
		List<IRoverlikeBlessingSlotItemData> DataList { get; set; }

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x06033BDB RID: 211931
		// (set) Token: 0x06033BDC RID: 211932
		List<int> ChangedSlots { get; set; }

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x06033BDD RID: 211933
		// (set) Token: 0x06033BDE RID: 211934
		int Count { get; set; }
	}
}
