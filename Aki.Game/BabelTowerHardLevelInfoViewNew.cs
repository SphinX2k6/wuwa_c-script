using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02001161 RID: 4449
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelInfoViewNew : UiViewBase
{
	// Token: 0x0600754E RID: 30030 RVA: 0x00182F10 File Offset: 0x00181110
	[NullableContext(1)]
	public BabelTowerHardLevelInfoViewNew(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x00182F1C File Offset: 0x0018111C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnQuestBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnRankBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x001830AB File Offset: 0x001812AB
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x001830C9 File Offset: 0x001812C9
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x001830E7 File Offset: 0x001812E7
	protected override void OnAfterHide()
	{
		if (this.LevelInfo != null)
		{
			BabelTowerHardLevelRightItem rightItem = this.RightItem;
			if (rightItem == null)
			{
				return;
			}
			rightItem.RefreshTeamRole();
		}
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x00183104 File Offset: 0x00181304
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelInfoViewNew.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x00183148 File Offset: 0x00181348
	private UniTask InitCaptionItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitCaptionItem>d__12 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitCaptionItem>d__12>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007555 RID: 30037 RVA: 0x0018318C File Offset: 0x0018138C
	private UniTask InitRoleTeamItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitRoleTeamItem>d__13 <InitRoleTeamItem>d__;
		<InitRoleTeamItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleTeamItem>d__.<>4__this = this;
		<InitRoleTeamItem>d__.<>1__state = -1;
		<InitRoleTeamItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitRoleTeamItem>d__13>(ref <InitRoleTeamItem>d__);
		return <InitRoleTeamItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007556 RID: 30038 RVA: 0x001831D0 File Offset: 0x001813D0
	private UniTask InitStartItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitStartItem>d__14 <InitStartItem>d__;
		<InitStartItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitStartItem>d__.<>4__this = this;
		<InitStartItem>d__.<>1__state = -1;
		<InitStartItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitStartItem>d__14>(ref <InitStartItem>d__);
		return <InitStartItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x00183214 File Offset: 0x00181414
	private UniTask InitRightItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitRightItem>d__15 <InitRightItem>d__;
		<InitRightItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightItem>d__.<>4__this = this;
		<InitRightItem>d__.<>1__state = -1;
		<InitRightItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitRightItem>d__15>(ref <InitRightItem>d__);
		return <InitRightItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x00183258 File Offset: 0x00181458
	private void InitSkillBranch()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		RoleModel instance = RoleModel.Instance;
		instance.StartGamePlayRoleEdit(ESkillBranchCacheType.BabelTower);
		BabelActivityLevelInfo levelInfo = BabelTowerController.Instance.GetBabelTowerData().GetLevelInfo(this.LevelInfo.BabelTowerLevelId);
		if (levelInfo == null)
		{
			return;
		}
		RepeatedField<int> roleSelection = levelInfo.RoleSelection;
		RepeatedField<int> skillBranchId = levelInfo.SkillBranchId;
		if (roleSelection.Count == 0 || roleSelection.Count != skillBranchId.Count)
		{
			return;
		}
		for (int i = 0; i < roleSelection.Count; i++)
		{
			instance.SetRoleSkillBranchGamePlayCache(roleSelection[i], skillBranchId[i], ESkillBranchCacheType.BabelTower);
		}
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x001832EC File Offset: 0x001814EC
	protected override void OnBeforeShow()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		this.RefreshHardBg();
		this.RefreshStarItem();
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem != null)
		{
			rightItem.SetLevelInfo(this.LevelInfo);
		}
		BabelTowerHardLevelRoleTeamPanel roleTeamItem = this.RoleTeamItem;
		if (roleTeamItem != null)
		{
			roleTeamItem.SetLevelInfo(this.LevelInfo);
		}
		BabelTowerHardLevelRoleTeamPanel roleTeamItem2 = this.RoleTeamItem;
		if (roleTeamItem2 != null)
		{
			roleTeamItem2.Refresh();
		}
		bool flag = !BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId).IsDifficult;
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(!flag);
	}

	// Token: 0x0600755A RID: 30042 RVA: 0x00183390 File Offset: 0x00181590
	private void OnTeamSelectClick()
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		BabelTowerHardLevelRoleTeamPanel roleTeamItem = this.RoleTeamItem;
		if (roleTeamItem != null)
		{
			roleTeamItem.SetUiActive(true);
		}
		BabelTowerHardLevelRoleTeamPanel roleTeamItem2 = this.RoleTeamItem;
		if (roleTeamItem2 != null)
		{
			roleTeamItem2.Refresh();
		}
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.SetRoleDetailBtnVisible(true);
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x001833E4 File Offset: 0x001815E4
	private void OnRoleTeamRefresh()
	{
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.RefreshTeamRole();
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x001833F6 File Offset: 0x001815F6
	private void OnSelectModeChange(EBabelTowerTeamTabType tabType)
	{
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.RefreshTeamRole();
	}

	// Token: 0x0600755D RID: 30045 RVA: 0x00183408 File Offset: 0x00181608
	private void OnRoleTeamPanelClose()
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.SetRoleDetailBtnVisible(false);
	}

	// Token: 0x0600755E RID: 30046 RVA: 0x00183430 File Offset: 0x00181630
	private void RefreshHardBg()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId);
		bool isDifficult = babelTowerLevelConfig.IsDifficult;
		UUITexture texture = base.GetTexture(2);
		if (texture != null)
		{
			texture.SetUIActive(isDifficult);
		}
		UUITexture texture2 = base.GetTexture(3);
		if (texture2 != null)
		{
			texture2.SetUIActive(isDifficult);
		}
		if (isDifficult && !string.IsNullOrEmpty(babelTowerLevelConfig.BossTexture))
		{
			base.SetTextureByPath(babelTowerLevelConfig.BossTexture, base.GetTexture(3), null, null);
		}
		string titleLocalText = isDifficult ? "BabelSelect_boss" : "BabelSelect_xiaoguai";
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetTitleLocalText(titleLocalText);
	}

	// Token: 0x0600755F RID: 30047 RVA: 0x001834DC File Offset: 0x001816DC
	private void RefreshStarItem()
	{
		if (this.StartItem == null || this.LevelInfo == null)
		{
			return;
		}
		this.StartItem.RefreshStar(this.LevelInfo.StarNumber);
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId);
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(babelTowerLevelConfig.ActivityId, this.LevelInfo.StarNumber);
		if (babelTowerDifficulty != null)
		{
			BabelTowerDifficulty valueOrDefault = babelTowerDifficulty.GetValueOrDefault();
			this.StartItem.SetDifficultyBg(valueOrDefault.TextBgColor);
			this.StartItem.SetDifficultyText(valueOrDefault.DifficultyTextKey);
		}
		this.StartItem.SetDeBuffNum(BabelTowerModel.Instance.GetSelectedDeTermCount());
		this.StartItem.SetNameText(babelTowerLevelConfig.NameText);
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x0018359F File Offset: 0x0018179F
	private void OnQuestBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x06007561 RID: 30049 RVA: 0x001835B2 File Offset: 0x001817B2
	private void OnRankBtnClick()
	{
		if (this.LevelInfo != null)
		{
			UiManager.Instance.OpenView(EUiViewName.BabelTowerRankView, this.LevelInfo.BabelTowerLevelId, null);
		}
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x001835DC File Offset: 0x001817DC
	private void OnLookBtnClick()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId);
		InstanceDungeonEntranceModel.Instance.SelectInstanceId = babelTowerLevelConfig.InstId;
		InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam param = new InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam
		{
			InstanceId = babelTowerLevelConfig.InstId,
			InfoType = null
		};
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, param, null);
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0018364C File Offset: 0x0018184C
	private void OnRoleSkillBranchChanged(int roleId)
	{
		BabelTowerHardLevelRoleTeamPanel roleTeamItem = this.RoleTeamItem;
		if (roleTeamItem != null)
		{
			roleTeamItem.RefreshRoleSkillBranch(roleId);
		}
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.RefreshSkillBranchIcon();
	}

	// Token: 0x040035E5 RID: 13797
	private PopupCaptionItem CaptionItem;

	// Token: 0x040035E6 RID: 13798
	private BabelTowerHardLevelStarItem StartItem;

	// Token: 0x040035E7 RID: 13799
	private BabelTowerHardLevelRightItem RightItem;

	// Token: 0x040035E8 RID: 13800
	private BabelTowerHardLevelRoleTeamPanel RoleTeamItem;

	// Token: 0x040035E9 RID: 13801
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x02007728 RID: 30504
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040274F4 RID: 161012
		public const int CaptionItem = 0;

		// Token: 0x040274F5 RID: 161013
		public const int QuestBtn = 1;

		// Token: 0x040274F6 RID: 161014
		public const int HardBg = 2;

		// Token: 0x040274F7 RID: 161015
		public const int BossBg = 3;

		// Token: 0x040274F8 RID: 161016
		public const int StartItem = 4;

		// Token: 0x040274F9 RID: 161017
		public const int RightItem = 5;

		// Token: 0x040274FA RID: 161018
		public const int RoleTeamItem = 6;

		// Token: 0x040274FB RID: 161019
		public const int RankBtn = 7;
	}
}
