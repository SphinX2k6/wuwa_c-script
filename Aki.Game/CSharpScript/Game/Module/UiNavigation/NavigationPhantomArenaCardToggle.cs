using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003896 RID: 14486
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaCardToggle : NavigationButton
	{
		// Token: 0x060259B9 RID: 154041 RVA: 0x00A95FA5 File Offset: 0x00A941A5
		public NavigationPhantomArenaCardToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D30 RID: 19760
		// (get) Token: 0x060259BA RID: 154042 RVA: 0x00A95FB0 File Offset: 0x00A941B0
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

		// Token: 0x060259BB RID: 154043 RVA: 0x00A95FF2 File Offset: 0x00A941F2
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x04014C4D RID: 85069
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
