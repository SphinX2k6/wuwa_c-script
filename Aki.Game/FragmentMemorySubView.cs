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

// Token: 0x0200073A RID: 1850
[NullableContext(2)]
[Nullable(0)]
public class FragmentMemorySubView : ActivitySubViewBase
{
	// Token: 0x06005512 RID: 21778 RVA: 0x001C067C File Offset: 0x001BE87C
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

	// Token: 0x06005513 RID: 21779 RVA: 0x001C076C File Offset: 0x001BE96C
	protected override UniTask OnBeforeStartAsync()
	{
		FragmentMemorySubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FragmentMemorySubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x001C07AF File Offset: 0x001BE9AF
	[NullableContext(1)]
	protected override void OnSequenceClose(string sequenceName)
	{
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x001C07B1 File Offset: 0x001BE9B1
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

	// Token: 0x06005516 RID: 21782 RVA: 0x001C07CF File Offset: 0x001BE9CF
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

	// Token: 0x06005517 RID: 21783 RVA: 0x001C07ED File Offset: 0x001BE9ED
	protected override void OnStart()
	{
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x001C07EF File Offset: 0x001BE9EF
	protected override void OnBeforeShow()
	{
		this.TryPlayAnimation();
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x001C07F7 File Offset: 0x001BE9F7
	protected override void OnBeforeHide()
	{
		FragmentMemoryModel.Instance.ActivitySubViewTryPlayAnimation = "";
		this.RemoveRedDot();
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x001C0810 File Offset: 0x001BEA10
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

	// Token: 0x0600551B RID: 21787 RVA: 0x001C0884 File Offset: 0x001BEA84
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

	// Token: 0x0600551C RID: 21788 RVA: 0x001C0948 File Offset: 0x001BEB48
	private void BindRedDot()
	{
		ButtonItem fragmentMemoryButtonItem = this.FragmentMemoryButtonItem;
		if (fragmentMemoryButtonItem == null)
		{
			return;
		}
		fragmentMemoryButtonItem.BindRedDot(ERedDotName.FragmentMemoryEntrance, 0);
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x001C0960 File Offset: 0x001BEB60
	private void RemoveRedDot()
	{
		ButtonItem fragmentMemoryButtonItem = this.FragmentMemoryButtonItem;
		if (fragmentMemoryButtonItem == null)
		{
			return;
		}
		fragmentMemoryButtonItem.UnBindRedDot();
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x001C0974 File Offset: 0x001BEB74
	private void RefreshState()
	{
		bool flag = this.ActivityBaseData.IsUnLock();
		this.FunctionalComponent.SetPanelConditionVisible(!flag);
		if (!flag)
		{
			this.FunctionalComponent.SetPerformanceConditionLock(this.ActivityBaseData.ConditionGroupId, this.ActivityBaseData.Id);
		}
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x001C09C0 File Offset: 0x001BEBC0
	private void RefreshButton()
	{
		bool active = this.ActivityBaseData.IsUnLock();
		this.FragmentMemoryButtonItem.SetActive(active);
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x001C09E8 File Offset: 0x001BEBE8
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

	// Token: 0x06005521 RID: 21793 RVA: 0x001C0A4C File Offset: 0x001BEC4C
	protected override void OnTimer(float gap)
	{
		this.RefreshTitle();
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x001C0A54 File Offset: 0x001BEC54
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

	// Token: 0x06005523 RID: 21795 RVA: 0x001C0ACC File Offset: 0x001BECCC
	private void RefreshReward()
	{
		List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
		this.RewardListComponent.SetTitleByTextId("FragmentMemoryCollectReward");
		this.RewardListComponent.RefreshItemLayout(previewReward, null);
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x001C0B0C File Offset: 0x001BED0C
	private void RefreshFunctionalComponent()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew("FragmentMemoryEnterText", null);
		this.FunctionalComponent.FunctionButton.SetText(localTextNew);
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x001C0B38 File Offset: 0x001BED38
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

	// Token: 0x04003B42 RID: 15170
	private const int HIDEVIEW01DELAY = 600;

	// Token: 0x04003B43 RID: 15171
	private const int HIDEVIEWDELAY = 600;

	// Token: 0x04003B44 RID: 15172
	[Nullable(1)]
	private const string FRAGMENTMEMORYMASK = "FragmentMemoryMask";

	// Token: 0x04003B45 RID: 15173
	[Nullable(1)]
	private const string START01 = "Start01";

	// Token: 0x04003B46 RID: 15174
	private ActivityTitleTypeA TitleComponent;

	// Token: 0x04003B47 RID: 15175
	private ActivityDescriptionTypeA DescriptionComponent;

	// Token: 0x04003B48 RID: 15176
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

	// Token: 0x04003B49 RID: 15177
	private ActivityFunctionalTypeA FunctionalComponent;

	// Token: 0x04003B4A RID: 15178
	private ButtonItem FragmentMemoryButtonItem;

	// Token: 0x02006A29 RID: 27177
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022F10 RID: 143120
		public const int TitleItem = 0;

		// Token: 0x04022F11 RID: 143121
		public const int DescItem = 1;

		// Token: 0x04022F12 RID: 143122
		public const int RewardItem = 2;

		// Token: 0x04022F13 RID: 143123
		public const int FunctionalAreaItem = 3;

		// Token: 0x04022F14 RID: 143124
		public const int CollectMemoryButton = 4;

		// Token: 0x04022F15 RID: 143125
		public const int FragmentMemoryButton = 5;
	}
}
