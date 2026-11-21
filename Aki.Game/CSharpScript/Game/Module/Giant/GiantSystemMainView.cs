using System;
using System.Collections.Generic;
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
	// Token: 0x0200494C RID: 18764
	[NullableContext(1)]
	[Nullable(0)]
	public class GiantSystemMainView : UiViewBase
	{
		// Token: 0x0602F0E1 RID: 192737 RVA: 0x00D1F02C File Offset: 0x00D1D22C
		public GiantSystemMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602F0E2 RID: 192738 RVA: 0x00D1F048 File Offset: 0x00D1D248
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

		// Token: 0x0602F0E3 RID: 192739 RVA: 0x00D1F508 File Offset: 0x00D1D708
		protected override void OnBeforeCreate()
		{
			IGiantSystemMainOpenParam giantSystemMainOpenParam = this.OpenParam as IGiantSystemMainOpenParam;
			this.ActivityId = giantSystemMainOpenParam.ActivityId;
		}

		// Token: 0x0602F0E4 RID: 192740 RVA: 0x00D1F530 File Offset: 0x00D1D730
		protected override UniTask OnBeforeStartAsync()
		{
			GiantSystemMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<GiantSystemMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F0E5 RID: 192741 RVA: 0x00D1F574 File Offset: 0x00D1D774
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

		// Token: 0x0602F0E6 RID: 192742 RVA: 0x00D1F600 File Offset: 0x00D1D800
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

		// Token: 0x0602F0E7 RID: 192743 RVA: 0x00D1F6B8 File Offset: 0x00D1D8B8
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

		// Token: 0x0602F0E8 RID: 192744 RVA: 0x00D1F774 File Offset: 0x00D1D974
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

		// Token: 0x0602F0E9 RID: 192745 RVA: 0x00D1F7AB File Offset: 0x00D1D9AB
		private void OnGiantDataChange()
		{
			this.Refresh();
		}

		// Token: 0x0602F0EA RID: 192746 RVA: 0x00D1F7B3 File Offset: 0x00D1D9B3
		private void Refresh()
		{
			this.RefreshMindsetEntries();
			this.RefreshTotalProgress();
			this.RefreshSelectedNode();
			this.RefreshGiantPic();
			this.RefreshRedDots();
			int activityId = this.ActivityId;
		}

		// Token: 0x0602F0EB RID: 192747 RVA: 0x00D1F7DC File Offset: 0x00D1D9DC
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

		// Token: 0x0602F0EC RID: 192748 RVA: 0x00D1F850 File Offset: 0x00D1DA50
		private void RefreshTotalProgress()
		{
			GiantModel instance = GiantModel.Instance;
			double totalStableValue = instance.GetTotalStableValue();
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			int[] array;
			if (totalNodes.Length != 0)
			{
				array = new int[totalNodes.Length];
				for (int i = 0; i < totalNodes.Length; i++)
				{
					array[i] = totalNodes[i].Goal;
				}
			}
			else
			{
				array = GiantConfig.GetTotalNodeGoals();
			}
			UUISliderComponent slider = base.GetSlider(23);
			if (slider != null)
			{
				slider.SetValue((float)this.GetProgressFillByNode(totalStableValue, array), true);
			}
			UUIText text = base.GetText(22);
			if (text != null)
			{
				text.SetText(totalStableValue.ToString(), true);
			}
			int reachedNodeIndex = this.GetReachedNodeIndex();
			int activatedNodeIndex = this.GetActivatedNodeIndex();
			List<IGiantNodeScaleData> list = new List<IGiantNodeScaleData>();
			for (int j = 0; j < array.Length; j++)
			{
				int num = array[j];
				EGiantNodeScaleState state = (j == reachedNodeIndex) ? EGiantNodeScaleState.Current : ((j < reachedNodeIndex) ? EGiantNodeScaleState.Expired : EGiantNodeScaleState.Lock);
				object obj = (j < totalNodes.Length) ? totalNodes[j].DropId : 0;
				int num2 = (j < totalNodes.Length) ? totalNodes[j].Id : 0;
				object obj2 = obj;
				bool flag = obj2 > 0 && instance.GetRewardGot(num2);
				bool canClaim = obj2 > 0 && !flag && totalStableValue >= (double)num && instance.IsNodeInteracted(num2);
				list.Add(new GiantNodeScaleData
				{
					NodeIndex = j,
					Value = num,
					State = state,
					IsGot = flag,
					CanClaim = canClaim,
					ShowCurrentMark = (j == activatedNodeIndex),
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

		// Token: 0x0602F0ED RID: 192749 RVA: 0x00D1F9F8 File Offset: 0x00D1DBF8
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

		// Token: 0x0602F0EE RID: 192750 RVA: 0x00D1FA79 File Offset: 0x00D1DC79
		private void OnClaimNodeReward()
		{
			GiantController.Instance.SendGiantStableValueActivityRequest(delegate(GiantStableValueActivityResponse _)
			{
				this.RefreshTotalProgress();
			});
		}

		// Token: 0x0602F0EF RID: 192751 RVA: 0x00D1FA94 File Offset: 0x00D1DC94
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

		// Token: 0x0602F0F0 RID: 192752 RVA: 0x00D1FB50 File Offset: 0x00D1DD50
		private void OnPreviewNodeReward(int nodeIndex, UUIItem mountItem)
		{
			GiantTotalProgress[] totalNodes = GiantConfig.GetTotalNodes();
			int num = (nodeIndex < totalNodes.Length) ? totalNodes[nodeIndex].DropId : 0;
			if (num <= 0)
			{
				return;
			}
			bool rewardGot = GiantModel.Instance.GetRewardGot((nodeIndex < totalNodes.Length) ? totalNodes[nodeIndex].Id : 0);
			List<TItem> dropPackagePreviewItemListByIdList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemListByIdList(new List<int>
			{
				num
			});
			List<DailyActivityDefine.RewardTuple> list = new List<DailyActivityDefine.RewardTuple>();
			foreach (TItem titem in dropPackagePreviewItemListByIdList)
			{
				list.Add(new DailyActivityDefine.RewardTuple
				{
					Id = titem.ItemData.ItemId,
					Num = titem.Count,
					Received = rewardGot
				});
			}
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

		// Token: 0x0602F0F1 RID: 192753 RVA: 0x00D1FC78 File Offset: 0x00D1DE78
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

		// Token: 0x0602F0F2 RID: 192754 RVA: 0x00D1FD9C File Offset: 0x00D1DF9C
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

		// Token: 0x0602F0F3 RID: 192755 RVA: 0x00D1FDD8 File Offset: 0x00D1DFD8
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

		// Token: 0x0602F0F4 RID: 192756 RVA: 0x00D1FE18 File Offset: 0x00D1E018
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

		// Token: 0x0602F0F5 RID: 192757 RVA: 0x00D1FE84 File Offset: 0x00D1E084
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

		// Token: 0x0602F0F6 RID: 192758 RVA: 0x00D1FEBE File Offset: 0x00D1E0BE
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

		// Token: 0x0602F0F7 RID: 192759 RVA: 0x00D1FEFC File Offset: 0x00D1E0FC
		private UniTask SwitchGiantPicAsync()
		{
			GiantSystemMainView.<SwitchGiantPicAsync>d__34 <SwitchGiantPicAsync>d__;
			<SwitchGiantPicAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SwitchGiantPicAsync>d__.<>4__this = this;
			<SwitchGiantPicAsync>d__.<>1__state = -1;
			<SwitchGiantPicAsync>d__.<>t__builder.Start<GiantSystemMainView.<SwitchGiantPicAsync>d__34>(ref <SwitchGiantPicAsync>d__);
			return <SwitchGiantPicAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F0F8 RID: 192760 RVA: 0x00D1FF40 File Offset: 0x00D1E140
		private GiantEcoNetType PickWeightedPicEco()
		{
			GiantModel instance = GiantModel.Instance;
			int[] array = new int[GiantSystemMainView.PicEcoList.Length];
			for (int i = 0; i < GiantSystemMainView.PicEcoList.Length; i++)
			{
				array[i] = GiantConfig.GetPicWeight(GiantSystemMainView.PicEcoList[i], (int)(instance.GetStage(GiantSystemMainView.PicEcoList[i]) + 1));
			}
			int num = 0;
			foreach (int num2 in array)
			{
				num += num2;
			}
			if (num <= 0)
			{
				return GiantSystemMainView.PicEcoList[0];
			}
			double num3 = MathUtils.Instance.GetRandomRange(0.0, 1.0) * (double)num;
			for (int k = 0; k < GiantSystemMainView.PicEcoList.Length; k++)
			{
				num3 -= (double)array[k];
				if (num3 < 0.0)
				{
					return GiantSystemMainView.PicEcoList[k];
				}
			}
			return GiantSystemMainView.PicEcoList[GiantSystemMainView.PicEcoList.Length - 1];
		}

		// Token: 0x0602F0F9 RID: 192761 RVA: 0x00D2002C File Offset: 0x00D1E22C
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

		// Token: 0x0602F0FA RID: 192762 RVA: 0x00D2007C File Offset: 0x00D1E27C
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

		// Token: 0x0602F0FB RID: 192763 RVA: 0x00D200DC File Offset: 0x00D1E2DC
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

		// Token: 0x0602F0FC RID: 192764 RVA: 0x00D20114 File Offset: 0x00D1E314
		private bool IsNodeLocked(int nodeIndex)
		{
			return nodeIndex > this.GetReachedNodeIndex();
		}

		// Token: 0x0602F0FD RID: 192765 RVA: 0x00D20120 File Offset: 0x00D1E320
		private void OnClickMindsetEntry(GiantEcoNetType eco)
		{
			GiantSystemQuestOpenParam param = new GiantSystemQuestOpenParam
			{
				EcoType = eco
			};
			UiManager.Instance.OpenView(EUiViewName.GiantSystemQuestView, param, null);
		}

		// Token: 0x0602F0FE RID: 192766 RVA: 0x00D2014C File Offset: 0x00D1E34C
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

		// Token: 0x0602F0FF RID: 192767 RVA: 0x00D201A0 File Offset: 0x00D1E3A0
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

		// Token: 0x04018FA0 RID: 102304
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] EntryEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Wood,
			GiantEcoNetType.Fire,
			GiantEcoNetType.Water
		};

		// Token: 0x04018FA1 RID: 102305
		[StaticVariableRuleIgnore]
		private static readonly GiantEcoNetType[] PicEcoList = new GiantEcoNetType[]
		{
			GiantEcoNetType.Fire,
			GiantEcoNetType.Wood,
			GiantEcoNetType.Water
		};

		// Token: 0x04018FA2 RID: 102306
		private int ActivityId;

		// Token: 0x04018FA3 RID: 102307
		private GiantEcoNetType CurrentPicEco;

		// Token: 0x04018FA4 RID: 102308
		private int SelectedNodeIndex = -1;

		// Token: 0x04018FA5 RID: 102309
		private bool HasUserSelectedNode;

		// Token: 0x04018FA6 RID: 102310
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x04018FA7 RID: 102311
		private readonly List<GiantMindsetEntryItem> MindsetEntries = new List<GiantMindsetEntryItem>();

		// Token: 0x04018FA8 RID: 102312
		[Nullable(2)]
		private GiantAttitudeRowItem AttitudeRow;

		// Token: 0x04018FA9 RID: 102313
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<GiantNodeScaleItem, IGiantNodeScaleData> NodeScaleLayout;

		// Token: 0x04018FAA RID: 102314
		[Nullable(2)]
		private TimerHandle PicSwitchTimer;

		// Token: 0x04018FAB RID: 102315
		[Nullable(2)]
		private CommonRewardPopup RewardPopup;
	}
}
