using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004961 RID: 18785
	public abstract class FormationEditSortBaseComponent : HotKeyComponent
	{
		// Token: 0x06031028 RID: 200744 RVA: 0x00B61266 File Offset: 0x00B5F466
		protected FormationEditSortBaseComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
			FormationEditSortController.AddCustomShieldHotKeyComponentSetData(this.HotKeyMapIndex);
		}

		// Token: 0x06031029 RID: 200745 RVA: 0x00B6127A File Offset: 0x00B5F47A
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IsVisibleSelf(), false);
		}

		// Token: 0x0603102A RID: 200746
		protected abstract bool IsVisibleSelf();
	}
}
