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
	// Token: 0x02004924 RID: 18724
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnHandToggle : NavigationButton
	{
		// Token: 0x06030EA6 RID: 200358 RVA: 0x00B5B55A File Offset: 0x00B5975A
		public NavigationPhantomArenaOwnHandToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079CE RID: 31182
		// (get) Token: 0x06030EA7 RID: 200359 RVA: 0x00B5B568 File Offset: 0x00B59768
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

		// Token: 0x06030EA8 RID: 200360 RVA: 0x00B5B5AA File Offset: 0x00B597AA
		protected override void OnButtonClick()
		{
		}

		// Token: 0x06030EA9 RID: 200361 RVA: 0x00B5B5AC File Offset: 0x00B597AC
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.GamepadLogic.IsInCardSelectState;
		}

		// Token: 0x06030EAA RID: 200362 RVA: 0x00B5B5CD File Offset: 0x00B597CD
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x06030EAB RID: 200363 RVA: 0x00B5B5EA File Offset: 0x00B597EA
		private int GetHandListenerIndex()
		{
			return (this.PanelHandle as PhantomArenaBattlePanelHandle).GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnHandToggle, "GroupNor").IndexOf(this.Listener);
		}

		// Token: 0x06030EAC RID: 200364 RVA: 0x00B5B610 File Offset: 0x00B59810
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

		// Token: 0x06030EAD RID: 200365 RVA: 0x00B5B654 File Offset: 0x00B59854
		public void SwitchHandCardTips()
		{
			if (this.Proxy != null)
			{
				int handListenerIndex = this.GetHandListenerIndex();
				this.Proxy.GamepadLogic.SwitchHandCardTips(handListenerIndex);
			}
		}

		// Token: 0x0401A3DF RID: 107487
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
