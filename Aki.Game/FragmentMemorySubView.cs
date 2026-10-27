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

// Token: 0x02001286 RID: 4742
[NullableContext(2)]
[Nullable(0)]
public class FragmentMemorySubView : ActivitySubViewBase
{
	// Token: 0x0600817B RID: 33147 RVA: 0x001B79AC File Offset: 0x001B5BAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600817C RID: 33148 RVA: 0x001B7A9C File Offset: 0x001B5C9C
	protected override UniTask OnBeforeStartAsync()
	{
		FragmentMemorySubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FragmentMemorySubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600817D RID: 33149 RVA: 0x001B7ADF File Offset: 0x001B5CDF
	[NullableContext(1)]
	protected override void OnSequenceClose(string sequenceName)
	{
	}

	// Token: 0x0600817E RID: 33150 RVA: 0x001B7AE1 File Offset: 0x001B5CE1
	private unsafe void OnFragmentMemoryButtonClick(int value)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			EventSystem.Instance.Emit<bool>(EEventName.ChangeActivityViewNeedBlurState, false);
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				return;
			}
			PhotoMemoryActivity? data = FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(this.ActivityBaseData.Id);
			FragmentMemoryTopicData topicData = FragmentMemoryModel.Instance.GetTopicDataById(data.Value.TopicId);
			if (topicData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.FragmentMemory;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "FragmentMemorySubView.OnFragmentMemoryButtonClick";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("message", "topicData is null");
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("topicId", data.Value.TopicId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("HideView01", false, false, null, null, false);
			}
			UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", true);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				FragmentMemoryModel.Instance.SaveTopicOpened(data.Value.TopicId);
				FragmentMemoryModel.Instance.MemoryFragmentMainViewTryPlayAnimation = "Start02";
				FragmentMemoryMainViewOpenData fragmentMemoryMainViewOpenData = new FragmentMemoryMainViewOpenData();
				fragmentMemoryMainViewOpenData.FragmentMemoryTopicData = topicData;
				UiManager.Instance.OpenView(EUiViewName.MemoryFragmentMainView, fragmentMemoryMainViewOpenData, null);
				UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", false);
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
			}, 600f, null, null, true, 1f);
		});
	}

	// Token: 0x0600817F RID: 33151 RVA: 0x001B7AFF File Offset: 0x001B5CFF
	private void OnCollectMemoryButtonClick(int value)
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			PhotoMemoryActivity? data = FragmentMemoryConfig.Instance.GetPhotoMemoryActivityById(this.ActivityBaseData.Id);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("HideView02", false, false, null, null, false);
			}
			UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", true);
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.MemoryDetailView, (data != null) ? new int?(data.GetValueOrDefault().TopicId) : null, null);
				UiLayer.Instance.SetShowMaskLayer("FragmentMemoryMask", false);
			}, 600f, null, null, true, 1f);
		});
	}

	// Token: 0x06008180 RID: 33152 RVA: 0x001B7B1D File Offset: 0x001B5D1D
	protected override void OnStart()
	{
	}

	// Token: 0x06008181 RID: 33153 RVA: 0x001B7B1F File Offset: 0x001B5D1F
	protected override void OnBeforeShow()
	{
		this.TryPlayAnimation();
	}

	// Token: 0x06008182 RID: 33154 RVA: 0x001B7B27 File Offset: 0x001B5D27
	protected override void OnBeforeHide()
	{
		FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "";
		this.RemoveRedDot();
	}

	// Token: 0x06008183 RID: 33155 RVA: 0x001B7B40 File Offset: 0x001B5D40
	protected override void OnRefreshView()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		if (localConfig == null)
		{
			return;
		}
		this.RefreshDesc();
		this.RefreshTitle();
		this.RefreshReward();
		this.RefreshFunctionalComponent();
		this.RefreshState();
		this.RefreshButton();
		this.RefreshCollectButton();
		this.TryPlayAnimation();
		this.BindRedDot();
		EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityBaseData.Id);
	}

	// Token: 0x06008184 RID: 33156 RVA: 0x001B7BB4 File Offset: 0x001B5DB4
	private void TryPlayAnimation()
	{
		if (!StringUtils.IsEmpty(FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation))
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely(FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation, false, false, null, null, false);
			}
			FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "";
			return;
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (((levelSequencePlayer2 != null) ? levelSequencePlayer2.GetCurrentSequence() : null) == "Start01")
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.StopSequenceByKey("Start01", false, false);
			}
			LevelSequencePlayer levelSequencePlayer4 = this.LevelSequencePlayer;
			if (levelSequencePlayer4 == null)
			{
				return;
			}
			levelSequencePlayer4.ReplaySequenceByKey("Start01");
			return;
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer5 = this.LevelSequencePlayer;
			if (levelSequencePlayer5 == null)
			{
				return;
			}
			levelSequencePlayer5.PlaySequencePurely("Start01", false, false, null, null, false);
			return;
		}
	}

	// Token: 0x06008185 RID: 33157 RVA: 0x001B7C78 File Offset: 0x001B5E78
	private void BindRedDot()
	{
		ButtonItem fragmentMemoryButtonItem = this.FragmentMemoryButtonItem;
		if (fragmentMemoryButtonItem == null)
		{
			return;
		}
		fragmentMemoryButtonItem.BindRedDot(ERedDotName.FragmentMemoryEntrance, 0);
	}

	// Token: 0x06008186 RID: 33158 RVA: 0x001B7C90 File Offset: 0x001B5E90
	private void RemoveRedDot()
	{
		ButtonItem fragmentMemoryButtonItem = this.FragmentMemoryButtonItem;
		if (fragmentMemoryButtonItem == null)
		{
			return;
		}
		fragmentMemoryButtonItem.UnBindRedDot();
	}

	// Token: 0x06008187 RID: 33159 RVA: 0x001B7CA4 File Offset: 0x001B5EA4
	private void RefreshState()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x06008188 RID: 33160 RVA: 0x001B7CF0 File Offset: 0x001B5EF0
	private void RefreshButton()
	{
		bool active = this.ActivityBaseData.IsUnLock();
		this.FragmentMemoryButtonItem.SetActive(active);
	}

	// Token: 0x06008189 RID: 33161 RVA: 0x001B7D18 File Offset: 0x001B5F18
	private void RefreshTitle()
	{
		this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
		this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
		bool item = timeVisibleAndRemainTime.Item1;
		string item2 = timeVisibleAndRemainTime.Item2;
		this.TitleComponent.SetTimeTextVisible(item);
		if (item)
		{
			this.TitleComponent.SetTimeTextByText(item2);
		}
	}

	// Token: 0x0600818A RID: 33162 RVA: 0x001B7D7C File Offset: 0x001B5F7C
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x0600818B RID: 33163 RVA: 0x001B7D84 File Offset: 0x001B5F84
	private void RefreshDesc()
	{
		Activity? localConfig = this.ActivityBaseData.LocalConfig;
		string descTheme = localConfig.Value.DescTheme;
		string desc = localConfig.Value.Desc;
		bool flag = !StringUtils.IsEmpty(descTheme);
		this.TitleComponent.SetSubTitleVisible(flag);
		if (flag)
		{
			this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
		}
		this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
	}

	// Token: 0x0600818C RID: 33164 RVA: 0x001B7DFC File Offset: 0x001B5FFC
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("FragmentMemoryCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x0600818D RID: 33165 RVA: 0x001B7E3C File Offset: 0x001B603C
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("FragmentMemoryEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
	}

	// Token: 0x0600818E RID: 33166 RVA: 0x001B7E68 File Offset: 0x001B6068
	private void RefreshCollectButton()
	{
		bool preGuideQuestFinishState = this.ActivityBaseData.GetPreGuideQuestFinishState();
		bool flag = this.ActivityBaseData.IsUnLock();
		ButtonItem fragmentMemoryButtonItem = this.FragmentMemoryButtonItem;
		if (fragmentMemoryButtonItem == null)
		{
			return;
		}
		fragmentMemoryButtonItem.SetActive(flag && preGuideQuestFinishState);
	}

	// Token: 0x04003AAA RID: 15018
	private const int HIDEVIEW01DELAY = 600;

	// Token: 0x04003AAB RID: 15019
	private const int HIDEVIEWDELAY = 600;

	// Token: 0x04003AAC RID: 15020
	[Nullable(1)]
	private const string FRAGMENTMEMORYMASK = "FragmentMemoryMask";

	// Token: 0x04003AAD RID: 15021
	[Nullable(1)]
	private const string START01 = "Start01";

	// Token: 0x04003AAE RID: 15022
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003AAF RID: 15023
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003AB0 RID: 15024
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003AB1 RID: 15025
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003AB2 RID: 15026
	private ButtonItem FragmentMemoryButtonItem;

	// Token: 0x0200789E RID: 30878
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027BDF RID: 162783
		public const int TitleItem = 0;

		// Token: 0x04027BE0 RID: 162784
		public const int DescItem = 1;

		// Token: 0x04027BE1 RID: 162785
		public const int RewardItem = 2;

		// Token: 0x04027BE2 RID: 162786
		public const int FunctionalAreaItem = 3;

		// Token: 0x04027BE3 RID: 162787
		public const int CollectMemoryButton = 4;

		// Token: 0x04027BE4 RID: 162788
		public const int FragmentMemoryButton = 5;
	}
}
