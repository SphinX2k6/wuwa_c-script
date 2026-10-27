using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl
{
	// Token: 0x02005A08 RID: 23048
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlMainViewProxy : GameMainViewProxy
	{
		// Token: 0x17008BC2 RID: 35778
		// (get) Token: 0x0603A6EA RID: 239338 RVA: 0x00DE6FC5 File Offset: 0x00DE51C5
		protected override bool NeedForceShowCursor
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17008BC3 RID: 35779
		// (get) Token: 0x0603A6EB RID: 239339 RVA: 0x00DE6FC8 File Offset: 0x00DE51C8
		protected override EBattleUiCommonChildVisibleReason? BattleUiCommonChildVisibleReason
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0603A6EC RID: 239340 RVA: 0x00DE6FDE File Offset: 0x00DE51DE
		protected override bool ShouldCreateJoystickPanel()
		{
			return false;
		}

		// Token: 0x0603A6ED RID: 239341 RVA: 0x00DE6FE4 File Offset: 0x00DE51E4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlMainViewProxy.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlMainViewProxy.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A6EE RID: 239342 RVA: 0x00DE7028 File Offset: 0x00DE5228
		private UniTask CreateMainPanel()
		{
			DangoBrawlMainViewProxy.<CreateMainPanel>d__7 <CreateMainPanel>d__;
			<CreateMainPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMainPanel>d__.<>4__this = this;
			<CreateMainPanel>d__.<>1__state = -1;
			<CreateMainPanel>d__.<>t__builder.Start<DangoBrawlMainViewProxy.<CreateMainPanel>d__7>(ref <CreateMainPanel>d__);
			return <CreateMainPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0603A6EF RID: 239343 RVA: 0x00DE706B File Offset: 0x00DE526B
		protected override void OnStart()
		{
		}

		// Token: 0x0603A6F0 RID: 239344 RVA: 0x00DE706D File Offset: 0x00DE526D
		protected override void OnBeforeShow(bool isFirstShow)
		{
		}

		// Token: 0x0603A6F1 RID: 239345 RVA: 0x00DE7070 File Offset: 0x00DE5270
		protected override void OnAfterShow()
		{
			UiAudioModel.Instance.SetLoopAudioEventShow(this.View.GetViewId(), this.View.GetRootActor(), "play_music_ui_3_7_tuanzi_battle");
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, true, true, 0);
		}

		// Token: 0x0603A6F2 RID: 239346 RVA: 0x00DE70C0 File Offset: 0x00DE52C0
		protected override void OnBeforeHide()
		{
			UiAudioModel.Instance.SetLoopAudioEventHide(this.View.GetViewId(), this.View.GetRootActor(), "play_music_ui_3_7_tuanzi_battle");
			DangoBrawlModel.Instance.ResetPlayRate();
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BattleFloat, false, true, 0);
		}

		// Token: 0x0603A6F3 RID: 239347 RVA: 0x00DE7117 File Offset: 0x00DE5317
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603A6F4 RID: 239348 RVA: 0x00DE7119 File Offset: 0x00DE5319
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x0603A6F5 RID: 239349 RVA: 0x00DE711B File Offset: 0x00DE531B
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x0603A6F6 RID: 239350 RVA: 0x00DE7120 File Offset: 0x00DE5320
		protected override void OnBeforeDestroy()
		{
			Log.Instance.Info(ELogModule.DangoBrawl, ELogAuthor.WHJ, "[DangoBrawlMainViewProxy] OnBeforeDestroy", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiAudioModel.Instance.SetLoopAudioEventDestroy(this.View.GetViewId(), this.View.GetRootActor(), "play_music_ui_3_7_tuanzi_battle");
			DangoBrawlModel.Instance.ResetPlayRate();
		}

		// Token: 0x0603A6F7 RID: 239351 RVA: 0x00DE717C File Offset: 0x00DE537C
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

		// Token: 0x0603A6F8 RID: 239352 RVA: 0x00DE71C6 File Offset: 0x00DE53C6
		public override bool NeedUiCameraBehavior()
		{
			return true;
		}

		// Token: 0x0603A6F9 RID: 239353 RVA: 0x00DE71C9 File Offset: 0x00DE53C9
		public override void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)"DangoBrawlCameraBattle", new int?(viewId), isBlend);
		}

		// Token: 0x0603A6FA RID: 239354 RVA: 0x00DE71E6 File Offset: 0x00DE53E6
		public override void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)"DangoBrawlCameraBattle", stackTopInfo, closeViewId, popOrDelete);
		}

		// Token: 0x0401E736 RID: 124726
		public DangoBrawlMainBattlePanel MainBattlePanel;

		// Token: 0x0401E737 RID: 124727
		private const string DANGOBRAWL_BATTLE_CAMERA = "DangoBrawlCameraBattle";
	}
}
