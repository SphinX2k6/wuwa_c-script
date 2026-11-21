using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameplayEntity
{
	// Token: 0x020036A6 RID: 13990
	[NullableContext(1)]
	public interface IPullRodPresentationWaitInfo
	{
		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x060244FF RID: 148735
		SceneInteractionActor SceneActor { get; }

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x06024500 RID: 148736
		ULevelSequence Sequence { get; }

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x06024501 RID: 148737
		float PlayRate { get; }
	}
}
