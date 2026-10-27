using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001160 RID: 4448
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelInfoView : UiViewBase
{
	// Token: 0x06007539 RID: 30009 RVA: 0x0018201B File Offset: 0x0018021B
	public BabelTowerHardLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600753A RID: 30010 RVA: 0x00182024 File Offset: 0x00180224
	protected unsafe override void OnRegisterComponent()
	{
		int num = 13;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLevelDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600753B RID: 30011 RVA: 0x00182260 File Offset: 0x00180460
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelInfoView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelInfoView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x001822A3 File Offset: 0x001804A3
	protected override void OnStart()
	{
		this.BabelTowerLevelInfo = (this.OpenParam as IBabelTowerLevelInfo);
		base.GetItem(12).SetUIActive(true);
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x001822E0 File Offset: 0x001804E0
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x0600753E RID: 30014 RVA: 0x00182300 File Offset: 0x00180500
	protected override void OnBeforeShow()
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		for (int i = 0; i < this.BabelTowerLevelInfo.RoleList.Count; i++)
		{
			int num = this.BabelTowerLevelInfo.RoleList[i];
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
			int num2 = (roleDataById != null) ? roleDataById.GetRoleId() : 0;
			if (RoleModel.Instance.IsMainRole(num2))
			{
				if (num < 100000 && RoleModel.Instance.GetRoleInstanceById(num2) == null)
				{
					this.BabelTowerLevelInfo.RoleList[i] = 0;
				}
				TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(num);
				if (num > 100000 && trialRoleConfig != null && trialRoleConfig.Value.Gender != (int)playerGender)
				{
					this.BabelTowerLevelInfo.RoleList[i] = 0;
				}
			}
		}
		this.RefreshView();
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x001823E1 File Offset: 0x001805E1
	private void OnClickButton()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.MultiTeamRoleSelectView))
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetRoleSelectViewData(), null);
		}
	}

	// Token: 0x06007540 RID: 30016 RVA: 0x0018240C File Offset: 0x0018060C
	private void OnRoleChangeEnd()
	{
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		RoleModel instance = RoleModel.Instance;
		bool flag = false;
		for (int i = 0; i < this.BabelTowerLevelInfo.RoleList.Count; i++)
		{
			int num = this.BabelTowerLevelInfo.RoleList[i];
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
			int roleId = (roleDataById != null) ? roleDataById.GetRoleId() : 0;
			if (instance.IsMainRole(roleId))
			{
				TrialRoleInfo? trialRoleConfig = RoleConfig.Instance.GetTrialRoleConfig(num);
				if (num < 100000 || (trialRoleConfig != null && trialRoleConfig.Value.Gender != (int)playerGender))
				{
					flag = true;
					this.BabelTowerLevelInfo.RoleList[i] = 0;
				}
			}
		}
		if (!flag)
		{
			return;
		}
		List<int> list = new List<int>();
		for (int j = 0; j < this.BabelTowerLevelInfo.RoleList.Count; j++)
		{
			int num2 = this.BabelTowerLevelInfo.RoleList[j];
			if (num2 != 0)
			{
				list.Add(num2);
			}
		}
		while (list.Count < 3)
		{
			list.Add(0);
		}
		this.BabelTowerLevelInfo.RoleList = list;
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x0018253C File Offset: 0x0018073C
	private MultiTeamRoleSelectData GetRoleSelectViewData()
	{
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.BabelTowerLevelInfo.BabelTowerLevelId);
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		int fightFormationId = (config != null) ? config.Value.FightFormationId : 0;
		FightFormation? fightFormationConfig = FormationConfig.Instance.GetFightFormationConfig(fightFormationId);
		RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
		List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
		List<int> list2;
		if (!BabelTowerController.Instance.GetBabelTowerData().RoleLockData.TryGetValue(this.BabelTowerLevelInfo.BabelTowerLevelId, out list2))
		{
			list2 = new List<int>();
		}
		foreach (RoleInstance roleInstance in roleList)
		{
			if (roleInstance.GetRoleId() != 0)
			{
				int weaponType = roleInstance.GetRoleConfig().WeaponType;
				bool isUnRecommend = false;
				for (int j = 0; j < babelTowerLevelConfig.UnRecommendRoleListLength; j++)
				{
					if (babelTowerLevelConfig.UnRecommendRoleList(j) == roleInstance.GetRoleId())
					{
						isUnRecommend = true;
						break;
					}
				}
				MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, false, list2.Count > 0 && !list2.Contains(weaponType), isUnRecommend);
				list.Add(item);
			}
		}
		List<MultiTeamRoleGridData> list3 = new List<MultiTeamRoleGridData>();
		int[] array = (fightFormationConfig != null) ? fightFormationConfig.Value.GetTrialRoleArray() : Array.Empty<int>();
		EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
		IReadOnlyList<MainRoleConfig> mainRoleByGender = RoleConfig.Instance.GetMainRoleByGender((playerGender == EPlayerGender.Male) ? LoginDefine.ELoginSex.Boy : LoginDefine.ELoginSex.Girl);
		List<int> list4 = new List<int>();
		if (mainRoleByGender != null)
		{
			for (int k = 0; k < mainRoleByGender.Count; k++)
			{
				list4.Add(mainRoleByGender[k].Id);
			}
		}
		foreach (int id in array)
		{
			TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
			if (trialRoleConfigByGroupId != null)
			{
				if (RoleModel.Instance.IsMainRole(trialRoleConfigByGroupId.Value.ParentId))
				{
					bool flag = false;
					for (int m = 0; m < list4.Count; m++)
					{
						if (list4[m] == trialRoleConfigByGroupId.Value.ParentId)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						goto IL_268;
					}
				}
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list3.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
				}
			}
			IL_268:;
		}
		MultiTeamRoleData item2 = MultiTeamRoleData.Phrase("BossRushNormalRole", list);
		List<MultiTeamRoleData> list5 = new List<MultiTeamRoleData>();
		if (list3.Count > 0)
		{
			MultiTeamRoleData item3 = MultiTeamRoleData.Phrase("BossRushTrailRole", list3);
			list5.Add(item3);
		}
		list5.Add(item2);
		List<int> roleList2 = this.BabelTowerLevelInfo.RoleList;
		List<int> list6 = new List<int>();
		for (int n = 0; n < roleList2.Count; n++)
		{
			int num = roleList2[n];
			if (num != 0)
			{
				list6.Add(num);
			}
		}
		int[] array2 = new int[babelTowerLevelConfig.UnRecommendRoleListLength];
		for (int num2 = 0; num2 < babelTowerLevelConfig.UnRecommendRoleListLength; num2++)
		{
			array2[num2] = babelTowerLevelConfig.UnRecommendRoleList(num2);
		}
		MultiTeamRoleSelectData result = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, list6.ToArray(), null, new Func<int[], bool>(this.OnCanChangeRole), new Action<int[], int[]>(this.OnEnsureFormation), null, list5, array2, "BabelTeamTips_1", "");
		BattleTeamModel.Instance.Context.SetInstanceDungeonId(new int?(instanceId));
		return result;
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x001828C8 File Offset: 0x00180AC8
	private void OnEnsureFormation(int[] roleIdList, int[] tagList)
	{
		for (int i = 0; i < 3; i++)
		{
			this.BabelTowerLevelInfo.RoleList[i] = 0;
		}
		for (int j = 0; j < roleIdList.Length; j++)
		{
			int value = roleIdList[j];
			this.BabelTowerLevelInfo.RoleList[j] = value;
		}
		this.OnSelectTeamRole();
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x00182920 File Offset: 0x00180B20
	private bool OnCanChangeRole(int[] roleIdList)
	{
		List<int> list;
		if (!BabelTowerController.Instance.GetBabelTowerData().RoleLockData.TryGetValue(this.BabelTowerLevelInfo.BabelTowerLevelId, out list))
		{
			list = new List<int>();
		}
		List<int> list2 = new List<int>();
		foreach (int num in roleIdList)
		{
			if (num != 0)
			{
				int weaponType = RoleConfig.Instance.GetRoleConfig(num).Value.WeaponType;
				if (list.Count > 0 && !list.Contains(weaponType))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("BabelTowerDebuffRoleSelectionTips", Array.Empty<object>());
					return false;
				}
				int baseRoleId = RoleConfig.Instance.GetBaseRoleId(num);
				bool flag = false;
				for (int j = 0; j < list2.Count; j++)
				{
					if (list2[j] == baseRoleId)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Text_SameRole_Text", Array.Empty<object>());
					return false;
				}
				list2.Add(baseRoleId);
			}
		}
		return true;
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x00182A1B File Offset: 0x00180C1B
	private void OnSelectTeamRole()
	{
		this.RefreshLowLevelTips();
		this.RefreshTeamRole();
	}

	// Token: 0x06007545 RID: 30021 RVA: 0x00182A2C File Offset: 0x00180C2C
	private void RefreshLowLevelTips()
	{
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
		bool ifLevelTooLow = BabelTowerModel.Instance.GetIfLevelTooLow(instanceId, this.BabelTowerLevelInfo.RoleList.ToArray());
		base.GetItem(5).SetUIActive(ifLevelTooLow);
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x00182A70 File Offset: 0x00180C70
	public void RefreshTeamRole()
	{
		List<int> list;
		if (!BabelTowerController.Instance.GetBabelTowerData().RoleLockData.TryGetValue(this.BabelTowerLevelInfo.BabelTowerLevelId, out list))
		{
			list = new List<int>();
		}
		List<int> roleList = this.BabelTowerLevelInfo.RoleList;
		for (int i = 0; i < roleList.Count; i++)
		{
			int num = roleList[i];
			if (num != 0)
			{
				int weaponType = RoleConfig.Instance.GetRoleConfig(num).Value.WeaponType;
				if (list.Count > 0 && !list.Contains(weaponType))
				{
					roleList[i] = 0;
				}
			}
		}
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
		this.TeamItem.RefreshItem(roleList, instanceId);
	}

	// Token: 0x06007547 RID: 30023 RVA: 0x00182B24 File Offset: 0x00180D24
	private void RefreshBuff()
	{
		List<int> buffList = this.BabelTowerLevelInfo.BuffList;
		int buffId = (buffList != null && buffList.Count > 0) ? buffList[0] : 0;
		BabelTowerLevelBuffItem babelTowerLevelBuffItem = this.BabelTowerLevelBuffItem1;
		if (babelTowerLevelBuffItem != null)
		{
			babelTowerLevelBuffItem.RefreshItem(this.BabelTowerLevelInfo.BuffCount < 1, buffId);
		}
		int buffId2 = (buffList != null && buffList.Count > 1) ? buffList[1] : 0;
		BabelTowerLevelBuffItem babelTowerLevelBuffItem2 = this.BabelTowerLevelBuffItem2;
		if (babelTowerLevelBuffItem2 == null)
		{
			return;
		}
		babelTowerLevelBuffItem2.RefreshItem(this.BabelTowerLevelInfo.BuffCount < 2, buffId2);
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x00182BAC File Offset: 0x00180DAC
	private void RefreshStar()
	{
		base.GetText(10).SetText(((this.BabelTowerLevelInfo.StarNumber < 10) ? "0" : "") + this.BabelTowerLevelInfo.StarNumber.ToString(), true);
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.BabelTowerLevelInfo.BabelTowerLevelId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), babelTowerLevelConfig.NameText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), babelTowerLevelConfig.LevelDesText, Array.Empty<object>());
		base.SetTextureByPath(babelTowerLevelConfig.BossTexture, base.GetTexture(8), null, null);
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(babelTowerLevelConfig.ActivityId, this.BabelTowerLevelInfo.StarNumber);
		if (babelTowerDifficulty == null)
		{
			return;
		}
		base.GetItem(11).SetUIActive(babelTowerDifficulty.Value.DifficultyId >= 2);
	}

	// Token: 0x06007549 RID: 30025 RVA: 0x00182CB3 File Offset: 0x00180EB3
	private void RefreshView()
	{
		this.OnSelectTeamRole();
		this.RefreshBuff();
		this.RefreshStar();
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x00182CC8 File Offset: 0x00180EC8
	private void OnClickConfirmBtn()
	{
		BabelTowerController.Instance.BabelTowerStartRequest(this.BabelTowerLevelInfo.InstanceId, this.BabelTowerLevelInfo.RoleList, this.BabelTowerLevelInfo.BabelTowerLevelId, this.BabelTowerLevelInfo.BuffList, BabelTowerController.Instance.BuildSkillBranchListFromRoleList(this.BabelTowerLevelInfo.RoleList));
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x00182D20 File Offset: 0x00180F20
	private void OnClickLevelDetailBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, this.BabelTowerLevelInfo.InstanceId, null);
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x00182D44 File Offset: 0x00180F44
	private void OnClickBuffItem(int buffId)
	{
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.BabelTowerLevelInfo.BabelTowerLevelId);
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
					if (buffIsUse > 0 && buffIsUse != this.BabelTowerLevelInfo.BabelTowerLevelId)
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
			List<IBabelTowerBuffInfo> list2 = list;
			BabelTowerBuffInfo babelTowerBuffInfo = new BabelTowerBuffInfo();
			babelTowerBuffInfo.Id = num;
			babelTowerBuffInfo.State = state;
			IBabelTowerLevelInfo babelTowerLevelInfo = this.BabelTowerLevelInfo;
			babelTowerBuffInfo.LevelId = ((babelTowerLevelInfo != null) ? new int?(babelTowerLevelInfo.BabelTowerLevelId) : null);
			babelTowerBuffInfo.IsRecommend = isRecommend;
			list2.Add(babelTowerBuffInfo);
		}
		List<int> list3 = new List<int>();
		if (this.BabelTowerLevelInfo.BuffList != null)
		{
			for (int k = 0; k < this.BabelTowerLevelInfo.BuffList.Count; k++)
			{
				list3.Add(this.BabelTowerLevelInfo.BuffList[k]);
			}
		}
		BabelTowerBuffSelectViewInfo param = new BabelTowerBuffSelectViewInfo
		{
			LevelId = this.BabelTowerLevelInfo.BabelTowerLevelId,
			CurrentSelectBuffList = list3,
			ShowBuffId = buffId,
			MaxSelectBuffCount = babelTowerLevelConfig.OptionalBabelBuffNum,
			AllBuffList = list,
			OnConfirmCallBack = new Action<List<int>>(this.OnBuffSelectConfirm)
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerBuffSelectView, param, null);
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00182EFC File Offset: 0x001810FC
	private void OnBuffSelectConfirm(List<int> buffList)
	{
		this.BabelTowerLevelInfo.BuffList = buffList;
		this.RefreshBuff();
	}

	// Token: 0x040035DF RID: 13791
	private const int ROLE_TEAM_SIZE = 3;

	// Token: 0x040035E0 RID: 13792
	[Nullable(2)]
	private IBabelTowerLevelInfo BabelTowerLevelInfo;

	// Token: 0x040035E1 RID: 13793
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040035E2 RID: 13794
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem1;

	// Token: 0x040035E3 RID: 13795
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem2;

	// Token: 0x040035E4 RID: 13796
	[Nullable(2)]
	private BabelTowerTeamItem TeamItem;

	// Token: 0x02007726 RID: 30502
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040274E3 RID: 160995
		public const int CaptionItem = 0;

		// Token: 0x040274E4 RID: 160996
		public const int LevelDetailBtn = 1;

		// Token: 0x040274E5 RID: 160997
		public const int BuffItem1 = 2;

		// Token: 0x040274E6 RID: 160998
		public const int BuffItem2 = 3;

		// Token: 0x040274E7 RID: 160999
		public const int TeamItem = 4;

		// Token: 0x040274E8 RID: 161000
		public const int LowLevelItem = 5;

		// Token: 0x040274E9 RID: 161001
		public const int ConfirmBtn = 6;

		// Token: 0x040274EA RID: 161002
		public const int LevelTitleText = 7;

		// Token: 0x040274EB RID: 161003
		public const int BossTexture = 8;

		// Token: 0x040274EC RID: 161004
		public const int DesText = 9;

		// Token: 0x040274ED RID: 161005
		public const int StarText = 10;

		// Token: 0x040274EE RID: 161006
		public const int HighestItem = 11;

		// Token: 0x040274EF RID: 161007
		public const int NormalItem = 12;
	}
}
