using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BFC RID: 27644
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemMachineryFactoryTouch : OpenSystemBase
	{
		// Token: 0x06044408 RID: 279560 RVA: 0x010D1C33 File Offset: 0x010CFE33
		public OpenSystemMachineryFactoryTouch(LevelEventOpenSystem levelEventOpenSystem) : base(levelEventOpenSystem)
		{
		}

		// Token: 0x06044409 RID: 279561 RVA: 0x010D1C3C File Offset: 0x010CFE3C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemMachineryFactoryTouch.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemMachineryFactoryTouch.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604440A RID: 279562 RVA: 0x010D1C7F File Offset: 0x010CFE7F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.MachineryFactoryTouchMoveView);
		}
	}
}
