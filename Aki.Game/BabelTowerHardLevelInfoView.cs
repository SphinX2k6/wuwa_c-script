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

// Token: 0x02000614 RID: 1556
[NullableContext(1)]
[Nullable(0)]
public class BabelTowerHardLevelInfoView : UiViewBase
{
	// Token: 0x060048D0 RID: 18640 RVA: 0x0018AB4B File Offset: 0x00188D4B
	public BabelTowerHardLevelInfoView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060048D1 RID: 18641 RVA: 0x0018AB54 File Offset: 0x00188D54
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

	// Token: 0x060048D2 RID: 18642 RVA: 0x0018AD90 File Offset: 0x00188F90
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerHardLevelInfoView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerHardLevelInfoView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060048D3 RID: 18643 RVA: 0x0018ADD3 File Offset: 0x00188FD3
	protected override void OnStart()
	{
		this.BabelTowerLevelInfo = (this.OpenParam as IBabelTowerLevelInfo);
		base.GetItem(12).SetUIActive(true);
		EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060048D4 RID: 18644 RVA: 0x0018AE10 File Offset: 0x00189010
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
	}

	// Token: 0x060048D5 RID: 18645 RVA: 0x0018AE30 File Offset: 0x00189030
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

	// Token: 0x060048D6 RID: 18646 RVA: 0x0018AF11 File Offset: 0x00189111
	private void OnClickButton()
	{
		if (!UiManager.Instance.IsViewShow(EUiViewName.MultiTeamRoleSelectView))
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetRoleSelectViewData(), null);
		}
	}

	// Token: 0x060048D7 RID: 18647 RVA: 0x0018AF3C File Offset: 0x0018913C
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

	// Token: 0x060048D8 RID: 18648 RVA: 0x0018B06C File Offset: 0x0018926C
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
				MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, false, list2.Count > 0 && !list2.Contains(weaponType), isUnRecommend, null, false, false, false);
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
						goto IL_270;
					}
				}
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list3.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false, null, false, false, false));
				}
			}
			IL_270:;
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

	// Token: 0x060048D9 RID: 18649 RVA: 0x0018B400 File Offset: 0x00189600
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

	// Token: 0x060048DA RID: 18650 RVA: 0x0018B458 File Offset: 0x00189658
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

	// Token: 0x060048DB RID: 18651 RVA: 0x0018B553 File Offset: 0x00189753
	private void OnSelectTeamRole()
	{
		this.RefreshLowLevelTips();
		this.RefreshTeamRole();
	}

	// Token: 0x060048DC RID: 18652 RVA: 0x0018B564 File Offset: 0x00189764
	private void RefreshLowLevelTips()
	{
		int instanceId = this.BabelTowerLevelInfo.InstanceId;
		bool ifLevelTooLow = BabelTowerModel.Instance.GetIfLevelTooLow(instanceId, this.BabelTowerLevelInfo.RoleList.ToArray());
		base.GetItem(5).SetUIActive(ifLevelTooLow);
	}

	// Token: 0x060048DD RID: 18653 RVA: 0x0018B5A8 File Offset: 0x001897A8
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

	// Token: 0x060048DE RID: 18654 RVA: 0x0018B65C File Offset: 0x0018985C
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

	// Token: 0x060048DF RID: 18655 RVA: 0x0018B6E4 File Offset: 0x001898E4
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

	// Token: 0x060048E0 RID: 18656 RVA: 0x0018B7EB File Offset: 0x001899EB
	private void RefreshView()
	{
		this.OnSelectTeamRole();
		this.RefreshBuff();
		this.RefreshStar();
	}

	// Token: 0x060048E1 RID: 18657 RVA: 0x0018B800 File Offset: 0x00189A00
	private void OnClickConfirmBtn()
	{
		BabelTowerController.Instance.BabelTowerStartRequest(this.BabelTowerLevelInfo.InstanceId, this.BabelTowerLevelInfo.RoleList, this.BabelTowerLevelInfo.BabelTowerLevelId, this.BabelTowerLevelInfo.BuffList, BabelTowerController.Instance.BuildSkillBranchListFromRoleList(this.BabelTowerLevelInfo.RoleList));
	}

	// Token: 0x060048E2 RID: 18658 RVA: 0x0018B858 File Offset: 0x00189A58
	private void OnClickLevelDetailBtn()
	{
		UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, this.BabelTowerLevelInfo.InstanceId, null);
	}

	// Token: 0x060048E3 RID: 18659 RVA: 0x0018B87C File Offset: 0x00189A7C
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

	// Token: 0x060048E4 RID: 18660 RVA: 0x0018BA34 File Offset: 0x00189C34
	private void OnBuffSelectConfirm(List<int> buffList)
	{
		this.BabelTowerLevelInfo.BuffList = buffList;
		this.RefreshBuff();
	}

	// Token: 0x04003678 RID: 13944
	private const int ROLE_TEAM_SIZE = 3;

	// Token: 0x04003679 RID: 13945
	[Nullable(2)]
	private IBabelTowerLevelInfo BabelTowerLevelInfo;

	// Token: 0x0400367A RID: 13946
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400367B RID: 13947
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem1;

	// Token: 0x0400367C RID: 13948
	[Nullable(2)]
	private BabelTowerLevelBuffItem BabelTowerLevelBuffItem2;

	// Token: 0x0400367D RID: 13949
	[Nullable(2)]
	private BabelTowerTeamItem TeamItem;

	// Token: 0x020068B4 RID: 26804
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04022822 RID: 141346
		public const int CaptionItem = 0;

		// Token: 0x04022823 RID: 141347
		public const int LevelDetailBtn = 1;

		// Token: 0x04022824 RID: 141348
		public const int BuffItem1 = 2;

		// Token: 0x04022825 RID: 141349
		public const int BuffItem2 = 3;

		// Token: 0x04022826 RID: 141350
		public const int TeamItem = 4;

		// Token: 0x04022827 RID: 141351
		public const int LowLevelItem = 5;

		// Token: 0x04022828 RID: 141352
		public const int ConfirmBtn = 6;

		// Token: 0x04022829 RID: 141353
		public const int LevelTitleText = 7;

		// Token: 0x0402282A RID: 141354
		public const int BossTexture = 8;

		// Token: 0x0402282B RID: 141355
		public const int DesText = 9;

		// Token: 0x0402282C RID: 141356
		public const int StarText = 10;

		// Token: 0x0402282D RID: 141357
		public const int HighestItem = 11;

		// Token: 0x0402282E RID: 141358
		public const int NormalItem = 12;
	}
}
