using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200114F RID: 4431
public class WeaponDescribeComponent : UiPanelBase
{
	// Token: 0x0600B0C2 RID: 45250 RVA: 0x00343298 File Offset: 0x00341498
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B0C3 RID: 45251 RVA: 0x00343385 File Offset: 0x00341585
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(true);
	}

	// Token: 0x0600B0C4 RID: 45252 RVA: 0x003433C0 File Offset: 0x003415C0
	public void Update(int gachaTextureInfoId, bool isUp = false)
	{
		this.GachaTextureInfoId = gachaTextureInfoId;
		GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(this.GachaTextureInfoId);
		if (gachaTextureInfo == null)
		{
			return;
		}
		int itemId = (gachaTextureInfo.Value.IdArrayLength <= 0) ? this.GachaTextureInfoId : gachaTextureInfo.Value.GetIdArrayArray()[0];
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		base.GetText(0).ShowTextNew(weaponConfigByItemId.Value.WeaponName);
		base.GetItem(1).SetUIActive(isUp);
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GachaWeaponBg");
		this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
		this.UpdateWeaponIcon(weaponConfigByItemId.Value.WeaponType);
		this.UpdateQuality(weaponConfigByItemId.Value.QualityId);
	}

	// Token: 0x0600B0C5 RID: 45253 RVA: 0x003434B2 File Offset: 0x003416B2
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x0600B0C6 RID: 45254 RVA: 0x003434C0 File Offset: 0x003416C0
	private void UpdateWeaponIcon(int weaponType)
	{
		foreach (Mapping mapping in MappingConfig.Instance.GetWeaponConfList())
		{
			if (weaponType == mapping.Value)
			{
				this.SetSpriteByPath(mapping.Icon, base.GetSprite(5), false, null, null);
				break;
			}
		}
	}

	// Token: 0x04006605 RID: 26117
	private int GachaTextureInfoId;

	// Token: 0x04006606 RID: 26118
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x020073F7 RID: 29687
	private enum EComponent
	{
		// Token: 0x04025C05 RID: 154629
		NameText,
		// Token: 0x04025C06 RID: 154630
		UpItem,
		// Token: 0x04025C07 RID: 154631
		StarLayout,
		// Token: 0x04025C08 RID: 154632
		WeaponIconTexture,
		// Token: 0x04025C09 RID: 154633
		WeaponBgSprite,
		// Token: 0x04025C0A RID: 154634
		WeaponIconSprite
	}
}
