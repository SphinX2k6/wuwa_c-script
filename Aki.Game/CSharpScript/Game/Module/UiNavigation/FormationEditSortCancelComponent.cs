using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004964 RID: 18788
	public class FormationEditSortCancelComponent : FormationEditSortBaseComponent
	{
		// Token: 0x06031031 RID: 200753 RVA: 0x00B612B8 File Offset: 0x00B5F4B8
		public FormationEditSortCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031032 RID: 200754 RVA: 0x00B612C1 File Offset: 0x00B5F4C1
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.Cancel();
		}

		// Token: 0x06031033 RID: 200755 RVA: 0x00B612C8 File Offset: 0x00B5F4C8
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}
	}
}
