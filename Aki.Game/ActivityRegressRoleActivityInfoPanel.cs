using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200094C RID: 2380
public class ActivityRegressRoleActivityInfoPanel : UiPanelBase
{
	// Token: 0x060068F6 RID: 26870 RVA: 0x0020C7E0 File Offset: 0x0020A9E0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x060068F7 RID: 26871 RVA: 0x0020C850 File Offset: 0x0020AA50
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRoleActivityInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRoleActivityInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060068F8 RID: 26872 RVA: 0x0020C893 File Offset: 0x0020AA93
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoRoleBtnClick));
		this.ActivityBottom.FunctionButton.SetLocalTextNew("RecallActivity_Go", Array.Empty<object>());
	}

	// Token: 0x060068F9 RID: 26873 RVA: 0x0020C8CB File Offset: 0x0020AACB
	public void RefreshData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
	}

	// Token: 0x060068FA RID: 26874 RVA: 0x0020C8DC File Offset: 0x0020AADC
	private void OnGotoRoleBtnClick()
	{
		int gachaId = this.Config.Value.GachaId;
		if (GachaModel.Instance.GetGachaInfo(gachaId) == null)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Tips_01", Array.Empty<object>());
		}
		ActivityRegressHelper.ReportRecallLog1024(EReportLogEventType.NewRole, 0);
		GachaController.Instance.OpenGachaView(gachaId);
	}

	// Token: 0x040042A3 RID: 17059
	private RegressBase? Config;

	// Token: 0x040042A4 RID: 17060
	[Nullable(2)]
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02006C4C RID: 27724
	private class EComponents
	{
		// Token: 0x04023969 RID: 145769
		public const int ComActivityTitle = 0;

		// Token: 0x0402396A RID: 145770
		public const int ComActivityDesc = 1;

		// Token: 0x0402396B RID: 145771
		public const int ComActivityReward = 2;

		// Token: 0x0402396C RID: 145772
		public const int ComActivityBottom = 3;
	}
}
