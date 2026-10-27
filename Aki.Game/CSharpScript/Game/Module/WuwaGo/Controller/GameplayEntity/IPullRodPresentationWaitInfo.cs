using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x02004775 RID: 18293
	[NullableContext(1)]
	public interface IPullRodPresentationWaitInfo
	{
		// Token: 0x1700776F RID: 30575
		// (get) Token: 0x0602FD35 RID: 195893
		SceneInteractionActor SceneActor { get; }

		// Token: 0x17007770 RID: 30576
		// (get) Token: 0x0602FD36 RID: 195894
		ULevelSequence Sequence { get; }

		// Token: 0x17007771 RID: 30577
		// (get) Token: 0x0602FD37 RID: 195895
		float PlayRate { get; }
	}
}
