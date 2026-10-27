using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055F9 RID: 22009
	[NullableContext(2)]
	public interface IEventStepItem
	{
		// Token: 0x17008714 RID: 34580
		// (get) Token: 0x06038080 RID: 229504
		int StepId { get; }

		// Token: 0x17008715 RID: 34581
		// (get) Token: 0x06038081 RID: 229505
		EStepType StepType { get; }

		// Token: 0x17008716 RID: 34582
		// (get) Token: 0x06038082 RID: 229506
		// (set) Token: 0x06038083 RID: 229507
		Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17008717 RID: 34583
		// (get) Token: 0x06038084 RID: 229508
		// (set) Token: 0x06038085 RID: 229509
		Action<int, int> ExecuteStep { get; set; }

		// Token: 0x06038086 RID: 229510
		void MaskClick();

		// Token: 0x06038087 RID: 229511
		UUIItem GetOriginalItem();
	}
}
