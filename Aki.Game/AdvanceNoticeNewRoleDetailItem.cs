using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200058A RID: 1418
public class AdvanceNoticeNewRoleDetailItem : UiPanelBase
{
	// Token: 0x060043CC RID: 17356 RVA: 0x001766C4 File Offset: 0x001748C4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x0017678C File Offset: 0x0017498C
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x001767B0 File Offset: 0x001749B0
	public void Refresh(int subTabId)
	{
		AdvertisingTabCharacter advertisingTabCharacterById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCharacterById(subTabId);
		if (advertisingTabCharacterById.Type == 1)
		{
			this.RefreshRoleItem(advertisingTabCharacterById);
			return;
		}
		this.RefreshWeaponItem(advertisingTabCharacterById);
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x001767E4 File Offset: 0x001749E4
	private void RefreshRoleItem(AdvertisingTabCharacter config)
	{
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(true);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		base.GetText(0).ShowTextNew(config.NameText);
		UUITexture texture2 = base.GetTexture(3);
		UUISprite sprite2 = base.GetSprite(4);
		base.SetTextureByPath(config.ElementIconPath, texture2, null, null);
		this.SetSpriteByPath(config.ElementBgIconPath, sprite2, false, null, null);
		this.UpdateQuality(config.QualityId);
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x00176878 File Offset: 0x00174A78
	private void RefreshWeaponItem(AdvertisingTabCharacter config)
	{
		UUITexture texture = base.GetTexture(3);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
		base.GetText(0).ShowTextNew(config.NameText);
		int qualityId = config.QualityId;
		string resourceId = AdvanceNoticeDefine.starToWeaponGachaBgResourceId[qualityId];
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
		this.SetSpriteByPath(config.WeaponTypeIconPath, base.GetSprite(5), false, null, null);
		this.UpdateQuality(qualityId);
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x0017691D File Offset: 0x00174B1D
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x040034B0 RID: 13488
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x0200682F RID: 26671
	private class EComponent
	{
		// Token: 0x0402258B RID: 140683
		public const int NameText = 0;

		// Token: 0x0402258C RID: 140684
		public const int UpItem = 1;

		// Token: 0x0402258D RID: 140685
		public const int StarLayout = 2;

		// Token: 0x0402258E RID: 140686
		public const int IconTexture = 3;

		// Token: 0x0402258F RID: 140687
		public const int IconBgSprite = 4;

		// Token: 0x04022590 RID: 140688
		public const int IconSprite = 5;

		// Token: 0x04022591 RID: 140689
		public const int BtnLook = 6;

		// Token: 0x04022592 RID: 140690
		public const int JumpBtnRoot = 7;
	}
}
