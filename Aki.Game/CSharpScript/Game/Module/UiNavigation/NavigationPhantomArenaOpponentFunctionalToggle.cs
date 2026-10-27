using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004922 RID: 18722
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOpponentFunctionalToggle : NavigationButton
	{
		// Token: 0x06030E99 RID: 200345 RVA: 0x00B5B316 File Offset: 0x00B59516
		public NavigationPhantomArenaOpponentFunctionalToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079CB RID: 31179
		// (get) Token: 0x06030E9A RID: 200346 RVA: 0x00B5B324 File Offset: 0x00B59524
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

		// Token: 0x06030E9B RID: 200347 RVA: 0x00B5B366 File Offset: 0x00B59566
		protected override void OnButtonClick()
		{
		}

		// Token: 0x06030E9C RID: 200348 RVA: 0x00B5B368 File Offset: 0x00B59568
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x06030E9D RID: 200349 RVA: 0x00B5B385 File Offset: 0x00B59585
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.GamepadLogic.IsInCardSelectState;
		}

		// Token: 0x0401A3DD RID: 107485
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
