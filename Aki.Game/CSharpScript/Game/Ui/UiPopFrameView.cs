using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004634 RID: 17972
	[NullableContext(1)]
	[Nullable(0)]
	public class UiPopFrameView : UiPanelBase, IUiPopFrameInterface
	{
		// Token: 0x170075E7 RID: 30183
		// (get) Token: 0x0602E55C RID: 189788 RVA: 0x00AB5A81 File Offset: 0x00AB3C81
		// (set) Token: 0x0602E55D RID: 189789 RVA: 0x00AB5A89 File Offset: 0x00AB3C89
		public CommonPopViewBase PopItem { get; set; }

		// Token: 0x0602E55E RID: 189790 RVA: 0x00AB5A92 File Offset: 0x00AB3C92
		public UiPopFrameView(UiViewInfo viewInfo)
		{
			this.ParentViewInfo = viewInfo;
		}

		// Token: 0x0602E55F RID: 189791 RVA: 0x00AB5AA4 File Offset: 0x00AB3CA4
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

		// Token: 0x0602E560 RID: 189792 RVA: 0x00AB5B04 File Offset: 0x00AB3D04
		protected override UniTask OnBeforeHideAsync()
		{
			UiPopFrameView.<OnBeforeHideAsync>d__8 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<UiPopFrameView.<OnBeforeHideAsync>d__8>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E561 RID: 189793 RVA: 0x00AB5B48 File Offset: 0x00AB3D48
		protected override UniTask OnBeforeStartAsync()
		{
			UiPopFrameView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<UiPopFrameView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E562 RID: 189794 RVA: 0x00AB5B8C File Offset: 0x00AB3D8C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			UiPopFrameView.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<UiPopFrameView.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E563 RID: 189795 RVA: 0x00AB5BCF File Offset: 0x00AB3DCF
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602E564 RID: 189796 RVA: 0x00AB5BD4 File Offset: 0x00AB3DD4
		protected override void OnAutoDestroy()
		{
			Log.Instance.Info(ELogModule.UiCommon, ELogAuthor.XXJ, "UiPopFrameView执行自动销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SequencePlayer.Clear();
		}

		// Token: 0x0602E565 RID: 189797 RVA: 0x00AB5C08 File Offset: 0x00AB3E08
		public void SetCloseBtnInteractive(bool state)
		{
			this.PopItem.SetCloseBtnInteractive(state);
		}

		// Token: 0x0602E566 RID: 189798 RVA: 0x00AB5C16 File Offset: 0x00AB3E16
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			this.PopItem.SetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x0602E567 RID: 189799 RVA: 0x00AB5C25 File Offset: 0x00AB3E25
		public void SetBackBtnShowState(bool state)
		{
			this.PopItem.SetBackBtnShowState(state);
		}

		// Token: 0x0602E568 RID: 189800 RVA: 0x00AB5C33 File Offset: 0x00AB3E33
		public AActor GetPopViewRootActor()
		{
			return base.GetRootActor();
		}

		// Token: 0x0602E569 RID: 189801 RVA: 0x00AB5C3B File Offset: 0x00AB3E3B
		public UUIItem GetPopViewRootItem()
		{
			return base.GetRootItem();
		}

		// Token: 0x0602E56A RID: 189802 RVA: 0x00AB5C43 File Offset: 0x00AB3E43
		public AActor GetPopViewOriginalActor()
		{
			return base.GetOriginalActor();
		}

		// Token: 0x0602E56B RID: 189803 RVA: 0x00AB5C4B File Offset: 0x00AB3E4B
		public void HidePopView()
		{
			base.Hide(null);
		}

		// Token: 0x0602E56C RID: 189804 RVA: 0x00AB5C54 File Offset: 0x00AB3E54
		public void ShowPopView()
		{
			base.Show(null);
		}

		// Token: 0x0602E56D RID: 189805 RVA: 0x00AB5C5D File Offset: 0x00AB3E5D
		public void SetViewPermanent()
		{
			LguiUtil.Instance.SetActorIsPermanent(base.GetOriginalActor(), true, true);
		}

		// Token: 0x0602E56E RID: 189806 RVA: 0x00AB5C74 File Offset: 0x00AB3E74
		public void PlayLevelSequenceByName(string sequenceName, bool blockClick = false)
		{
			this.SequencePlayer.PlaySequence(sequenceName, blockClick, null);
		}

		// Token: 0x0602E56F RID: 189807 RVA: 0x00AB5C98 File Offset: 0x00AB3E98
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

		// Token: 0x0602E570 RID: 189808 RVA: 0x00AB5CFC File Offset: 0x00AB3EFC
		public Action GetCloseCallback()
		{
			return null;
		}

		// Token: 0x0602E571 RID: 189809 RVA: 0x00AB5CFF File Offset: 0x00AB3EFF
		public void SetCloseCallback(Action callback)
		{
		}

		// Token: 0x0602E572 RID: 189810 RVA: 0x00AB5D01 File Offset: 0x00AB3F01
		public void AddButtonClickEvent(string btnName, Action callback)
		{
		}

		// Token: 0x0602E573 RID: 189811 RVA: 0x00AB5D03 File Offset: 0x00AB3F03
		public void HidePopFrame()
		{
			this.HidePopView();
		}

		// Token: 0x170075E8 RID: 30184
		// (get) Token: 0x0602E574 RID: 189812 RVA: 0x00AB5D0B File Offset: 0x00AB3F0B
		public int PopFrameId
		{
			get
			{
				return this.ComponentId;
			}
		}

		// Token: 0x04018D88 RID: 101768
		private readonly UiViewInfo ParentViewInfo;

		// Token: 0x04018D89 RID: 101769
		private UiSequencePlayer SequencePlayer;
	}
}
