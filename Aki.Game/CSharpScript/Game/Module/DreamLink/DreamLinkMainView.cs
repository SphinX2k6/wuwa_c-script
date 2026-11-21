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
	// Token: 0x02004A83 RID: 19075
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkMainView : UiViewBase
	{
		// Token: 0x0602FBD6 RID: 195542 RVA: 0x00D51B32 File Offset: 0x00D4FD32
		public DreamLinkMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FBD7 RID: 195543 RVA: 0x00D51B3C File Offset: 0x00D4FD3C
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

		// Token: 0x0602FBD8 RID: 195544 RVA: 0x00D51C6C File Offset: 0x00D4FE6C
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkMainView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkMainView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBD9 RID: 195545 RVA: 0x00D51CB0 File Offset: 0x00D4FEB0
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

		// Token: 0x0602FBDA RID: 195546 RVA: 0x00D51D22 File Offset: 0x00D4FF22
		protected override void OnBeforeShow()
		{
			this.LimitTimeRewardItem.RefreshActive();
			this.RefreshButtonState();
			this.RefreshStage();
		}

		// Token: 0x0602FBDB RID: 195547 RVA: 0x00D51D3B File Offset: 0x00D4FF3B
		protected override void OnBeforeHide()
		{
			this.LimitTimeRewardItem.SetActive(false);
			this.ClearDelayHandle();
		}

		// Token: 0x0602FBDC RID: 195548 RVA: 0x00D51D4F File Offset: 0x00D4FF4F
		private void OnClickProgress1()
		{
			this.OpenFunctionView(1, EUiViewName.DreamLinkWorldRunView);
		}

		// Token: 0x0602FBDD RID: 195549 RVA: 0x00D51D5D File Offset: 0x00D4FF5D
		private void OnClickProgress2()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("MowingTowerMultiTips", Array.Empty<object>());
				return;
			}
			this.OpenFunctionView(2, EUiViewName.DreamLinkDungeonView);
		}

		// Token: 0x0602FBDE RID: 195550 RVA: 0x00D51D8C File Offset: 0x00D4FF8C
		private void OnClickProgress3()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsById("MowingTowerMultiTips", Array.Empty<object>());
				return;
			}
			this.OpenFunctionView(3, EUiViewName.DreamLinkWhiteCatView);
		}

		// Token: 0x0602FBDF RID: 195551 RVA: 0x00D51DBC File Offset: 0x00D4FFBC
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

		// Token: 0x0602FBE0 RID: 195552 RVA: 0x00D51E5F File Offset: 0x00D5005F
		private void ClearDelayHandle()
		{
			if (this.DelayOpenHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.DelayOpenHandle);
				this.DelayOpenHandle = null;
			}
		}

		// Token: 0x0602FBE1 RID: 195553 RVA: 0x00D51E84 File Offset: 0x00D50084
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

		// Token: 0x0602FBE2 RID: 195554 RVA: 0x00D51FC4 File Offset: 0x00D501C4
		private void RefreshStage()
		{
			bool flag = this.Data.GetInstStage() == EDreamLinkStage.First;
			base.GetItem(6).SetUIActive(flag);
			base.GetItem(7).SetUIActive(!flag);
		}

		// Token: 0x0401958E RID: 103822
		public PopupCaptionItem CaptionComponent;

		// Token: 0x0401958F RID: 103823
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x04019590 RID: 103824
		private DreamLinkLimitTimeRewardItem LimitTimeRewardItem;

		// Token: 0x04019591 RID: 103825
		private DreamLinkButton MainButton1;

		// Token: 0x04019592 RID: 103826
		private DreamLinkButton MainButton2;

		// Token: 0x04019593 RID: 103827
		private DreamLinkButton MainButton3;

		// Token: 0x04019594 RID: 103828
		private DreamLinkData Data;

		// Token: 0x04019595 RID: 103829
		private TimerHandle DelayOpenHandle;

		// Token: 0x0200A6F0 RID: 42736
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033968 RID: 211304
			public const int CaptionItem = 0;

			// Token: 0x04033969 RID: 211305
			public const int ButtonProgress1 = 1;

			// Token: 0x0403396A RID: 211306
			public const int ButtonProgress2 = 2;

			// Token: 0x0403396B RID: 211307
			public const int ButtonProgress3 = 3;

			// Token: 0x0403396C RID: 211308
			public const int PermanentReward = 4;

			// Token: 0x0403396D RID: 211309
			public const int LimitTimeReward = 5;

			// Token: 0x0403396E RID: 211310
			public const int PanelStage1 = 6;

			// Token: 0x0403396F RID: 211311
			public const int PanelStage2 = 7;
		}
	}
}
