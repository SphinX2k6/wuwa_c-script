using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003547 RID: 13639
	[NullableContext(2)]
	public interface IUiPanelBase
	{
		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06022B0D RID: 142093
		// (set) Token: 0x06022B0E RID: 142094
		bool SkipDestroyActor { get; set; }

		// Token: 0x06022B0F RID: 142095
		void SetUiActive(bool visibility);

		// Token: 0x06022B10 RID: 142096
		UUIItem GetRootItem();
	}
}
