using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002BF6 RID: 11254
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TowerFormationRoleTeamItem : GridProxyAbstract<FormationData>
{
	// Token: 0x06017605 RID: 95749 RVA: 0x005F2B10 File Offset: 0x005F0D10
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

	// Token: 0x06017606 RID: 95750 RVA: 0x005F2BBC File Offset: 0x005F0DBC
	protected override UniTask OnBeforeStartAsync()
	{
		TowerFormationRoleTeamItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<TowerFormationRoleTeamItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06017607 RID: 95751 RVA: 0x005F2BFF File Offset: 0x005F0DFF
	[NullableContext(2)]
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06017608 RID: 95752 RVA: 0x005F2C08 File Offset: 0x005F0E08
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

	// Token: 0x06017609 RID: 95753 RVA: 0x005F2C3C File Offset: 0x005F0E3C
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

	// Token: 0x0601760A RID: 95754 RVA: 0x005F2ED0 File Offset: 0x005F10D0
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

	// Token: 0x0601760B RID: 95755 RVA: 0x005F2F3C File Offset: 0x005F113C
	public void RefreshRoleState()
	{
		if (this.ItemData != null)
		{
			this.Refresh(this.ItemData, false, base.GridIndex);
		}
	}

	// Token: 0x0601760C RID: 95756 RVA: 0x005F2F59 File Offset: 0x005F1159
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

	// Token: 0x0601760D RID: 95757 RVA: 0x005F2F86 File Offset: 0x005F1186
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400AEE8 RID: 44776
	private readonly List<MediumItemGrid> RoleList = new List<MediumItemGrid>();

	// Token: 0x0400AEE9 RID: 44777
	private FormationData ItemData;

	// Token: 0x0400AEEA RID: 44778
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnClickCallback;

	// Token: 0x020091B8 RID: 37304
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402F252 RID: 193106
		public const int ToggleRoot = 0;

		// Token: 0x0402F253 RID: 193107
		public const int TxtTeamIndex = 1;

		// Token: 0x0402F254 RID: 193108
		public const int ItemRole1 = 2;

		// Token: 0x0402F255 RID: 193109
		public const int ItemRole2 = 3;

		// Token: 0x0402F256 RID: 193110
		public const int ItemRole3 = 4;
	}
}
