using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C4 RID: 10692
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerResetView : UiViewBase
{
	// Token: 0x06016292 RID: 90770 RVA: 0x0059ADDA File Offset: 0x00598FDA
	public ShipTowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016293 RID: 90771 RVA: 0x0059ADE4 File Offset: 0x00598FE4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.CloseSelf)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickSure))
		};
	}

	// Token: 0x06016294 RID: 90772 RVA: 0x0059AE90 File Offset: 0x00599090
	private void InitDataParam()
	{
	}

	// Token: 0x06016295 RID: 90773 RVA: 0x0059AE94 File Offset: 0x00599094
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerResetView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerResetView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016296 RID: 90774 RVA: 0x0059AED8 File Offset: 0x005990D8
	protected override void OnBeforeShow()
	{
		ShipTowerResetViewParams shipTowerResetViewParams = this.OpenParam as ShipTowerResetViewParams;
		ShipTowerStageData shipTowerStageData = (shipTowerResetViewParams != null) ? shipTowerResetViewParams.StageData : null;
		if (shipTowerStageData != null)
		{
			this.ResetItem1.UpdateData(shipTowerStageData.TeamDataList[0]);
			this.ResetItem2.UpdateData(shipTowerStageData.TeamDataList[1]);
		}
	}

	// Token: 0x06016297 RID: 90775 RVA: 0x0059AF30 File Offset: 0x00599130
	private void OnClickSure()
	{
		ShipTowerResetViewParams shipTowerResetViewParams = this.OpenParam as ShipTowerResetViewParams;
		ShipTowerStageData shipTowerStageData = (shipTowerResetViewParams != null) ? shipTowerResetViewParams.StageData : null;
		if (shipTowerStageData != null)
		{
			shipTowerStageData.SureResetStage();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400A50F RID: 42255
	private ShipTowerResetItem ResetItem1;

	// Token: 0x0400A510 RID: 42256
	private ShipTowerResetItem ResetItem2;

	// Token: 0x02008FE3 RID: 36835
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E989 RID: 190857
		public const int ItemReset1 = 0;

		// Token: 0x0402E98A RID: 190858
		public const int ItemReset2 = 1;

		// Token: 0x0402E98B RID: 190859
		public const int BtnCancel = 2;

		// Token: 0x0402E98C RID: 190860
		public const int BtnSure = 3;
	}
}
