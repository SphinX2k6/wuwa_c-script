using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200389C RID: 14492
	public class NavigationPhantomArenaVisionButton : NavigationButton, INavigationInteractPrevGroup
	{
		// Token: 0x060259DB RID: 154075 RVA: 0x00A964F1 File Offset: 0x00A946F1
		[NullableContext(1)]
		public NavigationPhantomArenaVisionButton(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x060259DC RID: 154076 RVA: 0x00A964FC File Offset: 0x00A946FC
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x060259DD RID: 154077 RVA: 0x00A96536 File Offset: 0x00A94736
		public void InteractClickPrevGroup()
		{
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x04014C53 RID: 85075
		[Nullable(1)]
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
