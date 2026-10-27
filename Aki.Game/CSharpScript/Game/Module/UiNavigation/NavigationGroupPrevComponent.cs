using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A0 RID: 18848
	public class NavigationGroupPrevComponent : NavigationGroupPrevComponentBase
	{
		// Token: 0x06031157 RID: 201047 RVA: 0x00B63D55 File Offset: 0x00B61F55
		public NavigationGroupPrevComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031158 RID: 201048 RVA: 0x00B63D5E File Offset: 0x00B61F5E
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Left;
		}
	}
}
