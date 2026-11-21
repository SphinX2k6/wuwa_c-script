using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003920 RID: 14624
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleCardRecycleComponent : LongTimeToTriggerComponent
	{
		// Token: 0x06025C9E RID: 154782 RVA: 0x00A9EFDC File Offset: 0x00A9D1DC
		public PhantomArenaBattleCardRecycleComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x06025C9F RID: 154783 RVA: 0x00A9EFE8 File Offset: 0x00A9D1E8
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

		// Token: 0x06025CA0 RID: 154784 RVA: 0x00A9F02A File Offset: 0x00A9D22A
		[NullableContext(1)]
		protected override void ClickButton(string tag)
		{
			if (this.Proxy != null)
			{
				this.Proxy.GamepadLogic.TriggerRecycleCard();
			}
		}

		// Token: 0x06025CA1 RID: 154785 RVA: 0x00A9F044 File Offset: 0x00A9D244
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

		// Token: 0x04014D22 RID: 85282
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
