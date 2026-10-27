using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023E6 RID: 9190
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalRoleDisplayMediumItem : GridProxyAbstract<PersonalRoleDisplayContentData>
{
	// Token: 0x060125D9 RID: 75225 RVA: 0x00486C61 File Offset: 0x00484E61
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060125DA RID: 75226 RVA: 0x00486C9C File Offset: 0x00484E9C
	protected override void OnStart()
	{
		this.ItemBaseItem = new MediumItemGrid();
		this.ItemBaseItem.Initialize(base.GetItem(1).GetOwner());
		this.ItemBaseItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.ItemBaseItem.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnClickItemBaseItem));
	}

	// Token: 0x060125DB RID: 75227 RVA: 0x00486D0C File Offset: 0x00484F0C
	public override void Refresh(PersonalRoleDisplayContentData data, bool isSelected, int gridIndex)
	{
		base.GridIndex = gridIndex;
		this.RoleId = data.RoleId;
		if (this.RoleId < 0)
		{
			base.GetItem(0).SetUIActive(true);
			this.ItemBaseItem.SetUiActive(false);
			return;
		}
		base.GetItem(0).SetUIActive(false);
		this.ItemBaseItem.SetUiActive(true);
		RoleSkinData roleOriginalSkinData = RoleSkinModel.Instance.GetRoleOriginalSkinData(this.RoleId, !data.IfOtherData);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			Data = this.RoleId,
			SkinId = roleOriginalSkinData.GetItemId(),
			ItemConfigId = new int?(this.RoleId),
			BottomText = RoleConfig.Instance.GetRoleName(roleOriginalSkinData.GetName())
		};
		this.ItemBaseItem.Apply<CharacterMediumItemGrid>(parameters);
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.ItemBaseItem.GetItemGridExtendToggle().SetToggleStateForce(state, false, false, false);
	}

	// Token: 0x060125DC RID: 75228 RVA: 0x00486DF4 File Offset: 0x00484FF4
	public void BindClickItemCallBack(Action<int> callback)
	{
		this.ClickItemCallBack = callback;
	}

	// Token: 0x060125DD RID: 75229 RVA: 0x00486DFD File Offset: 0x00484FFD
	private void OnClickItemBaseItem(MediumItemGridExtendCallback _)
	{
		if (this.ClickItemCallBack != null)
		{
			this.ClickItemCallBack(this.RoleId);
		}
	}

	// Token: 0x060125DE RID: 75230 RVA: 0x00486E18 File Offset: 0x00485018
	public override void OnSelected(bool fireEvent)
	{
		this.ItemBaseItem.GetItemGridExtendToggle().SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060125DF RID: 75231 RVA: 0x00486E2E File Offset: 0x0048502E
	public override void OnDeselected(bool fireEvent)
	{
		this.ItemBaseItem.GetItemGridExtendToggle().SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008AF6 RID: 35574
	private int RoleId;

	// Token: 0x04008AF7 RID: 35575
	[Nullable(2)]
	private MediumItemGrid ItemBaseItem;

	// Token: 0x04008AF8 RID: 35576
	[Nullable(2)]
	private Action<int> ClickItemCallBack;

	// Token: 0x02008987 RID: 35207
	[NullableContext(0)]
	public enum EComponent
	{
		// Token: 0x0402CB0D RID: 183053
		EmptyItem,
		// Token: 0x0402CB0E RID: 183054
		ItemBaseItem
	}
}
