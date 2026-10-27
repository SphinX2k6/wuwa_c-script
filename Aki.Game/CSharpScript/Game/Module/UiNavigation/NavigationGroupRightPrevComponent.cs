using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A1 RID: 18849
	public class NavigationGroupRightPrevComponent : NavigationGroupPrevComponentBase
	{
		// Token: 0x06031159 RID: 201049 RVA: 0x00B63D61 File Offset: 0x00B61F61
		public NavigationGroupRightPrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603115A RID: 201050 RVA: 0x00B63D6A File Offset: 0x00B61F6A
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Right;
		}
	}
}
