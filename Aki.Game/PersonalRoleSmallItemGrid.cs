using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020023EC RID: 9196
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PersonalRoleSmallItemGrid : GridProxyAbstract<PlayerHeadData>
{
	// Token: 0x060125EE RID: 75246 RVA: 0x00487388 File Offset: 0x00485588
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

	// Token: 0x060125EF RID: 75247 RVA: 0x0048741C File Offset: 0x0048561C
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

	// Token: 0x060125F0 RID: 75248 RVA: 0x004874CC File Offset: 0x004856CC
	public void RefreshEquipHeadIconItem()
	{
		int? numberPropById = PlayerInfoModel.Instance.GetNumberPropById(EPlayerInfoNumber.HeadPhoto);
		UUIItem item = base.GetItem(3);
		int id = this.PlayerHeadData.Id;
		int? num = numberPropById;
		item.SetUIActive(id == num.GetValueOrDefault() & num != null);
	}

	// Token: 0x060125F1 RID: 75249 RVA: 0x0048750F File Offset: 0x0048570F
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

	// Token: 0x060125F2 RID: 75250 RVA: 0x00487531 File Offset: 0x00485731
	public void BindToggleClickCallBack(Action<PlayerHeadData> toggleClickClickBack)
	{
		this.ToggleClickCallBack = toggleClickClickBack;
	}

	// Token: 0x060125F3 RID: 75251 RVA: 0x0048753A File Offset: 0x0048573A
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060125F4 RID: 75252 RVA: 0x0048754D File Offset: 0x0048574D
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008B0E RID: 35598
	private PlayerHeadData PlayerHeadData;

	// Token: 0x04008B0F RID: 35599
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PlayerHeadData> ToggleClickCallBack;
}
