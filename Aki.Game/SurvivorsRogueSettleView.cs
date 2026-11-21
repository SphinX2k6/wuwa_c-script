using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020020F6 RID: 8438
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSettleView : SurvivorsRogueSettleBaseView, ISurvivorsRogueCommandView
{
	// Token: 0x06014B05 RID: 84741 RVA: 0x00607159 File Offset: 0x00605359
	public SurvivorsRogueSettleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001F1A RID: 7962
	// (get) Token: 0x06014B06 RID: 84742 RVA: 0x00607162 File Offset: 0x00605362
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x17001F1B RID: 7963
	// (get) Token: 0x06014B07 RID: 84743 RVA: 0x0060716A File Offset: 0x0060536A
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x06014B08 RID: 84744 RVA: 0x00607172 File Offset: 0x00605372
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06014B09 RID: 84745 RVA: 0x0060717B File Offset: 0x0060537B
	protected override void OnClickBtnReturn()
	{
		SurvivorsRogueModel.Instance.HasNewSettle = false;
		SurvivorsRogueController.Instance.LeaveRogueInstance();
	}

	// Token: 0x06014B0A RID: 84746 RVA: 0x00607192 File Offset: 0x00605392
	protected override void OnClickBtnReturnMain()
	{
		SurvivorsRogueModel.Instance.HasNewSettle = true;
		SurvivorsRogueController.Instance.LeaveRogueInstance();
	}

	// Token: 0x06014B0B RID: 84747 RVA: 0x006071AC File Offset: 0x006053AC
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014B0C RID: 84748 RVA: 0x006071EF File Offset: 0x006053EF
	[NullableContext(2)]
	protected override ResultView GetViewInfo()
	{
		return this.Command.GetViewInfo();
	}

	// Token: 0x06014B0D RID: 84749 RVA: 0x006071FC File Offset: 0x006053FC
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandResultSettle command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x06014B0E RID: 84750 RVA: 0x00607210 File Offset: 0x00605410
	public void Refresh()
	{
		UiAsyncTask task = new UiAsyncTask("SurvivorsRogueSettleView.Refresh", delegate()
		{
			SurvivorsRogueSettleView.<<Refresh>b__13_0>d <<Refresh>b__13_0>d;
			<<Refresh>b__13_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<Refresh>b__13_0>d.<>4__this = this;
			<<Refresh>b__13_0>d.<>1__state = -1;
			<<Refresh>b__13_0>d.<>t__builder.Start<SurvivorsRogueSettleView.<<Refresh>b__13_0>d>(ref <<Refresh>b__13_0>d);
			return <<Refresh>b__13_0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x0400B095 RID: 45205
	public int CommandIncId;

	// Token: 0x0400B096 RID: 45206
	public SurvivorsRogueCommandResultSettle Command;
}
