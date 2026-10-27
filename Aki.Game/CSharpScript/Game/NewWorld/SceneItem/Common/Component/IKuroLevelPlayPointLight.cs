using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x0200720F RID: 29199
	[NullableContext(1)]
	public interface IKuroLevelPlayPointLight
	{
		// Token: 0x17009E1D RID: 40477
		// (get) Token: 0x060477A0 RID: 292768
		// (set) Token: 0x060477A1 RID: 292769
		float Radius { get; set; }

		// Token: 0x17009E1E RID: 40478
		// (get) Token: 0x060477A2 RID: 292770
		// (set) Token: 0x060477A3 RID: 292771
		bool IsLit { get; set; }

		// Token: 0x17009E1F RID: 40479
		// (get) Token: 0x060477A4 RID: 292772
		// (set) Token: 0x060477A5 RID: 292773
		Vector Position { get; set; }

		// Token: 0x060477A6 RID: 292774
		bool Equals(IKuroLevelPlayPointLight b);
	}
}
