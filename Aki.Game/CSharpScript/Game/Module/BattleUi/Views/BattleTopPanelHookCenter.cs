using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C97 RID: 19607
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleTopPanelHookCenter
	{
		// Token: 0x170061C3 RID: 25027
		// (get) Token: 0x06030ECB RID: 200395 RVA: 0x00DA58D0 File Offset: 0x00DA3AD0
		private List<IBattleTopPanelHook> Hooks
		{
			get
			{
				return BattleUiModel.Instance.TopPanelHooks;
			}
		}

		// Token: 0x06030ECC RID: 200396 RVA: 0x00DA58DC File Offset: 0x00DA3ADC
		public UniTask OnInitAsync(TopPanel topPanel)
		{
			BattleTopPanelHookCenter.<OnInitAsync>d__2 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.topPanel = topPanel;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<BattleTopPanelHookCenter.<OnInitAsync>d__2>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030ECD RID: 200397 RVA: 0x00DA5928 File Offset: 0x00DA3B28
		public void OnShow(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnShow(topPanel);
			}
		}

		// Token: 0x06030ECE RID: 200398 RVA: 0x00DA597C File Offset: 0x00DA3B7C
		public void OnHide(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnHide(topPanel);
			}
		}

		// Token: 0x06030ECF RID: 200399 RVA: 0x00DA59D0 File Offset: 0x00DA3BD0
		public void OnAddEventListener(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnAddEventListener(topPanel);
			}
		}

		// Token: 0x06030ED0 RID: 200400 RVA: 0x00DA5A24 File Offset: 0x00DA3C24
		public void OnRemoveEventListener(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnRemoveEventListener(topPanel);
			}
		}

		// Token: 0x06030ED1 RID: 200401 RVA: 0x00DA5A78 File Offset: 0x00DA3C78
		public void OnRefresh(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnRefresh(topPanel);
			}
		}

		// Token: 0x06030ED2 RID: 200402 RVA: 0x00DA5ACC File Offset: 0x00DA3CCC
		public void OnReset(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnReset(topPanel);
			}
			this.Clear();
		}

		// Token: 0x06030ED3 RID: 200403 RVA: 0x00DA5B24 File Offset: 0x00DA3D24
		public void Clear()
		{
			BattleUiModel.Instance.TopPanelHooks.Clear();
		}
	}
}
