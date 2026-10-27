using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C29 RID: 27689
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTurntableControl : OpenSystemBase
	{
		// Token: 0x06044493 RID: 279699 RVA: 0x010D2E8F File Offset: 0x010D108F
		public OpenSystemTurntableControl(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044494 RID: 279700 RVA: 0x010D2E98 File Offset: 0x010D1098
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTurntableControl.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTurntableControl.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044495 RID: 279701 RVA: 0x010D2EDB File Offset: 0x010D10DB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TurntableControlView);
		}
	}
}
