using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B67 RID: 19303
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseTopHudHook : IBattleTopPanelHook
	{
		// Token: 0x06031F9D RID: 204701 RVA: 0x00B995B8 File Offset: 0x00B977B8
		public UniTask OnInitAsync(TopPanel topPanel)
		{
			TowerDefenseTopHudHook.<OnInitAsync>d__1 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<TowerDefenseTopHudHook.<OnInitAsync>d__1>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F9E RID: 204702 RVA: 0x00B995FB File Offset: 0x00B977FB
		public void OnShow(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x06031F9F RID: 204703 RVA: 0x00B99604 File Offset: 0x00B97804
		public void OnHide(TopPanel topPanel)
		{
		}

		// Token: 0x06031FA0 RID: 204704 RVA: 0x00B99606 File Offset: 0x00B97806
		public void OnAddEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06031FA1 RID: 204705 RVA: 0x00B99608 File Offset: 0x00B97808
		public void OnRemoveEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06031FA2 RID: 204706 RVA: 0x00B9960A File Offset: 0x00B9780A
		public void OnRefresh(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x06031FA3 RID: 204707 RVA: 0x00B99613 File Offset: 0x00B97813
		public void OnReset(TopPanel topPanel)
		{
			this.ApplyHide(false);
		}

		// Token: 0x06031FA4 RID: 204708 RVA: 0x00B9961C File Offset: 0x00B9781C
		private void ApplyHide(bool hide)
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			foreach (EBattleUiChild childType in this.HideChildren)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Custom, childType, !hide, true, 0);
			}
		}

		// Token: 0x0401AA45 RID: 109125
		private readonly EBattleUiChild[] HideChildren = new EBattleUiChild[]
		{
			EBattleUiChild.TopButton,
			EBattleUiChild.HomeButton
		};
	}
}
