using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020018D1 RID: 6353
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalRoleSmallItemGrid : GridProxyAbstract<PlayerHeadData>
{
	// Token: 0x0600FAA0 RID: 64160 RVA: 0x00494894 File Offset: 0x00492A94
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIInteractionGroup)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnSelectToggleClick))
		};
	}

	// Token: 0x0600FAA1 RID: 64161 RVA: 0x00494928 File Offset: 0x00492B28
	public override void Refresh(PlayerHeadData playerHeadData, bool isSelected, int gridIndex)
	{
		this.PlayerHeadData = playerHeadData;
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		UUITexture roleTexture = base.GetTexture(0);
		roleTexture.SetUIActive(false);
		base.SetTextureShowUntilLoaded(playerHeadData.GetRoleCardHeadIcon(), roleTexture, delegate(bool _)
		{
			roleTexture.SetUIActive(true);
		});
		base.GetTexture(0).SetIsGray(playerHeadData.Lock);
		UUIItem item = base.GetItem(3);
		int id = playerHeadData.Id;
		int? num = numberPropById;
		item.SetUIActive(id == num.GetValueOrDefault() & num != null);
		EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600FAA2 RID: 64162 RVA: 0x004949D8 File Offset: 0x00492BD8
	public void RefreshEquipHeadIconItem()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		UUIItem item = base.GetItem(3);
		int id = this.PlayerHeadData.Id;
		int? num = numberPropById;
		item.SetUIActive(id == num.GetValueOrDefault() & num != null);
	}

	// Token: 0x0600FAA3 RID: 64163 RVA: 0x00494A1B File Offset: 0x00492C1B
	private void OnSelectToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.ToggleClickCallBack != null)
		{
			this.ToggleClickCallBack(this.PlayerHeadData);
		}
	}

	// Token: 0x0600FAA4 RID: 64164 RVA: 0x00494A3D File Offset: 0x00492C3D
	public void BindToggleClickCallBack(Action<PlayerHeadData> toggleClickClickBack)
	{
		this.ToggleClickCallBack = toggleClickClickBack;
	}

	// Token: 0x0600FAA5 RID: 64165 RVA: 0x00494A46 File Offset: 0x00492C46
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x0600FAA6 RID: 64166 RVA: 0x00494A59 File Offset: 0x00492C59
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008C55 RID: 35925
	private PlayerHeadData PlayerHeadData;

	// Token: 0x04008C56 RID: 35926
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PlayerHeadData> ToggleClickCallBack;
}
