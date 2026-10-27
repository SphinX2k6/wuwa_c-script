using System;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004962 RID: 18786
	public class FormationEditSortComponent : FormationEditSortBaseComponent
	{
		// Token: 0x0603102B RID: 200747 RVA: 0x00B6128A File Offset: 0x00B5F48A
		public FormationEditSortComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603102C RID: 200748 RVA: 0x00B61293 File Offset: 0x00B5F493
		protected override void OnPress(HotKeyMap config)
		{
			FormationEditSortController.EnterSortMode();
		}

		// Token: 0x0603102D RID: 200749 RVA: 0x00B6129A File Offset: 0x00B5F49A
		protected override bool IsVisibleSelf()
		{
			return FormationEditSortController.CanEnterSortMode();
		}
	}
}
