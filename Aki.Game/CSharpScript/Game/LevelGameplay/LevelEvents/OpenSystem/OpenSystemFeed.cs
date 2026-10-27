using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDF RID: 27615
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFeed : OpenSystemBase
	{
		// Token: 0x060443B2 RID: 279474 RVA: 0x010D10D2 File Offset: 0x010CF2D2
		public OpenSystemFeed(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443B3 RID: 279475 RVA: 0x010D10DC File Offset: 0x010CF2DC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFeed.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFeed.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x060443B4 RID: 279476 RVA: 0x010D112F File Offset: 0x010CF32F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ItemDeliverView);
		}
	}
}
