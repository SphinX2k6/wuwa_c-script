using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200484B RID: 18507
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonEntranceView : UiTickViewBase
	{
		// Token: 0x0602E8AA RID: 190634 RVA: 0x00CFE29C File Offset: 0x00CFC49C
		[NullableContext(1)]
		public InstanceDungeonEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005E31 RID: 24113
		// (get) Token: 0x0602E8AB RID: 190635 RVA: 0x00CFE2B0 File Offset: 0x00CFC4B0
		private InstanceDungeon? InstanceConfig
		{
			get
			{
				if (this.InstanceId == 0)
				{
					return null;
				}
				return InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			}
		}

		// Token: 0x0602E8AC RID: 190636 RVA: 0x00CFE2E0 File Offset: 0x00CFC4E0
		protected unsafe override void OnRegisterComponent()
		{
			this.Vm = ((this.OpenParam as InstanceDungeonViewModelBase) ?? new BaseInstanceDungeonViewModel());
			this.Vm.RegisterView(this);
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E8AD RID: 190637 RVA: 0x00CFE47C File Offset: 0x00CFC67C
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonEntranceView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8AE RID: 190638 RVA: 0x00CFE4BF File Offset: 0x00CFC6BF
		protected override void OnStart()
		{
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			this.TitleInstanceGridNumberMap = new Dictionary<int, int>();
			this.SetDefaultSelect();
		}

		// Token: 0x0602E8AF RID: 190639 RVA: 0x00CFE4E5 File Offset: 0x00CFC6E5
		private void OpenPowerView(int index)
		{
			PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
		}

		// Token: 0x0602E8B0 RID: 190640 RVA: 0x00CFE4F3 File Offset: 0x00CFC6F3
		protected override void OnTick(float delta)
		{
			if (!this.NeedOnTimer)
			{
				return;
			}
			this.Vm.TimerRefreshFunction(delta);
		}

		// Token: 0x0602E8B1 RID: 190641 RVA: 0x00CFE50A File Offset: 0x00CFC70A
		protected override void OnBeforeShow()
		{
			this.InitView();
		}

		// Token: 0x0602E8B2 RID: 190642 RVA: 0x00CFE514 File Offset: 0x00CFC714
		protected override void OnAfterShow()
		{
			this.MatchingCountDownItem.BindOnClickBtnCancelMatching(delegate
			{
				InstanceDungeonEntranceController.Instance.CancelMatchRequest();
			});
			this.MatchingCountDownItem.BindOnAfterCloseAnimation(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.SetMatchingItemActive(false);
				}
			});
			if (this.Vm.InstanceIdList.Length == 0)
			{
				base.GetItem(2).SetUIActive(false);
				return;
			}
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				this.SetMatchingItemActive(true);
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem != null)
				{
					matchingCountDownItem.PlayAnimation("Start");
				}
				this.MatchingCountDownItem.StartTimer();
			}
		}

		// Token: 0x0602E8B3 RID: 190643 RVA: 0x00CFE5B3 File Offset: 0x00CFC7B3
		protected override void OnBeforeHide()
		{
			this.Vm.OnBeforeHide();
		}

		// Token: 0x0602E8B4 RID: 190644 RVA: 0x00CFE5C0 File Offset: 0x00CFC7C0
		protected override void OnBeforeDestroy()
		{
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingBackground", Array.Empty<object>());
			}
			InstanceDungeonEntranceController.Instance.RestoreDungeonEntranceEntity();
			this.Vm.OnBeforeDestroy();
			this.MatchingCountDownItem = null;
			PowerCurrencyItem powerCurrencyItem = this.PowerCurrencyItem;
			if (powerCurrencyItem != null)
			{
				powerCurrencyItem.Destroy(null);
			}
			PowerCurrencyItem overPowerCurrencyItem = this.OverPowerCurrencyItem;
			if (overPowerCurrencyItem != null)
			{
				overPowerCurrencyItem.Destroy(null);
			}
			if (this.InstanceLoopScroll != null)
			{
				this.InstanceLoopScroll.ClearChildren();
				this.InstanceLoopScroll = null;
			}
			this.DynamicScrollViewComponent = null;
			EventSystem.Instance.Emit(EEventName.OnBeforeDestroyInstanceDungeonEntranceView);
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
			EventSystem.Instance.Emit<int>(EEventName.CloseInstanceEntrancePositively, this.Vm.EntranceId);
		}

		// Token: 0x0602E8B5 RID: 190645 RVA: 0x00CFE688 File Offset: 0x00CFC888
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x0602E8B6 RID: 190646 RVA: 0x00CFE6E8 File Offset: 0x00CFC8E8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x0602E8B7 RID: 190647 RVA: 0x00CFE748 File Offset: 0x00CFC948
		private void SetDefaultSelect()
		{
			int selectInstanceId = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
			if (selectInstanceId > 0)
			{
				foreach (KeyValuePair<int, List<int>> keyValuePair in this.Vm.InstanceByTitleMap)
				{
					int num;
					List<int> list;
					keyValuePair.Deconstruct(out num, out list);
					int seriesId = num;
					if (list.Contains(selectInstanceId))
					{
						this.SeriesId = seriesId;
						this.InstanceId = selectInstanceId;
						return;
					}
				}
			}
			InstanceDungeonEntranceViewSelectData defaultSelectData = this.Vm.GetDefaultSelectData();
			if (defaultSelectData == null)
			{
				return;
			}
			this.SeriesId = defaultSelectData.SeriesId;
			this.InstanceId = defaultSelectData.InstanceId;
		}

		// Token: 0x0602E8B8 RID: 190648 RVA: 0x00CFE7FC File Offset: 0x00CFC9FC
		private void OnClickCaptionStateBtn()
		{
			HelpController.Instance.OpenHelpById(242);
		}

		// Token: 0x0602E8B9 RID: 190649 RVA: 0x00CFE810 File Offset: 0x00CFCA10
		private void InitView()
		{
			UiAsyncTask task = new UiAsyncTask("InstanceDungeonEntranceView.RefreshInstance", delegate()
			{
				InstanceDungeonEntranceView.<<InitView>b__40_0>d <<InitView>b__40_0>d;
				<<InitView>b__40_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<InitView>b__40_0>d.<>4__this = this;
				<<InitView>b__40_0>d.<>1__state = -1;
				<<InitView>b__40_0>d.<>t__builder.Start<InstanceDungeonEntranceView.<<InitView>b__40_0>d>(ref <<InitView>b__40_0>d);
				return <<InitView>b__40_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602E8BA RID: 190650 RVA: 0x00CFE840 File Offset: 0x00CFCA40
		private UniTask InitViewAsync()
		{
			InstanceDungeonEntranceView.<InitViewAsync>d__41 <InitViewAsync>d__;
			<InitViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitViewAsync>d__.<>4__this = this;
			<InitViewAsync>d__.<>1__state = -1;
			<InitViewAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<InitViewAsync>d__41>(ref <InitViewAsync>d__);
			return <InitViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8BB RID: 190651 RVA: 0x00CFE884 File Offset: 0x00CFCA84
		public void RefreshMowingInstance()
		{
			UiAsyncTask task = new UiAsyncTask("InstanceDungeonEntranceView.RefreshInstance", delegate()
			{
				InstanceDungeonEntranceView.<<RefreshMowingInstance>b__42_0>d <<RefreshMowingInstance>b__42_0>d;
				<<RefreshMowingInstance>b__42_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshMowingInstance>b__42_0>d.<>4__this = this;
				<<RefreshMowingInstance>b__42_0>d.<>1__state = -1;
				<<RefreshMowingInstance>b__42_0>d.<>t__builder.Start<InstanceDungeonEntranceView.<<RefreshMowingInstance>b__42_0>d>(ref <<RefreshMowingInstance>b__42_0>d);
				return <<RefreshMowingInstance>b__42_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602E8BC RID: 190652 RVA: 0x00CFE8B4 File Offset: 0x00CFCAB4
		private UniTask RefreshMowingInstanceAsync()
		{
			InstanceDungeonEntranceView.<RefreshMowingInstanceAsync>d__43 <RefreshMowingInstanceAsync>d__;
			<RefreshMowingInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMowingInstanceAsync>d__.<>4__this = this;
			<RefreshMowingInstanceAsync>d__.<>1__state = -1;
			<RefreshMowingInstanceAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<RefreshMowingInstanceAsync>d__43>(ref <RefreshMowingInstanceAsync>d__);
			return <RefreshMowingInstanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8BD RID: 190653 RVA: 0x00CFE8F8 File Offset: 0x00CFCAF8
		public void RefreshTowerDefenseInstance()
		{
			UiAsyncTask task = new UiAsyncTask("InstanceDungeonEntranceView.RefreshInstance", delegate()
			{
				InstanceDungeonEntranceView.<<RefreshTowerDefenseInstance>b__44_0>d <<RefreshTowerDefenseInstance>b__44_0>d;
				<<RefreshTowerDefenseInstance>b__44_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshTowerDefenseInstance>b__44_0>d.<>4__this = this;
				<<RefreshTowerDefenseInstance>b__44_0>d.<>1__state = -1;
				<<RefreshTowerDefenseInstance>b__44_0>d.<>t__builder.Start<InstanceDungeonEntranceView.<<RefreshTowerDefenseInstance>b__44_0>d>(ref <<RefreshTowerDefenseInstance>b__44_0>d);
				return <<RefreshTowerDefenseInstance>b__44_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602E8BE RID: 190654 RVA: 0x00CFE928 File Offset: 0x00CFCB28
		private UniTask RefreshTowerDefenceInstanceAsync()
		{
			InstanceDungeonEntranceView.<RefreshTowerDefenceInstanceAsync>d__45 <RefreshTowerDefenceInstanceAsync>d__;
			<RefreshTowerDefenceInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTowerDefenceInstanceAsync>d__.<>4__this = this;
			<RefreshTowerDefenceInstanceAsync>d__.<>1__state = -1;
			<RefreshTowerDefenceInstanceAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<RefreshTowerDefenceInstanceAsync>d__45>(ref <RefreshTowerDefenceInstanceAsync>d__);
			return <RefreshTowerDefenceInstanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8BF RID: 190655 RVA: 0x00CFE96C File Offset: 0x00CFCB6C
		public void RefreshSolarSpeedInstance(float delta, bool force = false)
		{
			if (!force)
			{
				this.CountDownMs -= delta;
				if (this.CountDownMs > 0f)
				{
					return;
				}
			}
			if (this.InstanceLoopScroll != null)
			{
				for (int i = 0; i < this.InstanceLoopScroll.GetScrollItemCount(); i++)
				{
					InstanceDetectItem scrollItemFromIndex = this.InstanceLoopScroll.GetScrollItemFromIndex(i);
					if (scrollItemFromIndex != null)
					{
						scrollItemFromIndex.UpdateSelf();
					}
				}
			}
			this.UpdateUnlockStateItem();
			this.CountDownMs = 1000f;
		}

		// Token: 0x0602E8C0 RID: 190656 RVA: 0x00CFE9E0 File Offset: 0x00CFCBE0
		private void RefreshCaptionStateItemByData(int dungeonId)
		{
			bool flag = InstanceDungeonEntranceModel.Instance.IsDungeonArchiveActivate(dungeonId);
			this.InstanceDungeonCaptionItem.SetCaptionStateActive(flag);
			this.InstanceDungeonCaptionItem.SetCaptionChangeColor(false);
			if (flag)
			{
				if (InstanceDungeonEntranceModel.Instance.HasDungeonArchive(dungeonId))
				{
					this.InstanceDungeonCaptionItem.SetCaptionStateTip("instance_HaveRecord");
					this.InstanceDungeonCaptionItem.SetCaptionChangeColor(true);
					return;
				}
				if (InstanceDungeonEntranceModel.Instance.IsDungeonSupportAndWithoutArchive(dungeonId))
				{
					this.InstanceDungeonCaptionItem.SetCaptionStateTip("instance_Record_leave");
				}
			}
		}

		// Token: 0x0602E8C1 RID: 190657 RVA: 0x00CFEA5C File Offset: 0x00CFCC5C
		private void UpdateInstancesView()
		{
			InstanceDetectionDynamicData[] instanceListBySelectSeriesId = this.GetInstanceListBySelectSeriesId();
			this.InstanceLoopScroll.RefreshByData(instanceListBySelectSeriesId, false, false);
			base.GetItem(2).SetUIActive(true);
			this.InstanceLoopScroll.BindLateUpdate(delegate(float _)
			{
				int scrollItemCount = this.InstanceLoopScroll.GetScrollItemCount();
				if (this.ScrollIndex + 1 < scrollItemCount)
				{
					this.InstanceLoopScroll.UnBindLateUpdate();
					return;
				}
				Dictionary<int, List<int>> instanceByTitleMap = this.Vm.InstanceByTitleMap;
				int num = (instanceByTitleMap != null) ? instanceByTitleMap.Count : 0;
				if (this.ScrollIndex >= num)
				{
					this.ScrollIndex = num - 1;
				}
				this.InstanceLoopScroll.ScrollToItemIndex(this.ScrollIndex, true, false).Forget();
				this.InstanceLoopScroll.UnBindLateUpdate();
			});
		}

		// Token: 0x0602E8C2 RID: 190658 RVA: 0x00CFEAA4 File Offset: 0x00CFCCA4
		private UniTask UpdateScorePanelAsync()
		{
			InstanceDungeonEntranceView.<UpdateScorePanelAsync>d__49 <UpdateScorePanelAsync>d__;
			<UpdateScorePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateScorePanelAsync>d__.<>4__this = this;
			<UpdateScorePanelAsync>d__.<>1__state = -1;
			<UpdateScorePanelAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateScorePanelAsync>d__49>(ref <UpdateScorePanelAsync>d__);
			return <UpdateScorePanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8C3 RID: 190659 RVA: 0x00CFEAE8 File Offset: 0x00CFCCE8
		private UniTask UpdateInstanceDungeonTowerDefenseItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceDungeonTowerDefenseItemAsync>d__50 <UpdateInstanceDungeonTowerDefenseItemAsync>d__;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>4__this = this;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>1__state = -1;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceDungeonTowerDefenseItemAsync>d__50>(ref <UpdateInstanceDungeonTowerDefenseItemAsync>d__);
			return <UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8C4 RID: 190660 RVA: 0x00CFEB2C File Offset: 0x00CFCD2C
		private UniTask UpdateInstanceDungeonSolarSpeedItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceDungeonSolarSpeedItemAsync>d__51 <UpdateInstanceDungeonSolarSpeedItemAsync>d__;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>4__this = this;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>1__state = -1;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceDungeonSolarSpeedItemAsync>d__51>(ref <UpdateInstanceDungeonSolarSpeedItemAsync>d__);
			return <UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8C5 RID: 190661 RVA: 0x00CFEB70 File Offset: 0x00CFCD70
		private UniTask UpdateMowingScorePanelItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateMowingScorePanelItemAsync>d__52 <UpdateMowingScorePanelItemAsync>d__;
			<UpdateMowingScorePanelItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMowingScorePanelItemAsync>d__.<>4__this = this;
			<UpdateMowingScorePanelItemAsync>d__.<>1__state = -1;
			<UpdateMowingScorePanelItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateMowingScorePanelItemAsync>d__52>(ref <UpdateMowingScorePanelItemAsync>d__);
			return <UpdateMowingScorePanelItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8C6 RID: 190662 RVA: 0x00CFEBB4 File Offset: 0x00CFCDB4
		[NullableContext(1)]
		private InstanceDetectItem CreateInstanceGrid(InstanceDetectionDynamicData data, UUIItem uiItem, int index)
		{
			InstanceDetectItem instanceDetectItem = new InstanceDetectItem();
			instanceDetectItem.OpenParam = this.Vm;
			instanceDetectItem.BindClickInstanceCallback(new Action<int, UUIExtendToggle, InstanceDetectionDynamicData>(this.RefreshInstanceById));
			instanceDetectItem.BindClickSeriesCallback(new Action<int, UUIExtendToggle, bool>(this.RefreshSeriesById));
			instanceDetectItem.BindCanExecuteChange(new Func<int, bool>(this.CanExecuteChange));
			instanceDetectItem.BindCanShowRedDot(new Func<int, bool>(this.CanShowRedDot));
			instanceDetectItem.BindIconRightPathGetter(new Func<int, string>(InstanceDungeonEntranceController.Instance.GetIconRightPathGetter));
			return instanceDetectItem;
		}

		// Token: 0x0602E8C7 RID: 190663 RVA: 0x00CFEC30 File Offset: 0x00CFCE30
		[NullableContext(1)]
		private void RefreshSeriesById(int id, UUIExtendToggle toggle, bool isShow)
		{
			if (this.CurrentSeriesToggle != null && this.CurrentSeriesToggle != toggle)
			{
				this.CurrentSeriesToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			this.CurrentSeriesToggle = toggle;
			this.SeriesId = (isShow ? id : -1);
			this.InstanceId = (isShow ? this.Vm.InstanceByTitleMap[id][0] : this.InstanceId);
			InstanceDetectionDynamicData[] instanceListBySelectSeriesId = this.GetInstanceListBySelectSeriesId();
			this.InstanceLoopScroll.RefreshByData(instanceListBySelectSeriesId, false, false);
			this.InstanceLoopScroll.BindLateUpdate(new Action<float>(this.ScrollToItem));
		}

		// Token: 0x0602E8C8 RID: 190664 RVA: 0x00CFECC8 File Offset: 0x00CFCEC8
		private void ScrollToItem(float delta)
		{
			int valueOrDefault = this.TitleInstanceGridNumberMap.GetValueOrDefault(this.SeriesId, 0);
			float scrollProgress = (float)(this.ScrollIndex - 1) / (float)(this.Vm.InstanceByTitleMap.Count + valueOrDefault);
			base.GetUIDynScrollViewComponent(0).SetScrollProgress(scrollProgress);
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll == null)
			{
				return;
			}
			instanceLoopScroll.UnBindLateUpdate();
		}

		// Token: 0x0602E8C9 RID: 190665 RVA: 0x00CFED24 File Offset: 0x00CFCF24
		[NullableContext(1)]
		private void RefreshInstanceById(int id, UUIExtendToggle toggle, [Nullable(2)] InstanceDetectionDynamicData data = null)
		{
			InstanceDungeonEntranceView.<>c__DisplayClass56_0 CS$<>8__locals1 = new InstanceDungeonEntranceView.<>c__DisplayClass56_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.id = id;
			CS$<>8__locals1.toggle = toggle;
			CS$<>8__locals1.data = data;
			UiAsyncTask task = new UiAsyncTask("InstanceDungeonEntranceView.RefreshInstance", delegate()
			{
				InstanceDungeonEntranceView.<>c__DisplayClass56_0.<<RefreshInstanceById>b__0>d <<RefreshInstanceById>b__0>d;
				<<RefreshInstanceById>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshInstanceById>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshInstanceById>b__0>d.<>1__state = -1;
				<<RefreshInstanceById>b__0>d.<>t__builder.Start<InstanceDungeonEntranceView.<>c__DisplayClass56_0.<<RefreshInstanceById>b__0>d>(ref <<RefreshInstanceById>b__0>d);
				return <<RefreshInstanceById>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602E8CA RID: 190666 RVA: 0x00CFED74 File Offset: 0x00CFCF74
		[NullableContext(1)]
		private UniTask RefreshInstanceByIdAsync(int id, UUIExtendToggle toggle, [Nullable(2)] InstanceDetectionDynamicData data = null)
		{
			InstanceDungeonEntranceView.<RefreshInstanceByIdAsync>d__57 <RefreshInstanceByIdAsync>d__;
			<RefreshInstanceByIdAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInstanceByIdAsync>d__.<>4__this = this;
			<RefreshInstanceByIdAsync>d__.id = id;
			<RefreshInstanceByIdAsync>d__.toggle = toggle;
			<RefreshInstanceByIdAsync>d__.data = data;
			<RefreshInstanceByIdAsync>d__.<>1__state = -1;
			<RefreshInstanceByIdAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<RefreshInstanceByIdAsync>d__57>(ref <RefreshInstanceByIdAsync>d__);
			return <RefreshInstanceByIdAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8CB RID: 190667 RVA: 0x00CFEDD0 File Offset: 0x00CFCFD0
		private void CheckAndShowDungeonArchiveExpireTips()
		{
			int selectInstanceId = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
			InstanceDungeonController.Instance.CheckAndShowDungeonArchiveExpireTips(selectInstanceId);
		}

		// Token: 0x0602E8CC RID: 190668 RVA: 0x00CFEDF3 File Offset: 0x00CFCFF3
		private bool CanExecuteChange(int id)
		{
			return this.InstanceId != id;
		}

		// Token: 0x0602E8CD RID: 190669 RVA: 0x00CFEE04 File Offset: 0x00CFD004
		private bool CanShowRedDot(int id)
		{
			InstanceDungeon? instanceConfig = this.InstanceConfig;
			if (instanceConfig != null && instanceConfig.GetValueOrDefault().InstSubType == 21)
			{
				List<int> list;
				if (!this.Vm.InstanceByTitleMap.TryGetValue(id, out list))
				{
					return false;
				}
				using (List<int>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int instanceId = enumerator.Current;
						if (this.Vm.CheckInstanceItemHasRedDot(instanceId))
						{
							return true;
						}
					}
					return false;
				}
			}
			instanceConfig = this.InstanceConfig;
			if (instanceConfig != null && instanceConfig.GetValueOrDefault().InstSubType == 28)
			{
				return SolarSpeedModel.Instance.HasRedDotByInstanceId(id);
			}
			return false;
		}

		// Token: 0x0602E8CE RID: 190670 RVA: 0x00CFEED8 File Offset: 0x00CFD0D8
		private UniTask UpdateInstanceAllItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceAllItemAsync>d__61 <UpdateInstanceAllItemAsync>d__;
			<UpdateInstanceAllItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceAllItemAsync>d__.<>4__this = this;
			<UpdateInstanceAllItemAsync>d__.<>1__state = -1;
			<UpdateInstanceAllItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceAllItemAsync>d__61>(ref <UpdateInstanceAllItemAsync>d__);
			return <UpdateInstanceAllItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8CF RID: 190671 RVA: 0x00CFEF1C File Offset: 0x00CFD11C
		private UniTask UpdateInstanceBg()
		{
			InstanceDungeonEntranceView.<UpdateInstanceBg>d__62 <UpdateInstanceBg>d__;
			<UpdateInstanceBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceBg>d__.<>4__this = this;
			<UpdateInstanceBg>d__.<>1__state = -1;
			<UpdateInstanceBg>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceBg>d__62>(ref <UpdateInstanceBg>d__);
			return <UpdateInstanceBg>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8D0 RID: 190672 RVA: 0x00CFEF60 File Offset: 0x00CFD160
		private UniTask UpdateInstanceInfoItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceInfoItemAsync>d__63 <UpdateInstanceInfoItemAsync>d__;
			<UpdateInstanceInfoItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceInfoItemAsync>d__.<>4__this = this;
			<UpdateInstanceInfoItemAsync>d__.<>1__state = -1;
			<UpdateInstanceInfoItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceInfoItemAsync>d__63>(ref <UpdateInstanceInfoItemAsync>d__);
			return <UpdateInstanceInfoItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8D1 RID: 190673 RVA: 0x00CFEFA3 File Offset: 0x00CFD1A3
		private void UpdateTimeAndCountItem()
		{
			this.InstanceDungeonTimeAndCountItem.RefreshItem(this.InstanceId);
		}

		// Token: 0x0602E8D2 RID: 190674 RVA: 0x00CFEFB6 File Offset: 0x00CFD1B6
		private void UpdateUnlockStateItem()
		{
			this.InstanceDungeonInfoItem.UpdateInstanceDungeonLockItemAndCostItem();
		}

		// Token: 0x0602E8D3 RID: 190675 RVA: 0x00CFEFC4 File Offset: 0x00CFD1C4
		private void UpdatePowerItem()
		{
			bool flag = !(InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(this.InstanceId) > 0);
			if (flag)
			{
				this.PowerCurrencyItem.SetActive(false);
				this.OverPowerCurrencyItem.SetActive(false);
				return;
			}
			this.PowerCurrencyItem.SetActive(true);
			this.OverPowerCurrencyItem.SetActive(true);
		}

		// Token: 0x0602E8D4 RID: 190676 RVA: 0x00CFF02F File Offset: 0x00CFD22F
		private void SetMatchingItemActive(bool isShow)
		{
			InstanceDungeonInfoItem instanceDungeonInfoItem = this.InstanceDungeonInfoItem;
			if (instanceDungeonInfoItem == null)
			{
				return;
			}
			instanceDungeonInfoItem.SetMatchingItemActive(isShow);
		}

		// Token: 0x0602E8D5 RID: 190677 RVA: 0x00CFF042 File Offset: 0x00CFD242
		private void OnClickBtnClose()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PowerView))
			{
				UiManager.Instance.CloseView(EUiViewName.PowerView, null);
			}
			this.UiViewSequence.CloseSequenceName = "Close01";
			base.CloseMe(null);
		}

		// Token: 0x0602E8D6 RID: 190678 RVA: 0x00CFF07C File Offset: 0x00CFD27C
		private void PlayPopupLevelSequenceReverse()
		{
			this.UiViewSequence.StopSequenceByKey("Popup", false, false);
			this.UiViewSequence.PlaySequencePurely("Popup", false, true);
		}

		// Token: 0x0602E8D7 RID: 190679 RVA: 0x00CFF0A4 File Offset: 0x00CFD2A4
		private void OnViewClose(EUiViewName name, int viewId)
		{
			InstanceDungeonEntranceView.<>c__DisplayClass70_0 CS$<>8__locals1 = new InstanceDungeonEntranceView.<>c__DisplayClass70_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.name = name;
			UiAsyncTask task = new UiAsyncTask("InstanceDungeonEntranceView.RefreshInstance", delegate()
			{
				InstanceDungeonEntranceView.<>c__DisplayClass70_0.<<OnViewClose>b__0>d <<OnViewClose>b__0>d;
				<<OnViewClose>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnViewClose>b__0>d.<>4__this = CS$<>8__locals1;
				<<OnViewClose>b__0>d.<>1__state = -1;
				<<OnViewClose>b__0>d.<>t__builder.Start<InstanceDungeonEntranceView.<>c__DisplayClass70_0.<<OnViewClose>b__0>d>(ref <<OnViewClose>b__0>d);
				return <<OnViewClose>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task);
		}

		// Token: 0x0602E8D8 RID: 190680 RVA: 0x00CFF0E8 File Offset: 0x00CFD2E8
		private UniTask OnViewCloseAsync(EUiViewName name)
		{
			InstanceDungeonEntranceView.<OnViewCloseAsync>d__71 <OnViewCloseAsync>d__;
			<OnViewCloseAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnViewCloseAsync>d__.<>4__this = this;
			<OnViewCloseAsync>d__.name = name;
			<OnViewCloseAsync>d__.<>1__state = -1;
			<OnViewCloseAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<OnViewCloseAsync>d__71>(ref <OnViewCloseAsync>d__);
			return <OnViewCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E8D9 RID: 190681 RVA: 0x00CFF133 File Offset: 0x00CFD333
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x0602E8DA RID: 190682 RVA: 0x00CFF14C File Offset: 0x00CFD34C
		private void OnMatchingChange()
		{
			switch (InstanceDungeonEntranceModel.Instance.GetMatchingState())
			{
			case EInstanceMatchState.Default:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem == null)
				{
					return;
				}
				matchingCountDownItem.PlayAnimation("Close");
				return;
			}
			case EInstanceMatchState.Matching:
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingOtherCancel", Array.Empty<object>());
				InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
				if (matchingCountDownItem2 != null)
				{
					matchingCountDownItem2.PlayAnimation("Start");
				}
				this.SetMatchingItemActive(true);
				this.BeginMatching();
				return;
			}
			case EInstanceMatchState.MatchConfirm:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem3 = this.MatchingCountDownItem;
				if (matchingCountDownItem3 != null)
				{
					matchingCountDownItem3.PlayAnimation("Finish");
				}
				UiManager.Instance.OpenView(EUiViewName.OnlineInstanceMatchTips, null, null);
				return;
			}
			case EInstanceMatchState.Waiting:
				break;
			case EInstanceMatchState.ConfirmToReady:
				this.SetMatchingItemActive(false);
				BattleTeamModel.Instance.Context.SetMultiEntry(true);
				if (UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonMonsterPreView))
				{
					UiManager.Instance.CloseView(EUiViewName.InstanceDungeonMonsterPreView, null);
				}
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.GetMatchingId(), true, true, false, null);
				EventSystem.Instance.Emit(EEventName.OnEnterTeam);
				break;
			default:
				return;
			}
		}

		// Token: 0x0602E8DB RID: 190683 RVA: 0x00CFF260 File Offset: 0x00CFD460
		private void OnMatchingBegin()
		{
			this.SetMatchingItemActive(true);
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Start");
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 != null)
			{
				matchingCountDownItem2.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
			}
			this.BeginMatching();
			this.UpdateUnlockStateItem();
		}

		// Token: 0x0602E8DC RID: 190684 RVA: 0x00CFF2C8 File Offset: 0x00CFD4C8
		[NullableContext(1)]
		private InstanceDetectionDynamicData[] GetInstanceListBySelectSeriesId()
		{
			this.ScrollIndex = 0;
			List<InstanceDetectionDynamicData> list = new List<InstanceDetectionDynamicData>();
			int num = -1;
			this.RefreshInstanceIdByTitleMap();
			ValueTuple<InstanceDetectionDynamicData[], int> diyInstanceDetectionDynamicData = this.Vm.GetDiyInstanceDetectionDynamicData(this.SeriesId, this.InstanceId);
			InstanceDetectionDynamicData[] item = diyInstanceDetectionDynamicData.Item1;
			if (item.Length != 0)
			{
				this.ScrollIndex = diyInstanceDetectionDynamicData.Item2;
				return item;
			}
			bool flag = this.TitleInstanceGridNumberMap.Count == 1;
			bool flag2 = false;
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.Vm.InstanceByTitleMap)
			{
				int num2;
				List<int> list2;
				keyValuePair.Deconstruct(out num2, out list2);
				int num3 = num2;
				List<int> list3 = list2;
				bool flag3 = num3 == this.SeriesId;
				bool flag4 = this.TitleInstanceGridNumberMap.GetValueOrNull(num3).GetValueOrDefault() == 1;
				this.Vm.SortInstanceArray(list3);
				foreach (int num4 in list3)
				{
					if ((num != num3 && !flag) || (num != num3 && flag && flag4))
					{
						InstanceDetectionDynamicData instanceDetectionDynamicData = new InstanceDetectionDynamicData();
						instanceDetectionDynamicData.InstanceSeriesTitle = num3;
						instanceDetectionDynamicData.InstanceGirdId = num4;
						instanceDetectionDynamicData.IsSelect = flag3;
						instanceDetectionDynamicData.IsOnlyOneGrid = flag4;
						num = num3;
						list.Add(instanceDetectionDynamicData);
						if (this.SeriesId == this.InstanceId && this.InstanceId == num4)
						{
							flag2 = true;
						}
						if (!flag2)
						{
							this.ScrollIndex++;
						}
						if (flag && flag4)
						{
							break;
						}
					}
					if (flag3 && !flag4)
					{
						InstanceDetectionDynamicData instanceDetectionDynamicData2 = new InstanceDetectionDynamicData();
						instanceDetectionDynamicData2.InstanceGirdId = num4;
						instanceDetectionDynamicData2.IsSelect = (num4 == this.InstanceId);
						instanceDetectionDynamicData2.IsShow = flag3;
						list.Add(instanceDetectionDynamicData2);
						if (instanceDetectionDynamicData2.IsSelect)
						{
							flag2 = true;
						}
						if (!flag2)
						{
							this.ScrollIndex++;
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0602E8DD RID: 190685 RVA: 0x00CFF4FC File Offset: 0x00CFD6FC
		private void RefreshInstanceIdByTitleMap()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.TitleInstanceGridNumberMap.Clear();
			bool flag = this.InstanceId != 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.Vm.InstanceByTitleMap)
			{
				int num4;
				List<int> list;
				keyValuePair.Deconstruct(out num4, out list);
				int num5 = num4;
				List<int> list2 = list;
				if (num2 == 0)
				{
					num2 = num5;
				}
				this.TitleInstanceGridNumberMap[num5] = list2.Count;
				if (!flag)
				{
					foreach (int num6 in list2)
					{
						if (this.SeriesId == 0 || num5 == this.SeriesId)
						{
							if (num == 0)
							{
								num = num6;
							}
							bool flag2 = InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(num6);
							if (flag2 && num6 > this.InstanceId)
							{
								bool flag3 = ExchangeRewardModel.Instance.IsFinishInstance(num6);
								int recommendLevel = InstanceDungeonConfig.Instance.GetRecommendLevel(num6, WorldLevelModel.Instance.CurWorldLevel);
								if (flag2 && !flag3 && recommendLevel > num3)
								{
									this.InstanceId = num6;
									this.SeriesId = num5;
									num3 = recommendLevel;
								}
							}
						}
					}
				}
			}
			if (this.InstanceId == 0)
			{
				this.InstanceId = num;
			}
			if (this.SeriesId == 0)
			{
				this.SeriesId = num2;
			}
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = this.InstanceId;
		}

		// Token: 0x0602E8DE RID: 190686 RVA: 0x00CFF68C File Offset: 0x00CFD88C
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int index = int.Parse(configParams[0]) - 1;
			InstanceDetectItem scrollItemFromIndex = this.InstanceLoopScroll.GetScrollItemFromIndex(index);
			if (scrollItemFromIndex == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TL;
				string message = "副本入口聚焦引导extraParam字段配置错误, 找不到对应的副本选项";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			UUIItem uuiitem = scrollItemFromIndex.GetExtendToggleForGuide().RootUIComp.Get();
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0602E8DF RID: 190687 RVA: 0x00CFF700 File Offset: 0x00CFD900
		private void OnClickedHelpButton()
		{
			int helpButtonId = InstanceDungeonEntranceConfig.Instance.GetConfig(this.Vm.EntranceId).Value.HelpButtonId;
			HelpController.Instance.OpenHelpById(helpButtonId);
		}

		// Token: 0x0602E8E0 RID: 190688 RVA: 0x00CFF740 File Offset: 0x00CFD940
		private void OnClickBtnSolo()
		{
			int instanceId = this.InstanceId;
			if (instanceId == 0)
			{
				Log.Instance.Error(ELogModule.InstanceDungeon, ELogAuthor.TL, "副本入口界面点击挑战错误，当前未选择副本", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(instanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonLackChallengeTimes", Array.Empty<object>());
				return;
			}
			if (RoleController.Instance.IsInRoleTrial() && !InstanceDungeonController.Instance.CanTrialRoleEnterDungeon(this.Vm.EntranceId, instanceId))
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			if (InstanceDungeonController.Instance.IsForbidDungeon(instanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
			}
			InstanceDungeonModel.Instance.InstanceContinue = false;
			if (InstanceDungeonEntranceModel.Instance.IsDungeonArchiveActivate(instanceId) && InstanceDungeonEntranceModel.Instance.HasDungeonArchive(instanceId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DungeonContinuePlayConfirm);
				Action value = delegate()
				{
					InstanceDungeonModel.Instance.InstanceContinue = true;
					this.HandleSoloEnterDungeon();
				};
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = value;
				confirmBoxDataNew.FunctionMap[1] = new Action(this.<OnClickBtnSolo>g__ContinueCallback|79_1);
				confirmBoxDataNew.FunctionMap[-1] = new Action(InstanceDungeonEntranceView.<OnClickBtnSolo>g__CloseCallBack|79_2);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.HandleSoloEnterDungeon();
		}

		// Token: 0x0602E8E1 RID: 190689 RVA: 0x00CFF884 File Offset: 0x00CFDA84
		private void HandleSoloEnterDungeon()
		{
			InstanceDungeonEntranceView.<>c__DisplayClass80_0 CS$<>8__locals1 = new InstanceDungeonEntranceView.<>c__DisplayClass80_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.instanceId = this.InstanceId;
			BattleTeamModel.Instance.Context.SetMultiEntry(false);
			CS$<>8__locals1.powerEnough = PowerModel.Instance.IsPowerWithConvertedEnough(InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(this.InstanceId));
			if (InstanceDungeonEntranceModel.Instance.CheckInstanceLevelTooLow(this.InstanceId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceLevelTooLowToGetPhantom);
				confirmBoxDataNew.FunctionMap[2] = new Action(CS$<>8__locals1.<HandleSoloEnterDungeon>g__ConfirmCallback|0);
				confirmBoxDataNew.FunctionMap[1] = new Action(CS$<>8__locals1.<HandleSoloEnterDungeon>g__CancelCallback|1);
				int[] unlockCondition = InstanceDungeonConfig.Instance.GetUnlockCondition(CS$<>8__locals1.instanceId);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					unlockCondition[1].ToString()
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (!CS$<>8__locals1.powerEnough)
			{
				InstanceDungeonModel instance = InstanceDungeonModel.Instance;
				if (instance == null || !instance.HidePowerLackConfirmBox)
				{
					this.OpenPowerConfirm();
					return;
				}
			}
			InstanceDungeonEntranceModel.Instance.InstanceId = CS$<>8__locals1.instanceId;
			InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
		}

		// Token: 0x0602E8E2 RID: 190690 RVA: 0x00CFF9A0 File Offset: 0x00CFDBA0
		private void OpenPowerConfirm()
		{
			int instanceId = this.InstanceId;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PowerNotEnoughForDungeon);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.PlayPopupLevelSequenceReverse();
				InstanceDungeonEntranceModel.Instance.InstanceId = instanceId;
				InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
			};
			confirmBoxDataNew.FunctionMap[1] = new Action(this.PlayPopupLevelSequenceReverse);
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = TextConfig.Instance.GetTextById("PlotSkipConfirmToggle");
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.OnClickedNotShowConfirm));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E8E3 RID: 190691 RVA: 0x00CFFA38 File Offset: 0x00CFDC38
		private void OnClickBtnTeam()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				Log.Instance.Error(ELogModule.InstanceDungeon, ELogAuthor.LJQ, "非联机下无法进行组队挑战，请联系程序查BUG", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			InstanceDungeonModel.Instance.InstanceContinue = false;
			InstanceDungeonEntranceModel.Instance.SetMatchingId(this.InstanceId);
			if (OnlineModel.Instance.GetCurrentTeamSize() <= 1)
			{
				InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.InstanceId, false);
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMultiStart);
			Action value = delegate()
			{
				InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.InstanceId, true);
			};
			Action value2 = delegate()
			{
				InstanceDungeonEntranceController.Instance.TeamChallengeRequest(this.InstanceId, false);
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap[2] = value;
			confirmBoxDataNew.FunctionMap[1] = value2;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E8E4 RID: 190692 RVA: 0x00CFFB0C File Offset: 0x00CFDD0C
		private void OnClickBtnMultiple()
		{
			if (!OnlineController.Instance.ShowTipsWhenOnlineDisabled(null))
			{
				return;
			}
			if (!InstanceDungeonEntranceModel.Instance.CheckInstanceCanChallenge(this.InstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("InstanceDungeonLackChallengeTimes", Array.Empty<object>());
				return;
			}
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			if (!FunctionModel.Instance.IsOpen(EFunctionType.Online))
			{
				ScrollingTipsController.Instance.ShowTipsById("IsNotOpenOnline", Array.Empty<object>());
				return;
			}
			if (InstanceDungeonController.Instance.IsForbidDungeon(this.InstanceId))
			{
				ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			InstanceDungeonModel.Instance.InstanceContinue = false;
			this.MatchingCountDownItem.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
			if (!GameModeModel.Instance.IsMulti)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(this.InstanceId, false, true);
				return;
			}
			int currentTeamSize = OnlineModel.Instance.GetCurrentTeamSize();
			if (currentTeamSize <= 1)
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(this.InstanceId, false, true);
				return;
			}
			if (currentTeamSize < OnlineModel.Instance.TeamMaxSize)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMatchStart);
				Action value = delegate()
				{
					InstanceDungeonEntranceController.Instance.StartMatchRequest(this.InstanceId, true, true);
				};
				Action value2 = delegate()
				{
					InstanceDungeonEntranceController.Instance.StartMatchRequest(this.InstanceId, false, true);
				};
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				confirmBoxDataNew.FunctionMap[2] = value;
				confirmBoxDataNew.FunctionMap[1] = value2;
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsById("CanNotMatching", Array.Empty<object>());
		}

		// Token: 0x0602E8E5 RID: 190693 RVA: 0x00CFFCB9 File Offset: 0x00CFDEB9
		private void OnClickedNotShowConfirm(bool isSelectedOn)
		{
			InstanceDungeonModel.Instance.HidePowerLackConfirmBox = isSelectedOn;
		}

		// Token: 0x0602E8E6 RID: 190694 RVA: 0x00CFFCC6 File Offset: 0x00CFDEC6
		public UUIItem GetRewardPanelItem()
		{
			return base.GetItem(8);
		}

		// Token: 0x0602E8ED RID: 190701 RVA: 0x00CFFE44 File Offset: 0x00CFE044
		[CompilerGenerated]
		private void <OnClickBtnSolo>g__ContinueCallback|79_1()
		{
			this.HandleSoloEnterDungeon();
		}

		// Token: 0x0602E8EE RID: 190702 RVA: 0x00CFFE4C File Offset: 0x00CFE04C
		[CompilerGenerated]
		internal static void <OnClickBtnSolo>g__CloseCallBack|79_2()
		{
			ConfirmBoxController.Instance.CloseConfirmBoxView();
		}

		// Token: 0x04018C64 RID: 101476
		private int InstanceId;

		// Token: 0x04018C65 RID: 101477
		private int SeriesId;

		// Token: 0x04018C66 RID: 101478
		private Dictionary<int, int> TitleInstanceGridNumberMap;

		// Token: 0x04018C67 RID: 101479
		private UUIExtendToggle CurrentSeriesToggle;

		// Token: 0x04018C68 RID: 101480
		private UUIExtendToggle CurrentInstanceToggle;

		// Token: 0x04018C69 RID: 101481
		private InstanceDetectionDynamicData CurrentInstanceDynaimcData;

		// Token: 0x04018C6A RID: 101482
		private UUIDynScrollViewComponent DynamicScrollViewComponent;

		// Token: 0x04018C6B RID: 101483
		private InstanceDetectDynamicItem InstanceDetectDynamicItem;

		// Token: 0x04018C6C RID: 101484
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> InstanceLoopScroll;

		// Token: 0x04018C6D RID: 101485
		private int ScrollIndex;

		// Token: 0x04018C6E RID: 101486
		private bool NeedOnTimer;

		// Token: 0x04018C6F RID: 101487
		private float CountDownMs = 1000f;

		// Token: 0x04018C70 RID: 101488
		private InstanceDungeonInfoItem InstanceDungeonInfoItem;

		// Token: 0x04018C71 RID: 101489
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x04018C72 RID: 101490
		private PowerCurrencyItem PowerCurrencyItem;

		// Token: 0x04018C73 RID: 101491
		private PowerCurrencyItem OverPowerCurrencyItem;

		// Token: 0x04018C74 RID: 101492
		private PopupCaptionItem InstanceDungeonCaptionItem;

		// Token: 0x04018C75 RID: 101493
		private InstanceDungeonTimeAndCountItem InstanceDungeonTimeAndCountItem;

		// Token: 0x04018C76 RID: 101494
		private InstanceDungeonTowerDefensePanelItem InstanceDungeonTowerDefenseItem;

		// Token: 0x04018C77 RID: 101495
		private InstanceDungeonMowingPanelItem InstanceDungeonMowingPanelItem;

		// Token: 0x04018C78 RID: 101496
		private InstanceDungeonSolarSpeedPanelItem InstanceDungeonSolarSpeedItem;

		// Token: 0x04018C79 RID: 101497
		[Nullable(1)]
		private InstanceDungeonViewModelBase Vm;

		// Token: 0x04018C7A RID: 101498
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x0200A4D1 RID: 42193
		[NullableContext(0)]
		private enum EChildCom
		{
			// Token: 0x040330D3 RID: 209107
			ScrollInstanceSeries,
			// Token: 0x040330D4 RID: 209108
			IntanceDetectItem,
			// Token: 0x040330D5 RID: 209109
			UiItemEntrance,
			// Token: 0x040330D6 RID: 209110
			TextureInstanceBG,
			// Token: 0x040330D7 RID: 209111
			TopItem,
			// Token: 0x040330D8 RID: 209112
			ContentItem,
			// Token: 0x040330D9 RID: 209113
			CaptionItem,
			// Token: 0x040330DA RID: 209114
			TimeAndCountItem,
			// Token: 0x040330DB RID: 209115
			LeftRewardItem,
			// Token: 0x040330DC RID: 209116
			GrayMask
		}
	}
}
