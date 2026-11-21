using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002094 RID: 8340
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SurvivorsLevelInfoItem : GridProxyAbstract<ISurvivorsLevelInfo>
{
	// Token: 0x060148F0 RID: 84208 RVA: 0x005FDD48 File Offset: 0x005FBF48
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

	// Token: 0x060148F1 RID: 84209 RVA: 0x005FDE26 File Offset: 0x005FC026
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetItem(7).SetUIActive(false);
	}

	// Token: 0x060148F2 RID: 84210 RVA: 0x005FDE48 File Offset: 0x005FC048
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

	// Token: 0x060148F3 RID: 84211 RVA: 0x005FDF10 File Offset: 0x005FC110
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

	// Token: 0x060148F4 RID: 84212 RVA: 0x005FE018 File Offset: 0x005FC218
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

	// Token: 0x060148F5 RID: 84213 RVA: 0x005FE140 File Offset: 0x005FC340
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

	// Token: 0x060148F6 RID: 84214 RVA: 0x005FE1A0 File Offset: 0x005FC3A0
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

	// Token: 0x060148F7 RID: 84215 RVA: 0x005FE224 File Offset: 0x005FC424
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

	// Token: 0x060148F8 RID: 84216 RVA: 0x005FE29C File Offset: 0x005FC49C
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

	// Token: 0x060148F9 RID: 84217 RVA: 0x005FE2B8 File Offset: 0x005FC4B8
	public void PlaySequenceByName(ESurvivorsLevelInfoSeqName seqName)
	{
		this.LevelSequencePlayer.PlayLevelSequenceByName(seqName.ToString(), true, null, false);
	}

	// Token: 0x060148FA RID: 84218 RVA: 0x005FE2E8 File Offset: 0x005FC4E8
	public override object GetKey(ISurvivorsLevelInfo data, int displayIndex)
	{
		return data.LevelId;
	}

	// Token: 0x0400AE78 RID: 44664
	private const string SPRITE_STATE_EASY = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemBlur.SP_SurvivorLvItemBlur";

	// Token: 0x0400AE79 RID: 44665
	private const string SPRITE_STATE_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemPurple.SP_SurvivorLvItemPurple";

	// Token: 0x0400AE7A RID: 44666
	private const string SPRITE_STATE_CHALLENGE = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_SurvivorLvItemRed.SP_SurvivorLvItemRed";

	// Token: 0x0400AE7B RID: 44667
	private const string SPRITE_STATE_ICON_LOCK = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLock.SP_IconSurvivorLvItemLock";

	// Token: 0x0400AE7C RID: 44668
	private const string SPRITE_STATE_ICON_NORMAL = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemLv.SP_IconSurvivorLvItemLv";

	// Token: 0x0400AE7D RID: 44669
	private const string SPRITE_STATE_ICON_ENDLESS = "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity27/Survivor/Level1/SP_IconSurvivorLvItemBoss.SP_IconSurvivorLvItemBoss";

	// Token: 0x0400AE7E RID: 44670
	private const string INFO_FINISHED = "SurvivorsLevelSelection_CustomsClearanceTips";

	// Token: 0x0400AE7F RID: 44671
	private const string INFO_ENDLESS_OPEN = "SurvivorsLevelSelection_EndlessTips";

	// Token: 0x0400AE80 RID: 44672
	private const string INFO_WAVE = "SurvivorsLevelSelection_ProgressTips";

	// Token: 0x0400AE81 RID: 44673
	private const string INFO_LOCK_TIME = "SurvivorsLevelSelection_UnlockTimeTips";

	// Token: 0x0400AE82 RID: 44674
	private const string INFO_KILL_COUNT = "SurvivorsLevelSelection_KillNumberTips";

	// Token: 0x0400AE83 RID: 44675
	[Nullable(2)]
	protected ISurvivorsLevelInfo LevelInfo;

	// Token: 0x0400AE84 RID: 44676
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AE85 RID: 44677
	private bool IsTimeUnlock;
}
