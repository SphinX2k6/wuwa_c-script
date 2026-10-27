using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004925 RID: 18725
	public class NavigationPhantomArenaVisionButton : NavigationButton, INavigationInteractPrevGroup
	{
		// Token: 0x06030EAE RID: 200366 RVA: 0x00B5B681 File Offset: 0x00B59881
		[NullableContext(1)]
		public NavigationPhantomArenaVisionButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x06030EAF RID: 200367 RVA: 0x00B5B68C File Offset: 0x00B5988C
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x06030EB0 RID: 200368 RVA: 0x00B5B6C6 File Offset: 0x00B598C6
		public void InteractClickPrevGroup()
		{
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x0401A3E0 RID: 107488
		[Nullable(1)]
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
