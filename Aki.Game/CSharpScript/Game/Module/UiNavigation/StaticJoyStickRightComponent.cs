using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003960 RID: 14688
	public class StaticJoyStickRightComponent : StaticJoyStickComponentBase
	{
		// Token: 0x06025D6B RID: 154987 RVA: 0x00AA077B File Offset: 0x00A9E97B
		public StaticJoyStickRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			this.Pivot = Vector2D.Create(0.9900000095367432, 0.5);
		}
	}
}
