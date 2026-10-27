using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050A6 RID: 20646
	[NullableContext(1)]
	[Nullable(0)]
	public class FlowActionAvgPlayRoleAction : FlowActionBase
	{
		// Token: 0x06034E8E RID: 216718 RVA: 0x00C8802C File Offset: 0x00C8622C
		protected override void OnExecute()
		{
			List<IAvgPlayRoleActionItem> roleActionList = (this.ActionInfo.Params as AvgPlayRoleAction).RoleActionList;
			List<UniTask> list = new List<UniTask>();
			foreach (IAvgPlayRoleActionItem roleAction in roleActionList)
			{
				list.Add(this.ExecuteRoleAction(roleAction));
			}
			if (this.ActionInfo.Async.GetValueOrDefault())
			{
				base.FinishExecute(true, true);
				return;
			}
			UniTask.WhenAll(list).ContinueWith(delegate()
			{
				base.FinishExecute(true, true);
			}).Forget();
		}

		// Token: 0x06034E8F RID: 216719 RVA: 0x00C880D4 File Offset: 0x00C862D4
		private UniTask ExecuteRoleAction(IAvgPlayRoleActionItem roleAction)
		{
			FlowActionAvgPlayRoleAction.<ExecuteRoleAction>d__1 <ExecuteRoleAction>d__;
			<ExecuteRoleAction>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExecuteRoleAction>d__.<>4__this = this;
			<ExecuteRoleAction>d__.roleAction = roleAction;
			<ExecuteRoleAction>d__.<>1__state = -1;
			<ExecuteRoleAction>d__.<>t__builder.Start<FlowActionAvgPlayRoleAction.<ExecuteRoleAction>d__1>(ref <ExecuteRoleAction>d__);
			return <ExecuteRoleAction>d__.<>t__builder.Task;
		}

		// Token: 0x06034E90 RID: 216720 RVA: 0x00C88120 File Offset: 0x00C86320
		private UniTask EnterAsync(IAvgPlayRoleActionItem roleAction)
		{
			FlowActionAvgPlayRoleAction.<EnterAsync>d__2 <EnterAsync>d__;
			<EnterAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnterAsync>d__.roleAction = roleAction;
			<EnterAsync>d__.<>1__state = -1;
			<EnterAsync>d__.<>t__builder.Start<FlowActionAvgPlayRoleAction.<EnterAsync>d__2>(ref <EnterAsync>d__);
			return <EnterAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034E91 RID: 216721 RVA: 0x00C88164 File Offset: 0x00C86364
		private UniTask ExitAsync(IAvgPlayRoleActionItem roleAction)
		{
			FlowActionAvgPlayRoleAction.<ExitAsync>d__3 <ExitAsync>d__;
			<ExitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ExitAsync>d__.roleAction = roleAction;
			<ExitAsync>d__.<>1__state = -1;
			<ExitAsync>d__.<>t__builder.Start<FlowActionAvgPlayRoleAction.<ExitAsync>d__3>(ref <ExitAsync>d__);
			return <ExitAsync>d__.<>t__builder.Task;
		}
	}
}
