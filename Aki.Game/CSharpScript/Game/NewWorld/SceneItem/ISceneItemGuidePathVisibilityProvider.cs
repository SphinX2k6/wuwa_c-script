using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02006216 RID: 25110
	[NullableContext(1)]
	public interface ISceneItemGuidePathVisibilityProvider
	{
		// Token: 0x170071FE RID: 29182
		// (get) Token: 0x0603C610 RID: 247312
		// (set) Token: 0x0603C611 RID: 247313
		Func<bool> IsVisible { get; set; }

		// Token: 0x170071FF RID: 29183
		// (get) Token: 0x0603C612 RID: 247314
		// (set) Token: 0x0603C613 RID: 247315
		[Nullable(2)]
		Action OnDetached { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
