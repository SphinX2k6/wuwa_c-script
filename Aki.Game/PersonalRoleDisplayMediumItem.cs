using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020018CB RID: 6347
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalRoleDisplayMediumItem : GridProxyAbstract<PersonalRoleDisplayContentData>
{
	// Token: 0x0600FA8B RID: 64139 RVA: 0x0049416D File Offset: 0x0049236D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600FA8C RID: 64140 RVA: 0x004941A8 File Offset: 0x004923A8
	protected override void OnStart()
	{
		this.ItemBaseItem = new MediumItemGrid();
		this.ItemBaseItem.Initialize(base.GetItem(1).GetOwner());
		this.ItemBaseItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
		this.ItemBaseItem.BindOnExtendToggleRelease(new Action<MediumItemGridExtendCallback>(this.OnClickItemBaseItem));
	}

	// Token: 0x0600FA8D RID: 64141 RVA: 0x00494218 File Offset: 0x00492418
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

	// Token: 0x0600FA8E RID: 64142 RVA: 0x00494300 File Offset: 0x00492500
	public void BindClickItemCallBack(Action<int> callback)
	{
		this.ClickItemCallBack = callback;
	}

	// Token: 0x0600FA8F RID: 64143 RVA: 0x00494309 File Offset: 0x00492509
	private void OnClickItemBaseItem(MediumItemGridExtendCallback _)
	{
		if (this.ClickItemCallBack != null)
		{
			this.ClickItemCallBack(this.RoleId);
		}
	}

	// Token: 0x0600FA90 RID: 64144 RVA: 0x00494324 File Offset: 0x00492524
	public override void OnSelected(bool fireEvent)
	{
		this.ItemBaseItem.GetItemGridExtendToggle().SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600FA91 RID: 64145 RVA: 0x0049433A File Offset: 0x0049253A
	public override void OnDeselected(bool fireEvent)
	{
		this.ItemBaseItem.GetItemGridExtendToggle().SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008C3D RID: 35901
	private int RoleId;

	// Token: 0x04008C3E RID: 35902
	[Nullable(2)]
	private MediumItemGrid ItemBaseItem;

	// Token: 0x04008C3F RID: 35903
	[Nullable(2)]
	private Action<int> ClickItemCallBack;

	// Token: 0x02007B10 RID: 31504
	[NullableContext(0)]
	public enum EComponent
	{
		// Token: 0x04027E28 RID: 163368
		EmptyItem,
		// Token: 0x04027E29 RID: 163369
		ItemBaseItem
	}
}
