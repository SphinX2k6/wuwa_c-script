using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003915 RID: 14613
	public class NavigationGroupNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06025C7D RID: 154749 RVA: 0x00A9EBA3 File Offset: 0x00A9CDA3
		public NavigationGroupNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C7E RID: 154750 RVA: 0x00A9EBAC File Offset: 0x00A9CDAC
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Right;
		}
	}
}
