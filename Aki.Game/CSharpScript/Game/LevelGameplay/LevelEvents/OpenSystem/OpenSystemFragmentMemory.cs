using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BE5 RID: 27621
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFragmentMemory : OpenSystemBase
	{
		// Token: 0x060443C4 RID: 279492 RVA: 0x010D12EB File Offset: 0x010CF4EB
		public OpenSystemFragmentMemory(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443C5 RID: 279493 RVA: 0x010D12F4 File Offset: 0x010CF4F4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFragmentMemory.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFragmentMemory.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443C6 RID: 279494 RVA: 0x010D1337 File Offset: 0x010CF537
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MemoryDetailView);
		}
	}
}
