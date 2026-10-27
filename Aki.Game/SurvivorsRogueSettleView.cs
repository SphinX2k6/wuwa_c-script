using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002B7A RID: 11130
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueSettleView : SurvivorsRogueSettleBaseView, ISurvivorsRogueCommandView
{
	// Token: 0x060170D4 RID: 94420 RVA: 0x005DA5E9 File Offset: 0x005D87E9
	public SurvivorsRogueSettleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x17001EC2 RID: 7874
	// (get) Token: 0x060170D5 RID: 94421 RVA: 0x005DA5F2 File Offset: 0x005D87F2
	int ISurvivorsRogueCommandView.CommandIncId
	{
		get
		{
			return this.CommandIncId;
		}
	}

	// Token: 0x17001EC3 RID: 7875
	// (get) Token: 0x060170D6 RID: 94422 RVA: 0x005DA5FA File Offset: 0x005D87FA
	SurvivorsRogueCommandBase ISurvivorsRogueCommandView.Command
	{
		get
		{
			return this.Command;
		}
	}

	// Token: 0x060170D7 RID: 94423 RVA: 0x005DA602 File Offset: 0x005D8802
	public void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x060170D8 RID: 94424 RVA: 0x005DA60B File Offset: 0x005D880B
	protected override void OnClickBtnReturn()
	{
		SurvivorsRogueModel.Instance.HasNewSettle = false;
		SurvivorsRogueController.Instance.LeaveRogueInstance();
	}

	// Token: 0x060170D9 RID: 94425 RVA: 0x005DA622 File Offset: 0x005D8822
	protected override void OnClickBtnReturnMain()
	{
		SurvivorsRogueModel.Instance.HasNewSettle = true;
		SurvivorsRogueController.Instance.LeaveRogueInstance();
	}

	// Token: 0x060170DA RID: 94426 RVA: 0x005DA63C File Offset: 0x005D883C
	protected override UniTask OnBeforeStartAsync()
	{
		SurvivorsRogueSettleView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<SurvivorsRogueSettleView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060170DB RID: 94427 RVA: 0x005DA67F File Offset: 0x005D887F
	[NullableContext(2)]
	protected override ResultView GetViewInfo()
	{
		return this.Command.GetViewInfo();
	}

	// Token: 0x060170DC RID: 94428 RVA: 0x005DA68C File Offset: 0x005D888C
	protected override void OnBeforeDestroy()
	{
		SurvivorsRogueCommandResultSettle command = this.Command;
		if (command == null)
		{
			return;
		}
		command.BindView(null);
	}

	// Token: 0x060170DD RID: 94429 RVA: 0x005DA6A0 File Offset: 0x005D88A0
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

	// Token: 0x0400AC8F RID: 44175
	public int CommandIncId;

	// Token: 0x0400AC90 RID: 44176
	public SurvivorsRogueCommandResultSettle Command;
}
