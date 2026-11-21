using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038DB RID: 14555
	public class FormationEditSortConfirmComponent : FormationEditSortBaseComponent
	{
		// Token: 0x06025B5E RID: 154462 RVA: 0x00A9C181 File Offset: 0x00A9A381
		public FormationEditSortConfirmComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025B5F RID: 154463 RVA: 0x00A9C18A File Offset: 0x00A9A38A
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.Confirm();
		}

		// Token: 0x06025B60 RID: 154464 RVA: 0x00A9C191 File Offset: 0x00A9A391
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.IsSortMode;
		}
	}
}
