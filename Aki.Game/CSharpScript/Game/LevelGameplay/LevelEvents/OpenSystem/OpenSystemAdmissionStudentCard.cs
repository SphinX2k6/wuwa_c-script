using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC7 RID: 27591
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemAdmissionStudentCard : OpenSystemBase
	{
		// Token: 0x0604436A RID: 279402 RVA: 0x010D06E3 File Offset: 0x010CE8E3
		public OpenSystemAdmissionStudentCard(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604436B RID: 279403 RVA: 0x010D06EC File Offset: 0x010CE8EC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemAdmissionStudentCard.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemAdmissionStudentCard.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604436C RID: 279404 RVA: 0x010D0727 File Offset: 0x010CE927
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.AdmissionStudentCardView);
		}
	}
}
