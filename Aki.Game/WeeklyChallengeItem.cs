using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002283 RID: 8835
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeeklyChallengeItem : GridProxyAbstract<WeeklyChallengeTaskData>
{
	// Token: 0x06015D77 RID: 89463 RVA: 0x00655A14 File Offset: 0x00653C14
	protected unsafe override void OnRegisterComponent()
	{
		int num = 16;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickGoToButton));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickHelpButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015D78 RID: 89464 RVA: 0x00655CB4 File Offset: 0x00653EB4
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyChallengeItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyChallengeItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015D79 RID: 89465 RVA: 0x00655CF7 File Offset: 0x00653EF7
	protected override void OnStart()
	{
		this.TagItemLayout = new GenericLayout<WeeklyChallengeTagItem, string>(base.GetHorizontalLayout(4), new Func<WeeklyChallengeTagItem>(this.CreateTagItem), null, false, true);
	}

	// Token: 0x06015D7A RID: 89466 RVA: 0x00655D1A File Offset: 0x00653F1A
	private WeeklyChallengeTagItem CreateTagItem()
	{
		return new WeeklyChallengeTagItem();
	}

	// Token: 0x06015D7B RID: 89467 RVA: 0x00655D24 File Offset: 0x00653F24
	public override void Refresh(WeeklyChallengeTaskData data, bool isSelected, int gridIndex)
	{
		int configId = data.ConfigId;
		if (configId == 0)
		{
			base.GetItem(13).SetUIActive(true);
			base.GetItem(12).SetUIActive(false);
			return;
		}
		WeeklyFrameHelp? playConfigById = WeeklyChallengeConfig.Instance.GetPlayConfigById(configId);
		if (playConfigById == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyChallenge;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "WeeklyChallengeItem Config not found";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ConfigId", data.ConfigId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.ConfigData = new WeeklyFrameHelp?(playConfigById.Value);
		this.IsUnlocked = data.IsUnlocked;
		base.GetText(2).ShowTextNew(this.ConfigData.Value.Name);
		base.GetText(6).SetText(this.ConfigData.Value.Score.ToString(), true);
		base.GetText(7).ShowTextNew(this.ConfigData.Value.Time);
		base.SetTextureByPath(this.ConfigData.Value.BgPic, base.GetTexture(1), null, null);
		string[] array = this.ConfigData.Value.Tag();
		if (array != null && array.Length != 0)
		{
			this.TagItemLayout.RefreshByData(new List<string>(array), null, false);
		}
		base.GetItem(10).SetUIActive(!data.IsUnlocked);
		if (!data.IsUnlocked)
		{
			int unlockCondition = this.ConfigData.Value.UnlockCondition;
			ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(unlockCondition);
			if (conditionGroupConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.WeeklyChallenge;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "WeeklyChallengeItem ConditionInfo not found";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ConditionId", unlockCondition);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			else
			{
				FunctionalPanelConditionLock panelLock = this.PanelLock;
				if (panelLock != null)
				{
					panelLock.SetTextByTextId(conditionGroupConfig.Value.HintText, Array.Empty<string>());
				}
			}
		}
		FunctionalPanelConditionLock panelLock2 = this.PanelLock;
		if (panelLock2 != null)
		{
			panelLock2.SetUiActive(!data.IsUnlocked);
		}
		WeeklyPlayData weeklyPlayData = WeeklyChallengeModel.Instance.GetWeeklyPlayData(configId);
		bool uiactive = weeklyPlayData != null && weeklyPlayData.HasRecord;
		base.GetItem(14).SetUIActive(uiactive);
		FColor color = FColor.FromHex(this.ConfigData.Value.ItemColor);
		base.GetSprite(15).SetColor(color);
		base.GetItem(12).SetUIActive(true);
		base.GetItem(13).SetUIActive(false);
	}

	// Token: 0x06015D7C RID: 89468 RVA: 0x00655FB0 File Offset: 0x006541B0
	private void OnClickLockButton()
	{
		if (this.ConfigData == null)
		{
			return;
		}
		this.ReportRedClearEvent();
		DailyActivityModel.Instance.MarkWeeklyPlayOpened();
		int unlockCondition = this.ConfigData.Value.UnlockCondition;
		Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(unlockCondition);
		int accessType = -1;
		if (conditionConfig != null && conditionConfig.GetValueOrDefault().AccessId > 0)
		{
			accessType = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId).Value.SkipName;
		}
		bool isFinished = LevelGeneralController.Instance.CheckCondition(unlockCondition.ToString(), null, false, Array.Empty<object>());
		ActivityConditionData item = new ActivityConditionData
		{
			ConditionId = unlockCondition,
			ConditionTextId = ((conditionConfig != null) ? conditionConfig.GetValueOrDefault().Description : null),
			IsFinished = isFinished,
			AccessId = ((conditionConfig != null) ? conditionConfig.GetValueOrDefault().AccessId : 0),
			AccessType = accessType
		};
		List<IActivityConditionData> dataList = new List<IActivityConditionData>
		{
			item
		};
		ConditionGroupData param = new ConditionGroupData(unlockCondition, dataList, "", false);
		UiManager.Instance.OpenView(EUiViewName.CommonConditionView, param, null);
	}

	// Token: 0x06015D7D RID: 89469 RVA: 0x006560F8 File Offset: 0x006542F8
	private void OnClickHelpButton()
	{
		if (this.ConfigData == null)
		{
			return;
		}
		HelpController.Instance.OpenHelpById(this.ConfigData.Value.HelpId);
	}

	// Token: 0x06015D7E RID: 89470 RVA: 0x00656130 File Offset: 0x00654330
	private void OnClickGoToButton()
	{
		if (this.ConfigData == null)
		{
			return;
		}
		this.ReportRedClearEvent();
		DailyActivityModel.Instance.MarkWeeklyPlayOpened();
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
			return;
		}
		WeeklyChallengeGoToClickLogData weeklyChallengeGoToClickLogData = new WeeklyChallengeGoToClickLogData();
		weeklyChallengeGoToClickLogData.i_activity_id = this.ConfigData.Value.Id;
		weeklyChallengeGoToClickLogData.i_activity_type = this.ConfigData.Value.ActivityType;
		weeklyChallengeGoToClickLogData.i_unlock = ((this.IsUnlocked > false) ? 1 : 0);
		LogReportController.Instance.LogReport(weeklyChallengeGoToClickLogData);
		SkipTaskManager.RunByConfigId(this.ConfigData.Value.AccessPathId, null);
	}

	// Token: 0x06015D7F RID: 89471 RVA: 0x006561E8 File Offset: 0x006543E8
	private void ReportRedClearEvent()
	{
		int valueOrDefault = DailyActivityModel.Instance.GetFirstOpenTabTime(DailyActivityDefine.EDailyActivityMainTab.Weekly).GetValueOrDefault();
		if ((int)WeeklyChallengeModel.Instance.WeeklyEndTime != valueOrDefault)
		{
			WeeklyChallengeRedClearLogEvent weeklyChallengeRedClearLogEvent = new WeeklyChallengeRedClearLogEvent();
			weeklyChallengeRedClearLogEvent.i_season_id = WeeklyChallengeModel.Instance.WeeklyConfigId;
			weeklyChallengeRedClearLogEvent.i_type = this.ConfigData.Value.Id;
			LogReportController.Instance.LogReport(weeklyChallengeRedClearLogEvent);
		}
	}

	// Token: 0x0400B7F9 RID: 47097
	private WeeklyFrameHelp? ConfigData;

	// Token: 0x0400B7FA RID: 47098
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeeklyChallengeTagItem, string> TagItemLayout;

	// Token: 0x0400B7FB RID: 47099
	[Nullable(2)]
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x0400B7FC RID: 47100
	private bool IsUnlocked;

	// Token: 0x020084E0 RID: 34016
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402AD5B RID: 175451
		ClickButton,
		// Token: 0x0402AD5C RID: 175452
		IconTexture,
		// Token: 0x0402AD5D RID: 175453
		NameText,
		// Token: 0x0402AD5E RID: 175454
		HelpButton,
		// Token: 0x0402AD5F RID: 175455
		TagHorizontalLayout,
		// Token: 0x0402AD60 RID: 175456
		TagItem,
		// Token: 0x0402AD61 RID: 175457
		ScoreText,
		// Token: 0x0402AD62 RID: 175458
		TimeText,
		// Token: 0x0402AD63 RID: 175459
		GoToItem,
		// Token: 0x0402AD64 RID: 175460
		GoToText,
		// Token: 0x0402AD65 RID: 175461
		LockPanel,
		// Token: 0x0402AD66 RID: 175462
		LockItem,
		// Token: 0x0402AD67 RID: 175463
		InfoPanel,
		// Token: 0x0402AD68 RID: 175464
		EmptyPanel,
		// Token: 0x0402AD69 RID: 175465
		ArchiveItem,
		// Token: 0x0402AD6A RID: 175466
		ColorSprite
	}
}
