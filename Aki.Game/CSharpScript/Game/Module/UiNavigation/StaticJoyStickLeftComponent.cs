using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E5 RID: 18917
	public class StaticJoyStickLeftComponent : StaticJoyStickComponentBase
	{
		// Token: 0x06031234 RID: 201268 RVA: 0x00B65805 File Offset: 0x00B63A05
		public StaticJoyStickLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			this.Pivot = Vector2D.Create(0.009999999776482582, 0.5);
		}
	}
}
