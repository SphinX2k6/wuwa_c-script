using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063C7 RID: 25543
	[NullableContext(1)]
	public interface IMowingRiskInstanceDetailLockItemData
	{
		// Token: 0x170093D7 RID: 37847
		// (get) Token: 0x06040411 RID: 263185
		// (set) Token: 0x06040412 RID: 263186
		bool IsUnlock { get; set; }

		// Token: 0x170093D8 RID: 37848
		// (get) Token: 0x06040413 RID: 263187
		// (set) Token: 0x06040414 RID: 263188
		string LockDescriptionTextId { get; set; }

		// Token: 0x170093D9 RID: 37849
		// (get) Token: 0x06040415 RID: 263189
		// (set) Token: 0x06040416 RID: 263190
		string[] LockDescriptionTextArgs { get; set; }
	}
}
