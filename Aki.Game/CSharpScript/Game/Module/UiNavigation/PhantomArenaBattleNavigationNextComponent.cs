using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049AB RID: 18859
	public class PhantomArenaBattleNavigationNextComponent : NavigationGroupNextComponent
	{
		// Token: 0x06031182 RID: 201090 RVA: 0x00B645B6 File Offset: 0x00B627B6
		public PhantomArenaBattleNavigationNextComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06031183 RID: 201091 RVA: 0x00B645C0 File Offset: 0x00B627C0
		protected override void OnInit()
		{
			base.OnInit();
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			this.Proxy = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleDetailsViewProxy);
		}

		// Token: 0x06031184 RID: 201092 RVA: 0x00B645FA File Offset: 0x00B627FA
		protected override void JumpToNextGroupListener()
		{
			base.JumpToNextGroupListener();
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(true);
			}
		}

		// Token: 0x06031185 RID: 201093 RVA: 0x00B64616 File Offset: 0x00B62816
		protected override void OnRelease(HotKeyMap config)
		{
			base.OnRelease(config);
			if (this.Proxy != null)
			{
				this.Proxy.SetIsInGamepadNavigation(true);
			}
		}

		// Token: 0x0401A4B2 RID: 107698
		[Nullable(2)]
		protected PhantomArenaBattleDetailsViewProxy Proxy;
	}
}
