using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200491F RID: 18719
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaCardToggle : NavigationButton
	{
		// Token: 0x06030E8C RID: 200332 RVA: 0x00B5B135 File Offset: 0x00B59335
		public NavigationPhantomArenaCardToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079C8 RID: 31176
		// (get) Token: 0x06030E8D RID: 200333 RVA: 0x00B5B140 File Offset: 0x00B59340
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

		// Token: 0x06030E8E RID: 200334 RVA: 0x00B5B182 File Offset: 0x00B59382
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x0401A3DA RID: 107482
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
