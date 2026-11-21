using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200391B RID: 14619
	public class NavigationGroupRightPrevComponent : NavigationGroupPrevComponentBase
	{
		// Token: 0x06025C8F RID: 154767 RVA: 0x00A9ECB1 File Offset: 0x00A9CEB1
		public NavigationGroupRightPrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C90 RID: 154768 RVA: 0x00A9ECBA File Offset: 0x00A9CEBA
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Right;
		}
	}
}
