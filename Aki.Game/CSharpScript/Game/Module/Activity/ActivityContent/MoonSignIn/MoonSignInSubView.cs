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
	// Token: 0x0200646E RID: 25710
	[NullableContext(2)]
	[Nullable(0)]
	public class MoonSignInSubView : ActivitySubViewBase
	{
		// Token: 0x060409AE RID: 264622 RVA: 0x00FA393C File Offset: 0x00FA1B3C
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

		// Token: 0x060409AF RID: 264623 RVA: 0x00FA3B10 File Offset: 0x00FA1D10
		protected override UniTask OnBeforeStartAsync()
		{
			MoonSignInSubView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoonSignInSubView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060409B0 RID: 264624 RVA: 0x00FA3B54 File Offset: 0x00FA1D54
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

		// Token: 0x060409B1 RID: 264625 RVA: 0x00FA3BBA File Offset: 0x00FA1DBA
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x060409B2 RID: 264626 RVA: 0x00FA3BC4 File Offset: 0x00FA1DC4
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

		// Token: 0x060409B3 RID: 264627 RVA: 0x00FA3C30 File Offset: 0x00FA1E30
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

		// Token: 0x060409B4 RID: 264628 RVA: 0x00FA3C99 File Offset: 0x00FA1E99
		private void RefreshTitle()
		{
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.RefreshTimerText();
		}

		// Token: 0x060409B5 RID: 264629 RVA: 0x00FA3CC8 File Offset: 0x00FA1EC8
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

		// Token: 0x060409B6 RID: 264630 RVA: 0x00FA3D04 File Offset: 0x00FA1F04
		private void RefreshReward()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x060409B7 RID: 264631 RVA: 0x00FA3D34 File Offset: 0x00FA1F34
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

		// Token: 0x060409B8 RID: 264632 RVA: 0x00FA3D94 File Offset: 0x00FA1F94
		private void RefreshRewardBtnText()
		{
			MoonSignInData data = MoonSignInController.Instance.GetData();
			if (data == null)
			{
				return;
			}
			base.GetText(5).SetText(data.GetMoonPhaseProgress(), true);
		}

		// Token: 0x060409B9 RID: 264633 RVA: 0x00FA3DC4 File Offset: 0x00FA1FC4
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

		// Token: 0x060409BA RID: 264634 RVA: 0x00FA3E03 File Offset: 0x00FA2003
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

		// Token: 0x060409BB RID: 264635 RVA: 0x00FA3E24 File Offset: 0x00FA2024
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

		// Token: 0x04021960 RID: 137568
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04021961 RID: 137569
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04021962 RID: 137570
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04021963 RID: 137571
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0200C699 RID: 50841
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403BF5B RID: 245595
			public const int TitleItem = 0;

			// Token: 0x0403BF5C RID: 245596
			public const int DescItem = 1;

			// Token: 0x0403BF5D RID: 245597
			public const int RewardItem = 2;

			// Token: 0x0403BF5E RID: 245598
			public const int FunctionalAreaItem = 3;

			// Token: 0x0403BF5F RID: 245599
			public const int RewardBtn = 4;

			// Token: 0x0403BF60 RID: 245600
			public const int RewardBtnText = 5;

			// Token: 0x0403BF61 RID: 245601
			public const int RewardRedDotItem = 6;

			// Token: 0x0403BF62 RID: 245602
			public const int MaleSpine = 7;

			// Token: 0x0403BF63 RID: 245603
			public const int FemaleSpine = 8;

			// Token: 0x0403BF64 RID: 245604
			public const int MaleItem = 9;

			// Token: 0x0403BF65 RID: 245605
			public const int FemaleItem = 10;
		}
	}
}
