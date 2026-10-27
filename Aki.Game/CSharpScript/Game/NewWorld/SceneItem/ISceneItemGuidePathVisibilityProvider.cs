using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x02007162 RID: 29026
	[NullableContext(1)]
	public interface ISceneItemGuidePathVisibilityProvider
	{
		// Token: 0x17009D53 RID: 40275
		// (get) Token: 0x06046DC4 RID: 290244
		// (set) Token: 0x06046DC5 RID: 290245
		Func<bool> IsVisible { get; set; }

		// Token: 0x17009D54 RID: 40276
		// (get) Token: 0x06046DC6 RID: 290246
		// (set) Token: 0x06046DC7 RID: 290247
		[Nullable(2)]
		Action OnDetached { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
