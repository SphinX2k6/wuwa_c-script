using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003897 RID: 14487
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaEmptyButton : NavigationButton
	{
		// Token: 0x060259BC RID: 154044 RVA: 0x00A9600F File Offset: 0x00A9420F
		public NavigationPhantomArenaEmptyButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259BD RID: 154045 RVA: 0x00A9601C File Offset: 0x00A9421C
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x060259BE RID: 154046 RVA: 0x00A96056 File Offset: 0x00A94256
		public void NotifyFocusListener()
		{
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x04014C4E RID: 85070
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
