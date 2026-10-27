using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001166 RID: 4454
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerPreTeamItem : GridProxyAbstract<FormationData>
{
	// Token: 0x0600759C RID: 30108 RVA: 0x00184B28 File Offset: 0x00182D28
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600759D RID: 30109 RVA: 0x00184C34 File Offset: 0x00182E34
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerPreTeamItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerPreTeamItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600759E RID: 30110 RVA: 0x00184C77 File Offset: 0x00182E77
	[NullableContext(2)]
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0600759F RID: 30111 RVA: 0x00184C80 File Offset: 0x00182E80
	public override void Refresh(FormationData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		List<int> roleIdListWithTrial = data.GetRoleIdListWithTrial(false);
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			MediumItemGrid mediumItemGrid = this.RoleList[i];
			int num = (i < roleIdListWithTrial.Count) ? roleIdListWithTrial[i] : 0;
			this.HasCharacter[i] = (num != 0);
			if (num != 0)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
				bool flag = isSelected && this.HasCharacter[i];
				int roleSkillBranchIndexInGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInGamePlay(num, ESkillBranchCacheType.Normal);
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
				characterMediumItemGrid.SkillBranchIndex = ((roleSkillBranchIndexInGamePlay > -1) ? new int?(roleSkillBranchIndexInGamePlay) : null);
				CharacterMediumItemGrid parameters = characterMediumItemGrid;
				mediumItemGrid.Apply<CharacterMediumItemGrid>(parameters);
				mediumItemGrid.GetItemGridExtendToggle().SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			else
			{
				mediumItemGrid.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid());
			}
		}
		base.GetText(1).SetText(data.FormationId.ToString(), true);
	}

	// Token: 0x060075A0 RID: 30112 RVA: 0x00184E0F File Offset: 0x0018300F
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		Action<FormationData, int> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this.ItemData, base.GridIndex);
	}

	// Token: 0x060075A1 RID: 30113 RVA: 0x00184E42 File Offset: 0x00183042
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060075A2 RID: 30114 RVA: 0x00184E58 File Offset: 0x00183058
	public void ForceSetSelected(bool selected)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060075A3 RID: 30115 RVA: 0x00184E74 File Offset: 0x00183074
	private void OnToggleClick(EToggleState state)
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

	// Token: 0x040035F9 RID: 13817
	private readonly List<MediumItemGrid> RoleList = new List<MediumItemGrid>();

	// Token: 0x040035FA RID: 13818
	private readonly List<bool> HasCharacter = new List<bool>();

	// Token: 0x040035FB RID: 13819
	private FormationData ItemData;

	// Token: 0x040035FC RID: 13820
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData, int> OnClickCallback;

	// Token: 0x02007738 RID: 30520
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04027542 RID: 161090
		public const int ToggleRoot = 0;

		// Token: 0x04027543 RID: 161091
		public const int TxtTeamIndex = 1;

		// Token: 0x04027544 RID: 161092
		public const int ItemRole1 = 2;

		// Token: 0x04027545 RID: 161093
		public const int ItemRole2 = 3;

		// Token: 0x04027546 RID: 161094
		public const int ItemRole3 = 4;
	}
}
