using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499E RID: 18846
	public class NavigationGroupLeftNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x0603114D RID: 201037 RVA: 0x00B63C77 File Offset: 0x00B61E77
		public NavigationGroupLeftNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603114E RID: 201038 RVA: 0x00B63C80 File Offset: 0x00B61E80
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Left;
		}
	}
}
