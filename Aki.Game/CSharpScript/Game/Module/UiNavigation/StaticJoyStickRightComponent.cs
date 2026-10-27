using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049E6 RID: 18918
	public class StaticJoyStickRightComponent : StaticJoyStickComponentBase
	{
		// Token: 0x06031235 RID: 201269 RVA: 0x00B6582B File Offset: 0x00B63A2B
		public StaticJoyStickRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			this.Pivot = Vector2D.Create(0.9900000095367432, 0.5);
		}
	}
}
