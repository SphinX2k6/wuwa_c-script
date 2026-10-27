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
	// Token: 0x02005870 RID: 22640
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceRootView : UiTickViewBase
	{
		// Token: 0x06039958 RID: 235864 RVA: 0x00DAE22B File Offset: 0x00DAC42B
		public InstanceDungeonEntranceRootView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x17008A62 RID: 35426
		// (get) Token: 0x06039959 RID: 235865 RVA: 0x00DAE260 File Offset: 0x00DAC460
		// (set) Token: 0x0603995A RID: 235866 RVA: 0x00DAE268 File Offset: 0x00DAC468
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

		// Token: 0x17008A63 RID: 35427
		// (get) Token: 0x0603995B RID: 235867 RVA: 0x00DAE2E1 File Offset: 0x00DAC4E1
		private bool InstanceBgDirty
		{
			get
			{
				return this.InstanceBgDirtyInternal;
			}
		}

		// Token: 0x0603995C RID: 235868 RVA: 0x00DAE2EC File Offset: 0x00DAC4EC
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

		// Token: 0x0603995D RID: 235869 RVA: 0x00DAE3FC File Offset: 0x00DAC5FC
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonEntranceRootView.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603995E RID: 235870 RVA: 0x00DAE43F File Offset: 0x00DAC63F
		protected override void OnStart()
		{
			this.UpdateInstancesView();
			this.UpdateInstanceSubView();
		}

		// Token: 0x0603995F RID: 235871 RVA: 0x00DAE44D File Offset: 0x00DAC64D
		protected override void OnBeforeShow()
		{
			this.UpdateEntranceDetail();
		}

		// Token: 0x06039960 RID: 235872 RVA: 0x00DAE455 File Offset: 0x00DAC655
		protected override void OnAfterShow()
		{
			if (this.InstanceIdList.Count <= 0)
			{
				base.GetItem(2).SetUIActive(false);
			}
		}

		// Token: 0x06039961 RID: 235873 RVA: 0x00DAE472 File Offset: 0x00DAC672
		protected override void OnBeforeDestroy()
		{
			this.DisposeView();
			this.DisposeData();
		}

		// Token: 0x06039962 RID: 235874 RVA: 0x00DAE480 File Offset: 0x00DAC680
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnClickEnterInstanceSingle, new Action(this.HandleOnClickEnterInstanceSingle));
			EventSystem.Instance.Add(EEventName.OnNeedRefreshByProtocol, new Action(this.HandleOnNeedRefreshByProtocol));
		}

		// Token: 0x06039963 RID: 235875 RVA: 0x00DAE4BA File Offset: 0x00DAC6BA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnClickEnterInstanceSingle, new Action(this.HandleOnClickEnterInstanceSingle));
			EventSystem.Instance.Remove(EEventName.OnNeedRefreshByProtocol, new Action(this.HandleOnNeedRefreshByProtocol));
		}

		// Token: 0x06039964 RID: 235876 RVA: 0x00DAE4F4 File Offset: 0x00DAC6F4
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

		// Token: 0x06039965 RID: 235877 RVA: 0x00DAE520 File Offset: 0x00DAC720
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

		// Token: 0x06039966 RID: 235878 RVA: 0x00DAE64C File Offset: 0x00DAC84C
		private void DisposeData()
		{
			this.InstanceIdList.Clear();
			this.InstanceByTitleMap.Clear();
			this.TitleInstanceGridNumberMap.Clear();
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
		}

		// Token: 0x06039967 RID: 235879 RVA: 0x00DAE67A File Offset: 0x00DAC87A
		private void DisposeView()
		{
			DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> instanceLoopScroll = this.InstanceLoopScroll;
			if (instanceLoopScroll != null)
			{
				instanceLoopScroll.ClearChildren();
			}
			this.InstanceLoopScroll = null;
		}

		// Token: 0x06039968 RID: 235880 RVA: 0x00DAE694 File Offset: 0x00DAC894
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

		// Token: 0x06039969 RID: 235881 RVA: 0x00DAE770 File Offset: 0x00DAC970
		private UniTask CreateInstanceLoopScrollAsync()
		{
			InstanceDungeonEntranceRootView.<CreateInstanceLoopScrollAsync>d__37 <CreateInstanceLoopScrollAsync>d__;
			<CreateInstanceLoopScrollAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInstanceLoopScrollAsync>d__.<>4__this = this;
			<CreateInstanceLoopScrollAsync>d__.<>1__state = -1;
			<CreateInstanceLoopScrollAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<CreateInstanceLoopScrollAsync>d__37>(ref <CreateInstanceLoopScrollAsync>d__);
			return <CreateInstanceLoopScrollAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603996A RID: 235882 RVA: 0x00DAE7B4 File Offset: 0x00DAC9B4
		private UniTask CreateInstanceSubViewAsync()
		{
			InstanceDungeonEntranceRootView.<CreateInstanceSubViewAsync>d__38 <CreateInstanceSubViewAsync>d__;
			<CreateInstanceSubViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInstanceSubViewAsync>d__.<>4__this = this;
			<CreateInstanceSubViewAsync>d__.<>1__state = -1;
			<CreateInstanceSubViewAsync>d__.<>t__builder.Start<InstanceDungeonEntranceRootView.<CreateInstanceSubViewAsync>d__38>(ref <CreateInstanceSubViewAsync>d__);
			return <CreateInstanceSubViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603996B RID: 235883 RVA: 0x00DAE7F8 File Offset: 0x00DAC9F8
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

		// Token: 0x0603996C RID: 235884 RVA: 0x00DAE884 File Offset: 0x00DACA84
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

		// Token: 0x0603996D RID: 235885 RVA: 0x00DAE8C8 File Offset: 0x00DACAC8
		private void UpdateInstanceSubView()
		{
			IInstanceDungeonEntranceAbility subView = this.SubView;
			if (subView == null)
			{
				return;
			}
			subView.RefreshExternalAsync();
		}

		// Token: 0x0603996E RID: 235886 RVA: 0x00DAE8DC File Offset: 0x00DACADC
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

		// Token: 0x0603996F RID: 235887 RVA: 0x00DAEAA8 File Offset: 0x00DACCA8
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

		// Token: 0x06039970 RID: 235888 RVA: 0x00DAEC34 File Offset: 0x00DACE34
		private bool GetIsAllowedClickBegin()
		{
			return this.NextCanClickButtonTime <= TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x06039971 RID: 235889 RVA: 0x00DAEC4C File Offset: 0x00DACE4C
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

		// Token: 0x06039972 RID: 235890 RVA: 0x00DAECC0 File Offset: 0x00DACEC0
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

		// Token: 0x06039973 RID: 235891 RVA: 0x00DAED5C File Offset: 0x00DACF5C
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

		// Token: 0x06039974 RID: 235892 RVA: 0x00DAEDF8 File Offset: 0x00DACFF8
		private bool CanExecuteChange(int id)
		{
			return this.InstanceId != id;
		}

		// Token: 0x06039975 RID: 235893 RVA: 0x00DAEE08 File Offset: 0x00DAD008
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

		// Token: 0x06039976 RID: 235894 RVA: 0x00DAEE5E File Offset: 0x00DAD05E
		private CommonTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
		{
			return new CommonTabItem();
		}

		// Token: 0x06039977 RID: 235895 RVA: 0x00DAEE65 File Offset: 0x00DAD065
		private void ToggleCallBack(int index)
		{
		}

		// Token: 0x06039978 RID: 235896 RVA: 0x00DAEE67 File Offset: 0x00DAD067
		[NullableContext(2)]
		private CommonTabData GetCommonData(int index)
		{
			return null;
		}

		// Token: 0x06039979 RID: 235897 RVA: 0x00DAEE6A File Offset: 0x00DAD06A
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603997A RID: 235898 RVA: 0x00DAEE74 File Offset: 0x00DAD074
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

		// Token: 0x0603997B RID: 235899 RVA: 0x00DAF009 File Offset: 0x00DAD209
		private void HandleOnNeedRefreshByProtocol()
		{
			this.UpdateInstancesView();
			this.UpdateInstanceSubView();
		}

		// Token: 0x0603997C RID: 235900 RVA: 0x00DAF018 File Offset: 0x00DAD218
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

		// Token: 0x0603997D RID: 235901 RVA: 0x00DAF074 File Offset: 0x00DAD274
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

		// Token: 0x0603997E RID: 235902 RVA: 0x00DAF0DE File Offset: 0x00DAD2DE
		private void PlayPopupLevelSequenceReverse()
		{
			this.UiViewSequence.StopSequenceByKey("Popup", false, false);
			this.UiViewSequence.PlaySequencePurely("Popup", false, true);
		}

		// Token: 0x0401E1B3 RID: 123315
		private int EntranceId;

		// Token: 0x0401E1B4 RID: 123316
		private int InstanceIdInternal;

		// Token: 0x0401E1B5 RID: 123317
		private bool InstanceBgDirtyInternal;

		// Token: 0x0401E1B6 RID: 123318
		private int SeriesId;

		// Token: 0x0401E1B7 RID: 123319
		private int ScrollIndex;

		// Token: 0x0401E1B8 RID: 123320
		private double NextCanClickButtonTime;

		// Token: 0x0401E1B9 RID: 123321
		private readonly List<int> InstanceIdList = new List<int>();

		// Token: 0x0401E1BA RID: 123322
		private readonly Dictionary<int, List<int>> InstanceByTitleMap = new Dictionary<int, List<int>>();

		// Token: 0x0401E1BB RID: 123323
		private readonly Dictionary<int, int> TitleInstanceGridNumberMap = new Dictionary<int, int>();

		// Token: 0x0401E1BC RID: 123324
		[Nullable(2)]
		private UUIExtendToggle CurrentSeriesToggle;

		// Token: 0x0401E1BD RID: 123325
		[Nullable(2)]
		private UUIExtendToggle CurrentInstanceToggle;

		// Token: 0x0401E1BE RID: 123326
		[Nullable(2)]
		private InstanceDetectionDynamicData CurrentInstanceDynamicData;

		// Token: 0x0401E1BF RID: 123327
		private int CountDownMs = 2000;

		// Token: 0x0401E1C0 RID: 123328
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<InstanceDetectItem, InstanceDetectDynamicItem, InstanceDetectionDynamicData> InstanceLoopScroll;

		// Token: 0x0401E1C1 RID: 123329
		[Nullable(2)]
		private IInstanceDungeonEntranceAbility SubView;

		// Token: 0x0401E1C2 RID: 123330
		private TabComponentWithCaptionItem<CommonTabItem> CaptionItem;

		// Token: 0x0401E1C3 RID: 123331
		private const int CLICK_INSTANCE_BEGIN_BUTTON_CD = 500;

		// Token: 0x0200BAB0 RID: 47792
		[NullableContext(0)]
		private enum EChildCom
		{
			// Token: 0x040386AF RID: 231087
			ScrollInstanceSeries,
			// Token: 0x040386B0 RID: 231088
			InstanceDetectItem,
			// Token: 0x040386B1 RID: 231089
			UiItemInstanceSeries,
			// Token: 0x040386B2 RID: 231090
			TextureInstanceBG,
			// Token: 0x040386B3 RID: 231091
			MatchParentItem,
			// Token: 0x040386B4 RID: 231092
			ContentParentItem,
			// Token: 0x040386B5 RID: 231093
			CaptionItem
		}
	}
}
