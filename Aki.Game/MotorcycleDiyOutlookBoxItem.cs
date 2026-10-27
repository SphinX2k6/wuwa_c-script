using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002279 RID: 8825
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyOutlookBoxItem : GridProxyAbstract<MotorcycleDiyOutlookBoxItemData>
{
	// Token: 0x060113C9 RID: 70601 RVA: 0x004348A4 File Offset: 0x00432AA4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060113CA RID: 70602 RVA: 0x00434964 File Offset: 0x00432B64
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiyOutlookBoxItemData data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		base.GetItem(4).SetUIActive(false);
		this.Data = data;
		switch (this.Data.OutlookType)
		{
		case EOutlookType.None:
		case EOutlookType.Frame:
			break;
		case EOutlookType.Sticker:
			this.RefreshStickerPartBoxItem();
			return;
		case EOutlookType.Decoration:
			this.RefreshDecorationPartBoxItem();
			break;
		default:
			return;
		}
	}

	// Token: 0x060113CB RID: 70603 RVA: 0x004349BC File Offset: 0x00432BBC
	private void RefreshStickerPartBoxItem()
	{
		MotorStickerPart? motorStickerPartConfig = MotorDiyConfig.Instance.GetMotorStickerPartConfig(this.Data.JumpIndex + 1);
		if (motorStickerPartConfig == null)
		{
			return;
		}
		bool flag = this.Data.ItemId == 0;
		base.SetTextureByPath(motorStickerPartConfig.Value.Icon, base.GetTexture(3), null, null);
		base.GetSprite(5).SetUIActive(false);
		base.GetItem(2).SetUIActive(flag);
		base.GetTexture(1).SetUIActive(!flag);
		if (!flag)
		{
			int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedStickerId(this.Data.JumpIndex + 1));
			if (num != null && num.Value > 0)
			{
				MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num.Value);
				if (motorStickerConfig == null)
				{
					return;
				}
				MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(motorStickerConfig.Value.QualityId);
				if (motorQualityConfig == null)
				{
					return;
				}
				base.GetSprite(5).SetUIActive(true);
				this.SetSpriteByPath(motorQualityConfig.Value.Path, base.GetSprite(5), false, null, null);
				base.SetTextureByPath(motorStickerConfig.Value.StickerIconPath, base.GetTexture(1), null, null);
			}
		}
	}

	// Token: 0x060113CC RID: 70604 RVA: 0x00434B28 File Offset: 0x00432D28
	private void RefreshDecorationPartBoxItem()
	{
		MotorDecorationsPart? motorDecorationPartConfig = MotorDiyConfig.Instance.GetMotorDecorationPartConfig(this.Data.JumpIndex + 1);
		if (motorDecorationPartConfig == null)
		{
			return;
		}
		bool flag = this.Data.ItemId == 0;
		base.SetTextureByPath(motorDecorationPartConfig.Value.Icon, base.GetTexture(3), null, null);
		base.GetSprite(5).SetUIActive(false);
		base.GetItem(2).SetUIActive(flag);
		base.GetTexture(1).SetUIActive(!flag);
		if (!flag)
		{
			int? num = new int?(MotorcycleDiyModel.Instance.GetEquippedDecorationId(this.Data.JumpIndex + 1));
			if (num != null && num.Value > 0)
			{
				MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num.Value);
				if (motorDecorationConfig == null)
				{
					return;
				}
				MotorQuality? motorQualityConfig = MotorDiyConfig.Instance.GetMotorQualityConfig(motorDecorationConfig.Value.QualityId);
				if (motorQualityConfig == null)
				{
					return;
				}
				base.GetSprite(5).SetUIActive(true);
				this.SetSpriteByPath(motorQualityConfig.Value.Path, base.GetSprite(5), false, null, null);
				base.SetTextureByPath(motorDecorationConfig.Value.DecorationsIconPath, base.GetTexture(1), null, null);
			}
		}
	}

	// Token: 0x060113CD RID: 70605 RVA: 0x00434C94 File Offset: 0x00432E94
	private void OnClickToggle(EToggleState toggleState)
	{
		if (this.Data == null || this.Data.JumpIndex == -1)
		{
			return;
		}
		switch (this.Data.OutlookType)
		{
		case EOutlookType.None:
			break;
		case EOutlookType.Frame:
			this.OnClickFrameToggle();
			return;
		case EOutlookType.Sticker:
			this.OnClickStickerToggle(this.Data.JumpIndex);
			return;
		case EOutlookType.Decoration:
			this.OnClickDecorationToggle(this.Data.JumpIndex);
			break;
		default:
			return;
		}
	}

	// Token: 0x060113CE RID: 70606 RVA: 0x00434D08 File Offset: 0x00432F08
	private void OnClickFrameToggle()
	{
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyFrameTabView),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
	}

	// Token: 0x060113CF RID: 70607 RVA: 0x00434D48 File Offset: 0x00432F48
	private void OnClickStickerToggle(int index)
	{
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyStickerTabView),
			PartTabIndex = new int?(index + 1),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060113D0 RID: 70608 RVA: 0x00434DA8 File Offset: 0x00432FA8
	private void OnClickDecorationToggle(int index)
	{
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyDecorationTabView),
			PartTabIndex = new int?(index + 1),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008325 RID: 33573
	[Nullable(2)]
	private MotorcycleDiyOutlookBoxItemData Data;

	// Token: 0x020087BD RID: 34749
	private class EOutlookBoxItemComponent
	{
		// Token: 0x0402C1D7 RID: 180695
		public const int TogItem = 0;

		// Token: 0x0402C1D8 RID: 180696
		public const int TexIcon = 1;

		// Token: 0x0402C1D9 RID: 180697
		public const int ItemEmpty = 2;

		// Token: 0x0402C1DA RID: 180698
		public const int TexPart = 3;

		// Token: 0x0402C1DB RID: 180699
		public const int ItemNone = 4;

		// Token: 0x0402C1DC RID: 180700
		public const int SprQuality = 5;
	}
}
