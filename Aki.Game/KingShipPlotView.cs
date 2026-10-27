using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002045 RID: 8261
public class KingShipPlotView : UiViewBase
{
	// Token: 0x060103B1 RID: 66481 RVA: 0x003F5C3C File Offset: 0x003F3E3C
	[NullableContext(1)]
	public KingShipPlotView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060103B2 RID: 66482 RVA: 0x003F5C45 File Offset: 0x003F3E45
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060103B3 RID: 66483 RVA: 0x003F5C80 File Offset: 0x003F3E80
	protected override UniTask OnBeforeStartAsync()
	{
		KingShipPlotView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<KingShipPlotView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060103B4 RID: 66484 RVA: 0x003F5CC4 File Offset: 0x003F3EC4
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

	// Token: 0x060103B5 RID: 66485 RVA: 0x003F5D11 File Offset: 0x003F3F11
	protected override void OnBeforeDestroy()
	{
		((IKingShipPlotViewData)this.OpenParam).OnCloseCallBack();
	}

	// Token: 0x060103B6 RID: 66486 RVA: 0x003F5D28 File Offset: 0x003F3F28
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		KingShipPlotView.<OnPlayingCloseSequenceAsync>d__7 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<KingShipPlotView.<OnPlayingCloseSequenceAsync>d__7>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x04007817 RID: 30743
	[Nullable(2)]
	private KingShipPlotItem KingShipPlotItem;

	// Token: 0x0200863D RID: 34365
	private class EComponentDefine
	{
		// Token: 0x0402BB06 RID: 178950
		public const int BgTexture = 0;

		// Token: 0x0402BB07 RID: 178951
		public const int PlotItem = 1;
	}
}
