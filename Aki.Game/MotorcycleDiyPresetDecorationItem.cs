using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200227A RID: 8826
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyPresetDecorationItem : GridProxyAbstract<MotorcycleDiyEditStickerDecoItemData>
{
	// Token: 0x060113D2 RID: 70610 RVA: 0x00434E10 File Offset: 0x00433010
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

	// Token: 0x060113D3 RID: 70611 RVA: 0x00434EE8 File Offset: 0x004330E8
	public void SetEnableClick(bool isEnable)
	{
		EToggleState state = isEnable ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x060113D4 RID: 70612 RVA: 0x00434F10 File Offset: 0x00433110
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
		MotorDecorationsPart? motorDecorationPartConfig = MotorDiyConfig.Instance.GetMotorDecorationPartConfig(data.Part);
		if (motorDecorationPartConfig == null)
		{
			return;
		}
		base.SetTextureByPath(motorDecorationPartConfig.Value.Icon, texture2, null, null);
		if (data.ItemId <= 0)
		{
			item2.SetUIActive(true);
			return;
		}
		MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(data.ItemId);
		if (motorDecorationConfig == null)
		{
			return;
		}
		int qualityId = motorDecorationConfig.Value.QualityId;
		MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(qualityId);
		if (motorQualityConfig == null)
		{
			return;
		}
		texture.SetUIActive(true);
		sprite.SetUIActive(true);
		this.SetSpriteByPath(motorQualityConfig.Value.Path, sprite, false, null, null);
		base.SetTextureByPath(motorDecorationConfig.Value.Icon, texture, null, null);
	}

	// Token: 0x060113D5 RID: 70613 RVA: 0x0043507C File Offset: 0x0043327C
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

	// Token: 0x04008326 RID: 33574
	[Nullable(2)]
	private MotorcycleDiyEditStickerDecoItemData Data;

	// Token: 0x04008327 RID: 33575
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleDiyEditStickerDecoItemData> OnClickToggleBack;

	// Token: 0x020087BE RID: 34750
	private class EDecorationItemComponent
	{
		// Token: 0x0402C1DD RID: 180701
		public const int TogItem = 0;

		// Token: 0x0402C1DE RID: 180702
		public const int TexIcon = 1;

		// Token: 0x0402C1DF RID: 180703
		public const int EmptyItem = 2;

		// Token: 0x0402C1E0 RID: 180704
		public const int TexIconPart = 3;

		// Token: 0x0402C1E1 RID: 180705
		public const int NoneItem = 4;

		// Token: 0x0402C1E2 RID: 180706
		public const int SprQuality = 5;

		// Token: 0x0402C1E3 RID: 180707
		public const int ChangeTagItem = 6;
	}
}
