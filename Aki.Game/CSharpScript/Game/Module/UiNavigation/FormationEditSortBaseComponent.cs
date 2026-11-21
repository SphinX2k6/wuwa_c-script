using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038D9 RID: 14553
	public abstract class FormationEditSortBaseComponent : HotKeyComponent
	{
		// Token: 0x06025B58 RID: 154456 RVA: 0x00A9C146 File Offset: 0x00A9A346
		protected FormationEditSortBaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationEditSortController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06025B59 RID: 154457 RVA: 0x00A9C15A File Offset: 0x00A9A35A
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsVisibleSelf(), false);
		}

		// Token: 0x06025B5A RID: 154458
		protected abstract bool IsVisibleSelf();
	}
}
