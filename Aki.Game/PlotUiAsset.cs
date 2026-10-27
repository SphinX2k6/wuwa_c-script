using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200331C RID: 13084
[NullableContext(1)]
[Nullable(0)]
public class PlotUiAsset
{
	// Token: 0x0601C7F7 RID: 116727 RVA: 0x007FE707 File Offset: 0x007FC907
	public PlotUiAsset(string FlowListName, int FlowId, int StateId)
	{
		this.FlowListName = FlowListName;
		this.FlowId = FlowId;
		this.StateId = StateId;
		this.LoadPromise = new CustomPromise();
	}

	// Token: 0x0601C7F8 RID: 116728 RVA: 0x007FE73A File Offset: 0x007FC93A
	public bool IsLoading()
	{
		return this.IsPlotUiAssetLoading && !this.IsPlotUiAssetLoaded;
	}

	// Token: 0x0601C7F9 RID: 116729 RVA: 0x007FE74F File Offset: 0x007FC94F
	public bool IsFinished()
	{
		return this.IsPlotUiAssetLoaded;
	}

	// Token: 0x0601C7FA RID: 116730 RVA: 0x007FE758 File Offset: 0x007FC958
	public bool HasPreloadQte(List<int> qteIds)
	{
		foreach (int item in qteIds)
		{
			if (!this.QteIdSet.Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601C7FB RID: 116731 RVA: 0x007FE7B4 File Offset: 0x007FC9B4
	public UniTask WaitForLoadAsync()
	{
		PlotUiAsset.<WaitForLoadAsync>d__11 <WaitForLoadAsync>d__;
		<WaitForLoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForLoadAsync>d__.<>4__this = this;
		<WaitForLoadAsync>d__.<>1__state = -1;
		<WaitForLoadAsync>d__.<>t__builder.Start<PlotUiAsset.<WaitForLoadAsync>d__11>(ref <WaitForLoadAsync>d__);
		return <WaitForLoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601C7FC RID: 116732 RVA: 0x007FE7F7 File Offset: 0x007FC9F7
	public void Clear()
	{
		this.IsPlotUiAssetLoaded = false;
		this.IsPlotUiAssetLoading = false;
		this.QteIdSet.Clear();
	}

	// Token: 0x0601C7FD RID: 116733 RVA: 0x007FE814 File Offset: 0x007FCA14
	public UniTask LoadAsync()
	{
		PlotUiAsset.<LoadAsync>d__13 <LoadAsync>d__;
		<LoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadAsync>d__.<>4__this = this;
		<LoadAsync>d__.<>1__state = -1;
		<LoadAsync>d__.<>t__builder.Start<PlotUiAsset.<LoadAsync>d__13>(ref <LoadAsync>d__);
		return <LoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400E26B RID: 57963
	private bool IsPlotUiAssetLoading;

	// Token: 0x0400E26C RID: 57964
	private bool IsPlotUiAssetLoaded;

	// Token: 0x0400E26D RID: 57965
	[Nullable(2)]
	private readonly CustomPromise LoadPromise;

	// Token: 0x0400E26E RID: 57966
	private readonly HashSet<int> QteIdSet = new HashSet<int>();

	// Token: 0x0400E26F RID: 57967
	private string FlowListName;

	// Token: 0x0400E270 RID: 57968
	private int FlowId;

	// Token: 0x0400E271 RID: 57969
	private int StateId;
}
