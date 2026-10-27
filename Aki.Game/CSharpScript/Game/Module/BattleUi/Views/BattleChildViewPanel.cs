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
	// Token: 0x02005CB4 RID: 23732
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleChildViewPanel : UiPanelBase
	{
		// Token: 0x0603BF53 RID: 245587 RVA: 0x00E54C8D File Offset: 0x00E52E8D
		public virtual UniTask InitializeAsync()
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x0603BF54 RID: 245588 RVA: 0x00E54C94 File Offset: 0x00E52E94
		public virtual void InitializeTemp()
		{
		}

		// Token: 0x0603BF55 RID: 245589 RVA: 0x00E54C98 File Offset: 0x00E52E98
		protected override UniTask OnBeforeStartAsync()
		{
			BattleChildViewPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleChildViewPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BF56 RID: 245590 RVA: 0x00E54CDB File Offset: 0x00E52EDB
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

		// Token: 0x0603BF57 RID: 245591 RVA: 0x00E54D0F File Offset: 0x00E52F0F
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

		// Token: 0x0603BF58 RID: 245592 RVA: 0x00E54D3C File Offset: 0x00E52F3C
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

		// Token: 0x0603BF59 RID: 245593 RVA: 0x00E54D90 File Offset: 0x00E52F90
		public override void SetActive(bool visibility)
		{
			if (this.Visible != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x0603BF5A RID: 245594 RVA: 0x00E54DCA File Offset: 0x00E52FCA
		public bool GetVisible()
		{
			return this.Visible;
		}

		// Token: 0x0603BF5B RID: 245595 RVA: 0x00E54DD4 File Offset: 0x00E52FD4
		protected void SetVisible(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			bool visible = this.Visible;
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603BF5C RID: 245596 RVA: 0x00E54DF8 File Offset: 0x00E52FF8
		private void OnBattleUiChildVisibleChanged()
		{
			bool visible = this.Visible;
			this.Visible = this.ChildViewData.GetChildVisible(this.ChildType);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603BF5D RID: 245597 RVA: 0x00E54E2C File Offset: 0x00E5302C
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

		// Token: 0x0603BF5E RID: 245598 RVA: 0x00E54E65 File Offset: 0x00E53065
		private void SetVisibleInner(EBattleUiVisibleReason visibleReason, bool bVisible)
		{
			if (this.ChildType == EBattleUiChild.Common)
			{
				return;
			}
			this.Visible = this.ChildViewData.SetChildVisible(visibleReason, this.ChildType, bVisible, false, 0);
		}

		// Token: 0x0603BF5F RID: 245599 RVA: 0x00E54E8B File Offset: 0x00E5308B
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

		// Token: 0x0603BF60 RID: 245600 RVA: 0x00E54EAB File Offset: 0x00E530AB
		protected virtual void OnShowBattleChildViewPanel(bool isFirst)
		{
		}

		// Token: 0x0603BF61 RID: 245601 RVA: 0x00E54EAD File Offset: 0x00E530AD
		protected virtual void OnHideBattleChildViewPanel()
		{
		}

		// Token: 0x0603BF62 RID: 245602 RVA: 0x00E54EAF File Offset: 0x00E530AF
		public virtual void OnTickBattleChildViewPanel(float delta)
		{
		}

		// Token: 0x0603BF63 RID: 245603 RVA: 0x00E54EB1 File Offset: 0x00E530B1
		public virtual void OnAfterTickBattleChildViewPanel(float delta)
		{
		}

		// Token: 0x0603BF64 RID: 245604 RVA: 0x00E54EB3 File Offset: 0x00E530B3
		protected virtual void AddEvents()
		{
		}

		// Token: 0x0603BF65 RID: 245605 RVA: 0x00E54EB5 File Offset: 0x00E530B5
		protected virtual void RemoveEvents()
		{
		}

		// Token: 0x0603BF66 RID: 245606 RVA: 0x00E54EB8 File Offset: 0x00E530B8
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

		// Token: 0x0603BF67 RID: 245607 RVA: 0x00E54F0C File Offset: 0x00E5310C
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

		// Token: 0x0603BF68 RID: 245608 RVA: 0x00E54F70 File Offset: 0x00E53170
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

		// Token: 0x0603BF69 RID: 245609 RVA: 0x00E54FCC File Offset: 0x00E531CC
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

		// Token: 0x0603BF6A RID: 245610 RVA: 0x00E55094 File Offset: 0x00E53294
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

		// Token: 0x0603BF6B RID: 245611 RVA: 0x00E550DF File Offset: 0x00E532DF
		protected EOperationType GetOperationType()
		{
			return Info.Instance.OperationType;
		}

		// Token: 0x0603BF6C RID: 245612 RVA: 0x00E550EC File Offset: 0x00E532EC
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

		// Token: 0x0603BF6D RID: 245613 RVA: 0x00E55124 File Offset: 0x00E53324
		protected void ClearAllTagSignificantChangedCallback()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedTaskList)
			{
				tagTask.EndTask();
			}
			this.TagSignificantChangedTaskList.Clear();
		}

		// Token: 0x0603BF6E RID: 245614 RVA: 0x00E55180 File Offset: 0x00E53380
		protected bool ContainsTag(EntityHandle handle, int gameplayTag)
		{
			BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
			return component != null && component.HasTag(gameplayTag);
		}

		// Token: 0x0603BF6F RID: 245615 RVA: 0x00E551A5 File Offset: 0x00E533A5
		[NullableContext(2)]
		public new UUIItem GetItem(int index)
		{
			return base.GetItem(index);
		}

		// Token: 0x0603BF70 RID: 245616 RVA: 0x00E551AE File Offset: 0x00E533AE
		[NullableContext(2)]
		public virtual AActor GetUiActorForGuide()
		{
			return null;
		}

		// Token: 0x0603BF71 RID: 245617 RVA: 0x00E551B1 File Offset: 0x00E533B1
		public virtual void OnSeamlessTravelFinish()
		{
		}

		// Token: 0x0603BF72 RID: 245618 RVA: 0x00E551B3 File Offset: 0x00E533B3
		public void RefreshPureMode(bool isOpen)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAlpha(!isOpen);
		}

		// Token: 0x0603BF73 RID: 245619 RVA: 0x00E551CA File Offset: 0x00E533CA
		public bool IsChildType(EBattleUiChild childType)
		{
			return this.ChildType == childType;
		}

		// Token: 0x0603BF74 RID: 245620 RVA: 0x00E551D5 File Offset: 0x00E533D5
		public bool CheckBattleChildViewPanelShowCondition()
		{
			return this.OnCheckBattleChildViewPanelShowCondition();
		}

		// Token: 0x0603BF75 RID: 245621 RVA: 0x00E551DD File Offset: 0x00E533DD
		protected virtual bool OnCheckBattleChildViewPanelShowCondition()
		{
			return true;
		}

		// Token: 0x0603BF76 RID: 245622 RVA: 0x00E551E0 File Offset: 0x00E533E0
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

		// Token: 0x0401F4AD RID: 128173
		private readonly List<BattleChildView> StaticChildViewList = new List<BattleChildView>();

		// Token: 0x0401F4AE RID: 128174
		private readonly List<ITagTask> TagSignificantChangedTaskList = new List<ITagTask>();

		// Token: 0x0401F4AF RID: 128175
		[Nullable(2)]
		protected BattleUiChildViewData ChildViewData;

		// Token: 0x0401F4B0 RID: 128176
		protected EBattleUiChild ChildType;

		// Token: 0x0401F4B1 RID: 128177
		protected bool Visible;

		// Token: 0x0401F4B2 RID: 128178
		protected bool IsEnable;

		// Token: 0x0401F4B3 RID: 128179
		protected bool IsShowOnce;
	}
}
