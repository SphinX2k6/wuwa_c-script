using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.InstanceDungeon.Define;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004848 RID: 18504
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceRootView : UiTickViewBase
	{
		// Token: 0x0602E879 RID: 190585 RVA: 0x00CFD0F7 File Offset: 0x00CFB2F7
		public InstanceDungeonEntranceRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17005E2E RID: 24110
		// (get) Token: 0x0602E87A RID: 190586 RVA: 0x00CFD12C File Offset: 0x00CFB32C
		// (set) Token: 0x0602E87B RID: 190587 RVA: 0x00CFD134 File Offset: 0x00CFB334
		private int InstanceId
		{
			get
			{
				return this.InstanceIdInternal;
			}
			set
			{
				if (this.InstanceIdInternal == 0)
				{
					this.InstanceBgDirtyInternal = true;
				}
				else
				{
					InstanceDungeonConfig instance = InstanceDungeonConfig.Instance;
					InstanceDungeon? config = instance.GetConfig(this.InstanceIdInternal);
					InstanceDungeon? config2 = instance.GetConfig(value);
					if (config != null && config2 != null)
					{
						this.InstanceBgDirtyInternal = (config.Value.BannerPath != config2.Value.BannerPath);
					}
				}
				this.InstanceIdInternal = value;
			}
		}

		// Token: 0x17005E2F RID: 24111
		// (get) Token: 0x0602E87C RID: 190588 RVA: 0x00CFD1AD File Offset: 0x00CFB3AD
		private bool InstanceBgDirty
		{
			get
			{
				return this.InstanceBgDirtyInternal;
			}
		}

		// Token: 0x0602E87D RID: 190589 RVA: 0x00CFD1B8 File Offset: 0x00CFB3B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E87E RID: 190590 RVA: 0x00CFD2C8 File Offset: 0x00CFB4C8
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonEntranceRootView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E87F RID: 190591 RVA: 0x00CFD30B File Offset: 0x00CFB50B
		protected override void OnStart()
		{
			this.UpdateInstancesView();
			this.UpdateInstanceSubView();
		}

		// Token: 0x0602E880 RID: 190592 RVA: 0x00CFD319 File Offset: 0x00CFB519
		protected override void OnBeforeShow()
		{
			this.UpdateEntranceDetail();
		}

		// Token: 0x0602E881 RID: 190593 RVA: 0x00CFD321 File Offset: 0x00CFB521
		protected override void OnAfterShow()
		{
			if (this.InstanceIdList.Count <= 0)
			{
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x0602E882 RID: 190594 RVA: 0x00CFD33E File Offset: 0x00CFB53E
		protected override void OnBeforeDestroy()
		{
			this.DisposeView();
			this.DisposeData();
		}

		// Token: 0x0602E883 RID: 190595 RVA: 0x00CFD34C File Offset: 0x00CFB54C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnClickEnterInstanceSingle, new Action(this.HandleOnClickEnterInstanceSingle));
			EventSystem.Instance.Add(EEventName.OnNeedRefreshByProtocol, new Action(this.HandleOnNeedRefreshByProtocol));
		}

		// Token: 0x0602E884 RID: 190596 RVA: 0x00CFD386 File Offset: 0x00CFB586
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnClickEnterInstanceSingle, new Action(this.HandleOnClickEnterInstanceSingle));
			EventSystem.Instance.Remove(EEventName.OnNeedRefreshByProtocol, new Action(this.HandleOnNeedRefreshByProtocol));
		}

		// Token: 0x0602E885 RID: 190597 RVA: 0x00CFD3C0 File Offset: 0x00CFB5C0
		protected override void OnTick(float delta)
		{
			this.CountDownMs -= (int)delta;
			if (this.CountDownMs > 0)
			{
				return;
			}
			this.HandleOnUpdateInstancesView();
			this.CountDownMs = 2000;
		}

		// Token: 0x0602E886 RID: 190598 RVA: 0x00CFD3EC File Offset: 0x00CFB5EC
		private void InitData()
		{
			this.EntranceId = InstanceDungeonEntranceModel.Instance.EntranceId;
			foreach (KeyValuePair<int, int> keyValuePair in InstanceDungeonEntranceModel.Instance.GetSortedByTitleEntranceInstanceIdList(this.EntranceId))
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int item = num;
				int key = num2;
				List<int> list;
				if (!this.InstanceByTitleMap.TryGetValue(key, out list))
				{
					list = new List<int>();
					this.InstanceByTitleMap[key] = list;
				}
				list.Add(item);
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair2 in this.InstanceByTitleMap)
			{
				foreach (int item2 in keyValuePair2.Value)
				{
					this.InstanceIdList.Add(item2);
				}
			}
		}

		// Token: 0x0602E887 RID: 190599 RVA: 0x00CFD518 File Offset: 0x00CFB718
		private void DisposeData()
		{
			this.InstanceIdList.Clear();
			this.InstanceByTitleMap.Clear();
			this.TitleInstanceGridNumberMap.Clear();
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
		}

		// Token: 0x0602E888 RID: 190600 RVA: 0x00CFD546 File Offset: 0x00CFB746
		private void DisposeView()
		{
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll != null)
			{
				instanceLoopScroll.ClearChildren();
			}
			this.InstanceLoopScroll = null;
		}

		// Token: 0x0602E889 RID: 190601 RVA: 0x00CFD560 File Offset: 0x00CFB760
		private void CreateCaption()
		{
			CommonTabComponentData<CommonTabItem> data = new CommonTabComponentData<CommonTabItem>(new Func<UUIItem, int?, CommonTabItem>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), new Func<int, CommonTabData>(this.GetCommonData));
			UUIItem item = base.GetItem(6);
			this.CaptionItem = new TabComponentWithCaptionItem<CommonTabItem>(item, data, new Action(this.OnClickBackBtn), false);
			this.CaptionItem.SetTabRootActive(false);
			InstanceDungeonEntrance? config = InstanceDungeonEntranceConfig.Instance.GetConfig(this.EntranceId);
			this.CaptionItem.SetTitleByTextIdAndArgNew(config.Value.Name, Array.Empty<string>());
			this.CaptionItem.SetTitleIcon(config.Value.TitleSprite);
			this.CaptionItem.SetHelpButtonCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(config.Value.HelpButtonId);
			});
		}

		// Token: 0x0602E88A RID: 190602 RVA: 0x00CFD63C File Offset: 0x00CFB83C
		private UniTask CreateInstanceLoopScrollAsync()
		{
			InstanceDungeonEntranceRootView.<CreateInstanceLoopScrollAsync>d__37 <CreateInstanceLoopScrollAsync>d__;
			<CreateInstanceLoopScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInstanceLoopScrollAsync>d__.<>4__this = this;
			<CreateInstanceLoopScrollAsync>d__.<>1__state = -1;
			<CreateInstanceLoopScrollAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<CreateInstanceLoopScrollAsync>d__37>(ref <CreateInstanceLoopScrollAsync>d__);
			return <CreateInstanceLoopScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E88B RID: 190603 RVA: 0x00CFD680 File Offset: 0x00CFB880
		private UniTask CreateInstanceSubViewAsync()
		{
			InstanceDungeonEntranceRootView.<CreateInstanceSubViewAsync>d__38 <CreateInstanceSubViewAsync>d__;
			<CreateInstanceSubViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInstanceSubViewAsync>d__.<>4__this = this;
			<CreateInstanceSubViewAsync>d__.<>1__state = -1;
			<CreateInstanceSubViewAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<CreateInstanceSubViewAsync>d__38>(ref <CreateInstanceSubViewAsync>d__);
			return <CreateInstanceSubViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E88C RID: 190604 RVA: 0x00CFD6C4 File Offset: 0x00CFB8C4
		private void UpdateEntranceDetail()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			if (config != null && this.InstanceBgDirty)
			{
				base.SetTextureByPath(config.Value.BannerPath, base.GetTexture(3), null, null);
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.StopSequenceByKey("Switch", false, false);
				}
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 == null)
				{
					return;
				}
				uiViewSequence2.PlaySequence("Switch", false, null);
			}
		}

		// Token: 0x0602E88D RID: 190605 RVA: 0x00CFD750 File Offset: 0x00CFB950
		private void UpdateInstancesView()
		{
			InstanceDetectionDynamicData[] instanceListBySelectSeriesId = this.GetInstanceListBySelectSeriesId();
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll != null)
			{
				instanceLoopScroll.RefreshByData(instanceListBySelectSeriesId, false, false);
			}
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll2 = this.InstanceLoopScroll;
			if (instanceLoopScroll2 == null)
			{
				return;
			}
			instanceLoopScroll2.BindLateUpdate(delegate(float _)
			{
				DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll3 = this.InstanceLoopScroll;
				int? num = (instanceLoopScroll3 != null) ? new int?(instanceLoopScroll3.GetScrollItemCount()) : null;
				if (num == null)
				{
					return;
				}
				int num2 = this.ScrollIndex + 1;
				int? num3 = num;
				if (num2 < num3.GetValueOrDefault() & num3 != null)
				{
					DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll4 = this.InstanceLoopScroll;
					if (instanceLoopScroll4 == null)
					{
						return;
					}
					instanceLoopScroll4.UnBindLateUpdate();
					return;
				}
				else
				{
					DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll5 = this.InstanceLoopScroll;
					if (instanceLoopScroll5 != null)
					{
						instanceLoopScroll5.ScrollToItemIndex(this.ScrollIndex, true, false);
					}
					DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll6 = this.InstanceLoopScroll;
					if (instanceLoopScroll6 == null)
					{
						return;
					}
					instanceLoopScroll6.UnBindLateUpdate();
					return;
				}
			});
		}

		// Token: 0x0602E88E RID: 190606 RVA: 0x00CFD794 File Offset: 0x00CFB994
		private void UpdateInstanceSubView()
		{
			IInstanceDungeonEntranceAbility subView = this.SubView;
			if (subView == null)
			{
				return;
			}
			subView.RefreshExternalAsync();
		}

		// Token: 0x0602E88F RID: 190607 RVA: 0x00CFD7A8 File Offset: 0x00CFB9A8
		private InstanceDetectionDynamicData[] GetInstanceListBySelectSeriesId()
		{
			this.ScrollIndex = 0;
			List<InstanceDetectionDynamicData> list = new List<InstanceDetectionDynamicData>();
			int num = -1;
			this.RefreshInstanceIdByTitleMap();
			bool flag = this.TitleInstanceGridNumberMap.Count == 1;
			bool flag2 = false;
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.InstanceByTitleMap)
			{
				int num2;
				List<int> list2;
				keyValuePair.Deconstruct(out num2, out list2);
				int num3 = num2;
				List<int> list3 = list2;
				bool flag3 = num3 == this.SeriesId;
				bool flag4 = this.TitleInstanceGridNumberMap.GetValueOrNull(num3).GetValueOrDefault() == 1;
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

		// Token: 0x0602E890 RID: 190608 RVA: 0x00CFD974 File Offset: 0x00CFBB74
		private void RefreshInstanceIdByTitleMap()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			this.TitleInstanceGridNumberMap.Clear();
			bool flag = this.InstanceId != 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.InstanceByTitleMap)
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

		// Token: 0x0602E891 RID: 190609 RVA: 0x00CFDB00 File Offset: 0x00CFBD00
		private bool GetIsAllowedClickBegin()
		{
			return this.NextCanClickButtonTime <= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x0602E892 RID: 190610 RVA: 0x00CFDB18 File Offset: 0x00CFBD18
		private InstanceDetectItem CreateInstanceGrid(InstanceDetectionDynamicData data, UUIItem uiItem, int index)
		{
			InstanceDetectItem instanceDetectItem = new InstanceDetectItem();
			instanceDetectItem.BindClickInstanceCallback(new Action<int, UUIExtendToggle, InstanceDetectionDynamicData>(this.RefreshInstanceById));
			instanceDetectItem.BindClickSeriesCallback(new Action<int, UUIExtendToggle, bool>(this.RefreshSeriesById));
			instanceDetectItem.BindCanExecuteChange(new Func<int, bool>(this.CanExecuteChange));
			instanceDetectItem.BindSubtitleTextIdGetter(new TInstanceSubtitleTextIdGetter(InstanceDungeonEntranceController.Instance.GetInstanceSubtitleTextIdByInstanceId));
			instanceDetectItem.BindSubtitleArgsGetter(new TInstanceSubtitleArgsGetter(InstanceDungeonEntranceController.Instance.GetInstanceSubtitleArgsByInstanceId));
			return instanceDetectItem;
		}

		// Token: 0x0602E893 RID: 190611 RVA: 0x00CFDB8C File Offset: 0x00CFBD8C
		private void RefreshInstanceById(int id, UUIExtendToggle toggle, [Nullable(2)] InstanceDetectionDynamicData data = null)
		{
			this.InstanceId = id;
			if (data != null)
			{
				if (this.CurrentInstanceDynamicData != null)
				{
					this.CurrentInstanceDynamicData.IsSelect = false;
				}
				this.CurrentInstanceDynamicData = data;
				this.CurrentInstanceDynamicData.IsSelect = true;
			}
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = this.InstanceId;
			if (this.CurrentInstanceToggle != null && this.CurrentInstanceToggle != toggle)
			{
				this.CurrentInstanceToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			this.CurrentInstanceToggle = toggle;
			this.UpdateEntranceDetail();
			this.UpdateInstanceSubView();
			this.UiViewSequence.PlaySequence("Xz", false, null);
		}

		// Token: 0x0602E894 RID: 190612 RVA: 0x00CFDC28 File Offset: 0x00CFBE28
		private void RefreshSeriesById(int id, UUIExtendToggle toggle, bool isShow)
		{
			if (this.CurrentSeriesToggle != null && this.CurrentSeriesToggle != toggle)
			{
				this.CurrentSeriesToggle.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			this.CurrentSeriesToggle = toggle;
			this.SeriesId = (isShow ? id : -1);
			this.InstanceId = (isShow ? this.InstanceByTitleMap[id][0] : this.InstanceId);
			InstanceDetectionDynamicData[] instanceListBySelectSeriesId = this.GetInstanceListBySelectSeriesId();
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll != null)
			{
				instanceLoopScroll.RefreshByData(instanceListBySelectSeriesId, false, false);
			}
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll2 = this.InstanceLoopScroll;
			if (instanceLoopScroll2 == null)
			{
				return;
			}
			instanceLoopScroll2.BindLateUpdate(new Action<float>(this.ScrollToItem));
		}

		// Token: 0x0602E895 RID: 190613 RVA: 0x00CFDCC4 File Offset: 0x00CFBEC4
		private bool CanExecuteChange(int id)
		{
			return this.InstanceId != id;
		}

		// Token: 0x0602E896 RID: 190614 RVA: 0x00CFDCD4 File Offset: 0x00CFBED4
		private void ScrollToItem(float delta)
		{
			int valueOrDefault = this.TitleInstanceGridNumberMap.GetValueOrDefault(this.SeriesId, 0);
			float scrollProgress = (float)(this.ScrollIndex - 1) / (float)(this.InstanceByTitleMap.Count + valueOrDefault);
			base.GetUIDynScrollViewComponent(0).SetScrollProgress(scrollProgress);
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll == null)
			{
				return;
			}
			instanceLoopScroll.UnBindLateUpdate();
		}

		// Token: 0x0602E897 RID: 190615 RVA: 0x00CFDD2A File Offset: 0x00CFBF2A
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x0602E898 RID: 190616 RVA: 0x00CFDD31 File Offset: 0x00CFBF31
		private void ToggleCallBack(int index)
		{
		}

		// Token: 0x0602E899 RID: 190617 RVA: 0x00CFDD33 File Offset: 0x00CFBF33
		[NullableContext(2)]
		private CommonTabData GetCommonData(int index)
		{
			return null;
		}

		// Token: 0x0602E89A RID: 190618 RVA: 0x00CFDD36 File Offset: 0x00CFBF36
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602E89B RID: 190619 RVA: 0x00CFDD40 File Offset: 0x00CFBF40
		private void HandleOnClickEnterInstanceSingle()
		{
			if (!this.GetIsAllowedClickBegin())
			{
				return;
			}
			this.NextCanClickButtonTime = TimeUtil.Instance.GetServerTimeStamp() + 500.0;
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
			if (RoleController.Instance.IsInRoleTrial())
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleDungeonsLimit", Array.Empty<object>());
				return;
			}
			BattleTeamModel.Instance.Context.SetMultiEntry(false);
			bool powerEnough = PowerModel.Instance.IsPowerEnough(InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(this.InstanceId));
			if (InstanceDungeonEntranceModel.Instance.CheckInstanceLevelTooLow(this.InstanceId))
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceLevelTooLowToGetPhantom);
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					if (!powerEnough)
					{
						this.OpenPowerConfirm();
						return;
					}
					InstanceDungeonEntranceModel.Instance.InstanceId = instanceId;
					InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
				};
				confirmBoxDataNew.FunctionMap[1] = new Action(this.PlayPopupLevelSequenceReverse);
				int[] unlockCondition = InstanceDungeonConfig.Instance.GetUnlockCondition(instanceId);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					unlockCondition[1].ToString()
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			if (!powerEnough)
			{
				this.OpenPowerConfirm();
				return;
			}
			InstanceDungeonEntranceModel.Instance.InstanceId = instanceId;
			InstanceDungeonEntranceController.Instance.ContinueEntranceFlow();
		}

		// Token: 0x0602E89C RID: 190620 RVA: 0x00CFDED5 File Offset: 0x00CFC0D5
		private void HandleOnNeedRefreshByProtocol()
		{
			this.UpdateInstancesView();
			this.UpdateInstanceSubView();
		}

		// Token: 0x0602E89D RID: 190621 RVA: 0x00CFDEE4 File Offset: 0x00CFC0E4
		private void HandleOnUpdateInstancesView()
		{
			if (this.InstanceLoopScroll != null)
			{
				for (int i = 0; i < this.InstanceLoopScroll.GetScrollItemCount(); i++)
				{
					DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
					InstanceDetectItem instanceDetectItem = (instanceLoopScroll != null) ? instanceLoopScroll.GetScrollItemFromIndex(i) : null;
					if (instanceDetectItem != null)
					{
						instanceDetectItem.UpdateSelf();
					}
				}
			}
			IInstanceDungeonEntranceAbility subView = this.SubView;
			if (subView == null)
			{
				return;
			}
			subView.RefreshOnTick();
		}

		// Token: 0x0602E89E RID: 190622 RVA: 0x00CFDF40 File Offset: 0x00CFC140
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
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602E89F RID: 190623 RVA: 0x00CFDFAA File Offset: 0x00CFC1AA
		private void PlayPopupLevelSequenceReverse()
		{
			this.UiViewSequence.StopSequenceByKey("Popup", false, false);
			this.UiViewSequence.PlaySequencePurely("Popup", false, true);
		}

		// Token: 0x04018C50 RID: 101456
		private int EntranceId;

		// Token: 0x04018C51 RID: 101457
		private int InstanceIdInternal;

		// Token: 0x04018C52 RID: 101458
		private bool InstanceBgDirtyInternal;

		// Token: 0x04018C53 RID: 101459
		private int SeriesId;

		// Token: 0x04018C54 RID: 101460
		private int ScrollIndex;

		// Token: 0x04018C55 RID: 101461
		private double NextCanClickButtonTime;

		// Token: 0x04018C56 RID: 101462
		private readonly List<int> InstanceIdList = new List<int>();

		// Token: 0x04018C57 RID: 101463
		private readonly Dictionary<int, List<int>> InstanceByTitleMap = new Dictionary<int, List<int>>();

		// Token: 0x04018C58 RID: 101464
		private readonly Dictionary<int, int> TitleInstanceGridNumberMap = new Dictionary<int, int>();

		// Token: 0x04018C59 RID: 101465
		[Nullable(2)]
		private UUIExtendToggle CurrentSeriesToggle;

		// Token: 0x04018C5A RID: 101466
		[Nullable(2)]
		private UUIExtendToggle CurrentInstanceToggle;

		// Token: 0x04018C5B RID: 101467
		[Nullable(2)]
		private InstanceDetectionDynamicData CurrentInstanceDynamicData;

		// Token: 0x04018C5C RID: 101468
		private int CountDownMs = 2000;

		// Token: 0x04018C5D RID: 101469
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> InstanceLoopScroll;

		// Token: 0x04018C5E RID: 101470
		[Nullable(2)]
		private IInstanceDungeonEntranceAbility SubView;

		// Token: 0x04018C5F RID: 101471
		private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

		// Token: 0x04018C60 RID: 101472
		private const int CLICK_INSTANCE_BEGIN_BUTTON_CD = 500;

		// Token: 0x0200A4C9 RID: 42185
		[NullableContext(0)]
		private enum EChildCom
		{
			// Token: 0x040330B0 RID: 209072
			ScrollInstanceSeries,
			// Token: 0x040330B1 RID: 209073
			InstanceDetectItem,
			// Token: 0x040330B2 RID: 209074
			UiItemInstanceSeries,
			// Token: 0x040330B3 RID: 209075
			TextureInstanceBG,
			// Token: 0x040330B4 RID: 209076
			MatchParentItem,
			// Token: 0x040330B5 RID: 209077
			ContentParentItem,
			// Token: 0x040330B6 RID: 209078
			CaptionItem
		}
	}
}
