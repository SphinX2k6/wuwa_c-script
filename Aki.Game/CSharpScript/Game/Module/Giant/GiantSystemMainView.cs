using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Giant.View;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant
{
	// Token: 0x02005973 RID: 22899
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantSystemMainView : UiViewBase
	{
		// Token: 0x0603A1BB RID: 238011 RVA: 0x00DCFD74 File Offset: 0x00DCDF74
		public GiantSystemMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603A1BC RID: 238012 RVA: 0x00DCFD90 File Offset: 0x00DCDF90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 33;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(28, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(29, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(30, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(31, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(32, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(20, new Action(this.OnClickBtnGotoInteract));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A1BD RID: 238013 RVA: 0x00DD0250 File Offset: 0x00DCE450
		protected override void OnBeforeCreate()
		{
			IGiantSystemMainOpenParam giantSystemMainOpenParam = this.OpenParam as IGiantSystemMainOpenParam;
			this.ActivityId = giantSystemMainOpenParam.ActivityId;
		}

		// Token: 0x0603A1BE RID: 238014 RVA: 0x00DD0278 File Offset: 0x00DCE478
		protected override UniTask OnBeforeStartAsync()
		{
			GiantSystemMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantSystemMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A1BF RID: 238015 RVA: 0x00DD02BC File Offset: 0x00DCE4BC
		protected override void OnStart()
		{
			this.Caption = new PopupCaptionItem(base.GetItem(0));
			this.Caption.SetCloseCallBack(delegate
			{
				base.CloseMe(null);
			});
			this.Caption.SetHelpBtnActive(true);
			this.Caption.SetHelpCallBack(delegate
			{
				HelpController.Instance.OpenHelpById(GiantConfig.GetHelpGroupId());
			});
			RedDotController.Instance.BindRedDot(ERedDotName.GiantInteract, base.GetItem(21), null, 0);
			this.Refresh();
		}

		// Token: 0x0603A1C0 RID: 238016 RVA: 0x00DD0348 File Offset: 0x00DCE548
		protected override void OnBeforeDestroy()
		{
			TimerHandle picSwitchTimer = this.PicSwitchTimer;
			if (picSwitchTimer != null)
			{
				picSwitchTimer.Remove();
			}
			this.PicSwitchTimer = null;
			this.RewardPopup = null;
			for (int i = 0; i < GiantSystemMainView.EntryEcoList.Length; i++)
			{
				GiantEcoNetType uId = GiantSystemMainView.EntryEcoList[i];
				GiantMindsetEntryItem giantMindsetEntryItem = (i < this.MindsetEntries.Count) ? this.MindsetEntries[i] : null;
				RedDotController.Instance.UnBindGivenUi(ERedDotName.GiantMindsetEntry, (giantMindsetEntryItem != null) ? giantMindsetEntryItem.GetRedDotItem() : null, (int)uId);
				RedDotController.Instance.UnBindGivenUi(ERedDotName.GiantAccessNew, (giantMindsetEntryItem != null) ? giantMindsetEntryItem.GetTagNewItem() : null, (int)uId);
			}
			RedDotController.Instance.UnBindGivenUi(ERedDotName.GiantInteract, base.GetItem(21), 0);
		}

		// Token: 0x0603A1C1 RID: 238017 RVA: 0x00DD0400 File Offset: 0x00DCE600
		protected override void OnAfterShow()
		{
			EventSystem.Instance.AddWithTarget<GiantEcoNetType?, double, double>(this, EEventName.OnGiantStableValueChange, delegate(GiantEcoNetType? _, double _, double _)
			{
				this.OnGiantDataChange();
			});
			EventSystem.Instance.AddWithTarget<GiantEcoNetType?, EGiantStage, EGiantStage>(this, EEventName.OnGiantStageCross, delegate(GiantEcoNetType? _, EGiantStage _, EGiantStage _)
			{
				this.OnGiantDataChange();
			});
			EventSystem.Instance.AddWithTarget<GiantEcoNetType, GiantEcoNetStatus, GiantEcoNetStatus>(this, EEventName.OnGiantEcoStatusChange, delegate(GiantEcoNetType _, GiantEcoNetStatus _, GiantEcoNetStatus _)
			{
				this.OnGiantDataChange();
			});
			EventSystem.Instance.AddWithTarget<int, int, int>(this, EEventName.OnGiantAccessProgressChange, delegate(int _, int _, int _)
			{
				this.OnGiantDataChange();
			});
			this.CurrentPicEco = (GiantModel.Instance.TakePendingPicEco() ?? this.PickWeightedPicEco());
			this.RefreshGiantPic();
			this.StartPicSwitchTimer();
			this.RefreshSelectedNode();
		}

		// Token: 0x0603A1C2 RID: 238018 RVA: 0x00DD04BC File Offset: 0x00DCE6BC
		protected override void OnAfterHide()
		{
			EventSystem.Instance.RemoveTargetEvents(this);
			TimerHandle picSwitchTimer = this.PicSwitchTimer;
			if (picSwitchTimer != null)
			{
				picSwitchTimer.Remove();
			}
			this.PicSwitchTimer = null;
			CommonRewardPopup rewardPopup = this.RewardPopup;
			if (rewardPopup == null)
			{
				return;
			}
			rewardPopup.SetActive(false);
		}

		// Token: 0x0603A1C3 RID: 238019 RVA: 0x00DD04F3 File Offset: 0x00DCE6F3
		private void OnGiantDataChange()
		{
			this.Refresh();
		}

		// Token: 0x0603A1C4 RID: 238020 RVA: 0x00DD04FB File Offset: 0x00DCE6FB
		private void Refresh()
		{
			this.RefreshMindsetEntries();
			this.RefreshTotalProgress();
			this.RefreshSelectedNode();
			this.RefreshGiantPic();
			this.RefreshRedDots();
			int activityId = this.ActivityId;
		}

		// Token: 0x0603A1C5 RID: 238021 RVA: 0x00DD0524 File Offset: 0x00DCE724
		private void RefreshMindsetEntries()
		{
			GiantModel instance = GiantModel.Instance;
			for (int i = 0; i < GiantSystemMainView.EntryEcoList.Length; i++)
			{
				GiantEcoNetType giantEcoNetType = GiantSystemMainView.EntryEcoList[i];
				GiantMindsetEntryItem giantMindsetEntryItem = (i < this.MindsetEntries.Count) ? this.MindsetEntries[i] : null;
				if (giantMindsetEntryItem != null)
				{
					int ecoLevelByValue = GiantConfig.GetEcoLevelByValue(giantEcoNetType, (int)instance.GetStableValue(giantEcoNetType));
					bool isGot = instance.GetEcoStatus(giantEcoNetType) == GiantEcoNetStatus.MaxStableValue;
					giantMindsetEntryItem.Refresh(ecoLevelByValue, isGot);
				}
			}
		}

		// Token: 0x0603A1C6 RID: 238022 RVA: 0x00DD0598 File Offset: 0x00DCE798
		private void RefreshTotalProgress()
		{
			GiantModel instance = GiantModel.Instance;
			double totalStableValue = instance.GetTotalStableValue();
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			int[] array;
			if (totalNodes.Length == 0)
			{
				array = GiantConfig.GetTotalNodeGoals();
			}
			else
			{
				array = (from node in totalNodes
				select node.Goal).ToArray<int>();
			}
			int[] array2 = array;
			UUISliderComponent slider = base.GetSlider(23);
			if (slider != null)
			{
				slider.SetValue((float)this.GetProgressFillByNode(totalStableValue, array2), true);
			}
			UUIText text = base.GetText(22);
			if (text != null)
			{
				text.SetText(totalStableValue.ToString(), true);
			}
			int reachedNodeIndex = this.GetReachedNodeIndex();
			int activatedNodeIndex = this.GetActivatedNodeIndex();
			List<IGiantNodeScaleData> list = new List<IGiantNodeScaleData>();
			for (int i = 0; i < array2.Length; i++)
			{
				int num = array2[i];
				EGiantNodeScaleState state = (i == reachedNodeIndex) ? EGiantNodeScaleState.Current : ((i < reachedNodeIndex) ? EGiantNodeScaleState.Expired : EGiantNodeScaleState.Lock);
				object obj = (i < totalNodes.Length) ? totalNodes[i].DropId : 0;
				int num2 = (i < totalNodes.Length) ? totalNodes[i].Id : 0;
				object obj2 = obj;
				bool flag = obj2 > 0 && instance.GetRewardGot(num2);
				bool canClaim = obj2 > 0 && !flag && totalStableValue >= (double)num && instance.IsNodeInteracted(num2);
				list.Add(new GiantNodeScaleData
				{
					NodeIndex = i,
					Value = num,
					State = state,
					IsGot = flag,
					CanClaim = canClaim,
					ShowCurrentMark = (i == activatedNodeIndex),
					OnClick = new Action<int, bool, UUIItem>(this.OnClickNode)
				});
			}
			GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> nodeScaleLayout = this.NodeScaleLayout;
			if (nodeScaleLayout == null)
			{
				return;
			}
			nodeScaleLayout.RefreshByData(list, delegate
			{
				GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> nodeScaleLayout2 = this.NodeScaleLayout;
				if (nodeScaleLayout2 == null)
				{
					return;
				}
				nodeScaleLayout2.SelectGridProxy(this.SelectedNodeIndex, false);
			}, false);
		}

		// Token: 0x0603A1C7 RID: 238023 RVA: 0x00DD073C File Offset: 0x00DCE93C
		private double GetProgressFillByNode(double total, int[] goals)
		{
			int num = goals.Length;
			if (num <= 0)
			{
				return 0.0;
			}
			double num2 = 1.0 / (double)num;
			for (int i = 0; i < num; i++)
			{
				int num3 = goals[i];
				if (total < (double)num3)
				{
					int num4 = (i > 0) ? goals[i - 1] : 0;
					int num5 = num3 - num4;
					double num6 = (num5 > 0) ? ((total - (double)num4) / (double)num5) : 0.0;
					return num2 * ((double)i + num6);
				}
			}
			return 1.0;
		}

		// Token: 0x0603A1C8 RID: 238024 RVA: 0x00DD07BD File Offset: 0x00DCE9BD
		private void OnClaimNodeReward()
		{
			GiantController.Instance.SendGiantStableValueActivityRequest(delegate(GiantStableValueActivityResponse _)
			{
				this.RefreshTotalProgress();
			});
		}

		// Token: 0x0603A1C9 RID: 238025 RVA: 0x00DD07D8 File Offset: 0x00DCE9D8
		private void OnClickNode(int nodeIndex, bool canClaim, UUIItem mountItem)
		{
			if (canClaim)
			{
				this.HasUserSelectedNode = true;
				this.SelectedNodeIndex = nodeIndex;
				GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> nodeScaleLayout = this.NodeScaleLayout;
				if (nodeScaleLayout != null)
				{
					nodeScaleLayout.SelectGridProxy(nodeIndex, false);
				}
				this.RefreshSelectedNode();
				this.OnClaimNodeReward();
				return;
			}
			if (this.HasUserSelectedNode)
			{
				GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> nodeScaleLayout2 = this.NodeScaleLayout;
				if (nodeScaleLayout2 != null && nodeScaleLayout2.GetSelectedGridIndex() == nodeIndex)
				{
					CommonRewardPopup rewardPopup = this.RewardPopup;
					if (rewardPopup == null || !rewardPopup.GetActive())
					{
						this.OnPreviewNodeReward(nodeIndex, mountItem);
						return;
					}
					CommonRewardPopup rewardPopup2 = this.RewardPopup;
					if (rewardPopup2 == null)
					{
						return;
					}
					rewardPopup2.SetActive(false);
					return;
				}
			}
			this.HasUserSelectedNode = true;
			this.SelectedNodeIndex = nodeIndex;
			GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> nodeScaleLayout3 = this.NodeScaleLayout;
			if (nodeScaleLayout3 != null)
			{
				nodeScaleLayout3.SelectGridProxy(nodeIndex, false);
			}
			this.RefreshSelectedNode();
			this.OnPreviewNodeReward(nodeIndex, mountItem);
		}

		// Token: 0x0603A1CA RID: 238026 RVA: 0x00DD0894 File Offset: 0x00DCEA94
		private void OnPreviewNodeReward(int nodeIndex, UUIItem mountItem)
		{
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			int num = (nodeIndex < totalNodes.Length) ? totalNodes[nodeIndex].DropId : 0;
			if (num <= 0)
			{
				return;
			}
			bool isGot = GiantModel.Instance.GetRewardGot((nodeIndex < totalNodes.Length) ? totalNodes[nodeIndex].Id : 0);
			List<DailyActivityDefine.RewardTuple> list = (from item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemListByIdList(new List<int>
			{
				num
			})
			select new DailyActivityDefine.RewardTuple
			{
				Id = item.ItemData.ItemId,
				Num = item.Count,
				Received = isGot
			}).ToList<DailyActivityDefine.RewardTuple>();
			if (list.Count == 0)
			{
				return;
			}
			RewardPopupData data = new RewardPopupData
			{
				RewardLists = list,
				MountItem = mountItem,
				PosBias = new FVector?(new FVector(0f, (float)GiantDefine.NodeRewardPopupOffsetY, 0f))
			};
			CommonRewardPopup rewardPopup = this.RewardPopup;
			if (rewardPopup == null)
			{
				return;
			}
			rewardPopup.Refresh(data);
		}

		// Token: 0x0603A1CB RID: 238027 RVA: 0x00DD096C File Offset: 0x00DCEB6C
		private void RefreshSelectedNode()
		{
			int num = (this.SelectedNodeIndex < 0) ? 0 : this.SelectedNodeIndex;
			int activatedNodeIndex = this.GetActivatedNodeIndex();
			if (this.HasUserSelectedNode && (this.IsNodeLocked(num) || this.IsNodePendingActivate(num)))
			{
				bool locked = this.IsNodeLocked(num);
				bool active = this.IsNodePendingActivate(num);
				GiantAttitudeRowItem attitudeRow = this.AttitudeRow;
				if (attitudeRow == null)
				{
					return;
				}
				attitudeRow.Refresh(new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeAttitudeText(num),
					IconPath = this.GetMindsetIconPath(num + 1)
				}, new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeAssistText(num)
				}, locked, active);
				return;
			}
			else if (activatedNodeIndex >= 0)
			{
				GiantAttitudeRowItem attitudeRow2 = this.AttitudeRow;
				if (attitudeRow2 == null)
				{
					return;
				}
				attitudeRow2.Refresh(new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeAttitudeText(activatedNodeIndex),
					IconPath = this.GetMindsetIconPath(activatedNodeIndex + 1)
				}, new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeAssistText(activatedNodeIndex)
				}, false, false);
				return;
			}
			else
			{
				GiantAttitudeRowItem attitudeRow3 = this.AttitudeRow;
				if (attitudeRow3 == null)
				{
					return;
				}
				attitudeRow3.Refresh(new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeInitAttitudeText(),
					IconPath = this.GetMindsetIconPath(0)
				}, new GiantAttitudeRowData
				{
					Text = GiantConfig.GetNodeInitAssistText()
				}, false, false);
				return;
			}
		}

		// Token: 0x0603A1CC RID: 238028 RVA: 0x00DD0A90 File Offset: 0x00DCEC90
		[NullableContext(2)]
		private string GetMindsetIconPath(int level)
		{
			string[] mindsetAttitudeIconsByLevel = GiantDefine.MindsetAttitudeIconsByLevel;
			int num = (level < 0) ? 0 : ((level >= mindsetAttitudeIconsByLevel.Length) ? (mindsetAttitudeIconsByLevel.Length - 1) : level);
			UiResourceConfig instance = UiResourceConfig.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.GetResourcePath(mindsetAttitudeIconsByLevel[num]);
		}

		// Token: 0x0603A1CD RID: 238029 RVA: 0x00DD0ACC File Offset: 0x00DCECCC
		private void RefreshSilhouetteNarrative()
		{
			int level = (int)(GiantModel.Instance.GetStage(this.CurrentPicEco) + 1);
			UUIText text = base.GetText(14);
			if (text == null)
			{
				return;
			}
			text.SetText(GiantConfig.GetSilhouetteNarrative(this.CurrentPicEco, level), true);
		}

		// Token: 0x0603A1CE RID: 238030 RVA: 0x00DD0B0C File Offset: 0x00DCED0C
		private void RefreshGiantPic()
		{
			List<int> list = new List<int>
			{
				26,
				27,
				28
			};
			for (int i = 0; i < list.Count; i++)
			{
				GiantEcoNetType giantEcoNetType = GiantSystemMainView.PicEcoList[i];
				UUIItem item = base.GetItem(list[i]);
				if (item != null)
				{
					item.SetUIActive(giantEcoNetType == this.CurrentPicEco);
				}
			}
			this.RefreshSilhouetteNarrative();
		}

		// Token: 0x0603A1CF RID: 238031 RVA: 0x00DD0B78 File Offset: 0x00DCED78
		private void RefreshRedDots()
		{
			bool flag = GiantConfig.HasReachedUninteractedNode();
			UUIText text = base.GetText(30);
			if (text == null)
			{
				return;
			}
			text.SetText(GiantConfig.ResolveLocalTextOrKey(flag ? GiantConfig.GetTextKeyGoBtnActive() : GiantConfig.GetTextKeyGoBtnNormal()), true);
		}

		// Token: 0x0603A1D0 RID: 238032 RVA: 0x00DD0BB2 File Offset: 0x00DCEDB2
		private void StartPicSwitchTimer()
		{
			TimerHandle picSwitchTimer = this.PicSwitchTimer;
			if (picSwitchTimer != null)
			{
				picSwitchTimer.Remove();
			}
			this.PicSwitchTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				this.SwitchGiantPicAsync().Forget();
			}, (float)GiantConfig.GetMainViewPicSwitchIntervalMs(), 1f, null, null, true);
		}

		// Token: 0x0603A1D1 RID: 238033 RVA: 0x00DD0BF0 File Offset: 0x00DCEDF0
		private UniTask SwitchGiantPicAsync()
		{
			GiantSystemMainView.<SwitchGiantPicAsync>d__34 <SwitchGiantPicAsync>d__;
			<SwitchGiantPicAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchGiantPicAsync>d__.<>4__this = this;
			<SwitchGiantPicAsync>d__.<>1__state = -1;
			<SwitchGiantPicAsync>d__.<>t__builder.Start<GiantSystemMainView.<SwitchGiantPicAsync>d__34>(ref <SwitchGiantPicAsync>d__);
			return <SwitchGiantPicAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A1D2 RID: 238034 RVA: 0x00DD0C34 File Offset: 0x00DCEE34
		private GiantEcoNetType PickWeightedPicEco()
		{
			GiantModel model = GiantModel.Instance;
			int[] array = (from eco in GiantSystemMainView.PicEcoList
			select GiantConfig.GetPicWeight(eco, (int)(model.GetStage(eco) + 1))).ToArray<int>();
			int num = array.Aggregate(0, (int sum, int w) => sum + w);
			if (num <= 0)
			{
				return GiantSystemMainView.PicEcoList[0];
			}
			double num2 = MathUtils.Instance.GetRandomRange(0.0, 1.0) * (double)num;
			for (int i = 0; i < GiantSystemMainView.PicEcoList.Length; i++)
			{
				num2 -= (double)array[i];
				if (num2 < 0.0)
				{
					return GiantSystemMainView.PicEcoList[i];
				}
			}
			return GiantSystemMainView.PicEcoList[GiantSystemMainView.PicEcoList.Length - 1];
		}

		// Token: 0x0603A1D3 RID: 238035 RVA: 0x00DD0D04 File Offset: 0x00DCEF04
		private bool IsNodePendingActivate(int nodeIndex)
		{
			GiantModel instance = GiantModel.Instance;
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			if (nodeIndex < 0 || nodeIndex >= totalNodes.Length)
			{
				return false;
			}
			GiantTotalProgress giantTotalProgress = totalNodes[nodeIndex];
			return instance.GetTotalStableValue() >= (double)giantTotalProgress.Goal && !instance.IsNodeInteracted(giantTotalProgress.Id);
		}

		// Token: 0x0603A1D4 RID: 238036 RVA: 0x00DD0D54 File Offset: 0x00DCEF54
		private int GetActivatedNodeIndex()
		{
			GiantModel instance = GiantModel.Instance;
			double totalStableValue = instance.GetTotalStableValue();
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			int result = -1;
			for (int i = 0; i < totalNodes.Length; i++)
			{
				if (totalStableValue >= (double)totalNodes[i].Goal && instance.IsNodeInteracted(totalNodes[i].Id))
				{
					result = i;
				}
			}
			return result;
		}

		// Token: 0x0603A1D5 RID: 238037 RVA: 0x00DD0DB4 File Offset: 0x00DCEFB4
		private int GetReachedNodeIndex()
		{
			double totalStableValue = GiantModel.Instance.GetTotalStableValue();
			int[] totalNodeGoals = GiantConfig.GetTotalNodeGoals();
			int result = -1;
			for (int i = 0; i < totalNodeGoals.Length; i++)
			{
				if (totalStableValue >= (double)totalNodeGoals[i])
				{
					result = i;
				}
			}
			return result;
		}

		// Token: 0x0603A1D6 RID: 238038 RVA: 0x00DD0DEC File Offset: 0x00DCEFEC
		private bool IsNodeLocked(int nodeIndex)
		{
			return nodeIndex > this.GetReachedNodeIndex();
		}

		// Token: 0x0603A1D7 RID: 238039 RVA: 0x00DD0DF8 File Offset: 0x00DCEFF8
		private void OnClickMindsetEntry(GiantEcoNetType eco)
		{
			GiantSystemQuestOpenParam param = new GiantSystemQuestOpenParam
			{
				EcoType = eco
			};
			UiManager.Instance.OpenView(EUiViewName.GiantSystemQuestView, param, null);
		}

		// Token: 0x0603A1D8 RID: 238040 RVA: 0x00DD0E24 File Offset: 0x00DCF024
		private void OnClickBtnGotoInteract()
		{
			GiantModel.Instance.MarkActivatedNodesInteractRead();
			int interactMarkId = GiantConfig.GetInteractMarkId();
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(interactMarkId),
				MarkType = GiantConfig.GetMarkTypeByMarkId(interactMarkId)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			base.CloseMe(null);
		}

		// Token: 0x0603A1D9 RID: 238041 RVA: 0x00DD0E78 File Offset: 0x00DCF078
		private void OnClickAttitudeRow()
		{
			int selectedNodeIndex = this.SelectedNodeIndex;
			if (this.HasUserSelectedNode && this.IsNodeLocked(selectedNodeIndex))
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyNodeLockedInteract()));
				return;
			}
			if (this.HasUserSelectedNode && this.IsNodePendingActivate(selectedNodeIndex))
			{
				ScrollingTipsController.Instance.ShowTipsByText(GiantConfig.ResolveLocalTextOrKey(GiantConfig.GetTipsKeyNodePendingActivate()));
				return;
			}
			int activatedNodeIndex = this.GetActivatedNodeIndex();
			string nodeAttitudeTipsTextByStage = GiantConfig.GetNodeAttitudeTipsTextByStage((activatedNodeIndex >= 0) ? (activatedNodeIndex + 1) : 0);
			if (nodeAttitudeTipsTextByStage.Length > 0)
			{
				ScrollingTipsController.Instance.ShowTipsByText(nodeAttitudeTipsTextByStage);
			}
		}

		// Token: 0x0401E502 RID: 124162
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] EntryEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Wood,
			GiantEcoNetType.Fire,
			GiantEcoNetType.Water
		};

		// Token: 0x0401E503 RID: 124163
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] PicEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Fire,
			GiantEcoNetType.Wood,
			GiantEcoNetType.Water
		};

		// Token: 0x0401E504 RID: 124164
		private int ActivityId;

		// Token: 0x0401E505 RID: 124165
		private GiantEcoNetType CurrentPicEco;

		// Token: 0x0401E506 RID: 124166
		private int SelectedNodeIndex = -1;

		// Token: 0x0401E507 RID: 124167
		private bool HasUserSelectedNode;

		// Token: 0x0401E508 RID: 124168
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0401E509 RID: 124169
		private readonly List<GiantMindsetEntryItem> MindsetEntries = new List<GiantMindsetEntryItem>();

		// Token: 0x0401E50A RID: 124170
		[Nullable(2)]
		private GiantAttitudeRowItem AttitudeRow;

		// Token: 0x0401E50B RID: 124171
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> NodeScaleLayout;

		// Token: 0x0401E50C RID: 124172
		[Nullable(2)]
		private TimerHandle PicSwitchTimer;

		// Token: 0x0401E50D RID: 124173
		[Nullable(2)]
		private CommonRewardPopup RewardPopup;
	}
}
