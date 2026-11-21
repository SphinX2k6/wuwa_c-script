using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CFF RID: 7423
public class RoleTowerSaveExitConfirmView : UiViewBase
{
	// Token: 0x06012611 RID: 75281 RVA: 0x0056DA38 File Offset: 0x0056BC38
	[NullableContext(1)]
	public RoleTowerSaveExitConfirmView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06012612 RID: 75282 RVA: 0x0056DA44 File Offset: 0x0056BC44
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x06012613 RID: 75283 RVA: 0x0056DAB4 File Offset: 0x0056BCB4
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerSaveExitConfirmView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerSaveExitConfirmView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012614 RID: 75284 RVA: 0x0056DAF8 File Offset: 0x0056BCF8
	protected override void OnStart()
	{
		int curStageFirstFloorIndex = RoleTowerModel.Instance.GetCurStageFirstFloorIndex();
		int levelTotalFloorCount = RoleTowerModel.Instance.GetLevelTotalFloorCount(RoleTowerModel.Instance.CurSelectLevel);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "RoleTowerSaveExitProgress", new <>z__ReadOnlyArray<object>(new object[]
		{
			curStageFirstFloorIndex,
			levelTotalFloorCount
		}));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "RoleTowerQuitTips", Array.Empty<object>());
	}

	// Token: 0x06012615 RID: 75285 RVA: 0x0056DB74 File Offset: 0x0056BD74
	private void OnClickSettle(int _)
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			RoleTowerController.Instance.ChallengeSettleRequest(RoleTowerModel.Instance.CurSelectLevel).Forget();
		});
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleTowerPauseView))
		{
			UiManager.Instance.CloseView(EUiViewName.RoleTowerPauseView, null);
		}
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleTowerPrepareView))
		{
			UiManager.Instance.CloseView(EUiViewName.RoleTowerPrepareView, null);
		}
	}

	// Token: 0x06012616 RID: 75286 RVA: 0x0056DBF8 File Offset: 0x0056BDF8
	private void OnClickExit(int _)
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, delegate(bool _)
		{
			RoleTowerModel.Instance.LeaveDungeonAndOpenActivityMain().Forget();
		});
		if (UiManager.Instance.IsViewOpen(EUiViewName.RoleTowerPrepareView))
		{
			UiManager.Instance.CloseView(EUiViewName.RoleTowerPrepareView, null);
		}
	}

	// Token: 0x0400A02A RID: 41002
	[Nullable(2)]
	private ButtonItem BtnSettleItem;

	// Token: 0x0400A02B RID: 41003
	[Nullable(2)]
	private ButtonItem BtnExitItem;

	// Token: 0x02008027 RID: 32807
	private static class EChildType
	{
		// Token: 0x04029770 RID: 169840
		public const int TxtProgress = 0;

		// Token: 0x04029771 RID: 169841
		public const int BtnSettle = 1;

		// Token: 0x04029772 RID: 169842
		public const int BtnExit = 2;

		// Token: 0x04029773 RID: 169843
		public const int TxtTips = 3;
	}
}
