using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002171 RID: 8561
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerFormationRoleTeamItem : GridProxyAbstract<FormationData>
{
	// Token: 0x06015036 RID: 86070 RVA: 0x0061F64C File Offset: 0x0061D84C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleRoot))
		};
	}

	// Token: 0x06015037 RID: 86071 RVA: 0x0061F6F8 File Offset: 0x0061D8F8
	protected override UniTask OnBeforeStartAsync()
	{
		TowerFormationRoleTeamItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerFormationRoleTeamItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015038 RID: 86072 RVA: 0x0061F73B File Offset: 0x0061D93B
	[NullableContext(2)]
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06015039 RID: 86073 RVA: 0x0061F744 File Offset: 0x0061D944
	private void OnClickToggleRoot(EToggleState state)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		IScrollViewDelegate<IGridProxy<FormationData>, FormationData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate == null)
		{
			return;
		}
		scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
	}

	// Token: 0x0601503A RID: 86074 RVA: 0x0061F778 File Offset: 0x0061D978
	public override void Refresh(FormationData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		List<int> roleIdListWithTrial = data.GetRoleIdListWithTrial(false);
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			MediumItemGrid mediumItemGrid = this.RoleList[i];
			int num = (i < roleIdListWithTrial.Count) ? roleIdListWithTrial[i] : 0;
			if (num != 0)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
				int roleCurrentBranchIndex = RoleModel.Instance.GetRoleCurrentBranchIndex(num);
				TowerModel instance = TowerModel.Instance;
				int roleRemainCost = instance.GetRoleRemainCost(num, instance.CurrentSelectDifficulties);
				TowerConfig? towerConfig;
				int num2 = (TowerClimbConfig.Instance.GetTowerInfo(instance.CurrentSelectFloor) != null) ? towerConfig.GetValueOrDefault().Cost : 0;
				bool floorIncludeRole = instance.GetFloorIncludeRole(num, instance.CurrentSelectFloor);
				int num3 = floorIncludeRole ? roleRemainCost : (roleRemainCost - num2);
				int teamSlot = this.GetTeamSlot(num);
				int? index = (teamSlot > 0) ? new int?(teamSlot) : null;
				bool flag = instance.IsRoleCostEnough(num);
				CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid();
				characterMediumItemGrid.ItemConfigId = new int?(num);
				CharacterMediumItemGrid characterMediumItemGrid2 = characterMediumItemGrid;
				FormationRoleData roleDataById2 = data.GetRoleDataById(num);
				characterMediumItemGrid2.SkinId = ((roleDataById2 != null) ? roleDataById2.RoleSkinId : 0);
				characterMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
				characterMediumItemGrid.BottomTextParameter = new object[]
				{
					roleDataById.GetLevelData().GetLevel()
				};
				characterMediumItemGrid.ElementId = new int?(roleDataById.GetRoleConfig().ElementId);
				characterMediumItemGrid.IsTrialRoleVisible = new bool?(roleDataById.IsTrialRole());
				characterMediumItemGrid.Index = index;
				characterMediumItemGrid.IsDisable = new bool?(!flag);
				characterMediumItemGrid.SkillBranchIndex = ((roleCurrentBranchIndex > -1) ? new int?(roleCurrentBranchIndex) : null);
				characterMediumItemGrid.ShowCostData = new MediumItemGridCostComponentData
				{
					Cost = num3,
					Color = ((num3 >= 4) ? TowerData.highColor : TowerData.lowColor).Value,
					BeforeCost = (floorIncludeRole ? null : new int?(roleRemainCost)),
					BeforeColor = (floorIncludeRole ? null : ((roleRemainCost >= 4) ? TowerData.highColor : TowerData.lowColor))
				};
				CharacterMediumItemGrid parameters = characterMediumItemGrid;
				mediumItemGrid.Apply<CharacterMediumItemGrid>(parameters);
				mediumItemGrid.SetSelected(RoleSelectModel.Instance.SelectedRoleSet.Contains(num), true);
			}
			else
			{
				mediumItemGrid.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid());
			}
		}
		base.GetText(1).SetText(data.FormationId.ToString(), true);
	}

	// Token: 0x0601503B RID: 86075 RVA: 0x0061FA0C File Offset: 0x0061DC0C
	private int GetTeamSlot(int roleId)
	{
		foreach (KeyValuePair<int, RoleDataBase> keyValuePair in RoleSelectModel.Instance.RoleIndexMap)
		{
			if (keyValuePair.Value.GetDataId() == roleId)
			{
				return keyValuePair.Key;
			}
		}
		return -1;
	}

	// Token: 0x0601503C RID: 86076 RVA: 0x0061FA78 File Offset: 0x0061DC78
	public void RefreshRoleState()
	{
		if (this.ItemData != null)
		{
			this.Refresh(this.ItemData, false, base.GridIndex);
		}
	}

	// Token: 0x0601503D RID: 86077 RVA: 0x0061FA95 File Offset: 0x0061DC95
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		Action<FormationData> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this.ItemData);
	}

	// Token: 0x0601503E RID: 86078 RVA: 0x0061FAC2 File Offset: 0x0061DCC2
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400B2ED RID: 45805
	private readonly List<MediumItemGrid> RoleList = new List<MediumItemGrid>();

	// Token: 0x0400B2EE RID: 45806
	private FormationData ItemData;

	// Token: 0x0400B2EF RID: 45807
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnClickCallback;

	// Token: 0x020083FB RID: 33787
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A953 RID: 174419
		public const int ToggleRoot = 0;

		// Token: 0x0402A954 RID: 174420
		public const int TxtTeamIndex = 1;

		// Token: 0x0402A955 RID: 174421
		public const int ItemRole1 = 2;

		// Token: 0x0402A956 RID: 174422
		public const int ItemRole2 = 3;

		// Token: 0x0402A957 RID: 174423
		public const int ItemRole3 = 4;
	}
}
