using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002560 RID: 9568
[NullableContext(1)]
[Nullable(0)]
public class PhotoAtmosphereItem : GridProxyAbstract<PhotoAtmosphere>
{
	// Token: 0x060134D5 RID: 79061 RVA: 0x004CD3D4 File Offset: 0x004CB5D4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060134D6 RID: 79062 RVA: 0x004CD4A9 File Offset: 0x004CB6A9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060134D7 RID: 79063 RVA: 0x004CD4B8 File Offset: 0x004CB6B8
	public override void Refresh(PhotoAtmosphere data, bool isSelected, int gridIndex)
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
		if (!isDefault)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(3), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.Name.ToString(), Array.Empty<object>());
		}
		this.IsUnlock = PhotoUnlockAnimPlayer.IsUnlockByItem(data.RelativeItem);
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(!this.IsUnlock);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		this.SetToggleState(isSelected, false);
		this.UnlockAnimPlayer.TryPlay(this.RootItem, data.RelativeItem);
	}

	// Token: 0x060134D8 RID: 79064 RVA: 0x004CD5A0 File Offset: 0x004CB7A0
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060134D9 RID: 79065 RVA: 0x004CD5BD File Offset: 0x004CB7BD
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060134DA RID: 79066 RVA: 0x004CD5C7 File Offset: 0x004CB7C7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060134DB RID: 79067 RVA: 0x004CD5D1 File Offset: 0x004CB7D1
	public override object GetKey(PhotoAtmosphere data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060134DC RID: 79068 RVA: 0x004CD5DF File Offset: 0x004CB7DF
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x060134DD RID: 79069 RVA: 0x004CD5EC File Offset: 0x004CB7EC
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
		this.OnAtmosphereClick(base.GridIndex);
	}

	// Token: 0x0400919D RID: 37277
	private PhotoAtmosphere Data;

	// Token: 0x0400919E RID: 37278
	private bool IsUnlock = true;

	// Token: 0x0400919F RID: 37279
	public Action<int> OnAtmosphereClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040091A0 RID: 37280
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02008B31 RID: 35633
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D311 RID: 185105
		ToggleItem,
		// Token: 0x0402D312 RID: 185106
		ItemNormalState,
		// Token: 0x0402D313 RID: 185107
		ItemContent,
		// Token: 0x0402D314 RID: 185108
		TextureBg,
		// Token: 0x0402D315 RID: 185109
		TextTitle,
		// Token: 0x0402D316 RID: 185110
		SpriteRedDot,
		// Token: 0x0402D317 RID: 185111
		ItemLockState
	}
}
