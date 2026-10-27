using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200256E RID: 9582
[NullableContext(1)]
[Nullable(0)]
public class PhotoLightItem : GridProxyAbstract<PhotoLight>
{
	// Token: 0x0601357D RID: 79229 RVA: 0x004D02F4 File Offset: 0x004CE4F4
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

	// Token: 0x0601357E RID: 79230 RVA: 0x004D03C9 File Offset: 0x004CE5C9
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601357F RID: 79231 RVA: 0x004D03D8 File Offset: 0x004CE5D8
	public override void Refresh(PhotoLight data, bool isSelected, int gridIndex)
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
			base.SetTextureByPath((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? data.IconFemale : data.IconMale, base.GetTexture(3), null, null);
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

	// Token: 0x06013580 RID: 79232 RVA: 0x004D04DA File Offset: 0x004CE6DA
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06013581 RID: 79233 RVA: 0x004D04F7 File Offset: 0x004CE6F7
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06013582 RID: 79234 RVA: 0x004D0501 File Offset: 0x004CE701
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06013583 RID: 79235 RVA: 0x004D050B File Offset: 0x004CE70B
	public override object GetKey(PhotoLight data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06013584 RID: 79236 RVA: 0x004D0519 File Offset: 0x004CE719
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x06013585 RID: 79237 RVA: 0x004D0528 File Offset: 0x004CE728
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
		this.OnLightClick(base.GridIndex);
	}

	// Token: 0x040091CA RID: 37322
	private PhotoLight Data;

	// Token: 0x040091CB RID: 37323
	public Action<int> OnLightClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040091CC RID: 37324
	private bool IsUnlock = true;

	// Token: 0x040091CD RID: 37325
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02008B54 RID: 35668
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D3D9 RID: 185305
		ToggleItem,
		// Token: 0x0402D3DA RID: 185306
		ItemNormalState,
		// Token: 0x0402D3DB RID: 185307
		ItemContent,
		// Token: 0x0402D3DC RID: 185308
		TextureBg,
		// Token: 0x0402D3DD RID: 185309
		TextTitle,
		// Token: 0x0402D3DE RID: 185310
		SpriteRedDot,
		// Token: 0x0402D3DF RID: 185311
		ItemLockPanel
	}
}
