using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x0200130C RID: 4876
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class WeaponHandBookWeaponItem : LoopScrollMediumItemGrid<WeaponHandBookDynamicLayoutItemData>
{
	// Token: 0x0600BFE9 RID: 49129 RVA: 0x0038B030 File Offset: 0x00389230
	protected override void OnRefresh(WeaponHandBookDynamicLayoutItemData data, bool isSelected, int gridIndex)
	{
		this.HandBookId = data.ItemId.GetValueOrDefault();
		this.SetSelected(isSelected, false);
		HandBookEntry handBookInfo = HandBookModel.Instance.GetHandBookInfo(EHandBookTabType.Weapon, this.HandBookId);
		bool value = handBookInfo == null || !handBookInfo.IsRead;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = this.HandBookId,
			ItemConfigId = new int?(this.HandBookId),
			IsNewVisible = new bool?(value),
			BottomTextId = (data.IsSkin ? WeaponConfig.Instance.GetWeaponSkinConfig(this.HandBookId).Name : WeaponConfig.Instance.GetWeaponConfigByItemId(this.HandBookId).Value.WeaponName)
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x0600BFEA RID: 49130 RVA: 0x0038B0FB File Offset: 0x003892FB
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BFEB RID: 49131 RVA: 0x0038B119 File Offset: 0x00389319
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600BFEC RID: 49132 RVA: 0x0038B137 File Offset: 0x00389337
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600BFED RID: 49133 RVA: 0x0038B14B File Offset: 0x0038934B
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600BFEE RID: 49134 RVA: 0x0038B155 File Offset: 0x00389355
	protected override void OnExtendToggleStateChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<UUIExtendToggle, int> onClickCallBack = this.OnClickCallBack;
			if (onClickCallBack == null)
			{
				return;
			}
			onClickCallBack(this.GetItemGridExtendToggle(), this.HandBookId);
		}
	}

	// Token: 0x0600BFEF RID: 49135 RVA: 0x0038B177 File Offset: 0x00389377
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Weapon || id != this.HandBookId)
		{
			return;
		}
		base.SetNewVisible(new bool?(false));
	}

	// Token: 0x04006E35 RID: 28213
	public int HandBookId;

	// Token: 0x04006E36 RID: 28214
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;
}
