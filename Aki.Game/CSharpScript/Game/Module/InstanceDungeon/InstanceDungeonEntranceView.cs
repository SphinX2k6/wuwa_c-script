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
	// Token: 0x02005873 RID: 22643
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonEntranceView : UiTickViewBase
	{
		// Token: 0x06039989 RID: 235913 RVA: 0x00DAF3D0 File Offset: 0x00DAD5D0
		[NullableContext(1)]
		public InstanceDungeonEntranceView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008A65 RID: 35429
		// (get) Token: 0x0603998A RID: 235914 RVA: 0x00DAF3E4 File Offset: 0x00DAD5E4
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

		// Token: 0x0603998B RID: 235915 RVA: 0x00DAF414 File Offset: 0x00DAD614
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

		// Token: 0x0603998C RID: 235916 RVA: 0x00DAF5B0 File Offset: 0x00DAD7B0
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonEntranceView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603998D RID: 235917 RVA: 0x00DAF5F3 File Offset: 0x00DAD7F3
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

		// Token: 0x0603998E RID: 235918 RVA: 0x00DAF619 File Offset: 0x00DAD819
		private void OpenPowerView(int index)
		{
			PowerController.Instance.OpenPowerView(EPowerMenuType.Supply, 0);
		}

		// Token: 0x0603998F RID: 235919 RVA: 0x00DAF627 File Offset: 0x00DAD827
		protected override void OnTick(float delta)
		{
			if (!this.NeedOnTimer)
			{
				return;
			}
			this.Vm.TimerRefreshFunction(delta);
		}

		// Token: 0x06039990 RID: 235920 RVA: 0x00DAF63E File Offset: 0x00DAD83E
		protected override void OnBeforeShow()
		{
			this.InitView();
		}

		// Token: 0x06039991 RID: 235921 RVA: 0x00DAF648 File Offset: 0x00DAD848
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

		// Token: 0x06039992 RID: 235922 RVA: 0x00DAF6E7 File Offset: 0x00DAD8E7
		protected override void OnBeforeHide()
		{
			this.Vm.OnBeforeHide();
		}

		// Token: 0x06039993 RID: 235923 RVA: 0x00DAF6F4 File Offset: 0x00DAD8F4
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

		// Token: 0x06039994 RID: 235924 RVA: 0x00DAF7BC File Offset: 0x00DAD9BC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06039995 RID: 235925 RVA: 0x00DAF81C File Offset: 0x00DADA1C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnViewClose));
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06039996 RID: 235926 RVA: 0x00DAF87C File Offset: 0x00DADA7C
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

		// Token: 0x06039997 RID: 235927 RVA: 0x00DAF930 File Offset: 0x00DADB30
		private void OnClickCaptionStateBtn()
		{
			HelpController.Instance.OpenHelpById(242);
		}

		// Token: 0x06039998 RID: 235928 RVA: 0x00DAF944 File Offset: 0x00DADB44
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

		// Token: 0x06039999 RID: 235929 RVA: 0x00DAF974 File Offset: 0x00DADB74
		private UniTask InitViewAsync()
		{
			InstanceDungeonEntranceView.<InitViewAsync>d__41 <InitViewAsync>d__;
			<InitViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitViewAsync>d__.<>4__this = this;
			<InitViewAsync>d__.<>1__state = -1;
			<InitViewAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<InitViewAsync>d__41>(ref <InitViewAsync>d__);
			return <InitViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603999A RID: 235930 RVA: 0x00DAF9B8 File Offset: 0x00DADBB8
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

		// Token: 0x0603999B RID: 235931 RVA: 0x00DAF9E8 File Offset: 0x00DADBE8
		private UniTask RefreshMowingInstanceAsync()
		{
			InstanceDungeonEntranceView.<RefreshMowingInstanceAsync>d__43 <RefreshMowingInstanceAsync>d__;
			<RefreshMowingInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshMowingInstanceAsync>d__.<>4__this = this;
			<RefreshMowingInstanceAsync>d__.<>1__state = -1;
			<RefreshMowingInstanceAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<RefreshMowingInstanceAsync>d__43>(ref <RefreshMowingInstanceAsync>d__);
			return <RefreshMowingInstanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603999C RID: 235932 RVA: 0x00DAFA2C File Offset: 0x00DADC2C
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

		// Token: 0x0603999D RID: 235933 RVA: 0x00DAFA5C File Offset: 0x00DADC5C
		private UniTask RefreshTowerDefenceInstanceAsync()
		{
			InstanceDungeonEntranceView.<RefreshTowerDefenceInstanceAsync>d__45 <RefreshTowerDefenceInstanceAsync>d__;
			<RefreshTowerDefenceInstanceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTowerDefenceInstanceAsync>d__.<>4__this = this;
			<RefreshTowerDefenceInstanceAsync>d__.<>1__state = -1;
			<RefreshTowerDefenceInstanceAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<RefreshTowerDefenceInstanceAsync>d__45>(ref <RefreshTowerDefenceInstanceAsync>d__);
			return <RefreshTowerDefenceInstanceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603999E RID: 235934 RVA: 0x00DAFAA0 File Offset: 0x00DADCA0
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

		// Token: 0x0603999F RID: 235935 RVA: 0x00DAFB14 File Offset: 0x00DADD14
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

		// Token: 0x060399A0 RID: 235936 RVA: 0x00DAFB90 File Offset: 0x00DADD90
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

		// Token: 0x060399A1 RID: 235937 RVA: 0x00DAFBD8 File Offset: 0x00DADDD8
		private UniTask UpdateScorePanelAsync()
		{
			InstanceDungeonEntranceView.<UpdateScorePanelAsync>d__49 <UpdateScorePanelAsync>d__;
			<UpdateScorePanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateScorePanelAsync>d__.<>4__this = this;
			<UpdateScorePanelAsync>d__.<>1__state = -1;
			<UpdateScorePanelAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateScorePanelAsync>d__49>(ref <UpdateScorePanelAsync>d__);
			return <UpdateScorePanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399A2 RID: 235938 RVA: 0x00DAFC1C File Offset: 0x00DADE1C
		private UniTask UpdateInstanceDungeonTowerDefenseItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceDungeonTowerDefenseItemAsync>d__50 <UpdateInstanceDungeonTowerDefenseItemAsync>d__;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>4__this = this;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>1__state = -1;
			<UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceDungeonTowerDefenseItemAsync>d__50>(ref <UpdateInstanceDungeonTowerDefenseItemAsync>d__);
			return <UpdateInstanceDungeonTowerDefenseItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399A3 RID: 235939 RVA: 0x00DAFC60 File Offset: 0x00DADE60
		private UniTask UpdateInstanceDungeonSolarSpeedItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceDungeonSolarSpeedItemAsync>d__51 <UpdateInstanceDungeonSolarSpeedItemAsync>d__;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>4__this = this;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>1__state = -1;
			<UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceDungeonSolarSpeedItemAsync>d__51>(ref <UpdateInstanceDungeonSolarSpeedItemAsync>d__);
			return <UpdateInstanceDungeonSolarSpeedItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399A4 RID: 235940 RVA: 0x00DAFCA4 File Offset: 0x00DADEA4
		private UniTask UpdateMowingScorePanelItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateMowingScorePanelItemAsync>d__52 <UpdateMowingScorePanelItemAsync>d__;
			<UpdateMowingScorePanelItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateMowingScorePanelItemAsync>d__.<>4__this = this;
			<UpdateMowingScorePanelItemAsync>d__.<>1__state = -1;
			<UpdateMowingScorePanelItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateMowingScorePanelItemAsync>d__52>(ref <UpdateMowingScorePanelItemAsync>d__);
			return <UpdateMowingScorePanelItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399A5 RID: 235941 RVA: 0x00DAFCE8 File Offset: 0x00DADEE8
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

		// Token: 0x060399A6 RID: 235942 RVA: 0x00DAFD64 File Offset: 0x00DADF64
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

		// Token: 0x060399A7 RID: 235943 RVA: 0x00DAFDFC File Offset: 0x00DADFFC
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

		// Token: 0x060399A8 RID: 235944 RVA: 0x00DAFE58 File Offset: 0x00DAE058
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

		// Token: 0x060399A9 RID: 235945 RVA: 0x00DAFEA8 File Offset: 0x00DAE0A8
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

		// Token: 0x060399AA RID: 235946 RVA: 0x00DAFF04 File Offset: 0x00DAE104
		private void CheckAndShowDungeonArchiveExpireTips()
		{
			int selectInstanceId = InstanceDungeonEntranceModel.Instance.SelectInstanceId;
			InstanceDungeonController.Instance.CheckAndShowDungeonArchiveExpireTips(selectInstanceId);
		}

		// Token: 0x060399AB RID: 235947 RVA: 0x00DAFF27 File Offset: 0x00DAE127
		private bool CanExecuteChange(int id)
		{
			return this.InstanceId != id;
		}

		// Token: 0x060399AC RID: 235948 RVA: 0x00DAFF38 File Offset: 0x00DAE138
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

		// Token: 0x060399AD RID: 235949 RVA: 0x00DB000C File Offset: 0x00DAE20C
		private UniTask UpdateInstanceAllItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceAllItemAsync>d__61 <UpdateInstanceAllItemAsync>d__;
			<UpdateInstanceAllItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceAllItemAsync>d__.<>4__this = this;
			<UpdateInstanceAllItemAsync>d__.<>1__state = -1;
			<UpdateInstanceAllItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceAllItemAsync>d__61>(ref <UpdateInstanceAllItemAsync>d__);
			return <UpdateInstanceAllItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399AE RID: 235950 RVA: 0x00DB0050 File Offset: 0x00DAE250
		private UniTask UpdateInstanceBg()
		{
			InstanceDungeonEntranceView.<UpdateInstanceBg>d__62 <UpdateInstanceBg>d__;
			<UpdateInstanceBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceBg>d__.<>4__this = this;
			<UpdateInstanceBg>d__.<>1__state = -1;
			<UpdateInstanceBg>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceBg>d__62>(ref <UpdateInstanceBg>d__);
			return <UpdateInstanceBg>d__.<>t__builder.Task;
		}

		// Token: 0x060399AF RID: 235951 RVA: 0x00DB0094 File Offset: 0x00DAE294
		private UniTask UpdateInstanceInfoItemAsync()
		{
			InstanceDungeonEntranceView.<UpdateInstanceInfoItemAsync>d__63 <UpdateInstanceInfoItemAsync>d__;
			<UpdateInstanceInfoItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateInstanceInfoItemAsync>d__.<>4__this = this;
			<UpdateInstanceInfoItemAsync>d__.<>1__state = -1;
			<UpdateInstanceInfoItemAsync>d__.<>t__builder.Start<InstanceDungeonEntranceView.<UpdateInstanceInfoItemAsync>d__63>(ref <UpdateInstanceInfoItemAsync>d__);
			return <UpdateInstanceInfoItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060399B0 RID: 235952 RVA: 0x00DB00D7 File Offset: 0x00DAE2D7
		private void UpdateTimeAndCountItem()
		{
			this.InstanceDungeonTimeAndCountItem.RefreshItem(this.InstanceId);
		}

		// Token: 0x060399B1 RID: 235953 RVA: 0x00DB00EA File Offset: 0x00DAE2EA
		private void UpdateUnlockStateItem()
		{
			this.InstanceDungeonInfoItem.UpdateInstanceDungeonLockItemAndCostItem();
		}

		// Token: 0x060399B2 RID: 235954 RVA: 0x00DB00F8 File Offset: 0x00DAE2F8
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

		// Token: 0x060399B3 RID: 235955 RVA: 0x00DB0163 File Offset: 0x00DAE363
		private void SetMatchingItemActive(bool isShow)
		{
			InstanceDungeonInfoItem instanceDungeonInfoItem = this.InstanceDungeonInfoItem;
			if (instanceDungeonInfoItem == null)
			{
				return;
			}
			instanceDungeonInfoItem.SetMatchingItemActive(isShow);
		}

		// Token: 0x060399B4 RID: 235956 RVA: 0x00DB0176 File Offset: 0x00DAE376
		private void OnClickBtnClose()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PowerView))
			{
				UiManager.Instance.CloseView(EUiViewName.PowerView, null);
			}
			this.UiViewSequence.CloseSequenceName = "Close01";
			base.CloseMe(null);
		}

		// Token: 0x060399B5 RID: 235957 RVA: 0x00DB01B0 File Offset: 0x00DAE3B0
		private void PlayPopupLevelSequenceReverse()
		{
			this.UiViewSequence.StopSequenceByKey("Popup", false, false);
			this.UiViewSequence.PlaySequencePurely("Popup", false, true);
		}

		// Token: 0x060399B6 RID: 235958 RVA: 0x00DB01D8 File Offset: 0x00DAE3D8
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

		// Token: 0x060399B7 RID: 235959 RVA: 0x00DB021C File Offset: 0x00DAE41C
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

		// Token: 0x060399B8 RID: 235960 RVA: 0x00DB0267 File Offset: 0x00DAE467
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x060399B9 RID: 235961 RVA: 0x00DB0280 File Offset: 0x00DAE480
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

		// Token: 0x060399BA RID: 235962 RVA: 0x00DB0394 File Offset: 0x00DAE594
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

		// Token: 0x060399BB RID: 235963 RVA: 0x00DB03FC File Offset: 0x00DAE5FC
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

		// Token: 0x060399BC RID: 235964 RVA: 0x00DB0630 File Offset: 0x00DAE830
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

		// Token: 0x060399BD RID: 235965 RVA: 0x00DB07C0 File Offset: 0x00DAE9C0
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

		// Token: 0x060399BE RID: 235966 RVA: 0x00DB0834 File Offset: 0x00DAEA34
		private void OnClickedHelpButton()
		{
			int helpButtonId = InstanceDungeonEntranceConfig.Instance.GetConfig(this.Vm.EntranceId).Value.HelpButtonId;
			HelpController.Instance.OpenHelpById(helpButtonId);
		}

		// Token: 0x060399BF RID: 235967 RVA: 0x00DB0874 File Offset: 0x00DAEA74
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

		// Token: 0x060399C0 RID: 235968 RVA: 0x00DB09B8 File Offset: 0x00DAEBB8
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

		// Token: 0x060399C1 RID: 235969 RVA: 0x00DB0AD4 File Offset: 0x00DAECD4
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

		// Token: 0x060399C2 RID: 235970 RVA: 0x00DB0B6C File Offset: 0x00DAED6C
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

		// Token: 0x060399C3 RID: 235971 RVA: 0x00DB0C40 File Offset: 0x00DAEE40
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

		// Token: 0x060399C4 RID: 235972 RVA: 0x00DB0DED File Offset: 0x00DAEFED
		private void OnClickedNotShowConfirm(bool isSelectedOn)
		{
			InstanceDungeonModel.Instance.HidePowerLackConfirmBox = isSelectedOn;
		}

		// Token: 0x060399C5 RID: 235973 RVA: 0x00DB0DFA File Offset: 0x00DAEFFA
		public UUIItem GetRewardPanelItem()
		{
			return base.GetItem(8);
		}

		// Token: 0x060399CC RID: 235980 RVA: 0x00DB0F78 File Offset: 0x00DAF178
		[CompilerGenerated]
		private void <OnClickBtnSolo>g__ContinueCallback|79_1()
		{
			this.HandleSoloEnterDungeon();
		}

		// Token: 0x060399CD RID: 235981 RVA: 0x00DB0F80 File Offset: 0x00DAF180
		[CompilerGenerated]
		internal static void <OnClickBtnSolo>g__CloseCallBack|79_2()
		{
			ConfirmBoxController.Instance.CloseConfirmBoxView();
		}

		// Token: 0x0401E1C7 RID: 123335
		private int InstanceId;

		// Token: 0x0401E1C8 RID: 123336
		private int SeriesId;

		// Token: 0x0401E1C9 RID: 123337
		private Dictionary<int, int> TitleInstanceGridNumberMap;

		// Token: 0x0401E1CA RID: 123338
		private UUIExtendToggle CurrentSeriesToggle;

		// Token: 0x0401E1CB RID: 123339
		private UUIExtendToggle CurrentInstanceToggle;

		// Token: 0x0401E1CC RID: 123340
		private InstanceDetectionDynamicData CurrentInstanceDynaimcData;

		// Token: 0x0401E1CD RID: 123341
		private UUIDynScrollViewComponent DynamicScrollViewComponent;

		// Token: 0x0401E1CE RID: 123342
		private InstanceDetectDynamicItem InstanceDetectDynamicItem;

		// Token: 0x0401E1CF RID: 123343
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> InstanceLoopScroll;

		// Token: 0x0401E1D0 RID: 123344
		private int ScrollIndex;

		// Token: 0x0401E1D1 RID: 123345
		private bool NeedOnTimer;

		// Token: 0x0401E1D2 RID: 123346
		private float CountDownMs = 1000f;

		// Token: 0x0401E1D3 RID: 123347
		private InstanceDungeonInfoItem InstanceDungeonInfoItem;

		// Token: 0x0401E1D4 RID: 123348
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x0401E1D5 RID: 123349
		private PowerCurrencyItem PowerCurrencyItem;

		// Token: 0x0401E1D6 RID: 123350
		private PowerCurrencyItem OverPowerCurrencyItem;

		// Token: 0x0401E1D7 RID: 123351
		private PopupCaptionItem InstanceDungeonCaptionItem;

		// Token: 0x0401E1D8 RID: 123352
		private InstanceDungeonTimeAndCountItem InstanceDungeonTimeAndCountItem;

		// Token: 0x0401E1D9 RID: 123353
		private InstanceDungeonTowerDefensePanelItem InstanceDungeonTowerDefenseItem;

		// Token: 0x0401E1DA RID: 123354
		private InstanceDungeonMowingPanelItem InstanceDungeonMowingPanelItem;

		// Token: 0x0401E1DB RID: 123355
		private InstanceDungeonSolarSpeedPanelItem InstanceDungeonSolarSpeedItem;

		// Token: 0x0401E1DC RID: 123356
		[Nullable(1)]
		private InstanceDungeonViewModelBase Vm;

		// Token: 0x0401E1DD RID: 123357
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x0200BAB8 RID: 47800
		[NullableContext(0)]
		private enum EChildCom
		{
			// Token: 0x040386D2 RID: 231122
			ScrollInstanceSeries,
			// Token: 0x040386D3 RID: 231123
			IntanceDetectItem,
			// Token: 0x040386D4 RID: 231124
			UiItemEntrance,
			// Token: 0x040386D5 RID: 231125
			TextureInstanceBG,
			// Token: 0x040386D6 RID: 231126
			TopItem,
			// Token: 0x040386D7 RID: 231127
			ContentItem,
			// Token: 0x040386D8 RID: 231128
			CaptionItem,
			// Token: 0x040386D9 RID: 231129
			TimeAndCountItem,
			// Token: 0x040386DA RID: 231130
			LeftRewardItem,
			// Token: 0x040386DB RID: 231131
			GrayMask
		}
	}
}
