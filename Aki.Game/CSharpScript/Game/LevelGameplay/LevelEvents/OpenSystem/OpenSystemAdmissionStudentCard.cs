using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D40 RID: 23872
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemAdmissionStudentCard : OpenSystemBase
	{
		// Token: 0x0603A4C2 RID: 238786 RVA: 0x0107A637 File Offset: 0x01078837
		public OpenSystemAdmissionStudentCard(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4C3 RID: 238787 RVA: 0x0107A640 File Offset: 0x01078840
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemAdmissionStudentCard.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemAdmissionStudentCard.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4C4 RID: 238788 RVA: 0x0107A67B File Offset: 0x0107887B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.AdmissionStudentCardView);
		}
	}
}
