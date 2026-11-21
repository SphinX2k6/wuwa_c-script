using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200395F RID: 14687
	public class StaticJoyStickLeftComponent : StaticJoyStickComponentBase
	{
		// Token: 0x06025D6A RID: 154986 RVA: 0x00AA0755 File Offset: 0x00A9E955
		public StaticJoyStickLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			this.Pivot = Vector2D.Create(0.009999999776482582, 0.5);
		}
	}
}
