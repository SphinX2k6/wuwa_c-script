using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003917 RID: 14615
	public class NavigationGroupDownNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06025C81 RID: 154753 RVA: 0x00A9EBBB File Offset: 0x00A9CDBB
		public NavigationGroupDownNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C82 RID: 154754 RVA: 0x00A9EBC4 File Offset: 0x00A9CDC4
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Down;
		}
	}
}
