using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200559C RID: 21916
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingQuestView : UiViewBase
	{
		// Token: 0x06036556 RID: 222550 RVA: 0x00F29BDB File Offset: 0x00F27DDB
		[NullableContext(1)]
		public FishingQuestView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06036557 RID: 222551 RVA: 0x00F29BF8 File Offset: 0x00F27DF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 28;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(23, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(24, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(25, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(26, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(27, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickLockBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickRightBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickLeftBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036558 RID: 222552 RVA: 0x00F2A055 File Offset: 0x00F28255
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x06036559 RID: 222553 RVA: 0x00F2A073 File Offset: 0x00F28273
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<bool, int?>(EEventName.FishingRefreshQuestView, new Action<bool, int?>(this.FishingRefreshQuestView));
		}

		// Token: 0x0603655A RID: 222554 RVA: 0x00F2A094 File Offset: 0x00F28294
		protected override UniTask OnBeforeStartAsync()
		{
			FishingQuestView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingQuestView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603655B RID: 222555 RVA: 0x00F2A0D8 File Offset: 0x00F282D8
		protected override void OnStart()
		{
			int currentTraceEntrust = FishingQuestModel.Instance.CurrentTraceEntrust;
			this.RefreshScrollView(currentTraceEntrust);
		}

		// Token: 0x0603655C RID: 222556 RVA: 0x00F2A0F8 File Offset: 0x00F282F8
		protected override void OnBeforeShow()
		{
			if (!this.IsInitBeforeShow)
			{
				this.IsInitBeforeShow = true;
				return;
			}
			this.RefreshView(this.CurrentSelectEntrust);
			GenericScrollViewNew<FishingQuestItem, int> taskScrollVieW = this.TaskScrollVieW;
			List<FishingQuestItem> list = (taskScrollVieW != null) ? taskScrollVieW.GetScrollItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (FishingQuestItem fishingQuestItem in list)
			{
				fishingQuestItem.RefreshChildItemStateAbout();
			}
		}

		// Token: 0x0603655D RID: 222557 RVA: 0x00F2A178 File Offset: 0x00F28378
		private void RefreshScrollView(int target = 0)
		{
			List<int> entrustPool = FishingQuestModel.Instance.EntrustPool;
			List<int> list = new List<int>();
			bool flag = false;
			foreach (int num in entrustPool)
			{
				if (num != 3)
				{
					if (FishingQuestModel.Instance.GetPoolHasAnyEntrust(num))
					{
						list.Add(num);
					}
					if (FishingQuestModel.Instance.GetPoolHasAnyAcceptedEntrust(num))
					{
						flag = true;
					}
				}
			}
			bool flag2 = list.Count > 0;
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(19);
			if (item2 != null)
			{
				item2.SetUIActive(!flag2);
			}
			if (!flag2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(24), flag ? "Fishing_EnrustEmptyState2" : "Fishing_EnrustEmptyState1", Array.Empty<object>());
			}
			GenericScrollViewNew<FishingQuestItem, int> taskScrollVieW = this.TaskScrollVieW;
			if (taskScrollVieW == null)
			{
				return;
			}
			taskScrollVieW.RefreshByData(list, delegate
			{
				if (target != 0)
				{
					GenericScrollViewNew<FishingQuestItem, int> taskScrollVieW2 = this.TaskScrollVieW;
					foreach (FishingQuestItem fishingQuestItem in ((taskScrollVieW2 != null) ? taskScrollVieW2.GetScrollItemList() : null))
					{
						int num2 = fishingQuestItem.HaveTargetTask(target);
						if (num2 > -1)
						{
							fishingQuestItem.SelectFirstItem(num2);
							return;
						}
					}
				}
				GenericScrollViewNew<FishingQuestItem, int> taskScrollVieW3 = this.TaskScrollVieW;
				if (taskScrollVieW3 == null)
				{
					return;
				}
				FishingQuestItem scrollItemByIndex = taskScrollVieW3.GetScrollItemByIndex(0);
				if (scrollItemByIndex == null)
				{
					return;
				}
				scrollItemByIndex.SelectFirstItem(0);
			}, false);
		}

		// Token: 0x0603655E RID: 222558 RVA: 0x00F2A290 File Offset: 0x00F28490
		private void RefreshView(int selectEntrust)
		{
			this.CurrentSelectEntrust = selectEntrust;
			bool flag = selectEntrust == -1;
			base.GetItem(23).SetUIActive(!flag);
			base.GetItem(25).SetUIActive(flag);
			if (flag)
			{
				return;
			}
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
			if (fishingEntrust == null)
			{
				return;
			}
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in fishingEntrust.Value.EntrustReward())
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int itemId = num;
				int count = num2;
				TItem item = new TItem(new InventoryDefine.GetItemData(itemId, 0), count);
				list.Add(item);
			}
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout != null)
			{
				rewardLayout.RefreshByData(list, null, false);
			}
			base.GetItem(26).SetUIActive(fishingEntrust.Value.IsNight);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), fishingEntrust.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), FishingDefine.fishingEntrustTypeText[fishingEntrust.Value.EntrustType], Array.Empty<object>());
			this.RefreshTargetAbout();
			this.RefreshBtn();
		}

		// Token: 0x0603655F RID: 222559 RVA: 0x00F2A3F4 File Offset: 0x00F285F4
		private void RefreshTargetAbout()
		{
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
			if (fishingEntrust == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = fishingEntrust.Value.EntrustTarget();
			int num = 0;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				int num2;
				int num3;
				keyValuePair.Deconstruct(out num2, out num3);
				int itemId = num2;
				num++;
				if (num == 1)
				{
					FishingQuestShapePanel fishingQuestShapePanel = this.FishingQuestShapePanel;
					if (fishingQuestShapePanel != null)
					{
						fishingQuestShapePanel.RefreshPanel(itemId, true);
					}
				}
				else if (num == 2)
				{
					FishingQuestShapePanel fishingQuestShapePanel2 = this.FishingQuestShapePanel2;
					if (fishingQuestShapePanel2 != null)
					{
						fishingQuestShapePanel2.SetUiActive(true);
					}
					FishingQuestShapePanel fishingQuestShapePanel3 = this.FishingQuestShapePanel2;
					if (fishingQuestShapePanel3 != null)
					{
						fishingQuestShapePanel3.RefreshPanel(itemId, true);
					}
				}
			}
			if (num < 2)
			{
				FishingQuestShapePanel fishingQuestShapePanel4 = this.FishingQuestShapePanel2;
				if (fishingQuestShapePanel4 != null)
				{
					fishingQuestShapePanel4.SetUiActive(false);
				}
			}
			int entrustDestination = fishingEntrust.Value.EntrustDestination;
			if (entrustDestination == 0)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "Fishing_AnyWharf", Array.Empty<object>());
			}
			else
			{
				FishingPort fishingPortConfig = FishingConfig.Instance.GetFishingPortConfig(entrustDestination);
				MapMark? configMark = MapConfig.Instance.GetConfigMark(fishingPortConfig.MarkId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), ((configMark != null) ? configMark.GetValueOrDefault().MarkTitle : null) ?? "Fishing_AnyWharf", Array.Empty<object>());
			}
			Dictionary<int, string> dictionary2 = fishingEntrust.Value.TargetDesText();
			if (dictionary2 == null)
			{
				base.GetText(17).SetText("--", true);
				return;
			}
			num = 0;
			foreach (KeyValuePair<int, string> keyValuePair2 in dictionary2)
			{
				int num3;
				string text;
				keyValuePair2.Deconstruct(out num3, out text);
				int num4 = num3;
				string text2 = text;
				num++;
				int num5 = 0;
				fishingEntrust.Value.EntrustTarget().TryGetValue(num4, out num5);
				int itemCountByItemId = DockyardModel.Instance.GetItemCountByItemId(num4);
				if (num == 1)
				{
					UUIText text3 = base.GetText(17);
					string[] array = new string[6];
					int num6 = 0;
					TextConfig instance = TextConfig.Instance;
					string key = text2;
					string[] array2 = new string[1];
					int num7 = 0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
					array2[num7] = defaultInterpolatedStringHandler.ToStringAndClear();
					array[num6] = instance.GetMultiText(key, array2);
					array[1] = " (";
					int num8 = 2;
					num3 = Math.Min(itemCountByItemId, num5);
					array[num8] = num3.ToString();
					array[3] = "/";
					array[4] = num5.ToString();
					array[5] = ")";
					text3.SetText(string.Concat(array), true);
					base.GetText(17).useChangeColor = (itemCountByItemId >= num5);
				}
				else if (num == 2)
				{
					base.GetItem(22).SetUIActive(true);
					UUIText text4 = base.GetText(21);
					string[] array3 = new string[6];
					int num9 = 0;
					TextConfig instance2 = TextConfig.Instance;
					string key2 = text2;
					string[] array4 = new string[1];
					int num10 = 0;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
					array4[num10] = defaultInterpolatedStringHandler.ToStringAndClear();
					array3[num9] = instance2.GetMultiText(key2, array4);
					array3[1] = " (";
					int num11 = 2;
					num3 = Math.Min(itemCountByItemId, num5);
					array3[num11] = num3.ToString();
					array3[3] = "/";
					array3[4] = num5.ToString();
					array3[5] = ")";
					text4.SetText(string.Concat(array3), true);
					base.GetText(21).useChangeColor = (itemCountByItemId >= num5);
				}
				if (num < 2)
				{
					base.GetItem(22).SetUIActive(false);
				}
			}
		}

		// Token: 0x06036560 RID: 222560 RVA: 0x00F2A788 File Offset: 0x00F28988
		private void OnClickLockBtn()
		{
			HelpController.Instance.OpenHelpById(191);
		}

		// Token: 0x06036561 RID: 222561 RVA: 0x00F2A79C File Offset: 0x00F2899C
		private void OnClickRightBtn()
		{
			switch (this.RightBtnState)
			{
			case EFishingQuestRightBtn.Acceptable:
				FishingController.Instance.RequestFishingEntrustAccept(this.CurrentSelectEntrust, true, delegate
				{
					FishingController.Instance.RequestFishingEntrustTrace(this.CurrentSelectEntrust);
				});
				return;
			case EFishingQuestRightBtn.Trace:
				FishingQuestModel.Instance.TraceFormClick = true;
				FishingController.Instance.RequestFishingEntrustTrace(this.CurrentSelectEntrust);
				return;
			case EFishingQuestRightBtn.CancelTrace:
				FishingController.Instance.RequestFishingEntrustTrace(0);
				break;
			case EFishingQuestRightBtn.Deliverable:
			{
				Dictionary<int, List<FishingHandInItem>> dictionary = new Dictionary<int, List<FishingHandInItem>>();
				FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
				if (fishingEntrust == null)
				{
					return;
				}
				foreach (KeyValuePair<int, int> keyValuePair in fishingEntrust.Value.EntrustTarget())
				{
					int num;
					int num2;
					keyValuePair.Deconstruct(out num, out num2);
					int num3 = num;
					int num4 = num2;
					List<DockyardItemBlockOriginalData> itemListByItemId = DockyardModel.Instance.GetItemListByItemId(num3);
					itemListByItemId.Sort((DockyardItemBlockOriginalData a, DockyardItemBlockOriginalData b) => a.Price - b.Price);
					foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in itemListByItemId)
					{
						List<FishingHandInItem> list;
						if (!dictionary.TryGetValue(num3, out list))
						{
							list = new List<FishingHandInItem>();
							dictionary[num3] = list;
						}
						if (list.Count >= num4)
						{
							break;
						}
						FishingHandInItem fishingHandInItem = FishingHandInItem.Create();
						fishingHandInItem.ItemId = num3;
						fishingHandInItem.IncrId = dockyardItemBlockOriginalData.IncId;
						fishingHandInItem.Count = 1;
						list.Add(fishingHandInItem);
					}
				}
				List<FishingHandInItem> list2 = new List<FishingHandInItem>();
				foreach (KeyValuePair<int, List<FishingHandInItem>> keyValuePair2 in dictionary)
				{
					int num2;
					List<FishingHandInItem> list3;
					keyValuePair2.Deconstruct(out num2, out list3);
					List<FishingHandInItem> collection = list3;
					list2.AddRange(collection);
				}
				FishingController.Instance.RequestFishingEntrustHandInRequest(this.CurrentSelectEntrust, list2);
				return;
			}
			case EFishingQuestRightBtn.UnDeliverable:
				break;
			case EFishingQuestRightBtn.JumpTo:
			{
				FishingEntrust? fishingEntrust2 = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
				if (fishingEntrust2 == null)
				{
					return;
				}
				SkipTaskManager.RunByConfigId(fishingEntrust2.Value.AccessPath, null);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06036562 RID: 222562 RVA: 0x00F2A9F8 File Offset: 0x00F28BF8
		private void OnClickLeftBtn()
		{
			switch (this.LeftBtnState)
			{
			case EFishingQuestLeftBtn.Refresh:
			{
				EFishingEntrustState efishingEntrustState;
				if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.CurrentSelectEntrust, out efishingEntrustState))
				{
					if (efishingEntrustState == EFishingEntrustState.Deliverable)
					{
						ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.FishingDeliverEntrustRefresh);
						confirmBoxDataNew.FunctionMap[2] = delegate()
						{
							FishingController.Instance.RequestFishingEntrustRefresh(this.CurrentSelectEntrust);
						};
						ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
						return;
					}
					FishingController.Instance.RequestFishingEntrustRefresh(this.CurrentSelectEntrust);
					return;
				}
				break;
			}
			case EFishingQuestLeftBtn.GiveUp:
			{
				FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
				if (fishingEntrust == null)
				{
					return;
				}
				bool flag = false;
				if (fishingEntrust.Value.EntrustType == 0 || fishingEntrust.Value.EntrustType == 1)
				{
					Dictionary<int, int> dictionary = fishingEntrust.Value.EntrustTarget();
					bool flag2 = true;
					foreach (KeyValuePair<int, int> keyValuePair in dictionary)
					{
						int num;
						int num2;
						keyValuePair.Deconstruct(out num, out num2);
						int num3 = num;
						int num4 = num2;
						if (num3 == 0 || num4 == 0)
						{
							flag2 = false;
							break;
						}
						if (DockyardModel.Instance.GetItemCountByItemId(num3) < num4)
						{
							flag2 = false;
							break;
						}
					}
					flag = flag2;
				}
				EFishingEntrustState efishingEntrustState2;
				if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.CurrentSelectEntrust, out efishingEntrustState2) && (fishingEntrust.Value.EntrustType == 2 || efishingEntrustState2 == EFishingEntrustState.Deliverable || flag))
				{
					ConfirmBoxDataNew confirmBoxDataNew2 = new ConfirmBoxDataNew(EConfirmBoxConfigId.FishingEntrustGiveUp);
					confirmBoxDataNew2.FunctionMap[2] = delegate()
					{
						FishingController.Instance.RequestFishingEntrustTrace(0);
						FishingController.Instance.RequestFishingEntrustAccept(this.CurrentSelectEntrust, false, null);
					};
					ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew2);
					return;
				}
				FishingController.Instance.RequestFishingEntrustTrace(0);
				FishingController.Instance.RequestFishingEntrustAccept(this.CurrentSelectEntrust, false, null);
				break;
			}
			case EFishingQuestLeftBtn.Hide:
				break;
			default:
				return;
			}
		}

		// Token: 0x06036563 RID: 222563 RVA: 0x00F2ABD4 File Offset: 0x00F28DD4
		[NullableContext(1)]
		private FishingQuestItem InitTaskItem()
		{
			return new FishingQuestItem
			{
				OnClickTaskCallBack = new Action<int, UUIExtendToggle, Action>(this.OnClickTaskToggle)
			};
		}

		// Token: 0x06036564 RID: 222564 RVA: 0x00F2ABED File Offset: 0x00F28DED
		[NullableContext(1)]
		private CommonItemSmallItemGrid InitRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06036565 RID: 222565 RVA: 0x00F2ABF4 File Offset: 0x00F28DF4
		[NullableContext(1)]
		private void OnClickTaskToggle(int entrustId, UUIExtendToggle toggle, Action changeColorBack)
		{
			Action changeColorBackFunc = this.ChangeColorBackFunc;
			if (changeColorBackFunc != null)
			{
				changeColorBackFunc();
			}
			this.ChangeColorBackFunc = changeColorBack;
			if (this.CurrentSelectTaskToggle != toggle)
			{
				UUIExtendToggle currentSelectTaskToggle = this.CurrentSelectTaskToggle;
				if (currentSelectTaskToggle != null)
				{
					currentSelectTaskToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				}
			}
			this.CurrentSelectTaskToggle = toggle;
			this.RefreshView(entrustId);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) != "Switch")
			{
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 == null)
				{
					return;
				}
				levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
				if (levelSequencePlayer3 == null)
				{
					return;
				}
				levelSequencePlayer3.ReplaySequenceByKey("Switch");
				return;
			}
		}

		// Token: 0x06036566 RID: 222566 RVA: 0x00F2AC9A File Offset: 0x00F28E9A
		private void FishingRefreshQuestView(bool keepSelect, int? targetId = null)
		{
			if (keepSelect)
			{
				this.RefreshView(this.CurrentSelectEntrust);
				return;
			}
			this.RefreshScrollView(targetId.GetValueOrDefault());
		}

		// Token: 0x06036567 RID: 222567 RVA: 0x00F2ACBC File Offset: 0x00F28EBC
		private void RefreshBtn()
		{
			FishingEntrust? fishingEntrust = FishingConfig.Instance.GetFishingEntrust(this.CurrentSelectEntrust);
			if (fishingEntrust == null)
			{
				return;
			}
			EFishingEntrustState efishingEntrustState;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.CurrentSelectEntrust, out efishingEntrustState))
			{
				base.GetItem(27).SetUIActive(false);
				if (efishingEntrustState == EFishingEntrustState.UnAcceptable)
				{
					base.GetItem(7).SetUIActive(true);
					string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(fishingEntrust.Value.UnlockCondition);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(8), conditionGroupHintText ?? "", Array.Empty<object>());
					base.GetButton(12).RootUIComp.Get().SetUIActive(false);
					base.GetButton(14).RootUIComp.Get().SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingTagJumpToTech", Array.Empty<object>());
					this.RightBtnState = EFishingQuestRightBtn.JumpTo;
					AccessPath? accessPathConfig = SkipInterfaceConfig.Instance.GetAccessPathConfig(fishingEntrust.Value.AccessPath);
					int num = int.Parse(((accessPathConfig != null) ? accessPathConfig.GetValueOrDefault().Val3 : null) ?? "0");
					if (accessPathConfig != null && num != 0)
					{
						bool techNodeCanLevelUp = FishingModel.Instance.GetTechNodeCanLevelUp(num);
						base.GetItem(27).SetUIActive(techNodeCanLevelUp);
					}
					return;
				}
			}
			base.GetItem(7).SetUIActive(false);
			if (FishingModel.Instance.DockId <= 0)
			{
				UUIButtonComponent button = base.GetButton(12);
				if (button != null)
				{
					button.RootUIComp.Get().SetUIActive(false);
				}
				this.LeftBtnState = EFishingQuestLeftBtn.Hide;
				bool flag = this.CurrentSelectEntrust == FishingQuestModel.Instance.CurrentTraceEntrust;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(15), (!flag) ? "FishingBtnTrace" : "FishingBtnCancelTrace", Array.Empty<object>());
				this.RightBtnState = ((!flag) ? EFishingQuestRightBtn.Trace : EFishingQuestRightBtn.CancelTrace);
				return;
			}
			double entrustsRefreshCost = FishingQuestModel.Instance.GetEntrustsRefreshCost(this.CurrentSelectEntrust);
			UUIButtonComponent button2 = base.GetButton(12);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(entrustsRefreshCost >= 0.0);
			}
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(13);
			string textStringId = "FishingRefreshEntrust";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<texture=");
			defaultInterpolatedStringHandler.AppendFormatted(this.FishingCurrencyItemIcon);
			defaultInterpolatedStringHandler.AppendLiteral(",0.5/>");
			defaultInterpolatedStringHandler.AppendFormatted<double>(entrustsRefreshCost);
			instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(defaultInterpolatedStringHandler.ToStringAndClear()));
			this.LeftBtnState = EFishingQuestLeftBtn.Refresh;
			EFishingEntrustState efishingEntrustState2;
			if (FishingQuestModel.Instance.CurrentEntrusts.TryGetValue(this.CurrentSelectEntrust, out efishingEntrustState2))
			{
				if (efishingEntrustState2 == EFishingEntrustState.Acceptable)
				{
					base.GetButton(14).RootUIComp.Get().SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingBtnReceiving", Array.Empty<object>());
					this.RightBtnState = EFishingQuestRightBtn.Acceptable;
					return;
				}
				base.GetItem(16).SetUIActive(false);
				if (efishingEntrustState2 == EFishingEntrustState.Deliverable)
				{
					base.GetButton(14).RootUIComp.Get().SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingBtnFinishing", Array.Empty<object>());
					this.RightBtnState = EFishingQuestRightBtn.Deliverable;
					return;
				}
				if (this.CurrentSelectEntrust == FishingQuestModel.Instance.CurrentTraceEntrust)
				{
					base.GetButton(14).RootUIComp.Get().SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingBtnCancelTrace", Array.Empty<object>());
					this.RightBtnState = EFishingQuestRightBtn.CancelTrace;
					return;
				}
				if (efishingEntrustState2 == EFishingEntrustState.UnDeliverable)
				{
					if (!FishingQuestModel.Instance.GetEntrustsTargetEnough(this.CurrentSelectEntrust) && this.CurrentSelectEntrust != FishingQuestModel.Instance.CurrentTraceEntrust)
					{
						base.GetButton(14).RootUIComp.Get().SetUIActive(true);
						LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingBtnTrace", Array.Empty<object>());
						this.RightBtnState = EFishingQuestRightBtn.Trace;
						return;
					}
					base.GetButton(14).RootUIComp.Get().SetUIActive(false);
					base.GetItem(16).SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "FishingBtnCanNotFinishing", Array.Empty<object>());
					this.RightBtnState = EFishingQuestRightBtn.UnDeliverable;
				}
			}
		}

		// Token: 0x0401CAC1 RID: 117441
		private int CurrentSelectEntrust = -1;

		// Token: 0x0401CAC2 RID: 117442
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CAC3 RID: 117443
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<FishingQuestItem, int> TaskScrollVieW;

		// Token: 0x0401CAC4 RID: 117444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardLayout;

		// Token: 0x0401CAC5 RID: 117445
		private FishingQuestShapePanel FishingQuestShapePanel;

		// Token: 0x0401CAC6 RID: 117446
		private FishingQuestShapePanel FishingQuestShapePanel2;

		// Token: 0x0401CAC7 RID: 117447
		private UUIExtendToggle CurrentSelectTaskToggle;

		// Token: 0x0401CAC8 RID: 117448
		private EFishingQuestLeftBtn LeftBtnState;

		// Token: 0x0401CAC9 RID: 117449
		private EFishingQuestRightBtn RightBtnState;

		// Token: 0x0401CACA RID: 117450
		[Nullable(1)]
		private string FishingCurrencyItemIcon = "";

		// Token: 0x0401CACB RID: 117451
		private bool IsInitBeforeShow;

		// Token: 0x0401CACC RID: 117452
		private Action ChangeColorBackFunc;

		// Token: 0x0401CACD RID: 117453
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B215 RID: 45589
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040370B7 RID: 225463
			public const int CaptionItem = 0;

			// Token: 0x040370B8 RID: 225464
			public const int TaskScrollView = 1;

			// Token: 0x040370B9 RID: 225465
			public const int TaskItem = 2;

			// Token: 0x040370BA RID: 225466
			public const int TagText = 3;

			// Token: 0x040370BB RID: 225467
			public const int NameText = 4;

			// Token: 0x040370BC RID: 225468
			public const int GirdPanelItem = 5;

			// Token: 0x040370BD RID: 225469
			public const int DestinationText = 6;

			// Token: 0x040370BE RID: 225470
			public const int LockItem = 7;

			// Token: 0x040370BF RID: 225471
			public const int LockText = 8;

			// Token: 0x040370C0 RID: 225472
			public const int LockBtn = 9;

			// Token: 0x040370C1 RID: 225473
			public const int RewardScrollView = 10;

			// Token: 0x040370C2 RID: 225474
			public const int RewardItem = 11;

			// Token: 0x040370C3 RID: 225475
			public const int RefreshBtn = 12;

			// Token: 0x040370C4 RID: 225476
			public const int RefreshBtnText = 13;

			// Token: 0x040370C5 RID: 225477
			public const int ConfirmBtn = 14;

			// Token: 0x040370C6 RID: 225478
			public const int ConfirmBtnText = 15;

			// Token: 0x040370C7 RID: 225479
			public const int NotEnoughItem = 16;

			// Token: 0x040370C8 RID: 225480
			public const int TargetText = 17;

			// Token: 0x040370C9 RID: 225481
			public const int AllInfoItem = 18;

			// Token: 0x040370CA RID: 225482
			public const int EmptyItem = 19;

			// Token: 0x040370CB RID: 225483
			public const int GirdPanelItem2 = 20;

			// Token: 0x040370CC RID: 225484
			public const int TargetText2 = 21;

			// Token: 0x040370CD RID: 225485
			public const int TargetText2Item = 22;

			// Token: 0x040370CE RID: 225486
			public const int TechNormalItem = 23;

			// Token: 0x040370CF RID: 225487
			public const int EmptyText = 24;

			// Token: 0x040370D0 RID: 225488
			public const int TechLockItem = 25;

			// Token: 0x040370D1 RID: 225489
			public const int NightItem = 26;

			// Token: 0x040370D2 RID: 225490
			public const int RightButtonRedDotItem = 27;
		}
	}
}
