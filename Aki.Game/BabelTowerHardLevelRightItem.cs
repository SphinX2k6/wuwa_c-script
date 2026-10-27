using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001162 RID: 4450
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerHardLevelRightItem : UiPanelBase
{
	// Token: 0x06007565 RID: 30053 RVA: 0x0018367C File Offset: 0x0018187C
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

	// Token: 0x06007566 RID: 30054 RVA: 0x001838DC File Offset: 0x00181ADC
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelRightItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x00183920 File Offset: 0x00181B20
	private UniTask InitBuffItems()
	{
		BabelTowerHardLevelRightItem.<InitBuffItems>d__8 <InitBuffItems>d__;
		<InitBuffItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBuffItems>d__.<>4__this = this;
		<InitBuffItems>d__.<>1__state = -1;
		<InitBuffItems>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<InitBuffItems>d__8>(ref <InitBuffItems>d__);
		return <InitBuffItems>d__.<>t__builder.Task;
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x00183964 File Offset: 0x00181B64
	private UniTask InitTeamItem()
	{
		BabelTowerHardLevelRightItem.<InitTeamItem>d__9 <InitTeamItem>d__;
		<InitTeamItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitTeamItem>d__.<>4__this = this;
		<InitTeamItem>d__.<>1__state = -1;
		<InitTeamItem>d__.<>t__builder.Start<BabelTowerHardLevelRightItem.<InitTeamItem>d__9>(ref <InitTeamItem>d__);
		return <InitTeamItem>d__.<>t__builder.Task;
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x001839A8 File Offset: 0x00181BA8
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

	// Token: 0x0600756A RID: 30058 RVA: 0x00183AC8 File Offset: 0x00181CC8
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
		bool uiactive = BabelTowerController.Instance.BuildSkillBranchListFromRoleList(roleList).Any((int branchId) => branchId > 0);
		base.GetButton(10).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x00183B9C File Offset: 0x00181D9C
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

	// Token: 0x0600756C RID: 30060 RVA: 0x00183BEC File Offset: 0x00181DEC
	public void SetRoleDetailBtnVisible(bool visible)
	{
		UUIButtonComponent button = base.GetButton(11);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(visible);
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x00183C19 File Offset: 0x00181E19
	public void RefreshSkillBranchIcon()
	{
		BabelTowerTeamItem teamItem = this.TeamItem;
		if (teamItem == null)
		{
			return;
		}
		teamItem.RefreshSkillBranchIcon();
	}

	// Token: 0x0600756E RID: 30062 RVA: 0x00183C2C File Offset: 0x00181E2C
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

	// Token: 0x0600756F RID: 30063 RVA: 0x00183CB4 File Offset: 0x00181EB4
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

	// Token: 0x06007570 RID: 30064 RVA: 0x00183E32 File Offset: 0x00182032
	[NullableContext(1)]
	private void OnBuffSelectConfirm(List<int> buffList)
	{
		this.LevelInfo.BuffList = buffList;
		this.RefreshBuff();
	}

	// Token: 0x06007571 RID: 30065 RVA: 0x00183E46 File Offset: 0x00182046
	private void OnTeamBtnClick()
	{
		Action onClickBattleTeamCallBack = this.OnClickBattleTeamCallBack;
		if (onClickBattleTeamCallBack == null)
		{
			return;
		}
		onClickBattleTeamCallBack();
	}

	// Token: 0x06007572 RID: 30066 RVA: 0x00183E58 File Offset: 0x00182058
	private void OnStartBtnClick()
	{
		BabelTowerController.Instance.BabelTowerStartRequest(this.LevelInfo.InstanceId, this.LevelInfo.RoleList, this.LevelInfo.BabelTowerLevelId, this.LevelInfo.BuffList, BabelTowerController.Instance.BuildSkillBranchListFromRoleList(this.LevelInfo.RoleList));
	}

	// Token: 0x06007573 RID: 30067 RVA: 0x00183EB0 File Offset: 0x001820B0
	private void OnRoleDetailBtnClick()
	{
		IBabelTowerLevelInfo levelInfo = this.LevelInfo;
		List<int> list;
		if (levelInfo == null)
		{
			list = null;
		}
		else
		{
			list = (from id in levelInfo.RoleList
			where id > 0
			select id).ToList<int>();
		}
		List<int> list2 = list ?? new List<int>();
		int num = (list2.Count > 0) ? list2[list2.Count - 1] : 0;
		List<int> roleDetailRoleIdList = this.GetRoleDetailRoleIdList(num, list2);
		RoleController.Instance.OpenRoleMainViewByParam(new OpenRoleMainViewData
		{
			AgentType = ERoleAgentType.Normal,
			SelectRoleId = new int?(num),
			RoleIdList = roleDetailRoleIdList,
			TeamPositionType = new ETeamPositionType?(ETeamPositionType.EditFormation),
			Source = new ERoleViewSource?(ERoleViewSource.BabelTower)
		});
	}

	// Token: 0x06007574 RID: 30068 RVA: 0x00183F68 File Offset: 0x00182168
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

	// Token: 0x06007575 RID: 30069 RVA: 0x00183FBC File Offset: 0x001821BC
	[NullableContext(1)]
	private List<int> GetRoleDetailRoleIdList(int selectRoleId, List<int> currentRoleList)
	{
		if (selectRoleId >= 100000)
		{
			return this.CollectTrialRoleIds();
		}
		HashSet<int> hashSet = new HashSet<int>(currentRoleList);
		foreach (int item in RoleModel.Instance.GetRoleIdList())
		{
			hashSet.Add(item);
		}
		return hashSet.ToList<int>();
	}

	// Token: 0x06007576 RID: 30070 RVA: 0x00184030 File Offset: 0x00182230
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
		return new HashSet<int>(list).ToList<int>();
	}

	// Token: 0x040035EA RID: 13802
	public Action OnClickBattleTeamCallBack;

	// Token: 0x040035EB RID: 13803
	private BabelTowerLevelBuffItem BuffItem1;

	// Token: 0x040035EC RID: 13804
	private BabelTowerLevelBuffItem BuffItem2;

	// Token: 0x040035ED RID: 13805
	private BabelTowerTeamItem TeamItem;

	// Token: 0x040035EE RID: 13806
	private IBabelTowerLevelInfo LevelInfo;

	// Token: 0x0200772E RID: 30510
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04027510 RID: 161040
		public const int ActivatItem = 0;

		// Token: 0x04027511 RID: 161041
		public const int BossInfoItem = 1;

		// Token: 0x04027512 RID: 161042
		public const int BossNameText = 2;

		// Token: 0x04027513 RID: 161043
		public const int BossSprityBg = 3;

		// Token: 0x04027514 RID: 161044
		public const int MechanismItem = 4;

		// Token: 0x04027515 RID: 161045
		public const int MechanismDesText = 5;

		// Token: 0x04027516 RID: 161046
		public const int EntryOneItem = 6;

		// Token: 0x04027517 RID: 161047
		public const int EntryTwoItem = 7;

		// Token: 0x04027518 RID: 161048
		public const int BattleTeamItem = 8;

		// Token: 0x04027519 RID: 161049
		public const int RedText = 9;

		// Token: 0x0402751A RID: 161050
		public const int RoleTagBtn = 10;

		// Token: 0x0402751B RID: 161051
		public const int RoleDetailBtn = 11;

		// Token: 0x0402751C RID: 161052
		public const int StartBtn = 12;
	}
}
