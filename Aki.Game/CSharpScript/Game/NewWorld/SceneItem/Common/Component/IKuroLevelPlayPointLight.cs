using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062C4 RID: 25284
	[NullableContext(1)]
	public interface IKuroLevelPlayPointLight
	{
		// Token: 0x17007389 RID: 29577
		// (get) Token: 0x0603D0B7 RID: 250039
		// (set) Token: 0x0603D0B8 RID: 250040
		float Radius { get; set; }

		// Token: 0x1700738A RID: 29578
		// (get) Token: 0x0603D0B9 RID: 250041
		// (set) Token: 0x0603D0BA RID: 250042
		bool IsLit { get; set; }

		// Token: 0x1700738B RID: 29579
		// (get) Token: 0x0603D0BB RID: 250043
		// (set) Token: 0x0603D0BC RID: 250044
		Vector Position { get; set; }

		// Token: 0x0603D0BD RID: 250045
		bool Equals(IKuroLevelPlayPointLight b);
	}
}
