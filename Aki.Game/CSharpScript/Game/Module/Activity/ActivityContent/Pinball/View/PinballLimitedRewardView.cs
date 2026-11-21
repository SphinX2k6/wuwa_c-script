using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x0200524E RID: 21070
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballLimitedRewardView : UiTickViewBase
	{
		// Token: 0x06034740 RID: 214848 RVA: 0x00EAD6DB File Offset: 0x00EAB8DB
		public PinballLimitedRewardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034741 RID: 214849 RVA: 0x00EAD6E4 File Offset: 0x00EAB8E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnBigRewardBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnPreviewBtnClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(13, new Action(this.OnBigRewardItemTipsClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034742 RID: 214850 RVA: 0x00EAD964 File Offset: 0x00EABB64
		protected override void OnStart()
		{
			this.ActivityData = (this.OpenParam as PinballActivityData);
			PopupCaptionItem popupCaptionItem = new PopupCaptionItem(base.GetItem(0));
			popupCaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			popupCaptionItem.SetHelpBtnActive(false);
			this.TaskLayout = new GenericScrollViewNew<PinballLimitedRewardTaskItem, PinballTaskData>(base.GetScrollViewWithScrollbar(1), new Func<PinballLimitedRewardTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshView(true);
		}

		// Token: 0x06034743 RID: 214851 RVA: 0x00EAD9D0 File Offset: 0x00EABBD0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballLimitedRewardView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballLimitedRewardView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034744 RID: 214852 RVA: 0x00EADA0B File Offset: 0x00EABC0B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06034745 RID: 214853 RVA: 0x00EADA29 File Offset: 0x00EABC29
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06034746 RID: 214854 RVA: 0x00EADA48 File Offset: 0x00EABC48
		protected override void OnTick(float delta)
		{
			if (this.ActivityData == null)
			{
				base.CloseMe(null);
				return;
			}
			if (!this.ActivityData.CheckIfInRewardTime())
			{
				base.CloseMe(null);
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndRewardTime, localTextNew);
			UUIText text = base.GetText(4);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeText, true);
		}

		// Token: 0x06034747 RID: 214855 RVA: 0x00EADAB0 File Offset: 0x00EABCB0
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (id != this.ActivityData.Id)
			{
				return;
			}
			this.RefreshView(false);
		}

		// Token: 0x06034748 RID: 214856 RVA: 0x00EADAC8 File Offset: 0x00EABCC8
		private void RefreshView(bool isPlayAnim = false)
		{
			List<PinballTaskData> timeLimitTaskList = this.ActivityData.GetTimeLimitTaskList();
			List<PinballTaskData> list = new List<PinballTaskData>();
			foreach (PinballTaskData pinballTaskData in timeLimitTaskList)
			{
				if (pinballTaskData.TaskTab != EPinballTaskTab.BigReward)
				{
					list.Add(pinballTaskData);
				}
			}
			this.TaskLayout.RefreshByData(list, delegate
			{
				UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
				if (scrollViewWithScrollbar == null)
				{
					return;
				}
				scrollViewWithScrollbar.SetScrollProgress(0f);
			}, isPlayAnim);
			this.RefreshProgress();
			this.RefreshBigRewardTask();
			this.RefreshBigRewardHeader();
		}

		// Token: 0x06034749 RID: 214857 RVA: 0x00EADB5C File Offset: 0x00EABD5C
		private void RefreshBigRewardHeader()
		{
			int bigRewardFirstItemConfigId = this.GetBigRewardFirstItemConfigId();
			UUITexture texture = base.GetTexture(5);
			UUIText text = base.GetText(6);
			if (bigRewardFirstItemConfigId <= 0)
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(bigRewardFirstItemConfigId);
			if (itemConfigData == null)
			{
				if (texture != null)
				{
					texture.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text, itemConfigData.Name, Array.Empty<object>());
			if (!string.IsNullOrEmpty(itemConfigData.Icon) && texture != null)
			{
				texture.SetUIActive(true);
				base.SetTextureByPath(itemConfigData.Icon, texture, null, null);
				return;
			}
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
		}

		// Token: 0x0603474A RID: 214858 RVA: 0x00EADC18 File Offset: 0x00EABE18
		private int GetBigRewardFirstItemConfigId()
		{
			PinballTaskData pinballTaskData = null;
			PinballActivityData activityData = this.ActivityData;
			List<PinballTaskData> list = (activityData != null) ? activityData.GetTimeLimitTaskList() : null;
			if (list != null)
			{
				foreach (PinballTaskData pinballTaskData2 in list)
				{
					if (pinballTaskData2.TaskTab == EPinballTaskTab.BigReward)
					{
						pinballTaskData = pinballTaskData2;
						break;
					}
				}
			}
			TItem? titem;
			if (pinballTaskData == null)
			{
				titem = null;
			}
			else
			{
				List<TItem> rewardList = pinballTaskData.RewardList;
				titem = ((rewardList != null) ? new TItem?(rewardList[0]) : null);
			}
			TItem? titem2 = titem;
			int? num;
			if (titem2 == null)
			{
				num = null;
			}
			else
			{
				InventoryDefine.IGetItemData itemData = titem2.GetValueOrDefault().ItemData;
				num = ((itemData != null) ? new int?(itemData.ItemId) : null);
			}
			int? num2 = num;
			if (num2 != null)
			{
				int? num3 = num2;
				int num4 = 0;
				if (num3.GetValueOrDefault() > num4 & num3 != null)
				{
					return num2.Value;
				}
			}
			return 0;
		}

		// Token: 0x0603474B RID: 214859 RVA: 0x00EADD24 File Offset: 0x00EABF24
		private void RefreshBigRewardTask()
		{
			List<PinballTaskData> timeLimitTaskList = this.ActivityData.GetTimeLimitTaskList();
			PinballTaskData pinballTaskData = null;
			foreach (PinballTaskData pinballTaskData2 in timeLimitTaskList)
			{
				if (pinballTaskData2.TaskTab == EPinballTaskTab.BigReward)
				{
					pinballTaskData = pinballTaskData2;
					break;
				}
			}
			UUIItem item = base.GetItem(12);
			UUIText text = base.GetText(11);
			if (pinballTaskData != null)
			{
				UUIText text2 = base.GetText(7);
				if (!string.IsNullOrEmpty(pinballTaskData.QuestNameTextKey))
				{
					LguiUtil.Instance.SetLocalTextNew(text2, pinballTaskData.QuestNameTextKey, Array.Empty<object>());
				}
				else if (text2 != null)
				{
					text2.SetText(pinballTaskData.QuestName, true);
				}
				UUIButtonComponent button = base.GetButton(9);
				if (item != null)
				{
					item.SetUIActive(pinballTaskData.IsFinished);
				}
				if (text != null)
				{
					text.SetUIActive(pinballTaskData.IsDoing);
				}
				if (pinballTaskData.IsDoing)
				{
					LguiUtil.Instance.SetLocalTextNew(text, "Pinball_Reward_Limited_bigaward", Array.Empty<object>());
				}
				if (button != null)
				{
					bool flag;
					if (pinballTaskData.IsUnclaimed)
					{
						ConditionTask data = pinballTaskData.Data;
						if (data == null)
						{
							flag = false;
						}
						else
						{
							int id = data.Id;
							flag = true;
						}
					}
					else
					{
						flag = false;
					}
					bool flag2 = flag;
					UUIItem uuiitem = button.RootUIComp.Get();
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(flag2);
					}
					button.SetSelfInteractive(flag2);
					return;
				}
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(9);
				if (button2 != null)
				{
					UUIItem uuiitem2 = button2.RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(false);
					}
				}
				if (item != null)
				{
					item.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603474C RID: 214860 RVA: 0x00EADEB0 File Offset: 0x00EAC0B0
		private void RefreshProgress()
		{
			PinballTaskData pinballTaskData = null;
			foreach (PinballTaskData pinballTaskData2 in this.ActivityData.GetTimeLimitTaskList())
			{
				if (pinballTaskData2.TaskTab == EPinballTaskTab.BigReward)
				{
					pinballTaskData = pinballTaskData2;
					break;
				}
			}
			int num = (pinballTaskData != null) ? pinballTaskData.Target : 0;
			int num2 = (pinballTaskData != null) ? pinballTaskData.Current : 0;
			int num3 = (num > 0) ? Math.Min(num2, num) : num2;
			UUIText text = base.GetText(8);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			float fillAmount = (num > 0) ? ((float)num3 / (float)num) : 0f;
			UUISprite sprite = base.GetSprite(10);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(fillAmount);
		}

		// Token: 0x0603474D RID: 214861 RVA: 0x00EADFA4 File Offset: 0x00EAC1A4
		private PinballLimitedRewardTaskItem CreateTaskItem()
		{
			return new PinballLimitedRewardTaskItem
			{
				OnTaskRewardClick = new Func<int, UniTask>(this.OnTaskRewardBtnClick)
			};
		}

		// Token: 0x0603474E RID: 214862 RVA: 0x00EADFC0 File Offset: 0x00EAC1C0
		private UniTask OnTaskRewardBtnClick(int taskId)
		{
			PinballLimitedRewardView.<OnTaskRewardBtnClick>d__17 <OnTaskRewardBtnClick>d__;
			<OnTaskRewardBtnClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnTaskRewardBtnClick>d__.<>4__this = this;
			<OnTaskRewardBtnClick>d__.<>1__state = -1;
			<OnTaskRewardBtnClick>d__.<>t__builder.Start<PinballLimitedRewardView.<OnTaskRewardBtnClick>d__17>(ref <OnTaskRewardBtnClick>d__);
			return <OnTaskRewardBtnClick>d__.<>t__builder.Task;
		}

		// Token: 0x0603474F RID: 214863 RVA: 0x00EAE004 File Offset: 0x00EAC204
		private void OnBigRewardBtnClick()
		{
			UiAsyncTask task = new UiAsyncTask("PinballLimitedRewardView.RequestBigReward", delegate()
			{
				PinballLimitedRewardView.<<OnBigRewardBtnClick>b__18_0>d <<OnBigRewardBtnClick>b__18_0>d;
				<<OnBigRewardBtnClick>b__18_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<OnBigRewardBtnClick>b__18_0>d.<>4__this = this;
				<<OnBigRewardBtnClick>b__18_0>d.<>1__state = -1;
				<<OnBigRewardBtnClick>b__18_0>d.<>t__builder.Start<PinballLimitedRewardView.<<OnBigRewardBtnClick>b__18_0>d>(ref <<OnBigRewardBtnClick>b__18_0>d);
				return <<OnBigRewardBtnClick>b__18_0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06034750 RID: 214864 RVA: 0x00EAE035 File Offset: 0x00EAC235
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034751 RID: 214865 RVA: 0x00EAE040 File Offset: 0x00EAC240
		private void OnPreviewBtnClick()
		{
			PinballActivityData activityData = this.ActivityData;
			int num = (activityData != null) ? activityData.GetTitleTipId() : 0;
			if (num > 0)
			{
				ItemController.Instance.OpenTitleTipsByItemId(num);
			}
		}

		// Token: 0x06034752 RID: 214866 RVA: 0x00EAE070 File Offset: 0x00EAC270
		private void OnBigRewardItemTipsClick()
		{
			int bigRewardFirstItemConfigId = this.GetBigRewardFirstItemConfigId();
			if (bigRewardFirstItemConfigId > 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(bigRewardFirstItemConfigId, true, null, false);
			}
		}

		// Token: 0x0401BD60 RID: 114016
		[Nullable(2)]
		private PinballActivityData ActivityData;

		// Token: 0x0401BD61 RID: 114017
		private GenericScrollViewNew<PinballLimitedRewardTaskItem, PinballTaskData> TaskLayout;

		// Token: 0x0200AE9A RID: 44698
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035F0B RID: 220939
			ItemCaption,
			// Token: 0x04035F0C RID: 220940
			RewardItemScroll,
			// Token: 0x04035F0D RID: 220941
			RewardItem,
			// Token: 0x04035F0E RID: 220942
			BtnCommon,
			// Token: 0x04035F0F RID: 220943
			TxtTime,
			// Token: 0x04035F10 RID: 220944
			TextureIcon,
			// Token: 0x04035F11 RID: 220945
			TxName,
			// Token: 0x04035F12 RID: 220946
			TxMission,
			// Token: 0x04035F13 RID: 220947
			TxNum,
			// Token: 0x04035F14 RID: 220948
			BtnConfirmBase,
			// Token: 0x04035F15 RID: 220949
			SpBar,
			// Token: 0x04035F16 RID: 220950
			PanelBigRewardUndone,
			// Token: 0x04035F17 RID: 220951
			PanelBigRewardDone,
			// Token: 0x04035F18 RID: 220952
			BtnMonsterHead
		}
	}
}
