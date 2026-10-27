using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BD4 RID: 27604
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoAbyssView : OpenSystemBase
	{
		// Token: 0x06044391 RID: 279441 RVA: 0x010D0BF3 File Offset: 0x010CEDF3
		public OpenSystemDangoAbyssView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044392 RID: 279442 RVA: 0x010D0BFC File Offset: 0x010CEDFC
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoAbyssEntranceView);
		}

		// Token: 0x06044393 RID: 279443 RVA: 0x010D0C08 File Offset: 0x010CEE08
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoAbyssView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoAbyssView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
