using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002B18 RID: 11032
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsLevelInfoItem : GridProxyAbstract<ISurvivorsLevelInfo>
{
	// Token: 0x06016EBF RID: 93887 RVA: 0x005D11CC File Offset: 0x005CF3CC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
	}

	// Token: 0x06016EC0 RID: 93888 RVA: 0x005D12AA File Offset: 0x005CF4AA
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x06016EC1 RID: 93889 RVA: 0x005D12CC File Offset: 0x005CF4CC
	public override void Refresh(ISurvivorsLevelInfo data, bool isSelected, int gridIndex)
	{
		this.LevelInfo = data;
		SurvivorsLevel? survivorsLevel = SurvivorsRogueConfig.Instance.GetSurvivorsLevel(data.LevelId);
		if (survivorsLevel == null)
		{
			return;
		}
		if (data.IsEndlessMode)
		{
			this.RefreshEndlessMode(survivorsLevel.Value);
		}
		else
		{
			this.RefreshNormalMode(survivorsLevel.Value);
		}
		string text;
		if (gridIndex >= 10)
		{
			text = gridIndex.ToString();
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(gridIndex);
			text = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		string newText = text;
		base.GetText(6).SetText(newText, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), survivorsLevel.Value.Name, Array.Empty<object>());
		this.RefreshSpriteDiff(survivorsLevel.Value);
	}

	// Token: 0x06016EC2 RID: 93890 RVA: 0x005D1394 File Offset: 0x005CF594
	private void RefreshEndlessMode(SurvivorsLevel levelConfig)
	{
		ModeInfo info = this.LevelInfo.Info;
		this.IsTimeUnlock = SurvivorsRogueModel.Instance.ActivityData.GetLevelTimeUnlockState(this.LevelInfo.LevelId);
		bool levelUnlockState = SurvivorsRogueModel.Instance.ActivityData.GetLevelUnlockState(this.LevelInfo.LevelId, true);
		bool flag = info.KillMonsterCount > 0;
		UUISprite sprite = base.GetSprite(1);
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		item.SetUIActive(levelUnlockState && flag);
		item2.SetUIActive(false);
		if (levelUnlockState)
		{
			List<string> list = new List<string>();
			string textStringId = string.Empty;
			if (!flag)
			{
				textStringId = "SurvivorsLevelSelection_EndlessTips";
			}
			else
			{
				textStringId = "SurvivorsLevelSelection_KillNumberTips";
				list.Add(info.KillMonsterCount.ToString());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, list.ToArray());
		}
		else
		{
			this.RefreshLockState(true);
		}
		this.SetSpriteByPath(levelUnlockState ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemBoss.SP_IconSurvivorLvItemBoss" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLock.SP_IconSurvivorLvItemLock", sprite, false, null, null);
	}

	// Token: 0x06016EC3 RID: 93891 RVA: 0x005D149C File Offset: 0x005CF69C
	private void RefreshNormalMode(SurvivorsLevel levelConfig)
	{
		ModeInfo info = this.LevelInfo.Info;
		this.IsTimeUnlock = SurvivorsRogueModel.Instance.ActivityData.GetLevelTimeUnlockState(this.LevelInfo.LevelId);
		bool levelUnlockState = SurvivorsRogueModel.Instance.ActivityData.GetLevelUnlockState(this.LevelInfo.LevelId, false);
		bool isFinish = info.IsFinish;
		UUISprite sprite = base.GetSprite(1);
		UUIItem item = base.GetItem(3);
		UUIItem item2 = base.GetItem(4);
		item.SetUIActive(false);
		item2.SetUIActive(levelUnlockState && isFinish);
		if (levelUnlockState)
		{
			List<string> list = new List<string>();
			string textStringId = string.Empty;
			if (isFinish)
			{
				textStringId = "SurvivorsLevelSelection_CustomsClearanceTips";
			}
			else
			{
				int maxWaveNumByLevelId = SurvivorsRogueConfig.Instance.GetMaxWaveNumByLevelId(this.LevelInfo.LevelId);
				textStringId = "SurvivorsLevelSelection_ProgressTips";
				list.Add(info.WaveId.ToString());
				list.Add(maxWaveNumByLevelId.ToString());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, list.ToArray());
		}
		else
		{
			this.RefreshLockState(true);
		}
		this.SetSpriteByPath(levelUnlockState ? "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLv.SP_IconSurvivorLvItemLv" : "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLock.SP_IconSurvivorLvItemLock", sprite, false, null, null);
	}

	// Token: 0x06016EC4 RID: 93892 RVA: 0x005D15C4 File Offset: 0x005CF7C4
	private void RefreshSpriteDiff(SurvivorsLevel levelConfig)
	{
		string path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemBlur.SP_SurvivorLvItemBlur";
		switch (levelConfig.Diff)
		{
		case 0:
			path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemBlur.SP_SurvivorLvItemBlur";
			break;
		case 1:
			path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemPurple.SP_SurvivorLvItemPurple";
			break;
		case 2:
			path = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemRed.SP_SurvivorLvItemRed";
			break;
		}
		this.SetSpriteByPath(path, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06016EC5 RID: 93893 RVA: 0x005D1624 File Offset: 0x005CF824
	private void RefreshLockState(bool isInit = true)
	{
		int levelId = this.LevelInfo.LevelId;
		string levelUnlockRemainTime = SurvivorsRogueModel.Instance.ActivityData.GetLevelUnlockRemainTime(levelId);
		if (levelUnlockRemainTime != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "SurvivorsLevelSelection_UnlockTimeTips", new <>z__ReadOnlySingleElementList<object>(levelUnlockRemainTime));
			return;
		}
		if (isInit)
		{
			string textStringId = LevelGeneralCommons.GetConditionGroupHintText(this.LevelInfo.Info.ConditionGroupId) ?? string.Empty;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, Array.Empty<object>());
		}
	}

	// Token: 0x06016EC6 RID: 93894 RVA: 0x005D16A8 File Offset: 0x005CF8A8
	public void SetSaveFile(SurvivorsActivityDefine.SurvivorsLevelInfo saveFile)
	{
		if (saveFile.LevelId == this.LevelInfo.LevelId)
		{
			base.GetItem(7).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "SurvivorsExitPopup_Text", new <>z__ReadOnlyArray<object>(new object[]
			{
				saveFile.Batch.ToString(),
				saveFile.MaxBatch.ToString()
			}));
			return;
		}
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x06016EC7 RID: 93895 RVA: 0x005D1720 File Offset: 0x005CF920
	public void OnTick(float deltaTime)
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		if (this.IsTimeUnlock)
		{
			return;
		}
		this.RefreshLockState(false);
	}

	// Token: 0x06016EC8 RID: 93896 RVA: 0x005D173C File Offset: 0x005CF93C
	public void PlaySequenceByName(ESurvivorsLevelInfoSeqName seqName)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(seqName.ToString(), true, null, false);
	}

	// Token: 0x06016EC9 RID: 93897 RVA: 0x005D176C File Offset: 0x005CF96C
	public override object GetKey(ISurvivorsLevelInfo data, int displayIndex)
	{
		return data.LevelId;
	}

	// Token: 0x0400AA72 RID: 43634
	private const string SPRITE_STATE_EASY = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemBlur.SP_SurvivorLvItemBlur";

	// Token: 0x0400AA73 RID: 43635
	private const string SPRITE_STATE_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemPurple.SP_SurvivorLvItemPurple";

	// Token: 0x0400AA74 RID: 43636
	private const string SPRITE_STATE_CHALLENGE = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemRed.SP_SurvivorLvItemRed";

	// Token: 0x0400AA75 RID: 43637
	private const string SPRITE_STATE_ICON_LOCK = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLock.SP_IconSurvivorLvItemLock";

	// Token: 0x0400AA76 RID: 43638
	private const string SPRITE_STATE_ICON_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLv.SP_IconSurvivorLvItemLv";

	// Token: 0x0400AA77 RID: 43639
	private const string SPRITE_STATE_ICON_ENDLESS = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemBoss.SP_IconSurvivorLvItemBoss";

	// Token: 0x0400AA78 RID: 43640
	private const string INFO_FINISHED = "SurvivorsLevelSelection_CustomsClearanceTips";

	// Token: 0x0400AA79 RID: 43641
	private const string INFO_ENDLESS_OPEN = "SurvivorsLevelSelection_EndlessTips";

	// Token: 0x0400AA7A RID: 43642
	private const string INFO_WAVE = "SurvivorsLevelSelection_ProgressTips";

	// Token: 0x0400AA7B RID: 43643
	private const string INFO_LOCK_TIME = "SurvivorsLevelSelection_UnlockTimeTips";

	// Token: 0x0400AA7C RID: 43644
	private const string INFO_KILL_COUNT = "SurvivorsLevelSelection_KillNumberTips";

	// Token: 0x0400AA7D RID: 43645
	[Nullable(2)]
	protected ISurvivorsLevelInfo LevelInfo;

	// Token: 0x0400AA7E RID: 43646
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AA7F RID: 43647
	private bool IsTimeUnlock;
}
