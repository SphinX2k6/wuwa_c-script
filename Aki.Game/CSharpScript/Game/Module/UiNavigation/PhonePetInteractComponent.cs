using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003928 RID: 14632
	[NullableContext(1)]
	[Nullable(0)]
	public class PhonePetInteractComponent : HotKeyComponent
	{
		// Token: 0x06025CBF RID: 154815 RVA: 0x00A9F60A File Offset: 0x00A9D80A
		public PhonePetInteractComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CC0 RID: 154816 RVA: 0x00A9F614 File Offset: 0x00A9D814
		public void SetDataCallback(Func<object> callback)
		{
			this.InteractAction = delegate()
			{
				callback();
			};
		}

		// Token: 0x06025CC1 RID: 154817 RVA: 0x00A9F640 File Offset: 0x00A9D840
		protected override void OnPress(HotKeyMap config)
		{
			Action interactAction = this.InteractAction;
			if (interactAction == null)
			{
				return;
			}
			interactAction();
		}

		// Token: 0x06025CC2 RID: 154818 RVA: 0x00A9F652 File Offset: 0x00A9D852
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.InteractAction != null, false);
		}

		// Token: 0x06025CC3 RID: 154819 RVA: 0x00A9F665 File Offset: 0x00A9D865
		protected override bool OnIsOccupancyFightInput()
		{
			return false;
		}

		// Token: 0x06025CC4 RID: 154820 RVA: 0x00A9F668 File Offset: 0x00A9D868
		protected override void OnClear()
		{
			base.OnClear();
			this.InteractAction = null;
		}

		// Token: 0x04014D29 RID: 85289
		[Nullable(2)]
		private Action InteractAction;
	}
}
