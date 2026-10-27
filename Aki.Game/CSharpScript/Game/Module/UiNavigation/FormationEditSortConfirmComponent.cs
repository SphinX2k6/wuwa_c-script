using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004963 RID: 18787
	public class FormationEditSortConfirmComponent : FormationEditSortBaseComponent
	{
		// Token: 0x0603102E RID: 200750 RVA: 0x00B612A1 File Offset: 0x00B5F4A1
		public FormationEditSortConfirmComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603102F RID: 200751 RVA: 0x00B612AA File Offset: 0x00B5F4AA
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.Confirm();
		}

		// Token: 0x06031030 RID: 200752 RVA: 0x00B612B1 File Offset: 0x00B5F4B1
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}
	}
}
