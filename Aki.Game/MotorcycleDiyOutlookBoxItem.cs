using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200175D RID: 5981
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiyOutlookBoxItem : GridProxyAbstract<MotorcycleDiyOutlookBoxItemData>
{
	// Token: 0x0600E85F RID: 59487 RVA: 0x004414B0 File Offset: 0x0043F6B0
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

	// Token: 0x0600E860 RID: 59488 RVA: 0x00441570 File Offset: 0x0043F770
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

	// Token: 0x0600E861 RID: 59489 RVA: 0x004415C8 File Offset: 0x0043F7C8
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

	// Token: 0x0600E862 RID: 59490 RVA: 0x00441734 File Offset: 0x0043F934
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

	// Token: 0x0600E863 RID: 59491 RVA: 0x004418A0 File Offset: 0x0043FAA0
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

	// Token: 0x0600E864 RID: 59492 RVA: 0x00441914 File Offset: 0x0043FB14
	private void OnClickFrameToggle()
	{
		OpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
		{
			OpenTabView = new EUiTabViewName?(EUiTabViewName.MotorcycleDiyFrameTabView),
			IsNeedResetMotor = new bool?(true)
		};
		UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
	}

	// Token: 0x0600E865 RID: 59493 RVA: 0x00441954 File Offset: 0x0043FB54
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

	// Token: 0x0600E866 RID: 59494 RVA: 0x004419B4 File Offset: 0x0043FBB4
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

	// Token: 0x04008463 RID: 33891
	[Nullable(2)]
	private MotorcycleDiyOutlookBoxItemData Data;

	// Token: 0x02007946 RID: 31046
	private class EOutlookBoxItemComponent
	{
		// Token: 0x040274EF RID: 161007
		public const int TogItem = 0;

		// Token: 0x040274F0 RID: 161008
		public const int TexIcon = 1;

		// Token: 0x040274F1 RID: 161009
		public const int ItemEmpty = 2;

		// Token: 0x040274F2 RID: 161010
		public const int TexPart = 3;

		// Token: 0x040274F3 RID: 161011
		public const int ItemNone = 4;

		// Token: 0x040274F4 RID: 161012
		public const int SprQuality = 5;
	}
}
