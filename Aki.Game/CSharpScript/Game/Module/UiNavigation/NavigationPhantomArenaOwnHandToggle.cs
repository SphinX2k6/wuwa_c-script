using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200389B RID: 14491
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnHandToggle : NavigationButton
	{
		// Token: 0x060259D3 RID: 154067 RVA: 0x00A963CA File Offset: 0x00A945CA
		public NavigationPhantomArenaOwnHandToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x060259D4 RID: 154068 RVA: 0x00A963D8 File Offset: 0x00A945D8
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

		// Token: 0x060259D5 RID: 154069 RVA: 0x00A9641A File Offset: 0x00A9461A
		protected override void OnButtonClick()
		{
		}

		// Token: 0x060259D6 RID: 154070 RVA: 0x00A9641C File Offset: 0x00A9461C
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.GamepadLogic.IsInCardSelectState;
		}

		// Token: 0x060259D7 RID: 154071 RVA: 0x00A9643D File Offset: 0x00A9463D
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x060259D8 RID: 154072 RVA: 0x00A9645A File Offset: 0x00A9465A
		private int GetHandListenerIndex()
		{
			return (this.PanelHandle as PhantomArenaBattlePanelHandle).GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnHandToggle, "GroupNor").IndexOf(this.Listener);
		}

		// Token: 0x060259D9 RID: 154073 RVA: 0x00A96480 File Offset: 0x00A94680
		[NullableContext(0)]
		public UniTask<bool> TriggerSelectCard()
		{
			NavigationPhantomArenaOwnHandToggle.<TriggerSelectCard>d__8 <TriggerSelectCard>d__;
			<TriggerSelectCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TriggerSelectCard>d__.<>4__this = this;
			<TriggerSelectCard>d__.<>1__state = -1;
			<TriggerSelectCard>d__.<>t__builder.Start<NavigationPhantomArenaOwnHandToggle.<TriggerSelectCard>d__8>(ref <TriggerSelectCard>d__);
			return <TriggerSelectCard>d__.<>t__builder.Task;
		}

		// Token: 0x060259DA RID: 154074 RVA: 0x00A964C4 File Offset: 0x00A946C4
		public void SwitchHandCardTips()
		{
			if (this.Proxy != null)
			{
				int handListenerIndex = this.GetHandListenerIndex();
				this.Proxy.GamepadLogic.SwitchHandCardTips(handListenerIndex);
			}
		}

		// Token: 0x04014C52 RID: 85074
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
