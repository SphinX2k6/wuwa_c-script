using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B0F RID: 15119
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseTopHudHook : IBattleTopPanelHook
	{
		// Token: 0x06026D2C RID: 159020 RVA: 0x00ADD7F4 File Offset: 0x00ADB9F4
		public UniTask OnInitAsync(TopPanel topPanel)
		{
			TowerDefenseTopHudHook.<OnInitAsync>d__1 <OnInitAsync>d__;
			<OnInitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnInitAsync>d__.<>4__this = this;
			<OnInitAsync>d__.<>1__state = -1;
			<OnInitAsync>d__.<>t__builder.Start<TowerDefenseTopHudHook.<OnInitAsync>d__1>(ref <OnInitAsync>d__);
			return <OnInitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026D2D RID: 159021 RVA: 0x00ADD837 File Offset: 0x00ADBA37
		public void OnShow(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x06026D2E RID: 159022 RVA: 0x00ADD840 File Offset: 0x00ADBA40
		public void OnHide(TopPanel topPanel)
		{
		}

		// Token: 0x06026D2F RID: 159023 RVA: 0x00ADD842 File Offset: 0x00ADBA42
		public void OnAddEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06026D30 RID: 159024 RVA: 0x00ADD844 File Offset: 0x00ADBA44
		public void OnRemoveEventListener(TopPanel topPanel)
		{
		}

		// Token: 0x06026D31 RID: 159025 RVA: 0x00ADD846 File Offset: 0x00ADBA46
		public void OnRefresh(TopPanel topPanel)
		{
			this.ApplyHide(true);
		}

		// Token: 0x06026D32 RID: 159026 RVA: 0x00ADD84F File Offset: 0x00ADBA4F
		public void OnReset(TopPanel topPanel)
		{
			this.ApplyHide(false);
		}

		// Token: 0x06026D33 RID: 159027 RVA: 0x00ADD858 File Offset: 0x00ADBA58
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

		// Token: 0x04015397 RID: 86935
		private readonly EBattleUiChild[] HideChildren = new EBattleUiChild[]
		{
			EBattleUiChild.TopButton,
			EBattleUiChild.HomeButton
		};
	}
}
