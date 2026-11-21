using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003899 RID: 14489
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOpponentFunctionalToggle : NavigationButton
	{
		// Token: 0x060259C6 RID: 154054 RVA: 0x00A96186 File Offset: 0x00A94386
		public NavigationPhantomArenaOpponentFunctionalToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D33 RID: 19763
		// (get) Token: 0x060259C7 RID: 154055 RVA: 0x00A96194 File Offset: 0x00A94394
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

		// Token: 0x060259C8 RID: 154056 RVA: 0x00A961D6 File Offset: 0x00A943D6
		protected override void OnButtonClick()
		{
		}

		// Token: 0x060259C9 RID: 154057 RVA: 0x00A961D8 File Offset: 0x00A943D8
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x060259CA RID: 154058 RVA: 0x00A961F5 File Offset: 0x00A943F5
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.GamepadLogic.IsInCardSelectState;
		}

		// Token: 0x04014C50 RID: 85072
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
