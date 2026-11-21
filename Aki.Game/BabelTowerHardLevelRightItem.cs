using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000616 RID: 1558
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelRightItem : UiPanelBase
{
	// Token: 0x060048FC RID: 18684 RVA: 0x0018C1B4 File Offset: 0x0018A3B4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnStartBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnRoleDetailBtnClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnRoleTagBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060048FD RID: 18685 RVA: 0x0018C414 File Offset: 0x0018A614
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelRightItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060048FE RID: 18686 RVA: 0x0018C458 File Offset: 0x0018A658
	private UniTask InitBuffItems()
	{
		BabelTowerHardLevelRightItem.<InitBuffItems>d__8 <InitBuffItems>d__;
		<InitBuffItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuffItems>d__.<>4__this = this;
		<InitBuffItems>d__.<>1__state = -1;
		<InitBuffItems>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<InitBuffItems>d__8>(ref <InitBuffItems>d__);
		return <InitBuffItems>d__.<>t__builder.Task;
	}

	// Token: 0x060048FF RID: 18687 RVA: 0x0018C49C File Offset: 0x0018A69C
	private UniTask InitTeamItem()
	{
		BabelTowerHardLevelRightItem.<InitTeamItem>d__9 <InitTeamItem>d__;
		<InitTeamItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTeamItem>d__.<>4__this = this;
		<InitTeamItem>d__.<>1__state = -1;
		<InitTeamItem>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<InitTeamItem>d__9>(ref <InitTeamItem>d__);
		return <InitTeamItem>d__.<>t__builder.Task;
	}

	// Token: 0x06004900 RID: 18688 RVA: 0x0018C4E0 File Offset: 0x0018A6E0
	[NullableContext(1)]
	public void SetLevelInfo(IBabelTowerLevelInfo levelInfo)
	{
		this.LevelInfo = levelInfo;
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId);
		bool isDifficult = babelTowerLevelConfig.IsDifficult;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(isDifficult);
		}
		UUIItem item2 = base.GetItem(0);
		if (item2 != null)
		{
			item2.SetUIActive(!isDifficult);
		}
		UUIItem item3 = base.GetItem(4);
		if (item3 != null)
		{
			item3.SetUIActive(isDifficult);
		}
		if (isDifficult && !string.IsNullOrEmpty(babelTowerLevelConfig.BossTitleTexture))
		{
			base.SetTextureByPath(babelTowerLevelConfig.BossTitleTexture, base.GetTexture(3), null, null);
		}
		if (isDifficult && !string.IsNullOrEmpty(babelTowerLevelConfig.BossNameText) && !StringUtils.IsBlank(babelTowerLevelConfig.BossNameText))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), babelTowerLevelConfig.BossNameText, Array.Empty<object>());
		}
		if (!string.IsNullOrEmpty(babelTowerLevelConfig.LevelDesText) && !StringUtils.IsBlank(babelTowerLevelConfig.LevelDesText))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), babelTowerLevelConfig.LevelDesText, Array.Empty<object>());
		}
		this.RefreshBuff();
		this.RefreshTeamRole();
	}

	// Token: 0x06004901 RID: 18689 RVA: 0x0018C600 File Offset: 0x0018A800
	public void RefreshTeamRole()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		List<int> roleList = this.LevelInfo.RoleList;
		List<int> list = new List<int>();
		int num = 0;
		for (;;)
		{
			int num2 = num;
			int? babel_TOWER_TEAM_ROLE_SLOT_COUNT = BabelTowerDefine.BABEL_TOWER_TEAM_ROLE_SLOT_COUNT;
			if (!(num2 < babel_TOWER_TEAM_ROLE_SLOT_COUNT.GetValueOrDefault() & babel_TOWER_TEAM_ROLE_SLOT_COUNT != null))
			{
				break;
			}
			int item = (num < roleList.Count) ? roleList[num] : 0;
			list.Add(item);
			num++;
		}
		this.TeamItem.RefreshItem(list, this.LevelInfo.InstanceId);
		this.RefreshLowLevelTips();
		bool uiactive = BabelTowerController.Instance.BuildSkillBranchListFromRoleList(roleList).Exists((int branchId) => branchId > 0);
		base.GetButton(10).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06004902 RID: 18690 RVA: 0x0018C6D4 File Offset: 0x0018A8D4
	private void RefreshLowLevelTips()
	{
		if (this.LevelInfo == null)
		{
			return;
		}
		bool ifLevelTooLow = BabelTowerModel.Instance.GetIfLevelTooLow(this.LevelInfo.InstanceId, this.LevelInfo.RoleList.ToArray());
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(ifLevelTooLow);
	}

	// Token: 0x06004903 RID: 18691 RVA: 0x0018C724 File Offset: 0x0018A924
	public void SetRoleDetailBtnVisible(bool visible)
	{
		UUIButtonComponent button = base.GetButton(11);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x06004904 RID: 18692 RVA: 0x0018C751 File Offset: 0x0018A951
	public void RefreshSkillBranchIcon()
	{
		BabelTowerTeamItem teamItem = this.TeamItem;
		if (teamItem == null)
		{
			return;
		}
		teamItem.RefreshSkillBranchIcon();
	}

	// Token: 0x06004905 RID: 18693 RVA: 0x0018C764 File Offset: 0x0018A964
	private void RefreshBuff()
	{
		List<int> buffList = this.LevelInfo.BuffList;
		int buffId = (buffList != null && buffList.Count > 0) ? buffList[0] : 0;
		BabelTowerLevelBuffItem buffItem = this.BuffItem1;
		if (buffItem != null)
		{
			buffItem.RefreshItem(this.LevelInfo.BuffCount < 1, buffId);
		}
		int buffId2 = (buffList != null && buffList.Count > 1) ? buffList[1] : 0;
		BabelTowerLevelBuffItem buffItem2 = this.BuffItem2;
		if (buffItem2 == null)
		{
			return;
		}
		buffItem2.RefreshItem(this.LevelInfo.BuffCount < 2, buffId2);
	}

	// Token: 0x06004906 RID: 18694 RVA: 0x0018C7EC File Offset: 0x0018A9EC
	private void OnBuffItemClick(int buffId)
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.LevelInfo.BabelTowerLevelId);
		bool isDifficult = babelTowerLevelConfig.IsDifficult;
		List<IBabelTowerBuffInfo> list = new List<IBabelTowerBuffInfo>();
		BabelTowerData babelTowerData = BabelTowerController.Instance.GetBabelTowerData();
		for (int i = 0; i < babelTowerLevelConfig.OptionalBabelBuffLength; i++)
		{
			int num = babelTowerLevelConfig.OptionalBabelBuff(i);
			EBabelTowerBuffState state = EBabelTowerBuffState.Normal;
			if (isDifficult)
			{
				if (babelTowerData.GetBuffIsLock(num))
				{
					state = EBabelTowerBuffState.Lock;
				}
				else
				{
					int buffIsUse = babelTowerData.GetBuffIsUse(num);
					if (buffIsUse > 0 && buffIsUse != this.LevelInfo.BabelTowerLevelId)
					{
						state = EBabelTowerBuffState.Use;
					}
				}
			}
			bool isRecommend = false;
			for (int j = 0; j < babelTowerLevelConfig.RecommendBuffLength; j++)
			{
				if (babelTowerLevelConfig.RecommendBuff(j) == num)
				{
					isRecommend = true;
					break;
				}
			}
			BabelTowerBuffInfo babelTowerBuffInfo = new BabelTowerBuffInfo();
			babelTowerBuffInfo.Id = num;
			babelTowerBuffInfo.State = state;
			IBabelTowerLevelInfo levelInfo = this.LevelInfo;
			babelTowerBuffInfo.LevelId = ((levelInfo != null) ? new int?(levelInfo.BabelTowerLevelId) : null);
			babelTowerBuffInfo.IsRecommend = isRecommend;
			BabelTowerBuffInfo item = babelTowerBuffInfo;
			list.Add(item);
		}
		BabelTowerBuffSelectViewInfo param = new BabelTowerBuffSelectViewInfo
		{
			LevelId = this.LevelInfo.BabelTowerLevelId,
			CurrentSelectBuffList = new List<int>(this.LevelInfo.BuffList),
			ShowBuffId = buffId,
			MaxSelectBuffCount = babelTowerLevelConfig.OptionalBabelBuffNum,
			AllBuffList = list,
			OnConfirmCallBack = new Action<List<int>>(this.OnBuffSelectConfirm)
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerBuffSelectView, param, null);
	}

	// Token: 0x06004907 RID: 18695 RVA: 0x0018C96A File Offset: 0x0018AB6A
	[NullableContext(1)]
	private void OnBuffSelectConfirm(List<int> buffList)
	{
		this.LevelInfo.BuffList = buffList;
		this.RefreshBuff();
	}

	// Token: 0x06004908 RID: 18696 RVA: 0x0018C97E File Offset: 0x0018AB7E
	private void OnTeamBtnClick()
	{
		Action onClickBattleTeamCallBack = this.OnClickBattleTeamCallBack;
		if (onClickBattleTeamCallBack == null)
		{
			return;
		}
		onClickBattleTeamCallBack();
	}

	// Token: 0x06004909 RID: 18697 RVA: 0x0018C990 File Offset: 0x0018AB90
	private void OnStartBtnClick()
	{
		BabelTowerController.Instance.BabelTowerStartRequest(this.LevelInfo.InstanceId, this.LevelInfo.RoleList, this.LevelInfo.BabelTowerLevelId, this.LevelInfo.BuffList, BabelTowerController.Instance.BuildSkillBranchListFromRoleList(this.LevelInfo.RoleList));
	}

	// Token: 0x0600490A RID: 18698 RVA: 0x0018C9E8 File Offset: 0x0018ABE8
	private void OnRoleDetailBtnClick()
	{
		List<int> list = new List<int>();
		IBabelTowerLevelInfo levelInfo = this.LevelInfo;
		List<int> list2 = (levelInfo != null) ? levelInfo.RoleList : null;
		if (list2 != null)
		{
			foreach (int num in list2)
			{
				if (num > 0)
				{
					list.Add(num);
				}
			}
		}
		int num2 = (list.Count > 0) ? list[list.Count - 1] : 0;
		List<int> roleDetailRoleIdList = this.GetRoleDetailRoleIdList(num2, list);
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			SelectRoleId = new int?(num2),
			RoleIdList = roleDetailRoleIdList,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.EditFormation),
			Source = new ERoleViewSource?(ERoleViewSource.BabelTower)
		});
	}

	// Token: 0x0600490B RID: 18699 RVA: 0x0018CAC0 File Offset: 0x0018ACC0
	private void OnRoleTagBtnClick()
	{
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams2 = roleSkillBranchPopViewParams;
		int[][] array = new int[1][];
		int num = 0;
		IBabelTowerLevelInfo levelInfo = this.LevelInfo;
		array[num] = (((levelInfo != null) ? levelInfo.RoleList.ToArray() : null) ?? Array.Empty<int>());
		roleSkillBranchPopViewParams2.Load(array);
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, roleSkillBranchPopViewParams, null);
	}

	// Token: 0x0600490C RID: 18700 RVA: 0x0018CB14 File Offset: 0x0018AD14
	[NullableContext(1)]
	private List<int> GetRoleDetailRoleIdList(int selectRoleId, List<int> currentRoleList)
	{
		if (selectRoleId >= 100000)
		{
			return this.CollectTrialRoleIds();
		}
		HashSet<int> hashSet = new HashSet<int>(currentRoleList);
		foreach (int item in RoleModel.Instance.GetRoleIdList(null))
		{
			hashSet.Add(item);
		}
		return new List<int>(hashSet);
	}

	// Token: 0x0600490D RID: 18701 RVA: 0x0018CB8C File Offset: 0x0018AD8C
	[NullableContext(1)]
	private List<int> CollectTrialRoleIds()
	{
		int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(this.LevelInfo.InstanceId).Value.FightFormationId;
		FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
		int[] array = (fightFormationConfig != null) ? fightFormationConfig.Value.GetTrialRoleArray() : Array.Empty<int>();
		List<int> list = new List<int>();
		foreach (int id in array)
		{
			TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
			if (trialRoleConfigByGroupId != null)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list.Add(roleDataById.GetDataId());
				}
			}
		}
		return new List<int>(new HashSet<int>(list));
	}

	// Token: 0x04003683 RID: 13955
	public Action OnClickBattleTeamCallBack;

	// Token: 0x04003684 RID: 13956
	private BabelTowerLevelBuffItem BuffItem1;

	// Token: 0x04003685 RID: 13957
	private BabelTowerLevelBuffItem BuffItem2;

	// Token: 0x04003686 RID: 13958
	private BabelTowerTeamItem TeamItem;

	// Token: 0x04003687 RID: 13959
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x020068BC RID: 26812
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402284F RID: 141391
		public const int ActivatItem = 0;

		// Token: 0x04022850 RID: 141392
		public const int BossInfoItem = 1;

		// Token: 0x04022851 RID: 141393
		public const int BossNameText = 2;

		// Token: 0x04022852 RID: 141394
		public const int BossSprityBg = 3;

		// Token: 0x04022853 RID: 141395
		public const int MechanismItem = 4;

		// Token: 0x04022854 RID: 141396
		public const int MechanismDesText = 5;

		// Token: 0x04022855 RID: 141397
		public const int EntryOneItem = 6;

		// Token: 0x04022856 RID: 141398
		public const int EntryTwoItem = 7;

		// Token: 0x04022857 RID: 141399
		public const int BattleTeamItem = 8;

		// Token: 0x04022858 RID: 141400
		public const int RedText = 9;

		// Token: 0x04022859 RID: 141401
		public const int RoleTagBtn = 10;

		// Token: 0x0402285A RID: 141402
		public const int RoleDetailBtn = 11;

		// Token: 0x0402285B RID: 141403
		public const int StartBtn = 12;
	}
}
