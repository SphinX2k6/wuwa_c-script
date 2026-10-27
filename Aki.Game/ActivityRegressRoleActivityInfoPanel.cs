using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001498 RID: 5272
public class ActivityRegressRoleActivityInfoPanel : UiPanelBase
{
	// Token: 0x06009561 RID: 38241 RVA: 0x00203878 File Offset: 0x00201A78
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

	// Token: 0x06009562 RID: 38242 RVA: 0x002038E8 File Offset: 0x00201AE8
	protected override UniTask OnBeforeStartAsync()
	{
		ActivityRegressRoleActivityInfoPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityRegressRoleActivityInfoPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009563 RID: 38243 RVA: 0x0020392B File Offset: 0x00201B2B
	protected override void OnStart()
	{
		this.ActivityBottom.FunctionButton.SetFunction(new Action(this.OnGotoRoleBtnClick));
		this.ActivityBottom.FunctionButton.SetLocalTextNew("RecallActivity_Go", Array.Empty<object>());
	}

	// Token: 0x06009564 RID: 38244 RVA: 0x00203963 File Offset: 0x00201B63
	public void RefreshData(RegressBase config)
	{
		this.Config = new RegressBase?(config);
	}

	// Token: 0x06009565 RID: 38245 RVA: 0x00203974 File Offset: 0x00201B74
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

	// Token: 0x0400420B RID: 16907
	private RegressBase? Config;

	// Token: 0x0400420C RID: 16908
	[Nullable(2)]
	private ActivityFunctionalTypeA ActivityBottom;

	// Token: 0x02007AC8 RID: 31432
	private class EComponents
	{
		// Token: 0x0402864F RID: 165455
		public const int ComActivityTitle = 0;

		// Token: 0x04028650 RID: 165456
		public const int ComActivityDesc = 1;

		// Token: 0x04028651 RID: 165457
		public const int ComActivityReward = 2;

		// Token: 0x04028652 RID: 165458
		public const int ComActivityBottom = 3;
	}
}
