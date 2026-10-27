using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C90 RID: 7312
public class WeaponDescribeComponent : UiPanelBase
{
	// Token: 0x0600DCAC RID: 56492 RVA: 0x00337D74 File Offset: 0x00335F74
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

	// Token: 0x0600DCAD RID: 56493 RVA: 0x00337E61 File Offset: 0x00336061
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

	// Token: 0x0600DCAE RID: 56494 RVA: 0x00337E9C File Offset: 0x0033609C
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

	// Token: 0x0600DCAF RID: 56495 RVA: 0x00337F8E File Offset: 0x0033618E
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x0600DCB0 RID: 56496 RVA: 0x00337F9C File Offset: 0x0033619C
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

	// Token: 0x04006533 RID: 25907
	private int GachaTextureInfoId;

	// Token: 0x04006534 RID: 25908
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x0200826F RID: 33391
	private enum EComponent
	{
		// Token: 0x0402A8E4 RID: 174308
		NameText,
		// Token: 0x0402A8E5 RID: 174309
		UpItem,
		// Token: 0x0402A8E6 RID: 174310
		StarLayout,
		// Token: 0x0402A8E7 RID: 174311
		WeaponIconTexture,
		// Token: 0x0402A8E8 RID: 174312
		WeaponBgSprite,
		// Token: 0x0402A8E9 RID: 174313
		WeaponIconSprite
	}
}
