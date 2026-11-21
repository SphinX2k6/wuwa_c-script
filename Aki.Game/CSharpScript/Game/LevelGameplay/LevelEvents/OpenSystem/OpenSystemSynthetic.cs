using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9C RID: 23964
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSynthetic : OpenSystemBase
	{
		// Token: 0x0603A5D6 RID: 239062 RVA: 0x0107CAB3 File Offset: 0x0107ACB3
		public OpenSystemSynthetic(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5D7 RID: 239063 RVA: 0x0107CABC File Offset: 0x0107ACBC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSynthetic.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSynthetic.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5D8 RID: 239064 RVA: 0x0107CAF7 File Offset: 0x0107ACF7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ComposeCarryOnView);
		}
	}
}
