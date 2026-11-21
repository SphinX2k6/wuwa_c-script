using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A3C RID: 23100
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolSpecialBehaviorAcceptView : SolarSchoolHideHudViewBase
	{
		// Token: 0x06038F4E RID: 233294 RVA: 0x00FF5141 File Offset: 0x00FF3341
		[NullableContext(1)]
		public SolarSchoolSpecialBehaviorAcceptView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038F4F RID: 233295 RVA: 0x00FF514C File Offset: 0x00FF334C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038F50 RID: 233296 RVA: 0x00FF53C8 File Offset: 0x00FF35C8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolSpecialBehaviorAcceptView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolSpecialBehaviorAcceptView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038F51 RID: 233297 RVA: 0x00FF540B File Offset: 0x00FF360B
		protected override void OnBeforeHide()
		{
			this.StopStarAnimation();
		}

		// Token: 0x06038F52 RID: 233298 RVA: 0x00FF5413 File Offset: 0x00FF3613
		protected override void OnBeforeDestroy()
		{
			this.StopStarAnimation();
			SolarSchoolRootViewModel rootViewModel = SolarSchoolGamePlayModel.Instance.RootViewModel;
			if (rootViewModel == null)
			{
				return;
			}
			Action snapTimeDisplay = rootViewModel.SnapTimeDisplay;
			if (snapTimeDisplay == null)
			{
				return;
			}
			snapTimeDisplay();
		}

		// Token: 0x06038F53 RID: 233299 RVA: 0x00FF543C File Offset: 0x00FF363C
		protected override void OnBeforeShow()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			SolarSchoolDateItem date = this.Date;
			if (date != null)
			{
				date.SetDateByDayIndex(timeData.DayIndex, timeData.DisplaySlot);
			}
			SolarSchoolAttrPanel scorePanel = this.ScorePanel;
			if (scorePanel != null)
			{
				scorePanel.RefreshAttr();
			}
			SolarSchoolSpecialBehaviorAcceptParam solarSchoolSpecialBehaviorAcceptParam = this.OpenParam as SolarSchoolSpecialBehaviorAcceptParam;
			if (solarSchoolSpecialBehaviorAcceptParam == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 特批接取界面打开参数缺失或类型错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.BehaviorId = solarSchoolSpecialBehaviorAcceptParam.BehaviorId;
			this.HideClose = solarSchoolSpecialBehaviorAcceptParam.HideClose;
			this.OnAccepted = solarSchoolSpecialBehaviorAcceptParam.OnAccepted;
			SolarSchoolCaptionItem caption = this.Caption;
			if (caption != null)
			{
				caption.SetBackVisible(!solarSchoolSpecialBehaviorAcceptParam.HideClose);
			}
			this.Refresh();
			if (solarSchoolSpecialBehaviorAcceptParam.HideClose && !SolarSchoolSpecialBehaviorCenter.Instance.CanAccept(this.BehaviorId))
			{
				SolarSchoolSpecialBehaviorCenter.Instance.LogAcceptFail(this.BehaviorId, "特批接取界面无关闭按钮但不满足接取条件，玩家将卡死");
			}
		}

		// Token: 0x06038F54 RID: 233300 RVA: 0x00FF5524 File Offset: 0x00FF3724
		private void CreateStarLayout()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(5);
			UUISprite sprite = base.GetSprite(6);
			AUIBaseActor auibaseActor = ((sprite != null) ? sprite.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.StarLayout = new GenericLayout<SolarSchoolStarItem, bool>(horizontalLayout, () => new SolarSchoolStarItem(), auibaseActor, false, true);
		}

		// Token: 0x06038F55 RID: 233301 RVA: 0x00FF5588 File Offset: 0x00FF3788
		private void CreateConditionLayout()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(9);
			UUIItem item = base.GetItem(10);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (gridLayout == null || auibaseActor == null)
			{
				return;
			}
			this.ConditionLayout = new GenericLayout<SolarSchoolSpecialBehaviorConditionItem, SolarSchoolAttrRequire?>(gridLayout, () => new SolarSchoolSpecialBehaviorConditionItem(), auibaseActor, false, true);
		}

		// Token: 0x06038F56 RID: 233302 RVA: 0x00FF55F0 File Offset: 0x00FF37F0
		private void CreateRewardLayout()
		{
			UUIGridLayout gridLayout = base.GetGridLayout(11);
			UUIItem item = base.GetItem(12);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (gridLayout == null || auibaseActor == null)
			{
				return;
			}
			this.RewardLayout = new GenericLayout<SolarSchoolSpecialBehaviorRewardItem, SolarSchoolReward>(gridLayout, () => new SolarSchoolSpecialBehaviorRewardItem(), auibaseActor, false, true);
		}

		// Token: 0x06038F57 RID: 233303 RVA: 0x00FF5658 File Offset: 0x00FF3858
		private void Refresh()
		{
			SolarSchoolSpecialBehaviorCenter instance = SolarSchoolSpecialBehaviorCenter.Instance;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			SolarSchoolBehavior? currentLevelRow = playerData.GetCurrentLevelRow(this.BehaviorId);
			if (currentLevelRow == null)
			{
				return;
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(playerData.GetBehaviorNameWithLevel(this.BehaviorId), true);
			}
			UUIText text2 = base.GetText(14);
			if (text2 != null)
			{
				text2.SetText(SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.TargetText), true);
			}
			UUIText text3 = base.GetText(13);
			if (text3 != null)
			{
				text3.SetText(SolarSchoolUtils.GetTextWithPlaceholder(currentLevelRow.Value.DescText), true);
			}
			this.RefreshStars(currentLevelRow.Value.StarLevel);
			this.RefreshDeadline(instance);
			this.RefreshReward(currentLevelRow.Value.RewardFinish);
			GenericLayout<SolarSchoolSpecialBehaviorConditionItem, SolarSchoolAttrRequire?> conditionLayout = this.ConditionLayout;
			if (conditionLayout != null)
			{
				conditionLayout.RefreshByData(this.BuildConditionDisplayList(instance.GetAcceptAttrRequireList(this.BehaviorId)), null, false);
			}
			UUIButtonComponent button = base.GetButton(8);
			if (button == null)
			{
				return;
			}
			button.SetEnable(instance.CanAccept(this.BehaviorId));
		}

		// Token: 0x06038F58 RID: 233304 RVA: 0x00FF5770 File Offset: 0x00FF3970
		private unsafe void RefreshReward(int rewardGroupId)
		{
			List<SolarSchoolReward> list = new List<SolarSchoolReward>();
			foreach (SolarSchoolReward item in SolarSchoolRewardCenter.Instance.GetRewardPreview(rewardGroupId))
			{
				if (item.RewardType == 4)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批完成奖励组配了 Buff，接取界面无法展示";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("rewardGroupId", rewardGroupId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("rewardId", item.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("buffId", item.TargetId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				}
				else if (item.Value != 0)
				{
					list.Add(item);
				}
			}
			GenericLayout<SolarSchoolSpecialBehaviorRewardItem, SolarSchoolReward> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06038F59 RID: 233305 RVA: 0x00FF58AC File Offset: 0x00FF3AAC
		[NullableContext(1)]
		private List<SolarSchoolAttrRequire?> BuildConditionDisplayList(List<SolarSchoolAttrRequire> requireList)
		{
			List<SolarSchoolAttrRequire?> list = new List<SolarSchoolAttrRequire?>();
			using (List<SolarSchoolAttrRequire>.Enumerator enumerator = requireList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					SolarSchoolAttrRequire value = enumerator.Current;
					list.Add(new SolarSchoolAttrRequire?(value));
				}
				goto IL_4B;
			}
			IL_3C:
			list.Add(null);
			IL_4B:
			if (list.Count >= 5)
			{
				return list;
			}
			goto IL_3C;
		}

		// Token: 0x06038F5A RID: 233306 RVA: 0x00FF5920 File Offset: 0x00FF3B20
		private void RefreshStars(int starLevel)
		{
			SolarSchoolSpecialBehaviorAcceptView.<>c__DisplayClass24_0 CS$<>8__locals1 = new SolarSchoolSpecialBehaviorAcceptView.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			List<bool> list = new List<bool>();
			for (int i = 0; i < starLevel; i++)
			{
				list.Add(true);
			}
			SolarSchoolSpecialBehaviorAcceptView.<>c__DisplayClass24_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.StarAnimationVersion + 1;
			this.StarAnimationVersion = num;
			CS$<>8__locals2.version = num;
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			if (starLayout == null)
			{
				return;
			}
			starLayout.RefreshByData(list, delegate
			{
				CS$<>8__locals1.<>4__this.PlayStarAnimation(CS$<>8__locals1.version);
			}, false);
		}

		// Token: 0x06038F5B RID: 233307 RVA: 0x00FF5988 File Offset: 0x00FF3B88
		private void PlayStarAnimation(int version)
		{
			if (version != this.StarAnimationVersion || !base.IsShowOrShowing || this.StarLayout == null)
			{
				return;
			}
			TArray<UUIItem> tarray = new TArray<UUIItem>();
			foreach (SolarSchoolStarItem solarSchoolStarItem in this.StarLayout.GetLayoutItemList())
			{
				UUIItem rootItem = solarSchoolStarItem.GetRootItem();
				if (rootItem != null)
				{
					tarray.Add(rootItem);
				}
			}
			if (tarray.Num() > 0)
			{
				UUIInturnAnimController uiAnimController = this.StarLayout.GetUiAnimController();
				if (uiAnimController == null)
				{
					return;
				}
				uiAnimController.PlayWithItems(tarray, "Start");
			}
		}

		// Token: 0x06038F5C RID: 233308 RVA: 0x00FF5A30 File Offset: 0x00FF3C30
		private void StopStarAnimation()
		{
			this.StarAnimationVersion++;
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			UUIInturnAnimController uuiinturnAnimController = (starLayout != null) ? starLayout.GetUiAnimController() : null;
			if (uuiinturnAnimController != null && uuiinturnAnimController.IsPlaying())
			{
				uuiinturnAnimController.Stop();
			}
		}

		// Token: 0x06038F5D RID: 233309 RVA: 0x00FF5A70 File Offset: 0x00FF3C70
		[NullableContext(1)]
		private void RefreshDeadline(SolarSchoolSpecialBehaviorCenter center)
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int acceptDeadline = center.GetAcceptDeadline(this.BehaviorId);
			if (acceptDeadline <= 0)
			{
				UUIText text = base.GetText(3);
				if (text != null)
				{
					text.SetText(string.Empty, true);
				}
			}
			else
			{
				int num = Math.Max(acceptDeadline - timeData.DayIndex + 1, 0);
				UUIText text2 = base.GetText(3);
				if (text2 != null)
				{
					text2.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_SpecialAccept_RemainDay", null) ?? string.Empty, num), true);
				}
			}
			int finishDeadline = center.GetFinishDeadline(this.BehaviorId);
			if (finishDeadline <= 0)
			{
				UUIText text3 = base.GetText(15);
				if (text3 == null)
				{
					return;
				}
				text3.SetText(string.Empty, true);
				return;
			}
			else
			{
				ValueTuple<int, int> monthDay = timeData.GetMonthDay(finishDeadline);
				int item = monthDay.Item1;
				int item2 = monthDay.Item2;
				UUIText text4 = base.GetText(15);
				if (text4 == null)
				{
					return;
				}
				text4.SetText(string.Format(ConfigMultiTextLang.GetLocalTextNew("SolarSchool_SpecialAccept_Deadline", null) ?? string.Empty, item.ToString("D2"), item2.ToString("D2")), true);
				return;
			}
		}

		// Token: 0x06038F5E RID: 233310 RVA: 0x00FF5B7C File Offset: 0x00FF3D7C
		private void OnClickConfirm()
		{
			SolarSchoolSpecialBehaviorCenter instance = SolarSchoolSpecialBehaviorCenter.Instance;
			if (!instance.CanAccept(this.BehaviorId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_SpecialAccept_ConditionFail", Array.Empty<object>());
				return;
			}
			if (!this.HideClose && instance.IsAcceptLimitReached())
			{
				this.ShowAcceptLimitWarnConfirm();
				return;
			}
			this.CheckDeadlineWarningThenAccept();
		}

		// Token: 0x06038F5F RID: 233311 RVA: 0x00FF5BD0 File Offset: 0x00FF3DD0
		private unsafe void ShowAcceptLimitWarnConfirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolSpecialAcceptLimitWarn);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.CheckDeadlineWarningThenAccept);
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 特批进行中数量超限确认框弹出失败，直接接取，检查 649 是否已进 ConfirmBox 配表";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", 649);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("进行中数量", SolarSchoolSpecialBehaviorCenter.Instance.GetInProgressCount());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("上限", SolarSchoolSpecialBehaviorCenter.Instance.GetAcceptMaxInProgress());
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.CheckDeadlineWarningThenAccept();
		}

		// Token: 0x06038F60 RID: 233312 RVA: 0x00FF5CC9 File Offset: 0x00FF3EC9
		private void CheckDeadlineWarningThenAccept()
		{
			if (SolarSchoolSpecialBehaviorCenter.Instance.NeedDeadlineWarning(this.BehaviorId))
			{
				this.ShowDeadlineWarnConfirm();
				return;
			}
			this.DoAccept();
		}

		// Token: 0x06038F61 RID: 233313 RVA: 0x00FF5CEC File Offset: 0x00FF3EEC
		private unsafe void ShowDeadlineWarnConfirm()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolSpecialAcceptDeadlineWarn);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.DoAccept);
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 特批过期预警确认框弹出失败，直接接取，检查 ConfirmBox 配表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("configId", 617);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("behaviorId", this.BehaviorId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.DoAccept();
		}

		// Token: 0x06038F62 RID: 233314 RVA: 0x00FF5D9C File Offset: 0x00FF3F9C
		private void DoAccept()
		{
			if (!SolarSchoolSpecialBehaviorCenter.Instance.TryAccept(this.BehaviorId))
			{
				return;
			}
			Action onAccepted = this.OnAccepted;
			if (onAccepted != null)
			{
				onAccepted();
			}
			this.CloseSelf();
			SolarSchoolGamePlayModel.Instance.TryInjectBehaviorDonePopup(this.BehaviorId, "SolarSchoolPopup_101", false);
		}

		// Token: 0x0401DF7F RID: 122751
		private const int MinConditionCount = 5;

		// Token: 0x0401DF80 RID: 122752
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DF81 RID: 122753
		private SolarSchoolDateItem Date;

		// Token: 0x0401DF82 RID: 122754
		private SolarSchoolAttrPanel ScorePanel;

		// Token: 0x0401DF83 RID: 122755
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolStarItem, bool> StarLayout;

		// Token: 0x0401DF84 RID: 122756
		private int StarAnimationVersion;

		// Token: 0x0401DF85 RID: 122757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolSpecialBehaviorConditionItem, SolarSchoolAttrRequire?> ConditionLayout;

		// Token: 0x0401DF86 RID: 122758
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolSpecialBehaviorRewardItem, SolarSchoolReward> RewardLayout;

		// Token: 0x0401DF87 RID: 122759
		private int BehaviorId;

		// Token: 0x0401DF88 RID: 122760
		private bool HideClose;

		// Token: 0x0401DF89 RID: 122761
		private Action OnAccepted;

		// Token: 0x0200B644 RID: 46660
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038620 RID: 230944
			public const int Caption = 0;

			// Token: 0x04038621 RID: 230945
			public const int Date = 1;

			// Token: 0x04038622 RID: 230946
			public const int ScorePanel = 2;

			// Token: 0x04038623 RID: 230947
			public const int TxtTime = 3;

			// Token: 0x04038624 RID: 230948
			public const int TxtTitle = 4;

			// Token: 0x04038625 RID: 230949
			public const int PnlStarLayout = 5;

			// Token: 0x04038626 RID: 230950
			public const int SprStarItem = 6;

			// Token: 0x04038627 RID: 230951
			public const int PnlCheck = 7;

			// Token: 0x04038628 RID: 230952
			public const int BtnConfirm = 8;

			// Token: 0x04038629 RID: 230953
			public const int PnlConditionLayout = 9;

			// Token: 0x0403862A RID: 230954
			public const int ConditionItem = 10;

			// Token: 0x0403862B RID: 230955
			public const int PnlRewardLayout = 11;

			// Token: 0x0403862C RID: 230956
			public const int RewardItem = 12;

			// Token: 0x0403862D RID: 230957
			public const int TxtRewardContent = 13;

			// Token: 0x0403862E RID: 230958
			public const int TxtGoalContent = 14;

			// Token: 0x0403862F RID: 230959
			public const int TxtDeadline = 15;
		}
	}
}
