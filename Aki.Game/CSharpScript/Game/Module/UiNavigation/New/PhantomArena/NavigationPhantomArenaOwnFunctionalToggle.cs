using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.New.PhantomArena
{
	// Token: 0x02004A07 RID: 18951
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnFunctionalToggle : NavigationButton
	{
		// Token: 0x060312E7 RID: 201447 RVA: 0x00B68362 File Offset: 0x00B66562
		public NavigationPhantomArenaOwnFunctionalToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079EC RID: 31212
		// (get) Token: 0x060312E8 RID: 201448 RVA: 0x00B68370 File Offset: 0x00B66570
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

		// Token: 0x060312E9 RID: 201449 RVA: 0x00B683B2 File Offset: 0x00B665B2
		protected override void OnButtonClick()
		{
		}

		// Token: 0x060312EA RID: 201450 RVA: 0x00B683B4 File Offset: 0x00B665B4
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

		// Token: 0x0401A4EE RID: 107758
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
