using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCC RID: 27596
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemChasingMoonMain : OpenSystemBase
	{
		// Token: 0x06044379 RID: 279417 RVA: 0x010D0887 File Offset: 0x010CEA87
		public OpenSystemChasingMoonMain(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604437A RID: 279418 RVA: 0x010D0890 File Offset: 0x010CEA90
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemChasingMoonMain.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemChasingMoonMain.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604437B RID: 279419 RVA: 0x010D08CB File Offset: 0x010CEACB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MoonChasingMainView);
		}
	}
}
