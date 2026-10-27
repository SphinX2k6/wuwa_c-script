using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A6 RID: 18854
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleCardRecycleComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06031168 RID: 201064 RVA: 0x00B6408C File Offset: 0x00B6228C
		public PhantomArenaBattleCardRecycleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x170079DA RID: 31194
		// (get) Token: 0x06031169 RID: 201065 RVA: 0x00B64098 File Offset: 0x00B62298
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

		// Token: 0x0603116A RID: 201066 RVA: 0x00B640DA File Offset: 0x00B622DA
		[NullableContext(1)]
		protected override void ClickButton(string tag)
		{
			if (this.Proxy != null)
			{
				this.Proxy.GamepadLogic.TriggerRecycleCard();
			}
		}

		// Token: 0x0603116B RID: 201067 RVA: 0x00B640F4 File Offset: 0x00B622F4
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (this.Proxy == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!this.Proxy.GamepadLogic.IsInCardSelectState)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (this.Proxy.IsInPanelInteract && !this.Proxy.IsMainInVisible)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x0401A4B0 RID: 107696
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
