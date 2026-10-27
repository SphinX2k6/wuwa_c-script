using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA7 RID: 23207
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkMainView : UiViewBase
	{
		// Token: 0x0603AC8A RID: 240778 RVA: 0x00E0157E File Offset: 0x00DFF77E
		public DreamLinkMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AC8B RID: 240779 RVA: 0x00E01588 File Offset: 0x00DFF788
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AC8C RID: 240780 RVA: 0x00E016B8 File Offset: 0x00DFF8B8
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC8D RID: 240781 RVA: 0x00E016FC File Offset: 0x00DFF8FC
		protected override void OnStart()
		{
			int? num = this.OpenParam as int?;
			if (num != null && num.Value == 1)
			{
				this.UiViewSequence.StartSequenceName = "Start01";
				this.UiViewSequence.CloseSequenceName = "Close01";
				return;
			}
			this.UiViewSequence.StartSequenceName = "Start02";
			this.UiViewSequence.CloseSequenceName = "Close02";
		}

		// Token: 0x0603AC8E RID: 240782 RVA: 0x00E0176E File Offset: 0x00DFF96E
		protected override void OnBeforeShow()
		{
			this.LimitTimeRewardItem.RefreshActive();
			this.RefreshButtonState();
			this.RefreshStage();
		}

		// Token: 0x0603AC8F RID: 240783 RVA: 0x00E01787 File Offset: 0x00DFF987
		protected override void OnBeforeHide()
		{
			this.LimitTimeRewardItem.SetActive(false);
			this.ClearDelayHandle();
		}

		// Token: 0x0603AC90 RID: 240784 RVA: 0x00E0179B File Offset: 0x00DFF99B
		private void OnClickProgress1()
		{
			this.OpenFunctionView(1, EUiViewName.DreamLinkWorldRunView);
		}

		// Token: 0x0603AC91 RID: 240785 RVA: 0x00E017A9 File Offset: 0x00DFF9A9
		private void OnClickProgress2()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("MowingTowerMultiTips", Array.Empty<object>());
				return;
			}
			this.OpenFunctionView(2, EUiViewName.DreamLinkDungeonView);
		}

		// Token: 0x0603AC92 RID: 240786 RVA: 0x00E017D8 File Offset: 0x00DFF9D8
		private void OnClickProgress3()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("MowingTowerMultiTips", Array.Empty<object>());
				return;
			}
			this.OpenFunctionView(3, EUiViewName.DreamLinkWhiteCatView);
		}

		// Token: 0x0603AC93 RID: 240787 RVA: 0x00E01808 File Offset: 0x00DFFA08
		private void OpenFunctionView(int id, EUiViewName viewName)
		{
			RogueWhiteCat activityConfig = this.Data.GetActivityConfig();
			bool flag = this.Data.IsDreamLinkFunctionUnlock(id);
			int num;
			int inConditionGroupId = activityConfig.OpenCondition().TryGetValue(id, out num) ? num : 0;
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(LevelGeneralCommons.GetConditionGroupHintText(inConditionGroupId), Array.Empty<object>());
				return;
			}
			base.PlaySequence("SwitchView", null, true);
			this.ClearDelayHandle();
			this.DelayOpenHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(viewName, null, null);
				this.DelayOpenHandle = null;
			}, 320f, null, null, true, 1f);
		}

		// Token: 0x0603AC94 RID: 240788 RVA: 0x00E018AB File Offset: 0x00DFFAAB
		private void ClearDelayHandle()
		{
			if (this.DelayOpenHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayOpenHandle);
				this.DelayOpenHandle = null;
			}
		}

		// Token: 0x0603AC95 RID: 240789 RVA: 0x00E018D0 File Offset: 0x00DFFAD0
		private void RefreshButtonState()
		{
			this.Data.GetActivityConfig();
			List<ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>>> list = new List<ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>>>();
			list.Add(new ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>>(1, this.MainButton1, () => this.Data.CheckHasRunRedDot(), () => this.Data.CheckHasRunFinished()));
			list.Add(new ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>>(2, this.MainButton2, () => this.Data.CheckDungeonRedDotState(), () => this.Data.IsAllInstFinished()));
			list.Add(new ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>>(3, this.MainButton3, () => this.Data.CheckHasBossReward() || this.Data.CheckAllBossInstRedDotState(), () => false));
			foreach (ValueTuple<int, DreamLinkButton, Func<bool>, Func<bool>> valueTuple in list)
			{
				int item = valueTuple.Item1;
				DreamLinkButton item2 = valueTuple.Item2;
				Func<bool> item3 = valueTuple.Item3;
				Func<bool> item4 = valueTuple.Item4;
				bool flag = this.Data.IsDreamLinkFunctionUnlock(item);
				item2.SetToggleEnable(flag);
				bool redDotState = false;
				if (flag)
				{
					redDotState = item3();
				}
				item2.SetRedDotState(redDotState);
				item2.SetFinishedState(item4());
			}
		}

		// Token: 0x0603AC96 RID: 240790 RVA: 0x00E01A10 File Offset: 0x00DFFC10
		private void RefreshStage()
		{
			bool flag = this.Data.GetInstStage() == EDreamLinkStage.First;
			base.GetItem(6).SetUIActive(flag);
			base.GetItem(7).SetUIActive(!flag);
		}

		// Token: 0x0401EAE7 RID: 125671
		public PopupCaptionItem CaptionComponent;

		// Token: 0x0401EAE8 RID: 125672
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x0401EAE9 RID: 125673
		private DreamLinkLimitTimeRewardItem LimitTimeRewardItem;

		// Token: 0x0401EAEA RID: 125674
		private DreamLinkButton MainButton1;

		// Token: 0x0401EAEB RID: 125675
		private DreamLinkButton MainButton2;

		// Token: 0x0401EAEC RID: 125676
		private DreamLinkButton MainButton3;

		// Token: 0x0401EAED RID: 125677
		private DreamLinkData Data;

		// Token: 0x0401EAEE RID: 125678
		private TimerHandle DelayOpenHandle;

		// Token: 0x0200BCE7 RID: 48359
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04038F9D RID: 233373
			public const int CaptionItem = 0;

			// Token: 0x04038F9E RID: 233374
			public const int ButtonProgress1 = 1;

			// Token: 0x04038F9F RID: 233375
			public const int ButtonProgress2 = 2;

			// Token: 0x04038FA0 RID: 233376
			public const int ButtonProgress3 = 3;

			// Token: 0x04038FA1 RID: 233377
			public const int PermanentReward = 4;

			// Token: 0x04038FA2 RID: 233378
			public const int LimitTimeReward = 5;

			// Token: 0x04038FA3 RID: 233379
			public const int PanelStage1 = 6;

			// Token: 0x04038FA4 RID: 233380
			public const int PanelStage2 = 7;
		}
	}
}
