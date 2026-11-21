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

// Token: 0x02000615 RID: 1557
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelInfoViewNew : UiViewBase
{
	// Token: 0x060048E5 RID: 18661 RVA: 0x0018BA48 File Offset: 0x00189C48
	[NullableContext(1)]
	public BabelTowerHardLevelInfoViewNew(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x060048E6 RID: 18662 RVA: 0x0018BA54 File Offset: 0x00189C54
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

	// Token: 0x060048E7 RID: 18663 RVA: 0x0018BBE3 File Offset: 0x00189DE3
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060048E8 RID: 18664 RVA: 0x0018BC01 File Offset: 0x00189E01
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060048E9 RID: 18665 RVA: 0x0018BC1F File Offset: 0x00189E1F
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

	// Token: 0x060048EA RID: 18666 RVA: 0x0018BC3C File Offset: 0x00189E3C
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelInfoViewNew.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060048EB RID: 18667 RVA: 0x0018BC80 File Offset: 0x00189E80
	private UniTask InitCaptionItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitCaptionItem>d__12 <InitCaptionItem>d__;
		<InitCaptionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitCaptionItem>d__.<>4__this = this;
		<InitCaptionItem>d__.<>1__state = -1;
		<InitCaptionItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitCaptionItem>d__12>(ref <InitCaptionItem>d__);
		return <InitCaptionItem>d__.<>t__builder.Task;
	}

	// Token: 0x060048EC RID: 18668 RVA: 0x0018BCC4 File Offset: 0x00189EC4
	private UniTask InitRoleTeamItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitRoleTeamItem>d__13 <InitRoleTeamItem>d__;
		<InitRoleTeamItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleTeamItem>d__.<>4__this = this;
		<InitRoleTeamItem>d__.<>1__state = -1;
		<InitRoleTeamItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitRoleTeamItem>d__13>(ref <InitRoleTeamItem>d__);
		return <InitRoleTeamItem>d__.<>t__builder.Task;
	}

	// Token: 0x060048ED RID: 18669 RVA: 0x0018BD08 File Offset: 0x00189F08
	private UniTask InitStartItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitStartItem>d__14 <InitStartItem>d__;
		<InitStartItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitStartItem>d__.<>4__this = this;
		<InitStartItem>d__.<>1__state = -1;
		<InitStartItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitStartItem>d__14>(ref <InitStartItem>d__);
		return <InitStartItem>d__.<>t__builder.Task;
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x0018BD4C File Offset: 0x00189F4C
	private UniTask InitRightItem()
	{
		BabelTowerHardLevelInfoViewNew.<InitRightItem>d__15 <InitRightItem>d__;
		<InitRightItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRightItem>d__.<>4__this = this;
		<InitRightItem>d__.<>1__state = -1;
		<InitRightItem>d__.<>t__builder.Start<BabelTowerHardLevelInfoViewNew.<InitRightItem>d__15>(ref <InitRightItem>d__);
		return <InitRightItem>d__.<>t__builder.Task;
	}

	// Token: 0x060048EF RID: 18671 RVA: 0x0018BD90 File Offset: 0x00189F90
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

	// Token: 0x060048F0 RID: 18672 RVA: 0x0018BE24 File Offset: 0x0018A024
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

	// Token: 0x060048F1 RID: 18673 RVA: 0x0018BEC8 File Offset: 0x0018A0C8
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

	// Token: 0x060048F2 RID: 18674 RVA: 0x0018BF1C File Offset: 0x0018A11C
	private void OnRoleTeamRefresh()
	{
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.RefreshTeamRole();
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x0018BF2E File Offset: 0x0018A12E
	private void OnSelectModeChange(EBabelTowerTeamTabType tabType)
	{
		BabelTowerHardLevelRightItem rightItem = this.RightItem;
		if (rightItem == null)
		{
			return;
		}
		rightItem.RefreshTeamRole();
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x0018BF40 File Offset: 0x0018A140
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

	// Token: 0x060048F5 RID: 18677 RVA: 0x0018BF68 File Offset: 0x0018A168
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

	// Token: 0x060048F6 RID: 18678 RVA: 0x0018C014 File Offset: 0x0018A214
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

	// Token: 0x060048F7 RID: 18679 RVA: 0x0018C0D7 File Offset: 0x0018A2D7
	private void OnQuestBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.BabelTowerQuestView, null, null);
	}

	// Token: 0x060048F8 RID: 18680 RVA: 0x0018C0EA File Offset: 0x0018A2EA
	private void OnRankBtnClick()
	{
		if (this.LevelInfo != null)
		{
			UiManager.Instance.OpenView(EUiViewName.BabelTowerRankView, this.LevelInfo.BabelTowerLevelId, null);
		}
	}

	// Token: 0x060048F9 RID: 18681 RVA: 0x0018C114 File Offset: 0x0018A314
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

	// Token: 0x060048FA RID: 18682 RVA: 0x0018C184 File Offset: 0x0018A384
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

	// Token: 0x0400367E RID: 13950
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400367F RID: 13951
	private BabelTowerHardLevelStarItem StartItem;

	// Token: 0x04003680 RID: 13952
	private BabelTowerHardLevelRightItem RightItem;

	// Token: 0x04003681 RID: 13953
	private BabelTowerHardLevelRoleTeamPanel RoleTeamItem;

	// Token: 0x04003682 RID: 13954
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x020068B6 RID: 26806
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04022833 RID: 141363
		public const int CaptionItem = 0;

		// Token: 0x04022834 RID: 141364
		public const int QuestBtn = 1;

		// Token: 0x04022835 RID: 141365
		public const int HardBg = 2;

		// Token: 0x04022836 RID: 141366
		public const int BossBg = 3;

		// Token: 0x04022837 RID: 141367
		public const int StartItem = 4;

		// Token: 0x04022838 RID: 141368
		public const int RightItem = 5;

		// Token: 0x04022839 RID: 141369
		public const int RoleTeamItem = 6;

		// Token: 0x0402283A RID: 141370
		public const int RankBtn = 7;
	}
}
