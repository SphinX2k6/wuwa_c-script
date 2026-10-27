using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010D6 RID: 4310
public class AdvanceNoticeNewRoleDetailItem : UiPanelBase
{
	// Token: 0x06007036 RID: 28726 RVA: 0x0016DD08 File Offset: 0x0016BF08
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

	// Token: 0x06007037 RID: 28727 RVA: 0x0016DDD0 File Offset: 0x0016BFD0
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(2));
		base.GetItem(1).SetUIActive(false);
	}

	// Token: 0x06007038 RID: 28728 RVA: 0x0016DDF4 File Offset: 0x0016BFF4
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

	// Token: 0x06007039 RID: 28729 RVA: 0x0016DE28 File Offset: 0x0016C028
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

	// Token: 0x0600703A RID: 28730 RVA: 0x0016DEBC File Offset: 0x0016C0BC
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

	// Token: 0x0600703B RID: 28731 RVA: 0x0016DF61 File Offset: 0x0016C161
	private void UpdateQuality(int quality)
	{
		this.StarLayout.RebuildLayout(quality);
	}

	// Token: 0x04003417 RID: 13335
	[Nullable(2)]
	private SimpleGenericLayout StarLayout;

	// Token: 0x0200769B RID: 30363
	private class EComponent
	{
		// Token: 0x04027242 RID: 160322
		public const int NameText = 0;

		// Token: 0x04027243 RID: 160323
		public const int UpItem = 1;

		// Token: 0x04027244 RID: 160324
		public const int StarLayout = 2;

		// Token: 0x04027245 RID: 160325
		public const int IconTexture = 3;

		// Token: 0x04027246 RID: 160326
		public const int IconBgSprite = 4;

		// Token: 0x04027247 RID: 160327
		public const int IconSprite = 5;

		// Token: 0x04027248 RID: 160328
		public const int BtnLook = 6;

		// Token: 0x04027249 RID: 160329
		public const int JumpBtnRoot = 7;
	}
}
