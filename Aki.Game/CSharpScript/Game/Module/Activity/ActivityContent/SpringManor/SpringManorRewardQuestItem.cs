using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FEB RID: 20459
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorRewardQuestItem : GridProxyAbstract<int>
	{
		// Token: 0x060333AB RID: 209835 RVA: 0x00E5BE70 File Offset: 0x00E5A070
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickSkip));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060333AC RID: 209836 RVA: 0x00E5BFBC File Offset: 0x00E5A1BC
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorRewardQuestItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorRewardQuestItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060333AD RID: 209837 RVA: 0x00E5C000 File Offset: 0x00E5A200
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(6), () => new CommonItemSmallItemGrid(), null, false, null);
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			ButtonItem receiveButton = this.ReceiveButton;
			if (receiveButton == null)
			{
				return;
			}
			receiveButton.SetRedDotVisible(true);
		}

		// Token: 0x060333AE RID: 209838 RVA: 0x00E5C068 File Offset: 0x00E5A268
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			ActivitySpringManorTaskData rewardTaskData = SpringManorModel.Instance.ActivityData.GetRewardTaskData(data);
			if (rewardTaskData == null)
			{
				return;
			}
			SpringFestivalReward? rewardTaskConfigById = SpringManorConfig.Instance.GetRewardTaskConfigById(data);
			if (rewardTaskConfigById == null)
			{
				return;
			}
			this.TaskId = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rewardTaskConfigById.Value.Desc, Array.Empty<object>());
			UUIText text = base.GetText(5);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardTaskData.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(rewardTaskData.Target);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			List<TItem> dropPackagePreviewItemList = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(rewardTaskConfigById.Value.DropId);
			GenericScrollViewNew<CommonItemSmallItemGrid, TItem> rewardScroll = this.RewardScroll;
			if (rewardScroll != null)
			{
				rewardScroll.RefreshByData(dropPackagePreviewItemList, null, false);
			}
			bool uiActive = rewardTaskData.Status == EActivityTaskState.FinishedAndUnclaimed;
			bool uiactive = rewardTaskData.Status == EActivityTaskState.FinishedAndClaimed;
			bool flag = rewardTaskData.Status == EActivityTaskState.Active;
			bool flag2 = rewardTaskConfigById.Value.SkipType > 0;
			ButtonItem receiveButton = this.ReceiveButton;
			if (receiveButton != null)
			{
				receiveButton.SetUiActive(uiActive);
			}
			base.GetButton(0).RootUIComp.Get().SetUIActive(flag && flag2);
			base.GetItem(2).SetUIActive(flag && !flag2);
			base.GetItem(3).SetUIActive(uiactive);
		}

		// Token: 0x060333AF RID: 209839 RVA: 0x00E5C1CB File Offset: 0x00E5A3CB
		[NullableContext(1)]
		public void SetReceiveClickCallback(Action callback)
		{
			this.ReceiveClickCallback = callback;
		}

		// Token: 0x060333B0 RID: 209840 RVA: 0x00E5C1D4 File Offset: 0x00E5A3D4
		private void OnClickSkip()
		{
			if (this.TaskId == 0)
			{
				return;
			}
			if (!SpringManorModel.Instance.CheckInInstance())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Spring26_BanSkipTips", Array.Empty<object>());
				return;
			}
			SpringFestivalReward? rewardTaskConfigById = SpringManorConfig.Instance.GetRewardTaskConfigById(this.TaskId);
			if (rewardTaskConfigById == null)
			{
				return;
			}
			int skipType = rewardTaskConfigById.Value.SkipType;
			if (skipType != 1)
			{
				if (skipType == 2)
				{
					SpringManorController.Instance.TrackRewardTask(this.TaskId);
				}
			}
			else
			{
				EUiViewName name = (EUiViewName)rewardTaskConfigById.Value.SkipParam(0);
				int skipParamLength = rewardTaskConfigById.Value.SkipParamLength;
				if (skipParamLength == 1)
				{
					UiManager.Instance.OpenView(name, null, null);
				}
				else if (skipParamLength == 2)
				{
					string text = rewardTaskConfigById.Value.SkipParam(1);
					double num;
					object param;
					if (double.TryParse(text, out num))
					{
						param = num;
					}
					else
					{
						param = text;
					}
					UiManager.Instance.OpenView(name, param, null);
				}
				else
				{
					List<string> list = new List<string>();
					for (int i = 1; i < rewardTaskConfigById.Value.SkipParamLength; i++)
					{
						list.Add(rewardTaskConfigById.Value.SkipParam(i));
					}
					UiManager.Instance.OpenView(name, list.ToArray(), null);
				}
			}
			Action<ESpringRewardTaskSkipType> onSkipClick = this.OnSkipClick;
			if (onSkipClick == null)
			{
				return;
			}
			onSkipClick((ESpringRewardTaskSkipType)rewardTaskConfigById.Value.SkipType);
		}

		// Token: 0x060333B1 RID: 209841 RVA: 0x00E5C349 File Offset: 0x00E5A549
		private void OnClickReceive(int _)
		{
			Action receiveClickCallback = this.ReceiveClickCallback;
			if (receiveClickCallback == null)
			{
				return;
			}
			receiveClickCallback();
		}

		// Token: 0x0401B35D RID: 111453
		private int TaskId;

		// Token: 0x0401B35E RID: 111454
		private Action ReceiveClickCallback;

		// Token: 0x0401B35F RID: 111455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401B360 RID: 111456
		private ButtonItem ReceiveButton;

		// Token: 0x0401B361 RID: 111457
		public Action<ESpringRewardTaskSkipType> OnSkipClick;
	}
}
