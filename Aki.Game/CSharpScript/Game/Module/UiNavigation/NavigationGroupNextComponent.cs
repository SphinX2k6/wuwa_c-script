using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200499B RID: 18843
	public class NavigationGroupNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06031147 RID: 201031 RVA: 0x00B63C53 File Offset: 0x00B61E53
		public NavigationGroupNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031148 RID: 201032 RVA: 0x00B63C5C File Offset: 0x00B61E5C
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Right;
		}
	}
}
