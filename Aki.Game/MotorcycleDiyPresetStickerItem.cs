using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001761 RID: 5985
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetStickerItem : GridProxyAbstract<MotorcycleDiyEditStickerDecoItemData>
{
	// Token: 0x0600E879 RID: 59513 RVA: 0x00442074 File Offset: 0x00440274
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickItem))
		};
	}

	// Token: 0x0600E87A RID: 59514 RVA: 0x0044214C File Offset: 0x0044034C
	public void SetEnableClick(bool isEnable)
	{
		EToggleState state = isEnable ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600E87B RID: 59515 RVA: 0x00442174 File Offset: 0x00440374
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiyEditStickerDecoItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(3);
		UUIItem item = base.GetItem(2);
		UUIItem item2 = base.GetItem(4);
		UUISprite sprite = base.GetSprite(5);
		UUIItem item3 = base.GetItem(6);
		extendToggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		texture.SetUIActive(false);
		item.SetUIActive(false);
		item2.SetUIActive(false);
		sprite.SetUIActive(false);
		item3.SetUIActive(data.HasChange);
		MotorStickerPart? motorStickerPartConfig = MotorDiyConfig.Instance.GetMotorStickerPartConfig(data.Part);
		if (motorStickerPartConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorStickerPartConfig.Value.Icon, texture2, null, null);
		if (data.ItemId <= 0)
		{
			item2.SetUIActive(true);
			return;
		}
		MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(data.ItemId);
		if (motorStickerConfig == null)
		{
			return;
		}
		int qualityId = motorStickerConfig.Value.QualityId;
		MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(qualityId);
		if (motorQualityConfig == null)
		{
			return;
		}
		texture.SetUIActive(true);
		sprite.SetUIActive(true);
		this.SetSpriteByPath(motorQualityConfig.Value.Path, sprite, false, null, null);
		base.SetTextureByPath(motorStickerConfig.Value.StickerIconPath, texture, null, null);
	}

	// Token: 0x0600E87C RID: 59516 RVA: 0x004422E0 File Offset: 0x004404E0
	private void OnClickItem(EToggleState state)
	{
		if (this.Data == null)
		{
			return;
		}
		Action<MotorcycleDiyEditStickerDecoItemData> onClickToggleBack = this.OnClickToggleBack;
		if (onClickToggleBack == null)
		{
			return;
		}
		onClickToggleBack(this.Data);
	}

	// Token: 0x0400846A RID: 33898
	[Nullable(2)]
	private MotorcycleDiyEditStickerDecoItemData Data;

	// Token: 0x0400846B RID: 33899
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleDiyEditStickerDecoItemData> OnClickToggleBack;

	// Token: 0x0200794B RID: 31051
	private class EStickerItemComponent
	{
		// Token: 0x04027504 RID: 161028
		public const int TogItem = 0;

		// Token: 0x04027505 RID: 161029
		public const int TexIcon = 1;

		// Token: 0x04027506 RID: 161030
		public const int EmptyItem = 2;

		// Token: 0x04027507 RID: 161031
		public const int TexIconPart = 3;

		// Token: 0x04027508 RID: 161032
		public const int NoneItem = 4;

		// Token: 0x04027509 RID: 161033
		public const int SprQuality = 5;

		// Token: 0x0402750A RID: 161034
		public const int ChangeTagItem = 6;
	}
}
