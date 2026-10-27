using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063BB RID: 25531
	[NullableContext(1)]
	public interface IMowingBuffGridGroupData
	{
		// Token: 0x170093AB RID: 37803
		// (get) Token: 0x060403B3 RID: 263091
		// (set) Token: 0x060403B4 RID: 263092
		string GroupNameTextId { get; set; }

		// Token: 0x170093AC RID: 37804
		// (get) Token: 0x060403B5 RID: 263093
		// (set) Token: 0x060403B6 RID: 263094
		bool ShowUnlockText { get; set; }

		// Token: 0x170093AD RID: 37805
		// (get) Token: 0x060403B7 RID: 263095
		// (set) Token: 0x060403B8 RID: 263096
		IMowingBuffGridItemData[] BuffItemList { get; set; }
	}
}
