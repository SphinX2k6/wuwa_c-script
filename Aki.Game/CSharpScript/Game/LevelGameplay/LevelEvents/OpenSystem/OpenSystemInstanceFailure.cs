using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BF7 RID: 27639
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemInstanceFailure : OpenSystemBase
	{
		// Token: 0x060443F9 RID: 279545 RVA: 0x010D1A6E File Offset: 0x010CFC6E
		public OpenSystemInstanceFailure(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443FA RID: 279546 RVA: 0x010D1A78 File Offset: 0x010CFC78
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemInstanceFailure.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemInstanceFailure.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443FB RID: 279547 RVA: 0x010D1AB3 File Offset: 0x010CFCB3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.InstanceDungeonFailView);
		}
	}
}
