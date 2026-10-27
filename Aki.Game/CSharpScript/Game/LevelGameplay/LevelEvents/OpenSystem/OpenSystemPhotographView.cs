using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C06 RID: 27654
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhotographView : OpenSystemBase
	{
		// Token: 0x06044426 RID: 279590 RVA: 0x010D205E File Offset: 0x010D025E
		public OpenSystemPhotographView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044427 RID: 279591 RVA: 0x010D2068 File Offset: 0x010D0268
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemPhotographView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemPhotographView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044428 RID: 279592 RVA: 0x010D20AB File Offset: 0x010D02AB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.PhotographView);
		}
	}
}
