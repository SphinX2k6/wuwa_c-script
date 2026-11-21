using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002179 RID: 8569
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerRecommendItem : GridProxyAbstract<TowerRecommendFormation>
{
	// Token: 0x0601507E RID: 86142 RVA: 0x00621388 File Offset: 0x0061F588
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickUseBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601507F RID: 86143 RVA: 0x00621491 File Offset: 0x0061F691
	protected override void OnStart()
	{
		this.RoleIdArray = new List<int>();
		this.RoleSkillBranchMap = new Dictionary<int, int>();
	}

	// Token: 0x06015080 RID: 86144 RVA: 0x006214AC File Offset: 0x0061F6AC
	public override void Refresh(TowerRecommendFormation formationInfo, bool isSelected, int gridIndex)
	{
		this.RoleSkillBranchMap.Clear();
		base.GetText(2).SetText((gridIndex + 1).ToString(), true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Text_ExplorationDegree_Text", new <>z__ReadOnlySingleElementList<object>(MathUtils.Instance.GetFloatPointFloorString((double)formationInfo.Usage * 0.01, 2)));
		this.RoleLayout = new GenericLayoutNew<MediumItemGrid>(base.GetHorizontalLayout(4), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MediumItemGrid>(this.InitRoleItem), null);
		List<TowerRecommendRole> list = new List<TowerRecommendRole>();
		foreach (TowerRecommendRole towerRecommendRole in formationInfo.Formation)
		{
			list.Add(towerRecommendRole);
			this.RoleSkillBranchMap[towerRecommendRole.RoleId] = towerRecommendRole.SkillBranchId;
		}
		list.Sort(delegate(TowerRecommendRole a, TowerRecommendRole b)
		{
			if (a.Level != b.Level)
			{
				return b.Level - a.Level;
			}
			int qualityId = RoleConfig.Instance.GetRoleConfig(a.RoleId).Value.QualityId;
			int qualityId2 = RoleConfig.Instance.GetRoleConfig(b.RoleId).Value.QualityId;
			if (qualityId == qualityId2)
			{
				return b.RoleId - a.RoleId;
			}
			return qualityId2 - qualityId;
		});
		this.RoleLayout.RebuildLayoutByDataNew<TowerRecommendRole>(list, null);
	}

	// Token: 0x06015081 RID: 86145 RVA: 0x006215CC File Offset: 0x0061F7CC
	private ILayoutItem<MediumItemGrid> InitRoleItem(object data, UUIItem uiItem, int index)
	{
		MediumItemGrid mediumItemGrid = new MediumItemGrid();
		mediumItemGrid.Initialize(uiItem.GetOwner());
		TowerRecommendRole towerRecommendRole = (TowerRecommendRole)data;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(towerRecommendRole.RoleId);
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(towerRecommendRole.RoleId, towerRecommendRole.SkillBranchId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(towerRecommendRole.RoleId),
			SkinId = roleConfig.Value.SkinId,
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				towerRecommendRole.Level
			},
			ElementId = new int?(roleConfig.Value.ElementId),
			IsDisable = new bool?(!this.IsRoleAllowUse(towerRecommendRole)),
			SkillBranchIndex = ((roleBranchIndexById >= 0) ? new int?(roleBranchIndexById) : null)
		};
		mediumItemGrid.Apply<CharacterMediumItemGrid>(parameters);
		return new LayoutItem<MediumItemGrid>
		{
			Key = index,
			Value = mediumItemGrid
		};
	}

	// Token: 0x06015082 RID: 86146 RVA: 0x006216E4 File Offset: 0x0061F8E4
	private bool IsRoleAllowUse(TowerRecommendRole roleInfo)
	{
		int roleId = roleInfo.RoleId;
		if (!RoleModel.Instance.IsMainRole(roleId))
		{
			if (RoleModel.Instance.GetRoleDataById(roleId, true) == null)
			{
				base.GetInteractionGroup(1).SetInteractable(false);
				return false;
			}
			this.RoleIdArray.Add(roleId);
		}
		else
		{
			int playerRoleId = PlayerInfoModel.Instance.GetPlayerRoleId();
			RoleInfo? roleInfo2;
			int? num = (RoleConfig.Instance.GetRoleConfig(roleId) != null) ? new int?(roleInfo2.GetValueOrDefault().ElementId) : null;
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(playerRoleId, true);
			ElementInfo? elementInfo;
			int? num2 = (roleDataById != null) ? ((roleDataById.GetElementInfo() != null) ? new int?(elementInfo.GetValueOrDefault().Id) : null) : null;
			if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
			{
				base.GetInteractionGroup(1).SetInteractable(false);
				return false;
			}
			this.RoleIdArray.Add(playerRoleId);
		}
		return true;
	}

	// Token: 0x06015083 RID: 86147 RVA: 0x00621803 File Offset: 0x0061FA03
	protected override void OnBeforeDestroy()
	{
		this.RoleIdArray.Clear();
		this.RoleSkillBranchMap.Clear();
		this.RoleSkillBranchMap = null;
		this.RoleLayout = null;
	}

	// Token: 0x06015084 RID: 86148 RVA: 0x0062182C File Offset: 0x0061FA2C
	private void OnClickUseBtn()
	{
		foreach (int num in this.RoleIdArray)
		{
			int num2;
			if (this.RoleSkillBranchMap.TryGetValue(num, out num2) && num2 != 0)
			{
				RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(num, num2, false);
			}
		}
		TowerChallengeFormationView towerChallengeFormationView = UiManager.Instance.GetViewByName(EUiViewName.TowerChallengeFormationView) as TowerChallengeFormationView;
		if (towerChallengeFormationView != null)
		{
			towerChallengeFormationView.ApplyRecommendFormation(this.RoleIdArray);
		}
		else
		{
			FormationController.Instance.SetBattleTeam(this.RoleIdArray.ToArray());
		}
		UiManager.Instance.CloseView(EUiViewName.TowerRecommendView, null);
	}

	// Token: 0x0400B308 RID: 45832
	private const double PERCENT = 0.01;

	// Token: 0x0400B309 RID: 45833
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayoutNew<MediumItemGrid> RoleLayout;

	// Token: 0x0400B30A RID: 45834
	[Nullable(2)]
	private List<int> RoleIdArray;

	// Token: 0x0400B30B RID: 45835
	[Nullable(2)]
	private Dictionary<int, int> RoleSkillBranchMap;

	// Token: 0x02008407 RID: 33799
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A9A9 RID: 174505
		UseBtn,
		// Token: 0x0402A9AA RID: 174506
		UseBtnInteractionGroup,
		// Token: 0x0402A9AB RID: 174507
		IndexText,
		// Token: 0x0402A9AC RID: 174508
		PercentText,
		// Token: 0x0402A9AD RID: 174509
		RoleScrollView
	}
}
