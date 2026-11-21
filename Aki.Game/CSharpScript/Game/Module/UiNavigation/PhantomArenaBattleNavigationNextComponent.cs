using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003925 RID: 14629
	public class PhantomArenaBattleNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06025CB8 RID: 154808 RVA: 0x00A9F506 File Offset: 0x00A9D706
		public PhantomArenaBattleNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CB9 RID: 154809 RVA: 0x00A9F510 File Offset: 0x00A9D710
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x06025CBA RID: 154810 RVA: 0x00A9F54A File Offset: 0x00A9D74A
		protected override void JumpToNextGroupListener()
		{
			base.JumpToNextGroupListener();
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(true);
			}
		}

		// Token: 0x06025CBB RID: 154811 RVA: 0x00A9F566 File Offset: 0x00A9D766
		protected override void OnRelease(HotKeyMap config)
		{
			base.OnRelease(config);
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(true);
			}
		}

		// Token: 0x04014D24 RID: 85284
		[Nullable(2)]
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
