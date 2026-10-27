using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499C RID: 18844
	public class NavigationGroupUpNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06031149 RID: 201033 RVA: 0x00B63C5F File Offset: 0x00B61E5F
		public NavigationGroupUpNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603114A RID: 201034 RVA: 0x00B63C68 File Offset: 0x00B61E68
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Up;
		}
	}
}
