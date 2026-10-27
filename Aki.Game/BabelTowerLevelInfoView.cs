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

// Token: 0x02001174 RID: 4468
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerLevelInfoView : UiViewBase
{
	// Token: 0x060075F1 RID: 30193 RVA: 0x00186A17 File Offset: 0x00184C17
	public BabelTowerLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060075F2 RID: 30194 RVA: 0x00186A20 File Offset: 0x00184C20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickConfirmBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLevelDetailBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060075F3 RID: 30195 RVA: 0x00186BF4 File Offset: 0x00184DF4
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerLevelInfoView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerLevelInfoView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060075F4 RID: 30196 RVA: 0x00186C37 File Offset: 0x00184E37
	protected override void OnStart()
	{
		this.BabelTowerLevelInfo = (this.OpenParam as IBabelTowerLevelInfo);
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060075F5 RID: 30197 RVA: 0x00186C66 File Offset: 0x00184E66
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060075F6 RID: 30198 RVA: 0x00186C84 File Offset: 0x00184E84
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

	// Token: 0x060075F7 RID: 30199 RVA: 0x00186D65 File Offset: 0x00184F65
	private void OnClickButton()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.MultiTeamRoleSelectView))
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetRoleSelectViewData(), null);
		}
	}

	// Token: 0x060075F8 RID: 30200 RVA: 0x00186D90 File Offset: 0x00184F90
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

	// Token: 0x060075F9 RID: 30201 RVA: 0x00186EC0 File Offset: 0x001850C0
	private MultiTeamRoleSelectData GetRoleSelectViewData()
	{
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
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
				MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, false, list2.Count > 0 && !list2.Contains(weaponType), false);
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
			for (int j = 0; j < mainRoleByGender.Count; j++)
			{
				list4.Add(mainRoleByGender[j].Id);
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
					for (int l = 0; l < list4.Count; l++)
					{
						if (list4[l] == trialRoleConfigByGroupId.Value.ParentId)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						goto IL_21A;
					}
				}
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list3.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
				}
			}
			IL_21A:;
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
		for (int m = 0; m < roleList2.Count; m++)
		{
			int num = roleList2[m];
			if (num != 0)
			{
				list6.Add(num);
			}
		}
		MultiTeamRoleSelectData result = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, list6.ToArray(), null, new Func<int[], bool>(this.OnCanChangeRole), new Action<int[], int[]>(this.OnEnsureFormation), null, list5, null, "BabelTeamTips_1", "");
		BattleTeamModel.Instance.Context.SetInstanceDungeonId(new int?(instanceId));
		return result;
	}

	// Token: 0x060075FA RID: 30202 RVA: 0x001871C8 File Offset: 0x001853C8
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

	// Token: 0x060075FB RID: 30203 RVA: 0x00187220 File Offset: 0x00185420
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

	// Token: 0x060075FC RID: 30204 RVA: 0x0018731B File Offset: 0x0018551B
	private void OnSelectTeamRole()
	{
		this.RefreshLowLevelTips();
		this.RefreshTeamRole();
	}

	// Token: 0x060075FD RID: 30205 RVA: 0x0018732C File Offset: 0x0018552C
	private void RefreshLowLevelTips()
	{
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
		bool ifLevelTooLow = BabelTowerModel.Instance.GetIfLevelTooLow(instanceId, this.BabelTowerLevelInfo.RoleList.ToArray());
		base.GetItem(8).SetUIActive(ifLevelTooLow);
	}

	// Token: 0x060075FE RID: 30206 RVA: 0x00187370 File Offset: 0x00185570
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

	// Token: 0x060075FF RID: 30207 RVA: 0x00187424 File Offset: 0x00185624
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

	// Token: 0x06007600 RID: 30208 RVA: 0x001874AC File Offset: 0x001856AC
	private void RefreshStar()
	{
		base.GetArtText(2).SetText(((this.BabelTowerLevelInfo.StarNumber < 10) ? "0" : "") + this.BabelTowerLevelInfo.StarNumber.ToString());
		BabelTowerLevel babelTowerLevelConfig = BabelTowerConfig.Instance.GetBabelTowerLevelConfig(this.BabelTowerLevelInfo.BabelTowerLevelId);
		BabelTowerDifficulty? babelTowerDifficulty = BabelTowerModel.Instance.CalculateDifficultyConfigByStarNum(babelTowerLevelConfig.ActivityId, this.BabelTowerLevelInfo.StarNumber);
		if (babelTowerDifficulty == null)
		{
			return;
		}
		FColor color = FColor.FromHex(babelTowerDifficulty.Value.TextBgColor);
		base.GetItem(3).SetColor(color);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), babelTowerDifficulty.Value.DifficultyTextKey, Array.Empty<object>());
	}

	// Token: 0x06007601 RID: 30209 RVA: 0x0018757E File Offset: 0x0018577E
	private void RefreshView()
	{
		this.OnSelectTeamRole();
		this.RefreshBuff();
		this.RefreshStar();
	}

	// Token: 0x06007602 RID: 30210 RVA: 0x00187594 File Offset: 0x00185794
	private void OnClickConfirmBtn()
	{
		BabelTowerController.Instance.BabelTowerStartRequest(this.BabelTowerLevelInfo.InstanceId, this.BabelTowerLevelInfo.RoleList, this.BabelTowerLevelInfo.BabelTowerLevelId, this.BabelTowerLevelInfo.BuffList, BabelTowerController.Instance.BuildSkillBranchListFromRoleList(this.BabelTowerLevelInfo.RoleList));
	}

	// Token: 0x06007603 RID: 30211 RVA: 0x001875EC File Offset: 0x001857EC
	private void OnClickLevelDetailBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, this.BabelTowerLevelInfo.InstanceId, null);
	}

	// Token: 0x06007604 RID: 30212 RVA: 0x00187610 File Offset: 0x00185810
	private void OnClickBuffItem(int clickBuffId)
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
			ShowBuffId = clickBuffId,
			MaxSelectBuffCount = babelTowerLevelConfig.OptionalBabelBuffNum,
			AllBuffList = list,
			OnConfirmCallBack = new Action<List<int>>(this.OnBuffSelectConfirm)
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerBuffSelectView, param, null);
	}

	// Token: 0x06007605 RID: 30213 RVA: 0x001877C8 File Offset: 0x001859C8
	private void OnBuffSelectConfirm(List<int> buffList)
	{
		this.BabelTowerLevelInfo.BuffList = buffList;
		this.RefreshBuff();
	}

	// Token: 0x0400361E RID: 13854
	private const int ROLE_TEAM_SIZE = 3;

	// Token: 0x0400361F RID: 13855
	[Nullable(2)]
	private IBabelTowerLevelInfo BabelTowerLevelInfo;

	// Token: 0x04003620 RID: 13856
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003621 RID: 13857
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem1;

	// Token: 0x04003622 RID: 13858
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem2;

	// Token: 0x04003623 RID: 13859
	[Nullable(2)]
	private BabelTowerTeamItem TeamItem;

	// Token: 0x02007745 RID: 30533
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402757C RID: 161148
		public const int CaptionItem = 0;

		// Token: 0x0402757D RID: 161149
		public const int LevelDetailBtn = 1;

		// Token: 0x0402757E RID: 161150
		public const int DeTermStarText = 2;

		// Token: 0x0402757F RID: 161151
		public const int HardItem = 3;

		// Token: 0x04027580 RID: 161152
		public const int HardText = 4;

		// Token: 0x04027581 RID: 161153
		public const int BuffItem1 = 5;

		// Token: 0x04027582 RID: 161154
		public const int BuffItem2 = 6;

		// Token: 0x04027583 RID: 161155
		public const int TeamItem = 7;

		// Token: 0x04027584 RID: 161156
		public const int LowLevelItem = 8;

		// Token: 0x04027585 RID: 161157
		public const int ConfirmBtn = 9;
	}
}
