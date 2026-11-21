using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C96 RID: 19606
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleChildViewPanel : UiPanelBase
	{
		// Token: 0x06030EA6 RID: 200358 RVA: 0x00DA5335 File Offset: 0x00DA3535
		public virtual UniTask InitializeAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x06030EA7 RID: 200359 RVA: 0x00DA533C File Offset: 0x00DA353C
		public virtual void InitializeTemp()
		{
		}

		// Token: 0x06030EA8 RID: 200360 RVA: 0x00DA5340 File Offset: 0x00DA3540
		protected override UniTask OnBeforeStartAsync()
		{
			BattleChildViewPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleChildViewPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EA9 RID: 200361 RVA: 0x00DA5383 File Offset: 0x00DA3583
		public void ShowBattleChildViewPanel()
		{
			if (!this.CheckBattleChildViewPanelShowCondition())
			{
				return;
			}
			this.IsEnable = true;
			this.SetVisibleInner(EBattleUiVisibleReason.Default, true);
			this.SetActive(this.Visible);
			if (this.Visible)
			{
				this.CheckFirstShow();
			}
		}

		// Token: 0x06030EAA RID: 200362 RVA: 0x00DA53B7 File Offset: 0x00DA35B7
		public void HideBattleChildViewPanel()
		{
			this.IsEnable = false;
			bool visible = this.Visible;
			this.SetVisibleInner(EBattleUiVisibleReason.Default, false);
			this.SetActive(this.Visible);
			if (visible)
			{
				this.OnHideBattleChildViewPanel();
			}
		}

		// Token: 0x06030EAB RID: 200363 RVA: 0x00DA53E4 File Offset: 0x00DA35E4
		public virtual void Reset()
		{
			this.SetVisibleInner(EBattleUiVisibleReason.Default, false);
			this.ResetAllStaticChildView();
			this.RemoveEvents();
			this.ClearAllTagSignificantChangedCallback();
			if (this.ChildViewData != null)
			{
				this.ChildViewData.RemoveCallback(this.ChildType, new Action(this.OnBattleUiChildVisibleChanged));
				this.ChildViewData = null;
			}
		}

		// Token: 0x06030EAC RID: 200364 RVA: 0x00DA5438 File Offset: 0x00DA3638
		public override void SetActive(bool visibility)
		{
			if (this.Visible != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x06030EAD RID: 200365 RVA: 0x00DA5472 File Offset: 0x00DA3672
		public bool GetVisible()
		{
			return this.Visible;
		}

		// Token: 0x06030EAE RID: 200366 RVA: 0x00DA547C File Offset: 0x00DA367C
		protected void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			bool visible = this.Visible;
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x06030EAF RID: 200367 RVA: 0x00DA54A0 File Offset: 0x00DA36A0
		private void OnBattleUiChildVisibleChanged()
		{
			bool visible = this.Visible;
			this.Visible = this.ChildViewData.GetChildVisible(this.ChildType);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x06030EB0 RID: 200368 RVA: 0x00DA54D4 File Offset: 0x00DA36D4
		private void CheckVisibleChange(bool oldVisible)
		{
			if (!this.IsEnable)
			{
				return;
			}
			bool visible = this.GetVisible();
			if (oldVisible == visible)
			{
				return;
			}
			this.SetActive(visible);
			if (visible)
			{
				this.CheckFirstShow();
				return;
			}
			this.OnHideBattleChildViewPanel();
		}

		// Token: 0x06030EB1 RID: 200369 RVA: 0x00DA550D File Offset: 0x00DA370D
		private void SetVisibleInner(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			if (this.ChildType == EBattleUiChild.Common)
			{
				return;
			}
			this.Visible = this.ChildViewData.SetChildVisible(visibleReason, this.ChildType, bVisible, false, 0);
		}

		// Token: 0x06030EB2 RID: 200370 RVA: 0x00DA5533 File Offset: 0x00DA3733
		private void CheckFirstShow()
		{
			if (this.IsShowOnce)
			{
				this.OnShowBattleChildViewPanel(false);
				return;
			}
			this.IsShowOnce = true;
			this.OnShowBattleChildViewPanel(true);
		}

		// Token: 0x06030EB3 RID: 200371 RVA: 0x00DA5553 File Offset: 0x00DA3753
		protected virtual void OnShowBattleChildViewPanel(bool isFirst)
		{
		}

		// Token: 0x06030EB4 RID: 200372 RVA: 0x00DA5555 File Offset: 0x00DA3755
		protected virtual void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x06030EB5 RID: 200373 RVA: 0x00DA5557 File Offset: 0x00DA3757
		public virtual void OnTickBattleChildViewPanel(float delta)
		{
		}

		// Token: 0x06030EB6 RID: 200374 RVA: 0x00DA5559 File Offset: 0x00DA3759
		public virtual void OnAfterTickBattleChildViewPanel(float delta)
		{
		}

		// Token: 0x06030EB7 RID: 200375 RVA: 0x00DA555B File Offset: 0x00DA375B
		protected virtual void AddEvents()
		{
		}

		// Token: 0x06030EB8 RID: 200376 RVA: 0x00DA555D File Offset: 0x00DA375D
		protected virtual void RemoveEvents()
		{
		}

		// Token: 0x06030EB9 RID: 200377 RVA: 0x00DA5560 File Offset: 0x00DA3760
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected UniTask<T> NewStaticChildViewAsync<[Nullable(0)] T>(AActor rootActor, [Nullable(2)] object param = null) where T : BattleChildView, new()
		{
			BattleChildViewPanel.<NewStaticChildViewAsync>d__26<T> <NewStaticChildViewAsync>d__;
			<NewStaticChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<NewStaticChildViewAsync>d__.<>4__this = this;
			<NewStaticChildViewAsync>d__.rootActor = rootActor;
			<NewStaticChildViewAsync>d__.param = param;
			<NewStaticChildViewAsync>d__.<>1__state = -1;
			<NewStaticChildViewAsync>d__.<>t__builder.Start<BattleChildViewPanel.<NewStaticChildViewAsync>d__26<T>>(ref <NewStaticChildViewAsync>d__);
			return <NewStaticChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EBA RID: 200378 RVA: 0x00DA55B4 File Offset: 0x00DA37B4
		private void ResetAllStaticChildView()
		{
			foreach (BattleChildView battleChildView in this.StaticChildViewList)
			{
				if (battleChildView != null)
				{
					battleChildView.Destroy(null);
				}
			}
			this.StaticChildViewList.Clear();
		}

		// Token: 0x06030EBB RID: 200379 RVA: 0x00DA5618 File Offset: 0x00DA3818
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		protected UniTask<T> NewDynamicChildViewByResourceId<[Nullable(0)] T>(UUIItem parentItem, string resourceId, bool bFromPool = false, [Nullable(2)] object param = null) where T : BattleChildView, new()
		{
			BattleChildViewPanel.<NewDynamicChildViewByResourceId>d__28<T> <NewDynamicChildViewByResourceId>d__;
			<NewDynamicChildViewByResourceId>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<NewDynamicChildViewByResourceId>d__.parentItem = parentItem;
			<NewDynamicChildViewByResourceId>d__.resourceId = resourceId;
			<NewDynamicChildViewByResourceId>d__.bFromPool = bFromPool;
			<NewDynamicChildViewByResourceId>d__.param = param;
			<NewDynamicChildViewByResourceId>d__.<>1__state = -1;
			<NewDynamicChildViewByResourceId>d__.<>t__builder.Start<BattleChildViewPanel.<NewDynamicChildViewByResourceId>d__28<T>>(ref <NewDynamicChildViewByResourceId>d__);
			return <NewDynamicChildViewByResourceId>d__.<>t__builder.Task;
		}

		// Token: 0x06030EBC RID: 200380 RVA: 0x00DA5674 File Offset: 0x00DA3874
		protected unsafe T NewDynamicChildViewByResourceIdWithCallback<[Nullable(0)] T>(UUIItem parentItem, string resourceId, bool bFromPool = false, [Nullable(new byte[]
		{
			2,
			1
		})] Action<T> onLoadCompleted = null, [Nullable(2)] object param = null) where T : BattleChildView, new()
		{
			T battleChildView = Activator.CreateInstance<T>();
			try
			{
				battleChildView.NewByResourceId(parentItem, resourceId, bFromPool, param).ContinueWith(delegate()
				{
					Action<T> onLoadCompleted2 = onLoadCompleted;
					if (onLoadCompleted2 == null)
					{
						return;
					}
					onLoadCompleted2(battleChildView);
				}).Forget();
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCommon;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "战斗界面子界面创建失败";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("资源名", resourceId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("错误", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return battleChildView;
		}

		// Token: 0x06030EBD RID: 200381 RVA: 0x00DA573C File Offset: 0x00DA393C
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		protected UniTask<T> NewDynamicChildViewAsync<[Nullable(0)] T>(AActor rootActor, [Nullable(2)] object param = null) where T : BattleChildView, new()
		{
			BattleChildViewPanel.<NewDynamicChildViewAsync>d__30<T> <NewDynamicChildViewAsync>d__;
			<NewDynamicChildViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<T>.Create();
			<NewDynamicChildViewAsync>d__.rootActor = rootActor;
			<NewDynamicChildViewAsync>d__.param = param;
			<NewDynamicChildViewAsync>d__.<>1__state = -1;
			<NewDynamicChildViewAsync>d__.<>t__builder.Start<BattleChildViewPanel.<NewDynamicChildViewAsync>d__30<T>>(ref <NewDynamicChildViewAsync>d__);
			return <NewDynamicChildViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030EBE RID: 200382 RVA: 0x00DA5787 File Offset: 0x00DA3987
		protected EOperationType GetOperationType()
		{
			return Info.Instance.OperationType;
		}

		// Token: 0x06030EBF RID: 200383 RVA: 0x00DA5794 File Offset: 0x00DA3994
		protected void ListenForTagSignificantChanged(EntityHandle handle, int gameplayTag, BaseTagComponent.TTagSwitchedCallback callback)
		{
			BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
			if (component == null)
			{
				return;
			}
			ITagTask item = component.ListenForTagAddOrRemove(new int?(gameplayTag), callback, null);
			this.TagSignificantChangedTaskList.Add(item);
		}

		// Token: 0x06030EC0 RID: 200384 RVA: 0x00DA57CC File Offset: 0x00DA39CC
		protected void ClearAllTagSignificantChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
		}

		// Token: 0x06030EC1 RID: 200385 RVA: 0x00DA5828 File Offset: 0x00DA3A28
		protected bool ContainsTag(EntityHandle handle, int gameplayTag)
		{
			BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
			return component != null && component.HasTag(gameplayTag);
		}

		// Token: 0x06030EC2 RID: 200386 RVA: 0x00DA584D File Offset: 0x00DA3A4D
		[NullableContext(2)]
		public new UUIItem GetItem(int index)
		{
			return base.GetItem(index);
		}

		// Token: 0x06030EC3 RID: 200387 RVA: 0x00DA5856 File Offset: 0x00DA3A56
		[NullableContext(2)]
		public virtual AActor GetUiActorForGuide()
		{
			return null;
		}

		// Token: 0x06030EC4 RID: 200388 RVA: 0x00DA5859 File Offset: 0x00DA3A59
		public virtual void OnSeamlessTravelFinish()
		{
		}

		// Token: 0x06030EC5 RID: 200389 RVA: 0x00DA585B File Offset: 0x00DA3A5B
		public void RefreshPureMode(bool isOpen)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(!isOpen);
		}

		// Token: 0x06030EC6 RID: 200390 RVA: 0x00DA5872 File Offset: 0x00DA3A72
		public bool IsChildType(EBattleUiChild childType)
		{
			return this.ChildType == childType;
		}

		// Token: 0x06030EC7 RID: 200391 RVA: 0x00DA587D File Offset: 0x00DA3A7D
		public bool CheckBattleChildViewPanelShowCondition()
		{
			return this.OnCheckBattleChildViewPanelShowCondition();
		}

		// Token: 0x06030EC8 RID: 200392 RVA: 0x00DA5885 File Offset: 0x00DA3A85
		protected virtual bool OnCheckBattleChildViewPanelShowCondition()
		{
			return true;
		}

		// Token: 0x06030EC9 RID: 200393 RVA: 0x00DA5888 File Offset: 0x00DA3A88
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			Log.Instance.Warn(ELogModule.Guide, ELogAuthor.HYF, "主界面子面板聚焦引导获取方法未实现", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x04019F66 RID: 106342
		private readonly List<BattleChildView> StaticChildViewList = new List<BattleChildView>();

		// Token: 0x04019F67 RID: 106343
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x04019F68 RID: 106344
		[Nullable(2)]
		protected BattleUiChildViewData ChildViewData;

		// Token: 0x04019F69 RID: 106345
		protected EBattleUiChild ChildType;

		// Token: 0x04019F6A RID: 106346
		protected bool Visible;

		// Token: 0x04019F6B RID: 106347
		protected bool IsEnable;

		// Token: 0x04019F6C RID: 106348
		protected bool IsShowOnce;
	}
}
