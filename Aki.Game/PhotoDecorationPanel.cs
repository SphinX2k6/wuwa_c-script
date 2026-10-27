using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200255F RID: 9567
[NullableContext(1)]
[Nullable(0)]
public class PhotoDecorationPanel : PhotoDetailPanelBase
{
	// Token: 0x060134C2 RID: 79042 RVA: 0x004CCE34 File Offset: 0x004CB034
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnImmersiveModeChanged))
		};
	}

	// Token: 0x170018EE RID: 6382
	// (get) Token: 0x060134C3 RID: 79043 RVA: 0x004CCF35 File Offset: 0x004CB135
	protected override int TabLockPanelIndex
	{
		get
		{
			return 5;
		}
	}

	// Token: 0x170018EF RID: 6383
	// (get) Token: 0x060134C4 RID: 79044 RVA: 0x004CCF38 File Offset: 0x004CB138
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 7;
		}
	}

	// Token: 0x060134C5 RID: 79045 RVA: 0x004CCF3C File Offset: 0x004CB13C
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoDecorationPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoDecorationPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060134C6 RID: 79046 RVA: 0x004CCF7F File Offset: 0x004CB17F
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnStickerRemoved = (Action)Delegate.Remove(viewModel.OnStickerRemoved, new Action(this.OnStickerRemoved));
		base.OnBeforeDestroy();
	}

	// Token: 0x060134C7 RID: 79047 RVA: 0x004CCFAE File Offset: 0x004CB1AE
	private void OnStickerRemoved()
	{
		if (!this.IsStickerSubTab)
		{
			return;
		}
		this.SelectDefaultSticker();
	}

	// Token: 0x060134C8 RID: 79048 RVA: 0x004CCFC0 File Offset: 0x004CB1C0
	private UniTask RefreshSubTabList()
	{
		PhotoDecorationPanel.<RefreshSubTabList>d__15 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoDecorationPanel.<RefreshSubTabList>d__15>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x060134C9 RID: 79049 RVA: 0x004CD004 File Offset: 0x004CB204
	private void OnSubTabClick(PhotoSubTab data, bool playSwitchAnim = true)
	{
		PhotoSubTabPanel tabMenuPanel = this.TabMenuPanel;
		if (tabMenuPanel != null)
		{
			tabMenuPanel.SelectByKey(data.Id, false);
		}
		base.SetSubTabId(data.Id, playSwitchAnim);
		EPhotoDecorationSubTabType type = (EPhotoDecorationSubTabType)data.Type;
		this.IsStickerSubTab = (type == EPhotoDecorationSubTabType.Sticker);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(this.IsStickerSubTab);
		}
		this.RefreshDecoList(type).Forget();
	}

	// Token: 0x060134CA RID: 79050 RVA: 0x004CD074 File Offset: 0x004CB274
	private UniTask RefreshDecoList(EPhotoDecorationSubTabType subTabType)
	{
		PhotoDecorationPanel.<RefreshDecoList>d__17 <RefreshDecoList>d__;
		<RefreshDecoList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshDecoList>d__.<>4__this = this;
		<RefreshDecoList>d__.subTabType = subTabType;
		<RefreshDecoList>d__.<>1__state = -1;
		<RefreshDecoList>d__.<>t__builder.Start<PhotoDecorationPanel.<RefreshDecoList>d__17>(ref <RefreshDecoList>d__);
		return <RefreshDecoList>d__.<>t__builder.Task;
	}

	// Token: 0x060134CB RID: 79051 RVA: 0x004CD0C0 File Offset: 0x004CB2C0
	private void SelectCurrentFrame()
	{
		int currentFrameId = this.ViewModel.CurrentFrameId;
		int i = 0;
		while (i < this.DecoDataList.Count)
		{
			if (this.DecoDataList[i].Id == currentFrameId)
			{
				LoopScrollView<PhotoDecoItem, PhotoDecoData> decoScroll = this.DecoScroll;
				if (decoScroll == null)
				{
					return;
				}
				decoScroll.SelectGridProxy(i, false);
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x060134CC RID: 79052 RVA: 0x004CD118 File Offset: 0x004CB318
	private void SelectCurrentSticker()
	{
		int currentStickerId = this.ViewModel.CurrentStickerId;
		if (currentStickerId > 0)
		{
			int i = 0;
			while (i < this.DecoDataList.Count)
			{
				if (this.DecoDataList[i].Id == currentStickerId)
				{
					LoopScrollView<PhotoDecoItem, PhotoDecoData> decoScroll = this.DecoScroll;
					if (decoScroll == null)
					{
						return;
					}
					decoScroll.SelectGridProxy(i, false);
					return;
				}
				else
				{
					i++;
				}
			}
		}
		this.SelectDefaultSticker();
	}

	// Token: 0x060134CD RID: 79053 RVA: 0x004CD178 File Offset: 0x004CB378
	private void SelectDefaultSticker()
	{
		int i = 0;
		while (i < this.DecoDataList.Count)
		{
			if (this.DecoDataList[i].IsDefault)
			{
				LoopScrollView<PhotoDecoItem, PhotoDecoData> decoScroll = this.DecoScroll;
				if (decoScroll == null)
				{
					return;
				}
				decoScroll.SelectGridProxy(i, false);
				return;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x060134CE RID: 79054 RVA: 0x004CD1C4 File Offset: 0x004CB3C4
	private List<PhotoDecoData> GetFrameDataList()
	{
		if (this.FrameDataCache != null)
		{
			return this.FrameDataCache;
		}
		this.FrameDataCache = new List<PhotoDecoData>();
		IReadOnlyList<PhotoFrame> configList = ConfigPhotoFrameAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (PhotoFrame cfg in configList)
			{
				this.FrameDataCache.Add(PhotoDecoData.FromFrame(cfg));
			}
		}
		return this.FrameDataCache;
	}

	// Token: 0x060134CF RID: 79055 RVA: 0x004CD240 File Offset: 0x004CB440
	private List<PhotoDecoData> GetStickerDataList()
	{
		if (this.StickerDataCache != null)
		{
			return this.StickerDataCache;
		}
		this.StickerDataCache = new List<PhotoDecoData>();
		IReadOnlyList<PhotoSticker> configList = ConfigPhotoStickerAll.GetConfigList(true);
		if (configList != null)
		{
			foreach (PhotoSticker cfg in configList)
			{
				this.StickerDataCache.Add(PhotoDecoData.FromSticker(cfg));
			}
		}
		return this.StickerDataCache;
	}

	// Token: 0x060134D0 RID: 79056 RVA: 0x004CD2BC File Offset: 0x004CB4BC
	private void OnDecoClick(int gridIndex)
	{
		if (gridIndex < 0 || gridIndex >= this.DecoDataList.Count)
		{
			return;
		}
		LoopScrollView<PhotoDecoItem, PhotoDecoData> decoScroll = this.DecoScroll;
		if (decoScroll != null)
		{
			decoScroll.SelectGridProxy(gridIndex, false);
		}
		PhotoDecoData photoDecoData = this.DecoDataList[gridIndex];
		if (photoDecoData.DecoType == EPhotoDecorationSubTabType.Sticker)
		{
			if (photoDecoData.IsDefault)
			{
				Action onRequestRemoveSticker = this.ViewModel.OnRequestRemoveSticker;
				if (onRequestRemoveSticker == null)
				{
					return;
				}
				onRequestRemoveSticker();
				return;
			}
			else if (photoDecoData.StickerConfig != null)
			{
				Action<PhotoSticker> onRequestCreateSticker = this.ViewModel.OnRequestCreateSticker;
				if (onRequestCreateSticker == null)
				{
					return;
				}
				onRequestCreateSticker(photoDecoData.StickerConfig.Value);
				return;
			}
		}
		else if (photoDecoData.DecoType == EPhotoDecorationSubTabType.Frame)
		{
			this.ViewModel.SetFrameId(photoDecoData.Id);
		}
	}

	// Token: 0x060134D1 RID: 79057 RVA: 0x004CD36B File Offset: 0x004CB56B
	private void OnImmersiveModeChanged(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action onRequestHideUi = this.ViewModel.OnRequestHideUi;
			if (onRequestHideUi != null)
			{
				onRequestHideUi();
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
	}

	// Token: 0x060134D2 RID: 79058 RVA: 0x004CD39C File Offset: 0x004CB59C
	private PhotoDecoItem CreateDecoItem()
	{
		return new PhotoDecoItem
		{
			OnDecoClick = new Action<int>(this.OnDecoClick)
		};
	}

	// Token: 0x04009197 RID: 37271
	[Nullable(2)]
	private PhotoSubTabPanel TabMenuPanel;

	// Token: 0x04009198 RID: 37272
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoDecoItem, PhotoDecoData> DecoScroll;

	// Token: 0x04009199 RID: 37273
	private List<PhotoDecoData> DecoDataList = new List<PhotoDecoData>();

	// Token: 0x0400919A RID: 37274
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoDecoData> FrameDataCache;

	// Token: 0x0400919B RID: 37275
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoDecoData> StickerDataCache;

	// Token: 0x0400919C RID: 37276
	private bool IsStickerSubTab;

	// Token: 0x02008B2D RID: 35629
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402D2F8 RID: 185080
		ItemTabMenu,
		// Token: 0x0402D2F9 RID: 185081
		LoopScrollDeco,
		// Token: 0x0402D2FA RID: 185082
		ItemDecoTemplate,
		// Token: 0x0402D2FB RID: 185083
		ItemImmersiveModePanel,
		// Token: 0x0402D2FC RID: 185084
		ToggleImmersiveMode,
		// Token: 0x0402D2FD RID: 185085
		ItemTabLockPanel,
		// Token: 0x0402D2FE RID: 185086
		TextTabLockTips,
		// Token: 0x0402D2FF RID: 185087
		ItemSubTabLockPanel,
		// Token: 0x0402D300 RID: 185088
		TextSubTabLockTips
	}
}
