using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003923 RID: 14627
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleComponentBase : HotKeyComponent
	{
		// Token: 0x06025CB0 RID: 154800 RVA: 0x00A9F41B File Offset: 0x00A9D61B
		public PhantomArenaBattleComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x06025CB1 RID: 154801 RVA: 0x00A9F424 File Offset: 0x00A9D624
		protected PhantomArenaBattleProxy Proxy
		{
			get
			{
				if (this.ProxyInternal == null)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleView);
					this.ProxyInternal = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleProxy);
				}
				return this.ProxyInternal;
			}
		}

		// Token: 0x06025CB2 RID: 154802 RVA: 0x00A9F468 File Offset: 0x00A9D668
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (this.Proxy == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!this.Proxy.IsInPanelInteract)
			{
				this.OnRefreshSelfHotKeyStateImplement();
				return;
			}
			if (this.Proxy.IsMainInVisible)
			{
				this.OnRefreshSelfHotKeyStateIsMainInVisible();
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}

		// Token: 0x06025CB3 RID: 154803 RVA: 0x00A9F4B8 File Offset: 0x00A9D6B8
		protected virtual void OnRefreshSelfHotKeyStateImplement()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x06025CB4 RID: 154804 RVA: 0x00A9F4C3 File Offset: 0x00A9D6C3
		protected virtual void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}

		// Token: 0x04014D23 RID: 85283
		private PhantomArenaBattleProxy ProxyInternal;
	}
}
