using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A01 RID: 23041
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolRewardTipView : UiTickViewBase
	{
		// Token: 0x17006C63 RID: 27747
		// (get) Token: 0x06038BB8 RID: 232376 RVA: 0x00FE094D File Offset: 0x00FDEB4D
		// (set) Token: 0x06038BB9 RID: 232377 RVA: 0x00FE0955 File Offset: 0x00FDEB55
		public bool SuppressShow { get; set; }

		// Token: 0x06038BBA RID: 232378 RVA: 0x00FE0960 File Offset: 0x00FDEB60
		public SolarSchoolRewardTipView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06038BBB RID: 232379 RVA: 0x00FE09B0 File Offset: 0x00FDEBB0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038BBC RID: 232380 RVA: 0x00FE0A7C File Offset: 0x00FDEC7C
		protected override void OnStart()
		{
			SolarSchoolRewardTipColumnState solarSchoolRewardTipColumnState = new SolarSchoolRewardTipColumnState(base.GetVerticalLayout(0), this.AttrRewardTipQueue);
			SolarSchoolRewardTipColumnState solarSchoolRewardTipColumnState2 = new SolarSchoolRewardTipColumnState(base.GetVerticalLayout(2), this.ItemRewardTipQueue);
			UUIItem item = base.GetItem(1);
			UUIItem item2 = base.GetItem(3);
			UUIItem item3 = base.GetItem(4);
			item.SetUIActive(false);
			item2.SetUIActive(false);
			item3.SetUIActive(false);
			this.AttrColumnState = solarSchoolRewardTipColumnState;
			this.ItemColumnState = solarSchoolRewardTipColumnState2;
			this.ItemTypeStates.Add(ESolarSchoolRewardTipType.Attr, new SolarSchoolRewardTipItemTypeState(solarSchoolRewardTipColumnState, item, () => new SolarSchoolRewardTipAttrItem()));
			this.ItemTypeStates.Add(ESolarSchoolRewardTipType.Item, new SolarSchoolRewardTipItemTypeState(solarSchoolRewardTipColumnState2, item2, () => new SolarSchoolRewardTipPropItem()));
			this.ItemTypeStates.Add(ESolarSchoolRewardTipType.Favor, new SolarSchoolRewardTipItemTypeState(solarSchoolRewardTipColumnState2, item3, () => new SolarSchoolRewardTipFavorItem()));
			this.ItemTypeStates.Add(ESolarSchoolRewardTipType.QuestDone, new SolarSchoolRewardTipItemTypeState(solarSchoolRewardTipColumnState2, item2, () => new SolarSchoolRewardTipQuestDoneItem()));
			this.ItemTypeStates.Add(ESolarSchoolRewardTipType.QuestRewardDone, new SolarSchoolRewardTipItemTypeState(solarSchoolRewardTipColumnState2, item2, () => new SolarSchoolRewardTipQuestRewardDoneItem()));
			this.AreColumnsActive = this.IsAnyColumnActive();
			this.AreColumnsInitialized = true;
			this.PrewarmItemAsync(ESolarSchoolRewardTipType.Favor).Forget();
		}

		// Token: 0x06038BBD RID: 232381 RVA: 0x00FE0C08 File Offset: 0x00FDEE08
		protected override void OnBeforeDestroy()
		{
			this.SuppressShow = false;
			this.LastCanShowNewRewardTip = null;
			this.AttrRewardTipQueue.Clear();
			this.ItemRewardTipQueue.Clear();
			if (!this.AreColumnsInitialized)
			{
				return;
			}
			this.AreColumnsInitialized = false;
			this.AttrColumnState.Layout.SetEnable(true);
			this.ItemColumnState.Layout.SetEnable(true);
			foreach (SolarSchoolRewardTipItemBase solarSchoolRewardTipItemBase in this.OwnedItems)
			{
				solarSchoolRewardTipItemBase.Destroy(null);
			}
			this.OwnedItems.Clear();
			this.RewardTipItems.Clear();
			this.ItemTypeStates.Clear();
			this.AttrColumnState.ResetPendingRewardTip();
			this.ItemColumnState.ResetPendingRewardTip();
		}

		// Token: 0x06038BBE RID: 232382 RVA: 0x00FE0CEC File Offset: 0x00FDEEEC
		protected override void OnTick(float delta)
		{
			this.UpdateColumnActiveState();
			if (!this.AreColumnsActive)
			{
				return;
			}
			bool flag = this.HasVisibleRewardTips();
			bool flag2 = this.HasQueuedOrPendingRewardTips();
			if (!flag && !flag2)
			{
				return;
			}
			bool flag3 = this.CanShowNewRewardTip();
			bool flag4 = flag3 && flag2;
			if (!flag && !flag4)
			{
				return;
			}
			float num = Math.Min(delta, 20f);
			this.BatchIdleElapsedTime = (flag4 ? 0f : (this.BatchIdleElapsedTime + num));
			this.TickRewardTipItems(num);
			this.UpdateOldestRewardTip(num, flag3);
			this.UpdateColumnSlideOffset(this.AttrColumnState, num);
			this.UpdateColumnSlideOffset(this.ItemColumnState, num);
			bool flag5 = this.RecycleFinishedRewardTips();
			this.UpdateColumnHeight(this.AttrColumnState);
			this.UpdateColumnHeight(this.ItemColumnState);
			if (flag5)
			{
				this.UpdateRewardTipItemPositions();
			}
			if (!flag3)
			{
				return;
			}
			this.TickColumnRewardTip(this.AttrColumnState, num);
			this.TickColumnRewardTip(this.ItemColumnState, num);
		}

		// Token: 0x06038BBF RID: 232383 RVA: 0x00FE0DC8 File Offset: 0x00FDEFC8
		private void TickColumnRewardTip(SolarSchoolRewardTipColumnState column, float delta)
		{
			if (this.CountVisibleRewardTips(null) >= 5)
			{
				return;
			}
			if (column.NextRewardTipLoadState == EItemLoadState.Loading && column.NextRewardTipElapsedTime > 2000f)
			{
				this.CancelPendingRewardTip(column, column.PendingRewardTipItem);
			}
			if (column.NextRewardTipLoadState == EItemLoadState.Loaded && (column.NextRewardTipElapsedTime >= 100f || column.RewardTipQueue.Empty))
			{
				this.PlayPendingRewardTip(column);
			}
			if (column.NextRewardTipLoadState == EItemLoadState.None && !column.RewardTipQueue.Empty)
			{
				column.NextRewardTipLoadState = EItemLoadState.Loading;
				this.LoadNextRewardTipAsync(column).Forget();
			}
			column.NextRewardTipElapsedTime += delta;
		}

		// Token: 0x06038BC0 RID: 232384 RVA: 0x00FE0E64 File Offset: 0x00FDF064
		private void UpdateColumnActiveState()
		{
			bool flag = this.IsAnyColumnActive();
			if (flag == this.AreColumnsActive)
			{
				return;
			}
			this.AreColumnsActive = flag;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchoolRewardTipView] 奖励提示列显隐变化";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("active", flag);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			foreach (SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance in this.RewardTipItems)
			{
				solarSchoolRewardTipItemInstance.Item.ActiveStatusChange(flag);
			}
		}

		// Token: 0x06038BC1 RID: 232385 RVA: 0x00FE0F04 File Offset: 0x00FDF104
		private bool IsAnyColumnActive()
		{
			return this.AttrColumnState.ParentUiItem.IsUIActiveInHierarchy() || this.ItemColumnState.ParentUiItem.IsUIActiveInHierarchy();
		}

		// Token: 0x06038BC2 RID: 232386 RVA: 0x00FE0F2C File Offset: 0x00FDF12C
		private unsafe bool CanShowNewRewardTip()
		{
			UiViewBase topView = this.GetTopView();
			bool flag = this.IsRewardTipAllowed(topView);
			bool flag2 = flag;
			bool? lastCanShowNewRewardTip = this.LastCanShowNewRewardTip;
			if (!(flag2 == lastCanShowNewRewardTip.GetValueOrDefault() & lastCanShowNewRewardTip != null))
			{
				this.LastCanShowNewRewardTip = new bool?(flag);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchoolRewardTipView] 奖励提示放行状态变化";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("canShow", flag);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("topView", (topView != null) ? new EUiViewName?(topView.ViewInfo.Name) : null);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item = "childView";
				SolarSchoolRootView solarSchoolRootView = topView as SolarSchoolRootView;
				ptr = new ValueTuple<string, object>(item, (solarSchoolRootView != null) ? solarSchoolRootView.CurrentChildViewName : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("suppressShow", this.SuppressShow);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("isInGamePlay", SolarSchoolGamePlayModel.Instance.IsInGamePlay);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			}
			return flag;
		}

		// Token: 0x06038BC3 RID: 232387 RVA: 0x00FE1070 File Offset: 0x00FDF270
		[NullableContext(2)]
		private bool IsRewardTipAllowed(UiViewBase topView)
		{
			if (this.SuppressShow || !SolarSchoolGamePlayModel.Instance.IsInGamePlay || topView == null)
			{
				return false;
			}
			if (!SolarSchoolGamePlayModel.Instance.IsViewAllowRewardTip(topView.ViewInfo.Name.ToString(), false))
			{
				return false;
			}
			SolarSchoolRootView solarSchoolRootView = topView as SolarSchoolRootView;
			if (solarSchoolRootView == null)
			{
				return true;
			}
			ECommonChildViewName? currentChildViewName = solarSchoolRootView.CurrentChildViewName;
			return currentChildViewName != null && SolarSchoolGamePlayModel.Instance.IsViewAllowRewardTip(currentChildViewName.Value.ToEnumString(), true);
		}

		// Token: 0x06038BC4 RID: 232388 RVA: 0x00FE10F3 File Offset: 0x00FDF2F3
		[NullableContext(2)]
		private UiViewBase GetTopView()
		{
			UiViewBase result;
			if ((result = UiModel.Instance.GetTopView(ELayerType.Pop)) == null)
			{
				result = (UiModel.Instance.GetTopView(ELayerType.Plot) ?? UiModel.Instance.GetTopView(ELayerType.Normal));
			}
			return result;
		}

		// Token: 0x06038BC5 RID: 232389 RVA: 0x00FE111F File Offset: 0x00FDF31F
		private bool HasQueuedOrPendingRewardTips()
		{
			return !this.AttrRewardTipQueue.Empty || !this.ItemRewardTipQueue.Empty || this.AttrColumnState.NextRewardTipLoadState != EItemLoadState.None || this.ItemColumnState.NextRewardTipLoadState > EItemLoadState.None;
		}

		// Token: 0x06038BC6 RID: 232390 RVA: 0x00FE1158 File Offset: 0x00FDF358
		internal bool HasVisibleRewardTips()
		{
			return this.CountVisibleRewardTips(null) > 0;
		}

		// Token: 0x06038BC7 RID: 232391 RVA: 0x00FE1164 File Offset: 0x00FDF364
		[NullableContext(2)]
		private int CountVisibleRewardTips(SolarSchoolRewardTipColumnState column = null)
		{
			int num = 0;
			foreach (SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance in this.RewardTipItems)
			{
				if ((column == null || solarSchoolRewardTipItemInstance.TypeState.ColumnState == column) && SolarSchoolRewardTipView.IsRewardTipVisible(solarSchoolRewardTipItemInstance.Item))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06038BC8 RID: 232392 RVA: 0x00FE11D8 File Offset: 0x00FDF3D8
		private static bool IsRewardTipVisible(SolarSchoolRewardTipItemBase item)
		{
			return item.Status != EStatus.None && item.Status != EStatus.Destroy;
		}

		// Token: 0x06038BC9 RID: 232393 RVA: 0x00FE11F0 File Offset: 0x00FDF3F0
		private void TickRewardTipItems(float delta)
		{
			this.UpdateRewardTipItemPositions();
			foreach (SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance in this.RewardTipItems)
			{
				solarSchoolRewardTipItemInstance.Item.Tick(delta);
			}
		}

		// Token: 0x06038BCA RID: 232394 RVA: 0x00FE124C File Offset: 0x00FDF44C
		private void UpdateRewardTipItemPositions()
		{
			int num = 0;
			int num2 = 0;
			foreach (SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance in this.RewardTipItems)
			{
				SolarSchoolRewardTipColumnState columnState = solarSchoolRewardTipItemInstance.TypeState.ColumnState;
				int num3;
				if (columnState != this.AttrColumnState)
				{
					num2 = (num3 = num2) + 1;
				}
				else
				{
					num = (num3 = num) + 1;
				}
				int num4 = num3;
				float anchorOffsetY = -columnState.SliderHeight - columnState.Layout.Padding.Top - columnState.ChildHeight * 0.5f - (float)num4 * (columnState.ChildHeight + columnState.Layout.Spacing);
				solarSchoolRewardTipItemInstance.Item.GetRootItem().SetAnchorOffsetY(anchorOffsetY);
			}
		}

		// Token: 0x06038BCB RID: 232395 RVA: 0x00FE1310 File Offset: 0x00FDF510
		private void UpdateOldestRewardTip(float delta, bool canShowNewRewardTip)
		{
			SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance = this.RewardTipItems.Find((SolarSchoolRewardTipItemInstance instance) => SolarSchoolRewardTipView.IsRewardTipVisible(instance.Item));
			SolarSchoolRewardTipItemBase solarSchoolRewardTipItemBase = (solarSchoolRewardTipItemInstance != null) ? solarSchoolRewardTipItemInstance.Item : null;
			if (solarSchoolRewardTipItemBase == null)
			{
				return;
			}
			if (solarSchoolRewardTipItemBase.Status == EStatus.Finish)
			{
				solarSchoolRewardTipItemBase.Status = EStatus.Destroy;
				return;
			}
			if (solarSchoolRewardTipItemBase.Status == EStatus.Halfway)
			{
				solarSchoolRewardTipItemBase.AddShowTime += delta;
				if (this.ShouldDismissOldestItem(canShowNewRewardTip))
				{
					solarSchoolRewardTipItemBase.Status = EStatus.Over;
					solarSchoolRewardTipItemBase.PlayEnd();
				}
			}
		}

		// Token: 0x06038BCC RID: 232396 RVA: 0x00FE1396 File Offset: 0x00FDF596
		private bool ShouldDismissOldestItem(bool canShowNewRewardTip)
		{
			if (!canShowNewRewardTip || !this.HasQueuedOrPendingRewardTips())
			{
				return this.BatchIdleElapsedTime >= 1000f;
			}
			return this.CountVisibleRewardTips(null) >= 5;
		}

		// Token: 0x06038BCD RID: 232397 RVA: 0x00FE13C4 File Offset: 0x00FDF5C4
		private void UpdateColumnSlideOffset(SolarSchoolRewardTipColumnState column, float delta)
		{
			if (column.SliderHeight <= 0f || column.ChildHeight <= 0f)
			{
				return;
			}
			float num = (column == this.AttrColumnState) ? (column.ChildHeight + column.Layout.Spacing) : column.ChildHeight;
			column.SliderHeight -= num / 100f * delta;
			if (column.SliderHeight < 0f)
			{
				column.SliderHeight = 0f;
			}
		}

		// Token: 0x06038BCE RID: 232398 RVA: 0x00FE1440 File Offset: 0x00FDF640
		private bool RecycleFinishedRewardTips()
		{
			bool result = false;
			int i = 0;
			while (i < this.RewardTipItems.Count)
			{
				SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance = this.RewardTipItems[i];
				if (solarSchoolRewardTipItemInstance.Item.Status != EStatus.Destroy)
				{
					i++;
				}
				else
				{
					this.RewardTipItems.RemoveAt(i);
					SolarSchoolRewardTipView.ReturnItemToPool(solarSchoolRewardTipItemInstance);
					SolarSchoolRewardTipColumnState column = solarSchoolRewardTipItemInstance.TypeState.ColumnState;
					if (column == this.AttrColumnState)
					{
						result = true;
						if (!this.RewardTipItems.Exists((SolarSchoolRewardTipItemInstance remaining) => remaining.TypeState.ColumnState == column && SolarSchoolRewardTipView.IsRewardTipVisible(remaining.Item)))
						{
							column.SliderHeight = 0f;
						}
					}
					else if (this.RewardTipItems.Exists((SolarSchoolRewardTipItemInstance remaining) => remaining.TypeState.ColumnState == column))
					{
						column.SliderHeight += column.ChildHeight + column.Layout.Spacing;
					}
					else
					{
						column.SliderHeight = 0f;
					}
				}
			}
			return result;
		}

		// Token: 0x06038BCF RID: 232399 RVA: 0x00FE1549 File Offset: 0x00FDF749
		private void UpdateColumnHeight(SolarSchoolRewardTipColumnState column)
		{
			this.UpdateColumnHeight(column, this.CountVisibleRewardTips(column));
		}

		// Token: 0x06038BD0 RID: 232400 RVA: 0x00FE155C File Offset: 0x00FDF75C
		private void UpdateColumnHeight(SolarSchoolRewardTipColumnState column, int count)
		{
			float num = (float)count * column.ChildHeight;
			if (column == this.AttrColumnState && count > 1)
			{
				num += (float)(count - 1) * column.Layout.Spacing;
			}
			column.ParentUiItem.SetHeight(num);
		}

		// Token: 0x06038BD1 RID: 232401 RVA: 0x00FE15A0 File Offset: 0x00FDF7A0
		private void PlayPendingRewardTip(SolarSchoolRewardTipColumnState column)
		{
			SolarSchoolRewardTipItemBase pendingItem = column.PendingRewardTipItem;
			if (pendingItem == null)
			{
				return;
			}
			SolarSchoolRewardTipItemInstance solarSchoolRewardTipItemInstance = this.RewardTipItems.Find((SolarSchoolRewardTipItemInstance instance) => instance.Item == pendingItem);
			if (solarSchoolRewardTipItemInstance != null)
			{
				this.RewardTipItems.Remove(solarSchoolRewardTipItemInstance);
				this.RewardTipItems.Add(solarSchoolRewardTipItemInstance);
			}
			int num = 0;
			if (column == this.AttrColumnState)
			{
				num = this.CountVisibleRewardTips(this.AttrColumnState);
				if (num > 0)
				{
					this.AttrColumnState.SliderHeight += this.AttrColumnState.ChildHeight + this.AttrColumnState.Layout.Spacing;
				}
			}
			pendingItem.SetActive(true);
			if (column == this.AttrColumnState)
			{
				this.UpdateColumnHeight(this.AttrColumnState, num + 1);
				this.UpdateRewardTipItemPositions();
			}
			pendingItem.Play();
			column.ResetPendingRewardTip();
		}

		// Token: 0x06038BD2 RID: 232402 RVA: 0x00FE1688 File Offset: 0x00FDF888
		private UniTask LoadNextRewardTipAsync(SolarSchoolRewardTipColumnState column)
		{
			SolarSchoolRewardTipView.<LoadNextRewardTipAsync>d__39 <LoadNextRewardTipAsync>d__;
			<LoadNextRewardTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadNextRewardTipAsync>d__.<>4__this = this;
			<LoadNextRewardTipAsync>d__.column = column;
			<LoadNextRewardTipAsync>d__.<>1__state = -1;
			<LoadNextRewardTipAsync>d__.<>t__builder.Start<SolarSchoolRewardTipView.<LoadNextRewardTipAsync>d__39>(ref <LoadNextRewardTipAsync>d__);
			return <LoadNextRewardTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BD3 RID: 232403 RVA: 0x00FE16D4 File Offset: 0x00FDF8D4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<SolarSchoolRewardTipItemBase> AcquireItemForNextRewardTipAsync(SolarSchoolRewardTipColumnState column)
		{
			SolarSchoolRewardTipView.<AcquireItemForNextRewardTipAsync>d__40 <AcquireItemForNextRewardTipAsync>d__;
			<AcquireItemForNextRewardTipAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SolarSchoolRewardTipItemBase>.Create();
			<AcquireItemForNextRewardTipAsync>d__.<>4__this = this;
			<AcquireItemForNextRewardTipAsync>d__.column = column;
			<AcquireItemForNextRewardTipAsync>d__.<>1__state = -1;
			<AcquireItemForNextRewardTipAsync>d__.<>t__builder.Start<SolarSchoolRewardTipView.<AcquireItemForNextRewardTipAsync>d__40>(ref <AcquireItemForNextRewardTipAsync>d__);
			return <AcquireItemForNextRewardTipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BD4 RID: 232404 RVA: 0x00FE1720 File Offset: 0x00FDF920
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<SolarSchoolRewardTipItemBase> CreateItemAsync(SolarSchoolRewardTipItemTypeState typeState)
		{
			SolarSchoolRewardTipView.<CreateItemAsync>d__41 <CreateItemAsync>d__;
			<CreateItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SolarSchoolRewardTipItemBase>.Create();
			<CreateItemAsync>d__.<>4__this = this;
			<CreateItemAsync>d__.typeState = typeState;
			<CreateItemAsync>d__.<>1__state = -1;
			<CreateItemAsync>d__.<>t__builder.Start<SolarSchoolRewardTipView.<CreateItemAsync>d__41>(ref <CreateItemAsync>d__);
			return <CreateItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BD5 RID: 232405 RVA: 0x00FE176C File Offset: 0x00FDF96C
		private UniTask PrewarmItemAsync(ESolarSchoolRewardTipType type)
		{
			SolarSchoolRewardTipView.<PrewarmItemAsync>d__42 <PrewarmItemAsync>d__;
			<PrewarmItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PrewarmItemAsync>d__.<>4__this = this;
			<PrewarmItemAsync>d__.type = type;
			<PrewarmItemAsync>d__.<>1__state = -1;
			<PrewarmItemAsync>d__.<>t__builder.Start<SolarSchoolRewardTipView.<PrewarmItemAsync>d__42>(ref <PrewarmItemAsync>d__);
			return <PrewarmItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038BD6 RID: 232406 RVA: 0x00FE17B8 File Offset: 0x00FDF9B8
		private void CancelPendingRewardTip(SolarSchoolRewardTipColumnState column, [Nullable(2)] SolarSchoolRewardTipItemBase item)
		{
			int num = (item == null) ? -1 : this.RewardTipItems.FindIndex((SolarSchoolRewardTipItemInstance instance) => instance.Item == item);
			if (num >= 0)
			{
				SolarSchoolRewardTipItemInstance itemInstance = this.RewardTipItems[num];
				this.RewardTipItems.RemoveAt(num);
				SolarSchoolRewardTipView.ReturnItemToPool(itemInstance);
			}
			column.ResetPendingRewardTip();
		}

		// Token: 0x06038BD7 RID: 232407 RVA: 0x00FE181C File Offset: 0x00FDFA1C
		private static void ReturnItemToPool(SolarSchoolRewardTipItemInstance itemInstance)
		{
			itemInstance.Item.Status = EStatus.None;
			itemInstance.Item.SetActive(false);
			itemInstance.TypeState.ItemPool.Add(itemInstance.Item);
		}

		// Token: 0x06038BD8 RID: 232408 RVA: 0x00FE184C File Offset: 0x00FDFA4C
		private SolarSchoolRewardTipItemTypeState GetItemTypeState(ESolarSchoolRewardTipType type)
		{
			SolarSchoolRewardTipItemTypeState result;
			if (!this.ItemTypeStates.TryGetValue(type, out result))
			{
				return this.ItemTypeStates[ESolarSchoolRewardTipType.Attr];
			}
			return result;
		}

		// Token: 0x06038BD9 RID: 232409 RVA: 0x00FE1877 File Offset: 0x00FDFA77
		internal bool HasUnfinishedRewardTips()
		{
			return !this.AttrRewardTipQueue.Empty || !this.ItemRewardTipQueue.Empty || this.RewardTipItems.Count > 0;
		}

		// Token: 0x06038BDA RID: 232410 RVA: 0x00FE18A3 File Offset: 0x00FDFAA3
		internal void EnqueueRewardTip(ESolarSchoolRewardTipType type, int targetId, int delta)
		{
			if (targetId <= 0 || delta == 0)
			{
				return;
			}
			this.GetRewardTipQueue(type).Push(new SolarSchoolRewardTipData(type, targetId, delta));
		}

		// Token: 0x06038BDB RID: 232411 RVA: 0x00FE18C1 File Offset: 0x00FDFAC1
		internal void EnqueueQuestDoneTip(int questId)
		{
			if (questId <= 0)
			{
				return;
			}
			this.GetRewardTipQueue(ESolarSchoolRewardTipType.QuestDone).Push(new SolarSchoolRewardTipData(ESolarSchoolRewardTipType.QuestDone, questId, 0));
		}

		// Token: 0x06038BDC RID: 232412 RVA: 0x00FE18DC File Offset: 0x00FDFADC
		private Queue<SolarSchoolRewardTipData> GetRewardTipQueue(ESolarSchoolRewardTipType type)
		{
			if (type != ESolarSchoolRewardTipType.Attr)
			{
				return this.ItemRewardTipQueue;
			}
			return this.AttrRewardTipQueue;
		}

		// Token: 0x0401DDE9 RID: 122345
		private float BatchIdleElapsedTime;

		// Token: 0x0401DDEA RID: 122346
		private bool AreColumnsActive;

		// Token: 0x0401DDEB RID: 122347
		private bool AreColumnsInitialized;

		// Token: 0x0401DDEC RID: 122348
		private bool? LastCanShowNewRewardTip;

		// Token: 0x0401DDEE RID: 122350
		private readonly Queue<SolarSchoolRewardTipData> AttrRewardTipQueue = new Queue<SolarSchoolRewardTipData>(4);

		// Token: 0x0401DDEF RID: 122351
		private readonly Queue<SolarSchoolRewardTipData> ItemRewardTipQueue = new Queue<SolarSchoolRewardTipData>(4);

		// Token: 0x0401DDF0 RID: 122352
		private readonly Dictionary<ESolarSchoolRewardTipType, SolarSchoolRewardTipItemTypeState> ItemTypeStates = new Dictionary<ESolarSchoolRewardTipType, SolarSchoolRewardTipItemTypeState>();

		// Token: 0x0401DDF1 RID: 122353
		private readonly List<SolarSchoolRewardTipItemInstance> RewardTipItems = new List<SolarSchoolRewardTipItemInstance>();

		// Token: 0x0401DDF2 RID: 122354
		private readonly List<SolarSchoolRewardTipItemBase> OwnedItems = new List<SolarSchoolRewardTipItemBase>();

		// Token: 0x0401DDF3 RID: 122355
		private SolarSchoolRewardTipColumnState AttrColumnState;

		// Token: 0x0401DDF4 RID: 122356
		private SolarSchoolRewardTipColumnState ItemColumnState;
	}
}
