using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F3F RID: 7999
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerResetView : UiViewBase
{
	// Token: 0x06013C98 RID: 81048 RVA: 0x005C5D92 File Offset: 0x005C3F92
	public ShipTowerResetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C99 RID: 81049 RVA: 0x005C5D9C File Offset: 0x005C3F9C
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

	// Token: 0x06013C9A RID: 81050 RVA: 0x005C5E48 File Offset: 0x005C4048
	private void InitDataParam()
	{
	}

	// Token: 0x06013C9B RID: 81051 RVA: 0x005C5E4C File Offset: 0x005C404C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerResetView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerResetView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C9C RID: 81052 RVA: 0x005C5E90 File Offset: 0x005C4090
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

	// Token: 0x06013C9D RID: 81053 RVA: 0x005C5EE8 File Offset: 0x005C40E8
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

	// Token: 0x0400A8F9 RID: 43257
	private ShipTowerResetItem ResetItem1;

	// Token: 0x0400A8FA RID: 43258
	private ShipTowerResetItem ResetItem2;

	// Token: 0x0200822A RID: 33322
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A081 RID: 172161
		public const int ItemReset1 = 0;

		// Token: 0x0402A082 RID: 172162
		public const int ItemReset2 = 1;

		// Token: 0x0402A083 RID: 172163
		public const int BtnCancel = 2;

		// Token: 0x0402A084 RID: 172164
		public const int BtnSure = 3;
	}
}
