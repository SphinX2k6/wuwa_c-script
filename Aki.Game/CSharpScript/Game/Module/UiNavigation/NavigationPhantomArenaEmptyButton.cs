using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004920 RID: 18720
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaEmptyButton : NavigationButton
	{
		// Token: 0x06030E8F RID: 200335 RVA: 0x00B5B19F File Offset: 0x00B5939F
		public NavigationPhantomArenaEmptyButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030E90 RID: 200336 RVA: 0x00B5B1AC File Offset: 0x00B593AC
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x06030E91 RID: 200337 RVA: 0x00B5B1E6 File Offset: 0x00B593E6
		public void NotifyFocusListener()
		{
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x0401A3DB RID: 107483
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
