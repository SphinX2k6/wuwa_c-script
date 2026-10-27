using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB5 RID: 23733
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleTopPanelHookCenter
	{
		// Token: 0x17008DF1 RID: 36337
		// (get) Token: 0x0603BF78 RID: 245624 RVA: 0x00E55228 File Offset: 0x00E53428
		private List<IBattleTopPanelHook> Hooks
		{
			get
			{
				return BattleUiModel.Instance.TopPanelHooks;
			}
		}

		// Token: 0x0603BF79 RID: 245625 RVA: 0x00E55234 File Offset: 0x00E53434
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

		// Token: 0x0603BF7A RID: 245626 RVA: 0x00E55280 File Offset: 0x00E53480
		public void OnShow(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnShow(topPanel);
			}
		}

		// Token: 0x0603BF7B RID: 245627 RVA: 0x00E552D4 File Offset: 0x00E534D4
		public void OnHide(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnHide(topPanel);
			}
		}

		// Token: 0x0603BF7C RID: 245628 RVA: 0x00E55328 File Offset: 0x00E53528
		public void OnAddEventListener(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnAddEventListener(topPanel);
			}
		}

		// Token: 0x0603BF7D RID: 245629 RVA: 0x00E5537C File Offset: 0x00E5357C
		public void OnRemoveEventListener(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnRemoveEventListener(topPanel);
			}
		}

		// Token: 0x0603BF7E RID: 245630 RVA: 0x00E553D0 File Offset: 0x00E535D0
		public void OnRefresh(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnRefresh(topPanel);
			}
		}

		// Token: 0x0603BF7F RID: 245631 RVA: 0x00E55424 File Offset: 0x00E53624
		public void OnReset(TopPanel topPanel)
		{
			foreach (IBattleTopPanelHook battleTopPanelHook in this.Hooks)
			{
				battleTopPanelHook.OnReset(topPanel);
			}
			this.Clear();
		}

		// Token: 0x0603BF80 RID: 245632 RVA: 0x00E5547C File Offset: 0x00E5367C
		public void Clear()
		{
			BattleUiModel.Instance.TopPanelHooks.Clear();
		}
	}
}
