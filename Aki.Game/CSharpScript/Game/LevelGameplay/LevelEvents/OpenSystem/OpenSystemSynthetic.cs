using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C23 RID: 27683
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSynthetic : OpenSystemBase
	{
		// Token: 0x0604447E RID: 279678 RVA: 0x010D2B5F File Offset: 0x010D0D5F
		public OpenSystemSynthetic(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604447F RID: 279679 RVA: 0x010D2B68 File Offset: 0x010D0D68
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSynthetic.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSynthetic.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044480 RID: 279680 RVA: 0x010D2BA3 File Offset: 0x010D0DA3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ComposeCarryOnView);
		}
	}
}
