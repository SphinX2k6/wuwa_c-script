using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499D RID: 18845
	public class NavigationGroupDownNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x0603114B RID: 201035 RVA: 0x00B63C6B File Offset: 0x00B61E6B
		public NavigationGroupDownNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603114C RID: 201036 RVA: 0x00B63C74 File Offset: 0x00B61E74
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Down;
		}
	}
}
