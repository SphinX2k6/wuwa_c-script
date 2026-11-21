using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A4B RID: 6731
[NullableContext(1)]
[Nullable(0)]
public class PhotoAtmosphereItem : GridProxyAbstract<PhotoAtmosphere>
{
	// Token: 0x060109B7 RID: 68023 RVA: 0x004DC00C File Offset: 0x004DA20C
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

	// Token: 0x060109B8 RID: 68024 RVA: 0x004DC0E1 File Offset: 0x004DA2E1
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060109B9 RID: 68025 RVA: 0x004DC0F0 File Offset: 0x004DA2F0
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

	// Token: 0x060109BA RID: 68026 RVA: 0x004DC1D8 File Offset: 0x004DA3D8
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x060109BB RID: 68027 RVA: 0x004DC1F5 File Offset: 0x004DA3F5
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x060109BC RID: 68028 RVA: 0x004DC1FF File Offset: 0x004DA3FF
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x060109BD RID: 68029 RVA: 0x004DC209 File Offset: 0x004DA409
	public override object GetKey(PhotoAtmosphere data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x060109BE RID: 68030 RVA: 0x004DC217 File Offset: 0x004DA417
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x060109BF RID: 68031 RVA: 0x004DC224 File Offset: 0x004DA424
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
				ItemController.Instance.OpenItemTipsByItemId(this.Data.RelativeItem, true, null, false);
			}
			return;
		}
		this.OnAtmosphereClick(base.GridIndex);
	}

	// Token: 0x040092F6 RID: 37622
	private PhotoAtmosphere Data;

	// Token: 0x040092F7 RID: 37623
	private bool IsUnlock = true;

	// Token: 0x040092F8 RID: 37624
	public Action<int> OnAtmosphereClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040092F9 RID: 37625
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02007CB7 RID: 31927
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402861E RID: 165406
		ToggleItem,
		// Token: 0x0402861F RID: 165407
		ItemNormalState,
		// Token: 0x04028620 RID: 165408
		ItemContent,
		// Token: 0x04028621 RID: 165409
		TextureBg,
		// Token: 0x04028622 RID: 165410
		TextTitle,
		// Token: 0x04028623 RID: 165411
		SpriteRedDot,
		// Token: 0x04028624 RID: 165412
		ItemLockState
	}
}
