using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.PreDownload;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200221A RID: 8730
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadView : UiViewBase, IPreDownloadUiEvent
{
	// Token: 0x06011039 RID: 69689 RVA: 0x00425B95 File Offset: 0x00423D95
	public PreDownloadView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601103A RID: 69690 RVA: 0x00425BC0 File Offset: 0x00423DC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickFunc));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601103B RID: 69691 RVA: 0x00425D50 File Offset: 0x00423F50
	protected override void OnStart()
	{
		string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PreDownloadBg");
		base.SetTextureByPath(resourcePath, base.GetTexture(5), null, null);
		PreDownloadManager.Get().SetView(this);
	}

	// Token: 0x0601103C RID: 69692 RVA: 0x00425D90 File Offset: 0x00423F90
	protected override void OnBeforeShow()
	{
		this.LastClickTime = 0.0;
		this.InitDownloadShow();
	}

	// Token: 0x0601103D RID: 69693 RVA: 0x00425DA7 File Offset: 0x00423FA7
	protected override void OnAfterShow()
	{
		if (!PreDownloadManager.Get().IsDownloading())
		{
			if (UKuroLauncherLibrary.GetNetworkConnectionType() == 3)
			{
				PreDownloadController.Instance.OnCellNetTypeChanged();
				return;
			}
			if (!PreDownloadModel.Instance.GetHasStartDownload())
			{
				PreDownloadModel.Instance.StartPreDownload();
				this.OnStateUpdate(false);
			}
		}
	}

	// Token: 0x0601103E RID: 69694 RVA: 0x00425DE5 File Offset: 0x00423FE5
	protected override void OnBeforeDestroy()
	{
		PreDownloadModel.Instance.ClearView();
	}

	// Token: 0x0601103F RID: 69695 RVA: 0x00425DF1 File Offset: 0x00423FF1
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.PreDownloadStateUpdate, new Action(this.OnStateUpdate));
	}

	// Token: 0x06011040 RID: 69696 RVA: 0x00425E0F File Offset: 0x0042400F
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PreDownloadStateUpdate, new Action(this.OnStateUpdate));
	}

	// Token: 0x06011041 RID: 69697 RVA: 0x00425E30 File Offset: 0x00424030
	public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
	{
		PreDownloadView.<UpdatePatchDownProgress>d__15 <UpdatePatchDownProgress>d__;
		<UpdatePatchDownProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdatePatchDownProgress>d__.<>4__this = this;
		<UpdatePatchDownProgress>d__.bNeedWait = bNeedWait;
		<UpdatePatchDownProgress>d__.rate = rate;
		<UpdatePatchDownProgress>d__.fileName = fileName;
		<UpdatePatchDownProgress>d__.speedText = speedText;
		<UpdatePatchDownProgress>d__.sizeCurrent = sizeCurrent;
		<UpdatePatchDownProgress>d__.sizeTotal = sizeTotal;
		<UpdatePatchDownProgress>d__.<>1__state = -1;
		<UpdatePatchDownProgress>d__.<>t__builder.Start<PreDownloadView.<UpdatePatchDownProgress>d__15>(ref <UpdatePatchDownProgress>d__);
		return <UpdatePatchDownProgress>d__.<>t__builder.Task;
	}

	// Token: 0x06011042 RID: 69698 RVA: 0x00425EA8 File Offset: 0x004240A8
	public UniTask BinPatchProgress(bool bNeedWait, float rate, string textId, params string[] args)
	{
		PreDownloadView.<BinPatchProgress>d__16 <BinPatchProgress>d__;
		<BinPatchProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BinPatchProgress>d__.<>4__this = this;
		<BinPatchProgress>d__.bNeedWait = bNeedWait;
		<BinPatchProgress>d__.rate = rate;
		<BinPatchProgress>d__.textId = textId;
		<BinPatchProgress>d__.args = args;
		<BinPatchProgress>d__.<>1__state = -1;
		<BinPatchProgress>d__.<>t__builder.Start<PreDownloadView.<BinPatchProgress>d__16>(ref <BinPatchProgress>d__);
		return <BinPatchProgress>d__.<>t__builder.Task;
	}

	// Token: 0x06011043 RID: 69699 RVA: 0x00425F0C File Offset: 0x0042410C
	[return: Nullable(0)]
	public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, string leftId, string rightId, string middleId, params string[] contentArgs)
	{
		PreDownloadView.<ShowDialog>d__17 <ShowDialog>d__;
		<ShowDialog>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowDialog>d__.titleId = titleId;
		<ShowDialog>d__.contentId = contentId;
		<ShowDialog>d__.leftId = leftId;
		<ShowDialog>d__.rightId = rightId;
		<ShowDialog>d__.middleId = middleId;
		<ShowDialog>d__.contentArgs = contentArgs;
		<ShowDialog>d__.<>1__state = -1;
		<ShowDialog>d__.<>t__builder.Start<PreDownloadView.<ShowDialog>d__17>(ref <ShowDialog>d__);
		return <ShowDialog>d__.<>t__builder.Task;
	}

	// Token: 0x06011044 RID: 69700 RVA: 0x00425F7C File Offset: 0x0042417C
	private void OnClickClose()
	{
		if (!PreDownloadManager.Get().IsDownloading())
		{
			PreDownloadController.Instance.ClosePreDownloadView();
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PreDownloadOnClickedClose);
		confirmBoxDataNew.FunctionMap.Add(2, new Action(PreDownloadView.<OnClickClose>g__ConfirmFunc|18_0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06011045 RID: 69701 RVA: 0x00425FD0 File Offset: 0x004241D0
	private void OnClickFunc()
	{
		if (PreDownloadManager.Get().IsComplete())
		{
			return;
		}
		int num = 1000;
		if (this.LastClickTime == 0.0 || Time.Instance.Now - this.LastClickTime >= (double)num)
		{
			this.LastClickTime = Time.Instance.Now;
			PreDownloadModel.Instance.SwitchResumeOrPause();
		}
	}

	// Token: 0x06011046 RID: 69702 RVA: 0x00426030 File Offset: 0x00424230
	private void OnStateUpdate()
	{
		this.OnStateUpdate(false);
	}

	// Token: 0x06011047 RID: 69703 RVA: 0x0042603C File Offset: 0x0042423C
	private unsafe void OnStateUpdate(bool isInit = false)
	{
		IPreDownload preDownload = PreDownloadManager.Get();
		bool flag = preDownload.IsComplete();
		UUIText text = base.GetText(7);
		bool flag2 = preDownload.IsDownloading();
		LauncherLog instance = LauncherLog.Instance;
		string message = "get pre download state update";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("is complete", flag);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("is downloading", flag2);
		instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		if (flag)
		{
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(true);
			}
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("PreDownload_Complete");
			if (text != null)
			{
				text.SetText(multiTextByKey, true);
			}
			this.UpdatePatchDownProgress(false, this.RateCount, "", "0B/s", this.SizeTotal, this.SizeTotal).ContinueWith(delegate()
			{
				string multiTextByKey3 = TextConfig.Instance.GetMultiTextByKey("PreDownload_Complete");
				UUIText text2 = base.GetText(6);
				if (text2 == null)
				{
					return;
				}
				text2.SetText(multiTextByKey3, true);
			}).Forget();
			return;
		}
		string multiTextByKey2 = TextConfig.Instance.GetMultiTextByKey(flag2 ? "PreDownload_Pause" : "PreDownload_Play");
		if (text != null)
		{
			text.SetText(multiTextByKey2, true);
		}
		if (!isInit && !flag2 && !PreDownloadModel.Instance.IsBinPatching())
		{
			this.UpdatePatchDownProgress(false, this.RateCount, this.FileName, "0B/s", this.SizeCurrent, this.SizeTotal).Forget();
		}
	}

	// Token: 0x06011048 RID: 69704 RVA: 0x00426198 File Offset: 0x00424398
	private void InitDownloadShow()
	{
		this.OnStateUpdate(true);
		bool flag = PreDownloadModel.Instance.IsBinPatching();
		UUIText text = base.GetText(6);
		UUITexture texture = base.GetTexture(2);
		UUIText text2 = base.GetText(4);
		UUIText text3 = base.GetText(3);
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!flag);
		}
		if (flag && PreDownloadModel.Instance.BinPatch != null)
		{
			BinPatchData binPatch = PreDownloadModel.Instance.BinPatch;
			string multiTextByKey = TextConfig.Instance.GetMultiTextByKey("PreDownload_BinPatch");
			if (text != null)
			{
				text.SetText(multiTextByKey, true);
			}
			if (texture != null)
			{
				texture.SetFillAmount(binPatch.Rate);
			}
			if (text2 != null)
			{
				text2.SetText("", true);
			}
			string newText = (binPatch.Rate * 100f).ToString("F2") + "%";
			if (text3 != null)
			{
				text3.SetText(newText, true);
				return;
			}
		}
		else
		{
			if (PreDownloadModel.Instance.UpdateData != null)
			{
				UpdateDownData updateData = PreDownloadModel.Instance.UpdateData;
				this.UpdatePatchDownProgress(false, updateData.Rate, updateData.FileName, updateData.SpeedText, updateData.SizeCurrent, updateData.SizeTotal).Forget();
				return;
			}
			if (text != null)
			{
				text.SetText("", true);
			}
			if (texture != null)
			{
				texture.SetFillAmount(0f);
			}
			if (text2 != null)
			{
				text2.SetText("", true);
			}
			if (text3 != null)
			{
				text3.SetText("", true);
			}
		}
	}

	// Token: 0x06011049 RID: 69705 RVA: 0x00426317 File Offset: 0x00424517
	[CompilerGenerated]
	internal static void <OnClickClose>g__ConfirmFunc|18_0()
	{
		PreDownloadController.Instance.ClosePreDownloadView();
	}

	// Token: 0x04008187 RID: 33159
	private const int BTN_INTERVAL = 1000;

	// Token: 0x04008188 RID: 33160
	private double LastClickTime;

	// Token: 0x04008189 RID: 33161
	private float RateCount;

	// Token: 0x0400818A RID: 33162
	private string FileName = "";

	// Token: 0x0400818B RID: 33163
	private string SizeCurrent = "";

	// Token: 0x0400818C RID: 33164
	private string SizeTotal = "";

	// Token: 0x0200874F RID: 34639
	[NullableContext(0)]
	private enum EChildComponentType
	{
		// Token: 0x0402BFC4 RID: 180164
		CloseBtn,
		// Token: 0x0402BFC5 RID: 180165
		FuncBtn,
		// Token: 0x0402BFC6 RID: 180166
		ProgressBar,
		// Token: 0x0402BFC7 RID: 180167
		TextNumber,
		// Token: 0x0402BFC8 RID: 180168
		TextPatch,
		// Token: 0x0402BFC9 RID: 180169
		PreviewTex,
		// Token: 0x0402BFCA RID: 180170
		TextProgress,
		// Token: 0x0402BFCB RID: 180171
		FuncBtnTxt
	}
}
