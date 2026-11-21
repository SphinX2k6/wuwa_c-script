using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DA RID: 14554
	public class FormationEditSortComponent : FormationEditSortBaseComponent
	{
		// Token: 0x06025B5B RID: 154459 RVA: 0x00A9C16A File Offset: 0x00A9A36A
		public FormationEditSortComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B5C RID: 154460 RVA: 0x00A9C173 File Offset: 0x00A9A373
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.EnterSortMode();
		}

		// Token: 0x06025B5D RID: 154461 RVA: 0x00A9C17A File Offset: 0x00A9A37A
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.CanEnterSortMode();
		}
	}
}
