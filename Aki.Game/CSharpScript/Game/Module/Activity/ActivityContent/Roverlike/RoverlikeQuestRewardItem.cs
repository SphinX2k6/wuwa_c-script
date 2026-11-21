using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050F0 RID: 20720
	public class RoverlikeQuestRewardItem : GridProxyAbstract<int>
	{
		// Token: 0x06033DB0 RID: 212400 RVA: 0x00E83D88 File Offset: 0x00E81F88
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033DB1 RID: 212401 RVA: 0x00E83EF4 File Offset: 0x00E820F4
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
			this.GetBtnItem = new ButtonItem(base.GetItem(7));
			this.GetBtnItem.SetFunction(delegate(int _)
			{
				this.OnClickGetBtn();
			});
		}

		// Token: 0x06033DB2 RID: 212402 RVA: 0x00E83F4B File Offset: 0x00E8214B
		[NullableContext(1)]
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid
			{
				ShowReceivedCallBack = ((TItem _) => this.IsTaken)
			};
		}

		// Token: 0x06033DB3 RID: 212403 RVA: 0x00E83F64 File Offset: 0x00E82164
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.TaskId = data;
			RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
			ConditionTask conditionTask = (currentActivityData != null) ? currentActivityData.QuestData.GetTask(this.TaskId) : null;
			RoverRogueReward? rewardConfig = RoverlikeConfig.Instance.GetRewardConfig(this.TaskId);
			if (conditionTask == null || rewardConfig == null)
			{
				return;
			}
			RoverRogueReward value = rewardConfig.Value;
			bool flag = conditionTask.Status == ConditionTaskState.ConditionTaskTaken;
			bool flag2 = conditionTask.Status == ConditionTaskState.ConditionTaskFinish;
			bool uiactive = conditionTask.Status == ConditionTaskState.ConditionTaskRunning;
			this.IsTaken = flag;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), value.Name, Array.Empty<object>());
			UUIText text = base.GetText(8);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(conditionTask.Current);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(conditionTask.Target);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(value.DropId);
			this.RewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.useChangeColor = flag;
				text2.outlineSize = (flag ? 0 : 3);
			}
			UUIText text3 = base.GetText(8);
			if (text3 != null)
			{
				text3.useChangeColor = flag;
			}
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetUIActive(flag);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			ButtonItem getBtnItem = this.GetBtnItem;
			if (getBtnItem != null)
			{
				getBtnItem.SetUiActive(flag2);
			}
			ButtonItem getBtnItem2 = this.GetBtnItem;
			if (getBtnItem2 != null)
			{
				getBtnItem2.SetRedDotVisible(flag2);
			}
			UUIText text4 = base.GetText(1);
			if (text4 != null)
			{
				text4.SetUIActive(uiactive);
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(false);
		}

		// Token: 0x06033DB4 RID: 212404 RVA: 0x00E8412C File Offset: 0x00E8232C
		public override void Clear()
		{
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScroll = this.RewardScroll;
			if (rewardScroll == null)
			{
				return;
			}
			rewardScroll.RefreshByData(new List<TItem>(), null, false);
		}

		// Token: 0x06033DB5 RID: 212405 RVA: 0x00E84145 File Offset: 0x00E82345
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06033DB6 RID: 212406 RVA: 0x00E84150 File Offset: 0x00E82350
		private void OnClickGetBtn()
		{
			RoverlikeActivityController instance = RoverlikeActivityController.Instance;
			RoverlikeActivityData roverlikeActivityData = (instance != null) ? instance.GetCurrentActivityData() : null;
			List<int> list = ((roverlikeActivityData != null) ? roverlikeActivityData.QuestData.GetAllTakeableTaskIds() : null) ?? new List<int>();
			if (list.Count == 0)
			{
				return;
			}
			RoverlikeController.Instance.RequestTaskRewardTake(list, null);
		}

		// Token: 0x06033DB7 RID: 212407 RVA: 0x00E8419E File Offset: 0x00E8239E
		private void OnClickJumpBtn()
		{
		}

		// Token: 0x0401B75E RID: 112478
		private int TaskId;

		// Token: 0x0401B75F RID: 112479
		private bool IsTaken;

		// Token: 0x0401B760 RID: 112480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401B761 RID: 112481
		[Nullable(2)]
		private ButtonItem GetBtnItem;

		// Token: 0x0200ADC2 RID: 44482
		private class EComponent
		{
			// Token: 0x04035AFA RID: 219898
			public const int JumpBtn = 0;

			// Token: 0x04035AFB RID: 219899
			public const int DoingText = 1;

			// Token: 0x04035AFC RID: 219900
			public const int SpriteDone = 2;

			// Token: 0x04035AFD RID: 219901
			public const int ItemDone = 3;

			// Token: 0x04035AFE RID: 219902
			public const int NameText = 4;

			// Token: 0x04035AFF RID: 219903
			public const int RewardScroll = 5;

			// Token: 0x04035B00 RID: 219904
			public const int GetBtn = 7;

			// Token: 0x04035B01 RID: 219905
			public const int ProgressText = 8;
		}
	}
}
