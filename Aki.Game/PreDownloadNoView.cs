using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.PreDownload;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002218 RID: 8728
[NullableContext(1)]
[Nullable(0)]
public class PreDownloadNoView : IPreDownloadUiEvent
{
	// Token: 0x06011012 RID: 69650 RVA: 0x00425374 File Offset: 0x00423574
	public UniTask UpdatePatchDownProgress(bool bNeedWait, float rate, string fileName, string speedText, string sizeCurrent, string sizeTotal)
	{
		PreDownloadNoView.<UpdatePatchDownProgress>d__0 <UpdatePatchDownProgress>d__;
		<UpdatePatchDownProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdatePatchDownProgress>d__.bNeedWait = bNeedWait;
		<UpdatePatchDownProgress>d__.rate = rate;
		<UpdatePatchDownProgress>d__.fileName = fileName;
		<UpdatePatchDownProgress>d__.speedText = speedText;
		<UpdatePatchDownProgress>d__.sizeCurrent = sizeCurrent;
		<UpdatePatchDownProgress>d__.sizeTotal = sizeTotal;
		<UpdatePatchDownProgress>d__.<>1__state = -1;
		<UpdatePatchDownProgress>d__.<>t__builder.Start<PreDownloadNoView.<UpdatePatchDownProgress>d__0>(ref <UpdatePatchDownProgress>d__);
		return <UpdatePatchDownProgress>d__.<>t__builder.Task;
	}

	// Token: 0x06011013 RID: 69651 RVA: 0x004253E4 File Offset: 0x004235E4
	public UniTask BinPatchProgress(bool bNeedWait, float rate, string textId, params string[] args)
	{
		PreDownloadNoView.<BinPatchProgress>d__1 <BinPatchProgress>d__;
		<BinPatchProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<BinPatchProgress>d__.bNeedWait = bNeedWait;
		<BinPatchProgress>d__.rate = rate;
		<BinPatchProgress>d__.textId = textId;
		<BinPatchProgress>d__.args = args;
		<BinPatchProgress>d__.<>1__state = -1;
		<BinPatchProgress>d__.<>t__builder.Start<PreDownloadNoView.<BinPatchProgress>d__1>(ref <BinPatchProgress>d__);
		return <BinPatchProgress>d__.<>t__builder.Task;
	}

	// Token: 0x06011014 RID: 69652 RVA: 0x00425440 File Offset: 0x00423640
	[return: Nullable(0)]
	public UniTask<bool> ShowDialog(bool bSelect, string titleId, string contentId, string leftId, string rightId, string middleId, params string[] contentArgs)
	{
		PreDownloadNoView.<ShowDialog>d__2 <ShowDialog>d__;
		<ShowDialog>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<ShowDialog>d__.titleId = titleId;
		<ShowDialog>d__.contentId = contentId;
		<ShowDialog>d__.leftId = leftId;
		<ShowDialog>d__.rightId = rightId;
		<ShowDialog>d__.middleId = middleId;
		<ShowDialog>d__.contentArgs = contentArgs;
		<ShowDialog>d__.<>1__state = -1;
		<ShowDialog>d__.<>t__builder.Start<PreDownloadNoView.<ShowDialog>d__2>(ref <ShowDialog>d__);
		return <ShowDialog>d__.<>t__builder.Task;
	}
}
