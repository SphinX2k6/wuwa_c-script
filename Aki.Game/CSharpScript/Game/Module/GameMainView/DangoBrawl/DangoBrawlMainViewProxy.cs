using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl
{
	// Token: 0x020049E4 RID: 18916
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainViewProxy : GameMainViewProxy
	{
		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x0602F633 RID: 194099 RVA: 0x00D375A1 File Offset: 0x00D357A1
		protected override bool NeedForceShowCursor
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x0602F634 RID: 194100 RVA: 0x00D375A4 File Offset: 0x00D357A4
		protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0602F635 RID: 194101 RVA: 0x00D375BA File Offset: 0x00D357BA
		protected override bool ShouldCreateJoystickPanel()
		{
			return false;
		}

		// Token: 0x0602F636 RID: 194102 RVA: 0x00D375C0 File Offset: 0x00D357C0
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainViewProxy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainViewProxy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F637 RID: 194103 RVA: 0x00D37604 File Offset: 0x00D35804
		private UniTask CreateMainPanel()
		{
			DangoBrawlMainViewProxy.<CreateMainPanel>d__7 <CreateMainPanel>d__;
			<CreateMainPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMainPanel>d__.<>4__this = this;
			<CreateMainPanel>d__.<>1__state = -1;
			<CreateMainPanel>d__.<>t__builder.Start<DangoBrawlMainViewProxy.<CreateMainPanel>d__7>(ref <CreateMainPanel>d__);
			return <CreateMainPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602F638 RID: 194104 RVA: 0x00D37647 File Offset: 0x00D35847
		protected override void OnStart()
		{
		}

		// Token: 0x0602F639 RID: 194105 RVA: 0x00D37649 File Offset: 0x00D35849
		protected override void OnBeforeShow(bool isFirstShow)
		{
		}

		// Token: 0x0602F63A RID: 194106 RVA: 0x00D3764B File Offset: 0x00D3584B
		protected override void OnAfterShow()
		{
			UiAudioSystem.Instance.PlayViewBgm(this.View, "play_music_ui_3_7_tuanzi_battle");
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, true, true, 0);
		}

		// Token: 0x0602F63B RID: 194107 RVA: 0x00D3767D File Offset: 0x00D3587D
		protected override void OnBeforeHide()
		{
			UiAudioSystem.Instance.StopViewBgm(this.View);
			DangoBrawlModel.Instance.ResetPlayRate();
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, false, true, 0);
		}

		// Token: 0x0602F63C RID: 194108 RVA: 0x00D376B4 File Offset: 0x00D358B4
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0602F63D RID: 194109 RVA: 0x00D376B6 File Offset: 0x00D358B6
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0602F63E RID: 194110 RVA: 0x00D376B8 File Offset: 0x00D358B8
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0602F63F RID: 194111 RVA: 0x00D376BC File Offset: 0x00D358BC
		protected override void OnBeforeDestroy()
		{
			Log.Instance.Info(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[DangoBrawlMainViewProxy] OnBeforeDestroy", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiAudioSystem.Instance.StopViewBgm(this.View);
			DangoBrawlModel.Instance.ResetPlayRate();
		}

		// Token: 0x0602F640 RID: 194112 RVA: 0x00D37704 File Offset: 0x00D35904
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length != 1 || !(configParams[0] == "TogDetail"))
			{
				return null;
			}
			DangoBrawlMainBattlePanel mainBattlePanel = this.MainBattlePanel;
			UUIItem uuiitem = (mainBattlePanel != null) ? mainBattlePanel.GetTogDetailItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0602F641 RID: 194113 RVA: 0x00D3774E File Offset: 0x00D3594E
		public override bool NeedUiCameraBehavior()
		{
			return true;
		}

		// Token: 0x0602F642 RID: 194114 RVA: 0x00D37751 File Offset: 0x00D35951
		public override void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)"DangoBrawlCameraBattle", viewId, operationType);
		}

		// Token: 0x0602F643 RID: 194115 RVA: 0x00D37769 File Offset: 0x00D35969
		public override void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)"DangoBrawlCameraBattle", nextViewName, closeViewId, operationType);
		}

		// Token: 0x040191DD RID: 102877
		public DangoBrawlMainBattlePanel MainBattlePanel;

		// Token: 0x040191DE RID: 102878
		private const string DANGOBRAWL_BATTLE_CAMERA = "DangoBrawlCameraBattle";
	}
}
