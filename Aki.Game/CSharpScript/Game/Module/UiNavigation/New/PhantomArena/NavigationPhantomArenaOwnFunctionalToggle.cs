using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.New.PhantomArena
{
	// Token: 0x02003983 RID: 14723
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnFunctionalToggle : NavigationButton
	{
		// Token: 0x06025E35 RID: 155189 RVA: 0x00AA3ACA File Offset: 0x00AA1CCA
		public NavigationPhantomArenaOwnFunctionalToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D54 RID: 19796
		// (get) Token: 0x06025E36 RID: 155190 RVA: 0x00AA3AD8 File Offset: 0x00AA1CD8
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

		// Token: 0x06025E37 RID: 155191 RVA: 0x00AA3B1A File Offset: 0x00AA1D1A
		protected override void OnButtonClick()
		{
		}

		// Token: 0x06025E38 RID: 155192 RVA: 0x00AA3B1C File Offset: 0x00AA1D1C
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			int index = int.Parse(this.ParamList[0]);
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
				if (this.Proxy.GamepadLogic.IsInHandCardSelectState)
				{
					this.Proxy.GamepadLogic.MoveHandCardToFunctional(index);
					return;
				}
				if (this.Proxy.GamepadLogic.IsInBattleCardSelectState)
				{
					this.Proxy.GamepadLogic.MoveBattleCardToFunctional(index);
				}
			}
		}

		// Token: 0x04014D72 RID: 85362
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
