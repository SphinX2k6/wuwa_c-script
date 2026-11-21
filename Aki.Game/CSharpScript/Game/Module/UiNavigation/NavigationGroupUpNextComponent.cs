using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003916 RID: 14614
	public class NavigationGroupUpNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06025C7F RID: 154751 RVA: 0x00A9EBAF File Offset: 0x00A9CDAF
		public NavigationGroupUpNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C80 RID: 154752 RVA: 0x00A9EBB8 File Offset: 0x00A9CDB8
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Up;
		}
	}
}
