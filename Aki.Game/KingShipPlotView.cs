using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001518 RID: 5400
public class KingShipPlotView : UiViewBase
{
	// Token: 0x0600D819 RID: 55321 RVA: 0x00402234 File Offset: 0x00400434
	[NullableContext(1)]
	public KingShipPlotView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D81A RID: 55322 RVA: 0x0040223D File Offset: 0x0040043D
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600D81B RID: 55323 RVA: 0x00402278 File Offset: 0x00400478
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipPlotView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipPlotView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D81C RID: 55324 RVA: 0x004022BC File Offset: 0x004004BC
	protected override void OnStart()
	{
		IKingShipPlotViewData kingShipPlotViewData = (IKingShipPlotViewData)this.OpenParam;
		KingShipPlotItem kingShipPlotItem = this.KingShipPlotItem;
		if (kingShipPlotItem != null)
		{
			kingShipPlotItem.RefreshPlot(kingShipPlotViewData.FlowId);
		}
		base.SetTextureByPath(kingShipPlotViewData.Path, base.GetTexture(0), null, null);
	}

	// Token: 0x0600D81D RID: 55325 RVA: 0x00402309 File Offset: 0x00400509
	protected override void OnBeforeDestroy()
	{
		((IKingShipPlotViewData)this.OpenParam).OnCloseCallBack();
	}

	// Token: 0x0600D81E RID: 55326 RVA: 0x00402320 File Offset: 0x00400520
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		KingShipPlotView.<OnPlayingCloseSequenceAsync>d__7 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<KingShipPlotView.<OnPlayingCloseSequenceAsync>d__7>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04007900 RID: 30976
	[Nullable(2)]
	private KingShipPlotItem KingShipPlotItem;

	// Token: 0x020077C4 RID: 30660
	private class EComponentDefine
	{
		// Token: 0x04026E15 RID: 159253
		public const int BgTexture = 0;

		// Token: 0x04026E16 RID: 159254
		public const int PlotItem = 1;
	}
}
