using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A9 RID: 18857
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomArenaBattleComponentBase : HotKeyComponent
	{
		// Token: 0x0603117A RID: 201082 RVA: 0x00B644CB File Offset: 0x00B626CB
		public PhantomArenaBattleComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x170079DB RID: 31195
		// (get) Token: 0x0603117B RID: 201083 RVA: 0x00B644D4 File Offset: 0x00B626D4
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

		// Token: 0x0603117C RID: 201084 RVA: 0x00B64518 File Offset: 0x00B62718
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			if (this.Proxy == null)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (!this.Proxy.IsInPanelInteract)
			{
				this.OnRefreshSelfHotKeyStateImplement();
				return;
			}
			if (this.Proxy.IsMainInVisible)
			{
				this.OnRefreshSelfHotKeyStateIsMainInVisible();
				return;
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}

		// Token: 0x0603117D RID: 201085 RVA: 0x00B64568 File Offset: 0x00B62768
		protected virtual void OnRefreshSelfHotKeyStateImplement()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, true, false);
		}

		// Token: 0x0603117E RID: 201086 RVA: 0x00B64573 File Offset: 0x00B62773
		protected virtual void OnRefreshSelfHotKeyStateIsMainInVisible()
		{
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
		}

		// Token: 0x0401A4B1 RID: 107697
		private PhantomArenaBattleProxy ProxyInternal;
	}
}
