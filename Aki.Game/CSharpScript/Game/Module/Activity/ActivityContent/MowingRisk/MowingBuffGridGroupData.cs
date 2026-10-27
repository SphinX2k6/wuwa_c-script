using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063BC RID: 25532
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingBuffGridGroupData : IMowingBuffGridGroupData
	{
		// Token: 0x170093AE RID: 37806
		// (get) Token: 0x060403B9 RID: 263097 RVA: 0x00F8B734 File Offset: 0x00F89934
		// (set) Token: 0x060403BA RID: 263098 RVA: 0x00F8B73C File Offset: 0x00F8993C
		public string GroupNameTextId { get; set; }

		// Token: 0x170093AF RID: 37807
		// (get) Token: 0x060403BB RID: 263099 RVA: 0x00F8B745 File Offset: 0x00F89945
		// (set) Token: 0x060403BC RID: 263100 RVA: 0x00F8B74D File Offset: 0x00F8994D
		public bool ShowUnlockText { get; set; }

		// Token: 0x170093B0 RID: 37808
		// (get) Token: 0x060403BD RID: 263101 RVA: 0x00F8B756 File Offset: 0x00F89956
		// (set) Token: 0x060403BE RID: 263102 RVA: 0x00F8B75E File Offset: 0x00F8995E
		public IMowingBuffGridItemData[] BuffItemList { get; set; }
	}
}
