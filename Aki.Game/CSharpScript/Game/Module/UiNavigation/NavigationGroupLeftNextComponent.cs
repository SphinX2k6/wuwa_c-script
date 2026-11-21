using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003918 RID: 14616
	public class NavigationGroupLeftNextComponent : NavigationGroupNextComponentBase
	{
		// Token: 0x06025C83 RID: 154755 RVA: 0x00A9EBC7 File Offset: 0x00A9CDC7
		public NavigationGroupLeftNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025C84 RID: 154756 RVA: 0x00A9EBD0 File Offset: 0x00A9CDD0
		protected override ENavigationDirectionType GetDirection()
		{
			return ENavigationDirectionType.Left;
		}
	}
}
