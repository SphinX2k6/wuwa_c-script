using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DC RID: 14556
	public class FormationEditSortCancelComponent : FormationEditSortBaseComponent
	{
		// Token: 0x06025B61 RID: 154465 RVA: 0x00A9C198 File Offset: 0x00A9A398
		public FormationEditSortCancelComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B62 RID: 154466 RVA: 0x00A9C1A1 File Offset: 0x00A9A3A1
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.Cancel();
		}

		// Token: 0x06025B63 RID: 154467 RVA: 0x00A9C1A8 File Offset: 0x00A9A3A8
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}
	}
}
