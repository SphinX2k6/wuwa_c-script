using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002276 RID: 8822
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditPresetPanel : UiPanelBase
{
	// Token: 0x060113AF RID: 70575 RVA: 0x00433AE0 File Offset: 0x00431CE0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem))
		};
	}

	// Token: 0x060113B0 RID: 70576 RVA: 0x00433BD8 File Offset: 0x00431DD8
	protected override void OnStart()
	{
		this.StickerScrollView = new GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData>(base.GetScrollViewWithScrollbar(5), new Func<MotorcycleDiyPresetStickerItem>(this.InitStickerScrollItem), null, false, null);
		this.DecorateScrollView = new GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData>(base.GetScrollViewWithScrollbar(8), new Func<MotorcycleDiyPresetDecorationItem>(this.InitDecorateScrollItem), null, false, null);
	}

	// Token: 0x060113B1 RID: 70577 RVA: 0x00433C27 File Offset: 0x00431E27
	private MotorcycleDiyPresetStickerItem InitStickerScrollItem()
	{
		return new MotorcycleDiyPresetStickerItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyEditStickerDecoItemData>(this.OnClickStickerItem)
		};
	}

	// Token: 0x060113B2 RID: 70578 RVA: 0x00433C40 File Offset: 0x00431E40
	private MotorcycleDiyPresetDecorationItem InitDecorateScrollItem()
	{
		return new MotorcycleDiyPresetDecorationItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyEditStickerDecoItemData>(this.OnClickDecorationItem)
		};
	}

	// Token: 0x060113B3 RID: 70579 RVA: 0x00433C5C File Offset: 0x00431E5C
	public void Refresh(int selectFrame, List<int> selectStickers, List<int> selectDecorations, [Nullable(2)] MotorcycleDiyPresetData presetData = null)
	{
		bool isChange = presetData != null && presetData.FrameId != selectFrame;
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		if (presetData != null)
		{
			isChange = (presetData.FrameId != selectFrame);
			for (int i = 0; i < presetData.StickerIds.Length; i++)
			{
				int? num = (i < selectStickers.Count) ? new int?(selectStickers[i]) : null;
				int num2 = presetData.StickerIds[i];
				int? num3 = num;
				if (!(num2 == num3.GetValueOrDefault() & num3 != null))
				{
					list.Add(i + 1);
				}
			}
			for (int j = 0; j < presetData.DecorateIds.Length; j++)
			{
				int? num4 = (j < selectDecorations.Count) ? new int?(selectDecorations[j]) : null;
				int num5 = presetData.DecorateIds[j];
				int? num3 = num4;
				if (!(num5 == num3.GetValueOrDefault() & num3 != null))
				{
					list2.Add(j + 1);
				}
			}
		}
		this.RefreshFrameList(selectFrame, isChange);
		this.RefreshStickerList(selectStickers, list);
		this.RefreshDecorationList(selectDecorations, list2);
	}

	// Token: 0x060113B4 RID: 70580 RVA: 0x00433D80 File Offset: 0x00431F80
	private void RefreshFrameList(int frameId, bool isChange)
	{
		if (frameId > 0)
		{
			MotorFrame? motorFrameConfig = MotorDiyConfig.Instance.GetMotorFrameConfig(frameId);
			MotorFramePart? motorFramePartConfig = MotorDiyConfig.Instance.GetMotorFramePartConfig();
			if (motorFrameConfig != null && motorFramePartConfig != null)
			{
				base.SetTextureByPath(motorFramePartConfig.Value.Icon, base.GetTexture(1), null, null);
				base.SetTextureByPath(motorFrameConfig.Value.ModelIconPath, base.GetTexture(3), null, null);
			}
		}
		base.GetItem(2).SetUIActive(isChange);
	}

	// Token: 0x060113B5 RID: 70581 RVA: 0x00433E14 File Offset: 0x00432014
	private void RefreshStickerList(List<int> showStickerIds, List<int> changeParts)
	{
		List<MotorcycleDiyEditStickerDecoItemData> list = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorSticker? motorSticker = null;
		for (int i = 0; i < showStickerIds.Count; i++)
		{
			int num = showStickerIds[i];
			if (num > 0)
			{
				motorSticker = MotorDiyConfig.Instance.GetMotorStickerConfig(num);
			}
			MotorcycleDiyEditStickerDecoItemData item = new MotorcycleDiyEditStickerDecoItemData
			{
				Part = i + 1,
				ItemId = num,
				QualityId = ((motorSticker != null) ? motorSticker.Value.QualityId : 0),
				SortIndex = ((motorSticker != null) ? motorSticker.Value.SortIndex : 0),
				IsSticker = true,
				HasChange = changeParts.Contains(i + 1)
			};
			list.Add(item);
		}
		GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> stickerScrollView = this.StickerScrollView;
		if (stickerScrollView == null)
		{
			return;
		}
		stickerScrollView.RefreshByData(list, delegate
		{
			GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> stickerScrollView2 = this.StickerScrollView;
			List<MotorcycleDiyPresetStickerItem> list2 = (stickerScrollView2 != null) ? stickerScrollView2.GetScrollItemList() : null;
			if (list2 == null)
			{
				return;
			}
			foreach (MotorcycleDiyPresetStickerItem motorcycleDiyPresetStickerItem in list2)
			{
				motorcycleDiyPresetStickerItem.SetEnableClick(true);
			}
		}, false);
	}

	// Token: 0x060113B6 RID: 70582 RVA: 0x00433EF8 File Offset: 0x004320F8
	private void RefreshDecorationList(List<int> showDecorationIds, List<int> changeParts)
	{
		List<MotorcycleDiyEditStickerDecoItemData> list = new List<MotorcycleDiyEditStickerDecoItemData>();
		MotorDecorations? motorDecorations = null;
		for (int i = 0; i < showDecorationIds.Count; i++)
		{
			int num = showDecorationIds[i];
			if (num > 0)
			{
				motorDecorations = MotorDiyConfig.Instance.GetMotorDecorationConfig(num);
			}
			MotorcycleDiyEditStickerDecoItemData item = new MotorcycleDiyEditStickerDecoItemData
			{
				Part = i + 1,
				ItemId = num,
				QualityId = ((motorDecorations != null) ? motorDecorations.Value.QualityId : 0),
				SortIndex = ((motorDecorations != null) ? motorDecorations.Value.SortIndex : 0),
				IsSticker = false,
				HasChange = changeParts.Contains(i + 1)
			};
			list.Add(item);
		}
		GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> decorateScrollView = this.DecorateScrollView;
		if (decorateScrollView == null)
		{
			return;
		}
		decorateScrollView.RefreshByData(list, delegate
		{
			GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> decorateScrollView2 = this.DecorateScrollView;
			List<MotorcycleDiyPresetDecorationItem> list2 = (decorateScrollView2 != null) ? decorateScrollView2.GetScrollItemList() : null;
			if (list2 == null)
			{
				return;
			}
			foreach (MotorcycleDiyPresetDecorationItem motorcycleDiyPresetDecorationItem in list2)
			{
				motorcycleDiyPresetDecorationItem.SetEnableClick(true);
			}
		}, false);
	}

	// Token: 0x060113B7 RID: 70583 RVA: 0x00433FD9 File Offset: 0x004321D9
	private void OnClickStickerItem(MotorcycleDiyEditStickerDecoItemData data)
	{
		this.JumpToEditTab(EUiTabViewName.MotorcycleDiyEditStickerTabView, data.Part);
	}

	// Token: 0x060113B8 RID: 70584 RVA: 0x00433FEC File Offset: 0x004321EC
	private void OnClickDecorationItem(MotorcycleDiyEditStickerDecoItemData data)
	{
		this.JumpToEditTab(EUiTabViewName.MotorcycleDiyEditDecorationTabView, data.Part);
	}

	// Token: 0x060113B9 RID: 70585 RVA: 0x00433FFF File Offset: 0x004321FF
	private void JumpToEditTab(EUiTabViewName tabViewName, int partTabIndex)
	{
		MotorcycleDiyEditRootView motorcycleDiyEditRootView = UiManager.Instance.GetViewByName(EUiViewName.MotorcycleDiyEditRootView) as MotorcycleDiyEditRootView;
		if (motorcycleDiyEditRootView == null)
		{
			return;
		}
		motorcycleDiyEditRootView.SwitchToTabPart(tabViewName, new int?(partTabIndex));
	}

	// Token: 0x0400831D RID: 33565
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x0400831E RID: 33566
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> DecorateScrollView;

	// Token: 0x020087B9 RID: 34745
	[NullableContext(0)]
	private class EPresetInfoComponent
	{
		// Token: 0x0402C1B7 RID: 180663
		public const int PnlFrame = 0;

		// Token: 0x0402C1B8 RID: 180664
		public const int TexFramePartIcon = 1;

		// Token: 0x0402C1B9 RID: 180665
		public const int PnlFrameTag = 2;

		// Token: 0x0402C1BA RID: 180666
		public const int TexFrameIcon = 3;

		// Token: 0x0402C1BB RID: 180667
		public const int PnlSticker = 4;

		// Token: 0x0402C1BC RID: 180668
		public const int StickerScroll = 5;

		// Token: 0x0402C1BD RID: 180669
		public const int StickerItem = 6;

		// Token: 0x0402C1BE RID: 180670
		public const int PnlDecoration = 7;

		// Token: 0x0402C1BF RID: 180671
		public const int DecorationScroll = 8;

		// Token: 0x0402C1C0 RID: 180672
		public const int DecorationItem = 9;
	}
}
