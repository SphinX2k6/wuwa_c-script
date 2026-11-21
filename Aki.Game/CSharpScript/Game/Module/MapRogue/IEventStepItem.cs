using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045CF RID: 17871
	[NullableContext(2)]
	public interface IEventStepItem
	{
		// Token: 0x17005ADB RID: 23259
		// (get) Token: 0x0602CF7E RID: 184190
		int StepId { get; }

		// Token: 0x17005ADC RID: 23260
		// (get) Token: 0x0602CF7F RID: 184191
		EStepType StepType { get; }

		// Token: 0x17005ADD RID: 23261
		// (get) Token: 0x0602CF80 RID: 184192
		// (set) Token: 0x0602CF81 RID: 184193
		Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17005ADE RID: 23262
		// (get) Token: 0x0602CF82 RID: 184194
		// (set) Token: 0x0602CF83 RID: 184195
		Action<int, int> ExecuteStep { get; set; }

		// Token: 0x0602CF84 RID: 184196
		void MaskClick();

		// Token: 0x0602CF85 RID: 184197
		UUIItem GetOriginalItem();
	}
}
