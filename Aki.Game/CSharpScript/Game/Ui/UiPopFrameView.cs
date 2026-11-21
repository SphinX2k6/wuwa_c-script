using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200355E RID: 13662
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameView : UiPanelBase, IUiPopFrameInterface
	{
		// Token: 0x170048A1 RID: 18593
		// (get) Token: 0x06022C80 RID: 142464 RVA: 0x009E2C5D File Offset: 0x009E0E5D
		// (set) Token: 0x06022C81 RID: 142465 RVA: 0x009E2C65 File Offset: 0x009E0E65
		public CommonPopViewBase PopItem { get; set; }

		// Token: 0x06022C82 RID: 142466 RVA: 0x009E2C6E File Offset: 0x009E0E6E
		public UiPopFrameView(UiViewInfo viewInfo)
		{
			this.ParentViewInfo = viewInfo;
		}

		// Token: 0x06022C83 RID: 142467 RVA: 0x009E2C80 File Offset: 0x009E0E80
		protected override void OnBeforeCreate()
		{
			UiPopFrameViewInfo uiBehaviourPopInfo = UiPopFrameViewStorage.Instance.GetUiBehaviourPopInfo((int)this.ParentViewInfo.CommonPopBg);
			if (uiBehaviourPopInfo == null)
			{
				return;
			}
			string resourceId = uiBehaviourPopInfo.ResourceId;
			this.PopItem = uiBehaviourPopInfo.Ctor();
			base.SetRootActorLoadInfo(resourceId, UiLayer.Instance.GetLayerRootUiItem(this.ParentViewInfo.Type), false, false);
		}

		// Token: 0x06022C84 RID: 142468 RVA: 0x009E2CE0 File Offset: 0x009E0EE0
		protected override UniTask OnBeforeHideAsync()
		{
			UiPopFrameView.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<UiPopFrameView.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C85 RID: 142469 RVA: 0x009E2D24 File Offset: 0x009E0F24
		protected override UniTask OnBeforeStartAsync()
		{
			UiPopFrameView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<UiPopFrameView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C86 RID: 142470 RVA: 0x009E2D68 File Offset: 0x009E0F68
		protected override UniTask OnShowAsyncImplementImplement()
		{
			UiPopFrameView.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<UiPopFrameView.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022C87 RID: 142471 RVA: 0x009E2DAB File Offset: 0x009E0FAB
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06022C88 RID: 142472 RVA: 0x009E2DB0 File Offset: 0x009E0FB0
		protected override void OnAutoDestroy()
		{
			Log.Instance.Info(ELogModule.UiCommon, ELogAuthor.XXJ, "UiPopFrameView执行自动销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SequencePlayer.Clear();
		}

		// Token: 0x06022C89 RID: 142473 RVA: 0x009E2DE4 File Offset: 0x009E0FE4
		public void SetCloseBtnInteractive(bool state)
		{
			this.PopItem.SetCloseBtnInteractive(state);
		}

		// Token: 0x06022C8A RID: 142474 RVA: 0x009E2DF2 File Offset: 0x009E0FF2
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x06022C8B RID: 142475 RVA: 0x009E2E01 File Offset: 0x009E1001
		public void SetBackBtnShowState(bool state)
		{
			this.PopItem.SetBackBtnShowState(state);
		}

		// Token: 0x06022C8C RID: 142476 RVA: 0x009E2E0F File Offset: 0x009E100F
		public AActor GetPopViewRootActor()
		{
			return base.GetRootActor();
		}

		// Token: 0x06022C8D RID: 142477 RVA: 0x009E2E17 File Offset: 0x009E1017
		public UUIItem GetPopViewRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x06022C8E RID: 142478 RVA: 0x009E2E1F File Offset: 0x009E101F
		public AActor GetPopViewOriginalActor()
		{
			return base.GetOriginalActor();
		}

		// Token: 0x06022C8F RID: 142479 RVA: 0x009E2E27 File Offset: 0x009E1027
		public void HidePopView()
		{
			base.Hide(null);
		}

		// Token: 0x06022C90 RID: 142480 RVA: 0x009E2E30 File Offset: 0x009E1030
		public void ShowPopView()
		{
			base.Show(null);
		}

		// Token: 0x06022C91 RID: 142481 RVA: 0x009E2E39 File Offset: 0x009E1039
		public void SetViewPermanent()
		{
			LguiUtil.Instance.SetActorIsPermanent(base.GetOriginalActor(), true, true);
		}

		// Token: 0x06022C92 RID: 142482 RVA: 0x009E2E50 File Offset: 0x009E1050
		public void PlayLevelSequenceByName(string sequenceName, bool blockClick = false)
		{
			this.SequencePlayer.PlaySequence(sequenceName, blockClick, null);
		}

		// Token: 0x06022C93 RID: 142483 RVA: 0x009E2E74 File Offset: 0x009E1074
		public UniTask PlaySequenceAsync(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false)
		{
			UiPopFrameView.<PlaySequenceAsync>d__23 <PlaySequenceAsync>d__;
			<PlaySequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlaySequenceAsync>d__.<>4__this = this;
			<PlaySequenceAsync>d__.sequenceName = sequenceName;
			<PlaySequenceAsync>d__.stopPromise = stopPromise;
			<PlaySequenceAsync>d__.blockClick = blockClick;
			<PlaySequenceAsync>d__.playReverse = playReverse;
			<PlaySequenceAsync>d__.<>1__state = -1;
			<PlaySequenceAsync>d__.<>t__builder.Start<UiPopFrameView.<PlaySequenceAsync>d__23>(ref <PlaySequenceAsync>d__);
			return <PlaySequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022C94 RID: 142484 RVA: 0x009E2ED8 File Offset: 0x009E10D8
		public Action GetCloseCallback()
		{
			return null;
		}

		// Token: 0x06022C95 RID: 142485 RVA: 0x009E2EDB File Offset: 0x009E10DB
		public void SetCloseCallback(Action callback)
		{
		}

		// Token: 0x06022C96 RID: 142486 RVA: 0x009E2EDD File Offset: 0x009E10DD
		public void AddButtonClickEvent(string btnName, Action callback)
		{
		}

		// Token: 0x06022C97 RID: 142487 RVA: 0x009E2EDF File Offset: 0x009E10DF
		public void HidePopFrame()
		{
			this.HidePopView();
		}

		// Token: 0x170048A2 RID: 18594
		// (get) Token: 0x06022C98 RID: 142488 RVA: 0x009E2EE7 File Offset: 0x009E10E7
		public int PopFrameId
		{
			get
			{
				return this.ComponentId;
			}
		}

		// Token: 0x040133D7 RID: 78807
		private readonly UiViewInfo ParentViewInfo;

		// Token: 0x040133D8 RID: 78808
		private UiSequencePlayer SequencePlayer;
	}
}
