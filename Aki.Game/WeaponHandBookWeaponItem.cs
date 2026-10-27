using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using UnrealEngine;

// Token: 0x02001E4A RID: 7754
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class WeaponHandBookWeaponItem : LoopScrollMediumItemGrid<WeaponHandBookDynamicLayoutItemData>
{
	// Token: 0x0600EBCA RID: 60362 RVA: 0x0037F3A0 File Offset: 0x0037D5A0
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

	// Token: 0x0600EBCB RID: 60363 RVA: 0x0037F46B File Offset: 0x0037D66B
	protected override void OnStart()
	{
		EventSystem.Instance.Add(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EBCC RID: 60364 RVA: 0x0037F489 File Offset: 0x0037D689
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnHandBookRead, new Action<EHandBookTabType, int>(this.OnHandBookRead));
	}

	// Token: 0x0600EBCD RID: 60365 RVA: 0x0037F4A7 File Offset: 0x0037D6A7
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, true);
		if (fireEvent)
		{
			this.OnExtendToggleStateChanged(EToggleState.ETT_Checked);
		}
	}

	// Token: 0x0600EBCE RID: 60366 RVA: 0x0037F4BB File Offset: 0x0037D6BB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600EBCF RID: 60367 RVA: 0x0037F4C5 File Offset: 0x0037D6C5
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

	// Token: 0x0600EBD0 RID: 60368 RVA: 0x0037F4E7 File Offset: 0x0037D6E7
	protected void OnHandBookRead(EHandBookTabType type, int id)
	{
		if (type != EHandBookTabType.Weapon || id != this.HandBookId)
		{
			return;
		}
		base.SetNewVisible(new bool?(false));
	}

	// Token: 0x04006D54 RID: 27988
	public int HandBookId;

	// Token: 0x04006D55 RID: 27989
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<UUIExtendToggle, int> OnClickCallBack;
}
