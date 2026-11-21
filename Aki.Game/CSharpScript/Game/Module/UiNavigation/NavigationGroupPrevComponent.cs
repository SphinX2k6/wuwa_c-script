using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200391A RID: 14618
	public class NavigationGroupPrevComponent : NavigationGroupPrevComponentBase
	{
		// Token: 0x06025C8D RID: 154765 RVA: 0x00A9ECA5 File Offset: 0x00A9CEA5
		public NavigationGroupPrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C8E RID: 154766 RVA: 0x00A9ECAE File Offset: 0x00A9CEAE
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Left;
		}
	}
}
