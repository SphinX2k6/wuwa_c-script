using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053EC RID: 21484
	[NullableContext(2)]
	[Nullable(0)]
	public class MoonSignInSubView : ActivitySubViewBase
	{
		// Token: 0x0603566F RID: 218735 RVA: 0x00EEA8B8 File Offset: 0x00EE8AB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
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
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickRewardBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035670 RID: 218736 RVA: 0x00EEAA8C File Offset: 0x00EE8C8C
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035671 RID: 218737 RVA: 0x00EEAAD0 File Offset: 0x00EE8CD0
		protected override void OnStart()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			base.GetItem(9).SetUIActive(flag);
			base.GetItem(10).SetUIActive(!flag);
			if (flag)
			{
				base.GetSpine(7).SetAnimation(0, "Idle", true);
				return;
			}
			base.GetSpine(8).SetAnimation(0, "Idle", true);
		}

		// Token: 0x06035672 RID: 218738 RVA: 0x00EEAB36 File Offset: 0x00EE8D36
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06035673 RID: 218739 RVA: 0x00EEAB40 File Offset: 0x00EE8D40
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.SetActivityViewCurrency, new <>z__ReadOnlySingleElementList<int>((this.ActivityBaseData as MoonSignInData).UseItemId));
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			if (localConfig == null)
			{
				return;
			}
			this.RefreshDesc();
			this.RefreshTitle();
			this.RefreshReward();
			this.RefreshState();
			this.RefreshRewardBtnText();
			this.RefreshRewardBtnRedDotState();
		}

		// Token: 0x06035674 RID: 218740 RVA: 0x00EEABAC File Offset: 0x00EE8DAC
		private void RefreshDesc()
		{
			Activity value = this.ActivityBaseData.LocalConfig.Value;
			string descTheme = value.DescTheme;
			string desc = value.Desc;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		}

		// Token: 0x06035675 RID: 218741 RVA: 0x00EEAC15 File Offset: 0x00EE8E15
		private void RefreshTitle()
		{
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.RefreshTimerText();
		}

		// Token: 0x06035676 RID: 218742 RVA: 0x00EEAC44 File Offset: 0x00EE8E44
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06035677 RID: 218743 RVA: 0x00EEAC80 File Offset: 0x00EE8E80
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06035678 RID: 218744 RVA: 0x00EEACB0 File Offset: 0x00EE8EB0
		private void RefreshState()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			this.FunctionalComponent.SetPanelConditionVisible(!flag);
			if (!flag)
			{
				this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
			}
			this.FunctionalComponent.FunctionButton.SetUiActive(flag);
		}

		// Token: 0x06035679 RID: 218745 RVA: 0x00EEAD10 File Offset: 0x00EE8F10
		private void RefreshRewardBtnText()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			base.GetText(5).SetText(data.GetMoonPhaseProgress(), true);
		}

		// Token: 0x0603567A RID: 218746 RVA: 0x00EEAD40 File Offset: 0x00EE8F40
		private void RefreshRewardBtnRedDotState()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			base.GetItem(6).SetUIActive(data.GetCanGetMoonGrandReward());
			this.FunctionalComponent.SetFunctionRedDotVisible(data.GetAnyRedDot());
		}

		// Token: 0x0603567B RID: 218747 RVA: 0x00EEAD7F File Offset: 0x00EE8F7F
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.MoonSignInMainView, null, null);
			});
		}

		// Token: 0x0603567C RID: 218748 RVA: 0x00EEADA0 File Offset: 0x00EE8FA0
		private void OnClickRewardBtn()
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MoonSignInRewardView, null, null);
		}

		// Token: 0x0401C28F RID: 115343
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401C290 RID: 115344
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401C291 RID: 115345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401C292 RID: 115346
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0200B07F RID: 45183
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040368B6 RID: 223414
			public const int TitleItem = 0;

			// Token: 0x040368B7 RID: 223415
			public const int DescItem = 1;

			// Token: 0x040368B8 RID: 223416
			public const int RewardItem = 2;

			// Token: 0x040368B9 RID: 223417
			public const int FunctionalAreaItem = 3;

			// Token: 0x040368BA RID: 223418
			public const int RewardBtn = 4;

			// Token: 0x040368BB RID: 223419
			public const int RewardBtnText = 5;

			// Token: 0x040368BC RID: 223420
			public const int RewardRedDotItem = 6;

			// Token: 0x040368BD RID: 223421
			public const int MaleSpine = 7;

			// Token: 0x040368BE RID: 223422
			public const int FemaleSpine = 8;

			// Token: 0x040368BF RID: 223423
			public const int MaleItem = 9;

			// Token: 0x040368C0 RID: 223424
			public const int FemaleItem = 10;
		}
	}
}
