using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A47 RID: 6727
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PhotoSelfieItem : GridProxyAbstract<PhotoSelfieItemData>
{
	// Token: 0x06010989 RID: 67977 RVA: 0x004DB2D8 File Offset: 0x004D94D8
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

	// Token: 0x0601098A RID: 67978 RVA: 0x004DB3AD File Offset: 0x004D95AD
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601098B RID: 67979 RVA: 0x004DB3BC File Offset: 0x004D95BC
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

	// Token: 0x0601098C RID: 67980 RVA: 0x004DB4B0 File Offset: 0x004D96B0
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601098D RID: 67981 RVA: 0x004DB4CD File Offset: 0x004D96CD
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x0601098E RID: 67982 RVA: 0x004DB4D7 File Offset: 0x004D96D7
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x0601098F RID: 67983 RVA: 0x004DB4E1 File Offset: 0x004D96E1
	public override object GetKey(PhotoSelfieItemData data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010990 RID: 67984 RVA: 0x004DB4EE File Offset: 0x004D96EE
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x06010991 RID: 67985 RVA: 0x004DB4FC File Offset: 0x004D96FC
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
		this.OnSelfieClick(base.GridIndex);
	}

	// Token: 0x040092E3 RID: 37603
	private PhotoSelfieItemData Data;

	// Token: 0x040092E4 RID: 37604
	private bool IsUnlock = true;

	// Token: 0x040092E5 RID: 37605
	public Action<int> OnSelfieClick = delegate(int gridIndex)
	{
	};

	// Token: 0x040092E6 RID: 37606
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02007CAE RID: 31918
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040285EE RID: 165358
		Toggle,
		// Token: 0x040285EF RID: 165359
		ItemDefaultPanel,
		// Token: 0x040285F0 RID: 165360
		ItemContentPanel,
		// Token: 0x040285F1 RID: 165361
		TexBg,
		// Token: 0x040285F2 RID: 165362
		TextTitle,
		// Token: 0x040285F3 RID: 165363
		SpriteRedDot,
		// Token: 0x040285F4 RID: 165364
		ItemLockPanel
	}
}
