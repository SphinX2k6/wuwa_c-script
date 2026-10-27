using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200255C RID: 9564
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoSelfieItem : GridProxyAbstract<PhotoSelfieItemData>
{
	// Token: 0x060134A7 RID: 79015 RVA: 0x004CC6A4 File Offset: 0x004CA8A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060134A8 RID: 79016 RVA: 0x004CC779 File Offset: 0x004CA979
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060134A9 RID: 79017 RVA: 0x004CC788 File Offset: 0x004CA988
	public override void Refresh(PhotoSelfieItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool isDefault = data.IsDefault;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(isDefault);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(!isDefault);
		}
		if (!isDefault && !string.IsNullOrEmpty(data.Icon))
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(3), null, null);
		}
		if (!isDefault)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.Name, Array.Empty<object>());
		}
		this.IsUnlock = PhotoUnlockAnimPlayer.IsUnlockByItem(data.RelativeItem);
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(!isDefault && !this.IsUnlock);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
		this.UnlockAnimPlayer.TryPlay(this.RootItem, data.RelativeItem);
	}

	// Token: 0x060134AA RID: 79018 RVA: 0x004CC87C File Offset: 0x004CAA7C
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060134AB RID: 79019 RVA: 0x004CC899 File Offset: 0x004CAA99
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060134AC RID: 79020 RVA: 0x004CC8A3 File Offset: 0x004CAAA3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060134AD RID: 79021 RVA: 0x004CC8AD File Offset: 0x004CAAAD
	public override object GetKey(PhotoSelfieItemData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060134AE RID: 79022 RVA: 0x004CC8BA File Offset: 0x004CAABA
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x060134AF RID: 79023 RVA: 0x004CC8C8 File Offset: 0x004CAAC8
	private void OnToggleClick(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (!this.IsUnlock)
		{
			this.SetToggleState(false, false);
			if (this.Data.RelativeItem != 0)
			{
				ItemController.Instance.OpenItemTipsByItemId(this.Data.RelativeItem, true, null);
			}
			return;
		}
		this.OnSelfieClick(base.GridIndex);
	}

	// Token: 0x0400918A RID: 37258
	private PhotoSelfieItemData Data;

	// Token: 0x0400918B RID: 37259
	private bool IsUnlock = true;

	// Token: 0x0400918C RID: 37260
	public Action<int> OnSelfieClick = delegate(int gridIndex)
	{
	};

	// Token: 0x0400918D RID: 37261
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02008B28 RID: 35624
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D2E1 RID: 185057
		Toggle,
		// Token: 0x0402D2E2 RID: 185058
		ItemDefaultPanel,
		// Token: 0x0402D2E3 RID: 185059
		ItemContentPanel,
		// Token: 0x0402D2E4 RID: 185060
		TexBg,
		// Token: 0x0402D2E5 RID: 185061
		TextTitle,
		// Token: 0x0402D2E6 RID: 185062
		SpriteRedDot,
		// Token: 0x0402D2E7 RID: 185063
		ItemLockPanel
	}
}
