using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A59 RID: 6745
[NullableContext(1)]
[Nullable(0)]
public class PhotoLightItem : GridProxyAbstract<PhotoLight>
{
	// Token: 0x06010A5F RID: 68191 RVA: 0x004DEF2C File Offset: 0x004DD12C
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

	// Token: 0x06010A60 RID: 68192 RVA: 0x004DF001 File Offset: 0x004DD201
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06010A61 RID: 68193 RVA: 0x004DF010 File Offset: 0x004DD210
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

	// Token: 0x06010A62 RID: 68194 RVA: 0x004DF112 File Offset: 0x004DD312
	private void SetToggleState(bool isSelect, bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(isSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x06010A63 RID: 68195 RVA: 0x004DF12F File Offset: 0x004DD32F
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true, fireEvent);
	}

	// Token: 0x06010A64 RID: 68196 RVA: 0x004DF139 File Offset: 0x004DD339
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false, fireEvent);
	}

	// Token: 0x06010A65 RID: 68197 RVA: 0x004DF143 File Offset: 0x004DD343
	public override object GetKey(PhotoLight data, int displayIndex)
	{
		return data.Id;
	}

	// Token: 0x06010A66 RID: 68198 RVA: 0x004DF151 File Offset: 0x004DD351
	protected override void OnBeforeDestroy()
	{
		this.UnlockAnimPlayer.Clear();
	}

	// Token: 0x06010A67 RID: 68199 RVA: 0x004DF160 File Offset: 0x004DD360
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
		this.OnLightClick(base.GridIndex);
	}

	// Token: 0x04009323 RID: 37667
	private PhotoLight Data;

	// Token: 0x04009324 RID: 37668
	public Action<int> OnLightClick = delegate(int gridIndex)
	{
	};

	// Token: 0x04009325 RID: 37669
	private bool IsUnlock = true;

	// Token: 0x04009326 RID: 37670
	private readonly PhotoUnlockAnimPlayer UnlockAnimPlayer = new PhotoUnlockAnimPlayer();

	// Token: 0x02007CDA RID: 31962
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040286E6 RID: 165606
		ToggleItem,
		// Token: 0x040286E7 RID: 165607
		ItemNormalState,
		// Token: 0x040286E8 RID: 165608
		ItemContent,
		// Token: 0x040286E9 RID: 165609
		TextureBg,
		// Token: 0x040286EA RID: 165610
		TextTitle,
		// Token: 0x040286EB RID: 165611
		SpriteRedDot,
		// Token: 0x040286EC RID: 165612
		ItemLockPanel
	}
}
