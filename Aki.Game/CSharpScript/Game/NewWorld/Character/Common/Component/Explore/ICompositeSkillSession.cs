using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Explore
{
	// Token: 0x0200634F RID: 25423
	[NullableContext(1)]
	public interface ICompositeSkillSession
	{
		// Token: 0x170074F5 RID: 29941
		// (get) Token: 0x0603D9B6 RID: 252342
		// (set) Token: 0x0603D9B7 RID: 252343
		ICompositeExploreSkillConfig Config { get; set; }

		// Token: 0x170074F6 RID: 29942
		// (get) Token: 0x0603D9B8 RID: 252344
		// (set) Token: 0x0603D9B9 RID: 252345
		bool EnterSent { get; set; }

		// Token: 0x170074F7 RID: 29943
		// (get) Token: 0x0603D9BA RID: 252346
		// (set) Token: 0x0603D9BB RID: 252347
		double CreatedTime { get; set; }
	}
}
