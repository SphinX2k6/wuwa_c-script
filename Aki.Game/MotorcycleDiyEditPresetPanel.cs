using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200175A RID: 5978
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleDiyEditPresetPanel : UiPanelBase
{
	// Token: 0x0600E845 RID: 59461 RVA: 0x004406EC File Offset: 0x0043E8EC
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

	// Token: 0x0600E846 RID: 59462 RVA: 0x004407E4 File Offset: 0x0043E9E4
	protected override void OnStart()
	{
		this.StickerScrollView = new GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData>(base.GetScrollViewWithScrollbar(5), new Func<MotorcycleDiyPresetStickerItem>(this.InitStickerScrollItem), null, false, null);
		this.DecorateScrollView = new GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData>(base.GetScrollViewWithScrollbar(8), new Func<MotorcycleDiyPresetDecorationItem>(this.InitDecorateScrollItem), null, false, null);
	}

	// Token: 0x0600E847 RID: 59463 RVA: 0x00440833 File Offset: 0x0043EA33
	private MotorcycleDiyPresetStickerItem InitStickerScrollItem()
	{
		return new MotorcycleDiyPresetStickerItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyEditStickerDecoItemData>(this.OnClickStickerItem)
		};
	}

	// Token: 0x0600E848 RID: 59464 RVA: 0x0044084C File Offset: 0x0043EA4C
	private MotorcycleDiyPresetDecorationItem InitDecorateScrollItem()
	{
		return new MotorcycleDiyPresetDecorationItem
		{
			OnClickToggleBack = new Action<MotorcycleDiyEditStickerDecoItemData>(this.OnClickDecorationItem)
		};
	}

	// Token: 0x0600E849 RID: 59465 RVA: 0x00440868 File Offset: 0x0043EA68
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

	// Token: 0x0600E84A RID: 59466 RVA: 0x0044098C File Offset: 0x0043EB8C
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

	// Token: 0x0600E84B RID: 59467 RVA: 0x00440A20 File Offset: 0x0043EC20
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

	// Token: 0x0600E84C RID: 59468 RVA: 0x00440B04 File Offset: 0x0043ED04
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

	// Token: 0x0600E84D RID: 59469 RVA: 0x00440BE5 File Offset: 0x0043EDE5
	private void OnClickStickerItem(MotorcycleDiyEditStickerDecoItemData data)
	{
		this.JumpToEditTab(EUiTabViewName.MotorcycleDiyEditStickerTabView, data.Part);
	}

	// Token: 0x0600E84E RID: 59470 RVA: 0x00440BF8 File Offset: 0x0043EDF8
	private void OnClickDecorationItem(MotorcycleDiyEditStickerDecoItemData data)
	{
		this.JumpToEditTab(EUiTabViewName.MotorcycleDiyEditDecorationTabView, data.Part);
	}

	// Token: 0x0600E84F RID: 59471 RVA: 0x00440C0B File Offset: 0x0043EE0B
	private void JumpToEditTab(EUiTabViewName tabViewName, int partTabIndex)
	{
		MotorcycleDiyEditRootView motorcycleDiyEditRootView = UiManager.Instance.GetViewByName(EUiViewName.MotorcycleDiyEditRootView) as MotorcycleDiyEditRootView;
		if (motorcycleDiyEditRootView == null)
		{
			return;
		}
		motorcycleDiyEditRootView.SwitchToTabPart(tabViewName, new int?(partTabIndex));
	}

	// Token: 0x0400845B RID: 33883
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetStickerItem, MotorcycleDiyEditStickerDecoItemData> StickerScrollView;

	// Token: 0x0400845C RID: 33884
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<MotorcycleDiyPresetDecorationItem, MotorcycleDiyEditStickerDecoItemData> DecorateScrollView;

	// Token: 0x02007942 RID: 31042
	[NullableContext(0)]
	private class EPresetInfoComponent
	{
		// Token: 0x040274CF RID: 160975
		public const int PnlFrame = 0;

		// Token: 0x040274D0 RID: 160976
		public const int TexFramePartIcon = 1;

		// Token: 0x040274D1 RID: 160977
		public const int PnlFrameTag = 2;

		// Token: 0x040274D2 RID: 160978
		public const int TexFrameIcon = 3;

		// Token: 0x040274D3 RID: 160979
		public const int PnlSticker = 4;

		// Token: 0x040274D4 RID: 160980
		public const int StickerScroll = 5;

		// Token: 0x040274D5 RID: 160981
		public const int StickerItem = 6;

		// Token: 0x040274D6 RID: 160982
		public const int PnlDecoration = 7;

		// Token: 0x040274D7 RID: 160983
		public const int DecorationScroll = 8;

		// Token: 0x040274D8 RID: 160984
		public const int DecorationItem = 9;
	}
}
