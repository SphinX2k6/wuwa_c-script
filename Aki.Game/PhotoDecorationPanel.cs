using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A4A RID: 6730
[NullableContext(1)]
[Nullable(0)]
public class PhotoDecorationPanel : PhotoDetailPanelBase
{
	// Token: 0x060109A4 RID: 68004 RVA: 0x004DBA6C File Offset: 0x004D9C6C
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

	// Token: 0x17001928 RID: 6440
	// (get) Token: 0x060109A5 RID: 68005 RVA: 0x004DBB6D File Offset: 0x004D9D6D
	protected override int TabLockPanelIndex
	{
		get
		{
			return 5;
		}
	}

	// Token: 0x17001929 RID: 6441
	// (get) Token: 0x060109A6 RID: 68006 RVA: 0x004DBB70 File Offset: 0x004D9D70
	protected override int SubTabLockPanelIndex
	{
		get
		{
			return 7;
		}
	}

	// Token: 0x060109A7 RID: 68007 RVA: 0x004DBB74 File Offset: 0x004D9D74
	protected override UniTask OnBeforeStartAsync()
	{
		PhotoDecorationPanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotoDecorationPanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060109A8 RID: 68008 RVA: 0x004DBBB7 File Offset: 0x004D9DB7
	protected override void OnBeforeDestroy()
	{
		PhotoMainViewModel viewModel = this.ViewModel;
		viewModel.OnStickerRemoved = (Action)Delegate.Remove(viewModel.OnStickerRemoved, new Action(this.OnStickerRemoved));
		base.OnBeforeDestroy();
	}

	// Token: 0x060109A9 RID: 68009 RVA: 0x004DBBE6 File Offset: 0x004D9DE6
	private void OnStickerRemoved()
	{
		if (!this.IsStickerSubTab)
		{
			return;
		}
		this.SelectDefaultSticker();
	}

	// Token: 0x060109AA RID: 68010 RVA: 0x004DBBF8 File Offset: 0x004D9DF8
	private UniTask RefreshSubTabList()
	{
		PhotoDecorationPanel.<RefreshSubTabList>d__15 <RefreshSubTabList>d__;
		<RefreshSubTabList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSubTabList>d__.<>4__this = this;
		<RefreshSubTabList>d__.<>1__state = -1;
		<RefreshSubTabList>d__.<>t__builder.Start<PhotoDecorationPanel.<RefreshSubTabList>d__15>(ref <RefreshSubTabList>d__);
		return <RefreshSubTabList>d__.<>t__builder.Task;
	}

	// Token: 0x060109AB RID: 68011 RVA: 0x004DBC3C File Offset: 0x004D9E3C
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

	// Token: 0x060109AC RID: 68012 RVA: 0x004DBCAC File Offset: 0x004D9EAC
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

	// Token: 0x060109AD RID: 68013 RVA: 0x004DBCF8 File Offset: 0x004D9EF8
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

	// Token: 0x060109AE RID: 68014 RVA: 0x004DBD50 File Offset: 0x004D9F50
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

	// Token: 0x060109AF RID: 68015 RVA: 0x004DBDB0 File Offset: 0x004D9FB0
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

	// Token: 0x060109B0 RID: 68016 RVA: 0x004DBDFC File Offset: 0x004D9FFC
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

	// Token: 0x060109B1 RID: 68017 RVA: 0x004DBE78 File Offset: 0x004DA078
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

	// Token: 0x060109B2 RID: 68018 RVA: 0x004DBEF4 File Offset: 0x004DA0F4
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

	// Token: 0x060109B3 RID: 68019 RVA: 0x004DBFA3 File Offset: 0x004DA1A3
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

	// Token: 0x060109B4 RID: 68020 RVA: 0x004DBFD4 File Offset: 0x004DA1D4
	private PhotoDecoItem CreateDecoItem()
	{
		return new PhotoDecoItem
		{
			OnDecoClick = new Action<int>(this.OnDecoClick)
		};
	}

	// Token: 0x040092F0 RID: 37616
	[Nullable(2)]
	private PhotoSubTabPanel TabMenuPanel;

	// Token: 0x040092F1 RID: 37617
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<PhotoDecoItem, PhotoDecoData> DecoScroll;

	// Token: 0x040092F2 RID: 37618
	private List<PhotoDecoData> DecoDataList = new List<PhotoDecoData>();

	// Token: 0x040092F3 RID: 37619
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoDecoData> FrameDataCache;

	// Token: 0x040092F4 RID: 37620
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PhotoDecoData> StickerDataCache;

	// Token: 0x040092F5 RID: 37621
	private bool IsStickerSubTab;

	// Token: 0x02007CB3 RID: 31923
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x04028605 RID: 165381
		ItemTabMenu,
		// Token: 0x04028606 RID: 165382
		LoopScrollDeco,
		// Token: 0x04028607 RID: 165383
		ItemDecoTemplate,
		// Token: 0x04028608 RID: 165384
		ItemImmersiveModePanel,
		// Token: 0x04028609 RID: 165385
		ToggleImmersiveMode,
		// Token: 0x0402860A RID: 165386
		ItemTabLockPanel,
		// Token: 0x0402860B RID: 165387
		TextTabLockTips,
		// Token: 0x0402860C RID: 165388
		ItemSubTabLockPanel,
		// Token: 0x0402860D RID: 165389
		TextSubTabLockTips
	}
}
