using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200288E RID: 10382
[NullableContext(1)]
[Nullable(0)]
public class PlotUiAsset
{
	// Token: 0x0601A4F0 RID: 107760 RVA: 0x00824C73 File Offset: 0x00822E73
	public PlotUiAsset(string FlowListName, int FlowId, int StateId)
	{
		this.FlowListName = FlowListName;
		this.FlowId = FlowId;
		this.StateId = StateId;
		this.LoadPromise = new CustomPromise();
	}

	// Token: 0x0601A4F1 RID: 107761 RVA: 0x00824CA6 File Offset: 0x00822EA6
	public bool IsLoading()
	{
		return this.IsPlotUiAssetLoading && !this.IsPlotUiAssetLoaded;
	}

	// Token: 0x0601A4F2 RID: 107762 RVA: 0x00824CBB File Offset: 0x00822EBB
	public bool IsFinished()
	{
		return this.IsPlotUiAssetLoaded;
	}

	// Token: 0x0601A4F3 RID: 107763 RVA: 0x00824CC4 File Offset: 0x00822EC4
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

	// Token: 0x0601A4F4 RID: 107764 RVA: 0x00824D20 File Offset: 0x00822F20
	public UniTask WaitForLoadAsync()
	{
		PlotUiAsset.<WaitForLoadAsync>d__11 <WaitForLoadAsync>d__;
		<WaitForLoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitForLoadAsync>d__.<>4__this = this;
		<WaitForLoadAsync>d__.<>1__state = -1;
		<WaitForLoadAsync>d__.<>t__builder.Start<PlotUiAsset.<WaitForLoadAsync>d__11>(ref <WaitForLoadAsync>d__);
		return <WaitForLoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601A4F5 RID: 107765 RVA: 0x00824D63 File Offset: 0x00822F63
	public void Clear()
	{
		this.IsPlotUiAssetLoaded = false;
		this.IsPlotUiAssetLoading = false;
		this.QteIdSet.Clear();
	}

	// Token: 0x0601A4F6 RID: 107766 RVA: 0x00824D80 File Offset: 0x00822F80
	public UniTask LoadAsync()
	{
		PlotUiAsset.<LoadAsync>d__13 <LoadAsync>d__;
		<LoadAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadAsync>d__.<>4__this = this;
		<LoadAsync>d__.<>1__state = -1;
		<LoadAsync>d__.<>t__builder.Start<PlotUiAsset.<LoadAsync>d__13>(ref <LoadAsync>d__);
		return <LoadAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400E71C RID: 59164
	private bool IsPlotUiAssetLoading;

	// Token: 0x0400E71D RID: 59165
	private bool IsPlotUiAssetLoaded;

	// Token: 0x0400E71E RID: 59166
	[Nullable(2)]
	private readonly CustomPromise LoadPromise;

	// Token: 0x0400E71F RID: 59167
	private readonly HashSet<int> QteIdSet = new HashSet<int>();

	// Token: 0x0400E720 RID: 59168
	private string FlowListName;

	// Token: 0x0400E721 RID: 59169
	private int FlowId;

	// Token: 0x0400E722 RID: 59170
	private int StateId;
}
