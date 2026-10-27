using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.DiffPatch.Update;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002761 RID: 10081
[NullableContext(1)]
[Nullable(0)]
public class ResDownLoadView : UiViewBase
{
	// Token: 0x06014ADA RID: 84698 RVA: 0x0053B0C9 File Offset: 0x005392C9
	public ResDownLoadView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014ADB RID: 84699 RVA: 0x0053B0DC File Offset: 0x005392DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickLeftBtn));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickRightBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014ADC RID: 84700 RVA: 0x0053B338 File Offset: 0x00539538
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EVideoDownloadStatus>(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014ADD RID: 84701 RVA: 0x0053B356 File Offset: 0x00539556
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ResDownLoadStateRefresh, new Action<EVideoDownloadStatus>(this.ResDownLoadStateRefresh));
	}

	// Token: 0x06014ADE RID: 84702 RVA: 0x0053B374 File Offset: 0x00539574
	protected override void OnStart()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem != null)
			{
				popItem.SetMaskResponsibleState(false);
			}
		}
		this.DownLoadTabLayout = new GenericLayout<ResDownLoadViewTabItem, int>(base.GetVerticalLayout(1), () => new ResDownLoadViewTabItem
		{
			OnClickExtendToggleCallBack = new Action<int, int, UUIExtendToggle>(this.OnClickToggle)
		}, null, false, true);
		this.DownloadState = VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).GetDownLoadState();
		if (this.UpdateProxy == null)
		{
			this.UpdateProxy = new VideoResourceUpdateProxy();
		}
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshDownLoadState();
		}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		base.GetButton(8).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x06014ADF RID: 84703 RVA: 0x0053B436 File Offset: 0x00539636
	protected override void OnBeforeDestroy()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		if (this.UpdateProxy != null)
		{
			this.UpdateProxy = null;
		}
	}

	// Token: 0x06014AE0 RID: 84704 RVA: 0x0053B468 File Offset: 0x00539668
	protected override void OnBeforeShow()
	{
		QuestResourceModel instance = QuestResourceModel.Instance;
		if (instance != null)
		{
			instance.CalcPrepareResource();
		}
		List<int> list = new List<int>();
		list.Add(3);
		list.Add(4);
		this.DownLoadTabLayout.RefreshByData(list, delegate
		{
			if (ResDownLoadModel.Instance.CurrentDownLoadVideo <= 0)
			{
				this.DownLoadTabLayout.GetLayoutItemByIndex(0).SelectToggle();
				return;
			}
			EPlayerGender playerGender = PlayerInfoModel.Instance.GetPlayerGender();
			if ((playerGender == EPlayerGender.Male && ResDownLoadModel.Instance.CurrentDownLoadVideo == 3) || (playerGender == EPlayerGender.Female && ResDownLoadModel.Instance.CurrentDownLoadVideo == 4))
			{
				this.DownLoadTabLayout.GetLayoutItemByIndex(1).SelectToggle();
				return;
			}
			this.DownLoadTabLayout.GetLayoutItemByIndex(0).SelectToggle();
		}, false);
		this.RefreshDownLoadState();
	}

	// Token: 0x06014AE1 RID: 84705 RVA: 0x0053B4B8 File Offset: 0x005396B8
	private void ResDownLoadStateRefresh(EVideoDownloadStatus state)
	{
		this.DownloadState = VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).GetDownLoadState();
		this.RefreshDownLoadState();
	}

	// Token: 0x06014AE2 RID: 84706 RVA: 0x0053B4DB File Offset: 0x005396DB
	private void OnClickLeftBtn()
	{
		if (this.DownloadState != EVideoDownloadStatus.Pause)
		{
			return;
		}
		ResDownLoadModel.Instance.CurrentDownLoadVideo = -1;
		VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).CancelDownload();
	}

	// Token: 0x06014AE3 RID: 84707 RVA: 0x0053B508 File Offset: 0x00539708
	private void OnClickRightBtn()
	{
		if (ResDownLoadModel.Instance.CurrentDownLoadVideo > 0 && this.SelectResType != ResDownLoadModel.Instance.CurrentDownLoadVideo)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("DownLoadTips_WaitOtherDown", Array.Empty<object>());
			return;
		}
		if (this.DownloadState == EVideoDownloadStatus.None)
		{
			long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
			if (VideoResUpdate.Instance.GetVideoResSize((EVideoResSizeType)this.SelectResType) <= 0L)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("HaveDownLoadResTips", Array.Empty<object>());
				return;
			}
			if (freeSpace < VideoResUpdate.Instance.GetVideoResSize((EVideoResSizeType)this.SelectResType))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DownLoadTips_NotEnough", Array.Empty<object>());
				return;
			}
			QuestNewController.Instance.SetIsReportDownloadNotEnoughSpace(false);
			VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).Update((EVideoResSizeType)this.SelectResType, this.UpdateProxy).Forget<bool>();
			ResDownLoadModel.Instance.CurrentDownLoadVideo = this.SelectResType;
			return;
		}
		else
		{
			if (this.DownloadState == EVideoDownloadStatus.Downloading)
			{
				VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).Pause();
				QuestResourceModel.Instance.CalcPrepareResource();
				ResDownLoadModel.Instance.CurrentDownLoadVideo = -1;
				return;
			}
			if (this.DownloadState == EVideoDownloadStatus.Pause)
			{
				QuestNewController.Instance.SetIsReportDownloadNotEnoughSpace(false);
				VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).Update((EVideoResSizeType)this.SelectResType, this.UpdateProxy).Forget<bool>();
				ResDownLoadModel.Instance.CurrentDownLoadVideo = this.SelectResType;
			}
			return;
		}
	}

	// Token: 0x06014AE4 RID: 84708 RVA: 0x0053B670 File Offset: 0x00539870
	private void RefreshDownLoadState()
	{
		switch (this.DownloadState)
		{
		case EVideoDownloadStatus.None:
			this.ShowNoneState();
			return;
		case EVideoDownloadStatus.Downloading:
		{
			ValueTuple<long, long, long, long> downLoadProgress = VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).GetDownLoadProgress();
			if (downLoadProgress.Item3 == 0L)
			{
				base.GetTexture(6).SetFillAmount(0f);
				return;
			}
			base.GetText(7).SetUIActive(true);
			base.GetText(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "DownLoadText_Downing", Array.Empty<object>());
			float num = (float)downLoadProgress.Item2 / (float)downLoadProgress.Item3;
			string str = HotFixManager.ByteConverter(downLoadProgress.Item4) + "/s ";
			string str2 = string.Concat(new string[]
			{
				"(",
				HotFixManager.ByteConverter(downLoadProgress.Item2),
				"/",
				HotFixManager.ByteConverter(downLoadProgress.Item3),
				") "
			});
			base.GetTexture(6).SetFillAmount(num);
			string str3 = (num * 100f).ToString("F2").TrimEnd('0').TrimEnd('.') + "%";
			base.GetText(7).SetText(str + str2 + str3, true);
			base.GetButton(10).RootUIComp.Get().SetUIActive(true);
			base.GetItem(13).SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DownLoadButton_Pause", Array.Empty<object>());
			return;
		}
		case EVideoDownloadStatus.Pause:
		{
			base.GetText(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "DownLoadText_Pause", Array.Empty<object>());
			base.GetButton(10).RootUIComp.Get().SetUIActive(true);
			base.GetItem(13).SetUIActive(false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), "DownLoadButton_Cancel", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DownLoadButton_Continue", Array.Empty<object>());
			ValueTuple<long, long, long, long> downLoadProgress2 = VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).GetDownLoadProgress();
			if (downLoadProgress2.Item3 != 0L)
			{
				float num2 = (float)downLoadProgress2.Item2 / (float)downLoadProgress2.Item3;
				string str4 = string.Concat(new string[]
				{
					"(",
					HotFixManager.ByteConverter(downLoadProgress2.Item2),
					"/",
					HotFixManager.ByteConverter(downLoadProgress2.Item3),
					") "
				});
				base.GetTexture(6).SetFillAmount(num2);
				string str5 = (num2 * 100f).ToString("F2").TrimEnd('0').TrimEnd('.') + "%";
				base.GetText(7).SetUIActive(true);
				base.GetText(7).SetText(str4 + str5, true);
				return;
			}
			base.GetText(7).SetUIActive(false);
			return;
		}
		case EVideoDownloadStatus.Done:
			base.GetItem(13).SetUIActive(true);
			base.GetButton(10).RootUIComp.Get().SetUIActive(false);
			base.GetText(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			return;
		default:
			return;
		}
	}

	// Token: 0x06014AE5 RID: 84709 RVA: 0x0053B9DC File Offset: 0x00539BDC
	private void ShowNoneState()
	{
		long freeSpace = VideoResUpdate.Instance.GetFreeSpace();
		if (freeSpace > VideoResUpdate.Instance.GetVideoResSize((EVideoResSizeType)this.SelectResType))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#36cd33>" + HotFixManager.ByteConverter(freeSpace) + "</color>"));
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "DownLoadText_LeftSpace", new <>z__ReadOnlySingleElementList<object>("<color=#c25757>" + HotFixManager.ByteConverter(freeSpace) + "</color>"));
		}
		base.GetText(4).SetUIActive(true);
		base.GetItem(5).SetUIActive(false);
		base.GetButton(10).RootUIComp.Get().SetUIActive(true);
		base.GetItem(13).SetUIActive(false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "DownLoadButton_Down", Array.Empty<object>());
	}

	// Token: 0x06014AE6 RID: 84710 RVA: 0x0053BAC8 File Offset: 0x00539CC8
	private void OnClickToggle(int tabIndex, int resType, UUIExtendToggle toggle)
	{
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.SelectResType = resType;
		this.RefreshTabContent(tabIndex);
	}

	// Token: 0x06014AE7 RID: 84711 RVA: 0x0053BAF8 File Offset: 0x00539CF8
	private void RefreshTabContent(int tabIndex)
	{
		DownLoadTab? config = ConfigDownLoadTabById.GetConfig(tabIndex, true);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), config.Value.ContentTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), config.Value.Content, Array.Empty<object>());
		this.DownloadState = VideoUpdateManager.Instance.GetVideoUpdater((EVideoResSizeType)this.SelectResType).GetDownLoadState();
		if (this.DownloadState == EVideoDownloadStatus.None)
		{
			if (VideoResUpdate.Instance.GetIsResPakDownloading((EVideoResSizeType)this.SelectResType))
			{
				this.DownloadState = EVideoDownloadStatus.Pause;
			}
			else if (VideoResUpdate.Instance.GetVideoResSize((EVideoResSizeType)this.SelectResType) == VideoResUpdate.Instance.GetVideoResSavedSize((EVideoResSizeType)this.SelectResType))
			{
				this.DownloadState = EVideoDownloadStatus.Done;
			}
		}
		this.RefreshDownLoadState();
	}

	// Token: 0x06014AE8 RID: 84712 RVA: 0x0053BBC4 File Offset: 0x00539DC4
	protected override void OnBeforeHide()
	{
		if (this.DownloadState == EVideoDownloadStatus.Downloading)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("DownLoadTips_Downing", Array.Empty<object>());
		}
	}

	// Token: 0x04009B5E RID: 39774
	private int SelectResType = -1;

	// Token: 0x04009B5F RID: 39775
	private EVideoDownloadStatus DownloadState;

	// Token: 0x04009B60 RID: 39776
	private GenericLayout<ResDownLoadViewTabItem, int> DownLoadTabLayout;

	// Token: 0x04009B61 RID: 39777
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x04009B62 RID: 39778
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04009B63 RID: 39779
	[Nullable(2)]
	private VideoResourceUpdateProxy UpdateProxy;

	// Token: 0x02008DC9 RID: 36297
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402E035 RID: 188469
		LayoutItem,
		// Token: 0x0402E036 RID: 188470
		TabLayout,
		// Token: 0x0402E037 RID: 188471
		TitleText,
		// Token: 0x0402E038 RID: 188472
		DesText,
		// Token: 0x0402E039 RID: 188473
		MemoryText,
		// Token: 0x0402E03A RID: 188474
		DownLoadBarItem,
		// Token: 0x0402E03B RID: 188475
		DownLoadBarTexture,
		// Token: 0x0402E03C RID: 188476
		SpeedText,
		// Token: 0x0402E03D RID: 188477
		LeftBtn,
		// Token: 0x0402E03E RID: 188478
		LeftBtnText,
		// Token: 0x0402E03F RID: 188479
		RightBtn,
		// Token: 0x0402E040 RID: 188480
		RightBtnText,
		// Token: 0x0402E041 RID: 188481
		DownLoadStateText,
		// Token: 0x0402E042 RID: 188482
		DoneItem
	}

	// Token: 0x02008DCA RID: 36298
	[NullableContext(0)]
	private enum EDownLoadTab
	{
		// Token: 0x0402E044 RID: 188484
		Same = 3,
		// Token: 0x0402E045 RID: 188485
		Change
	}
}
