using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA8 RID: 23976
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemWorldMap : OpenSystemBase
	{
		// Token: 0x0603A5FE RID: 239102 RVA: 0x0107D0C6 File Offset: 0x0107B2C6
		public OpenSystemWorldMap(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5FF RID: 239103 RVA: 0x0107D0D0 File Offset: 0x0107B2D0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemWorldMap.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemWorldMap.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A600 RID: 239104 RVA: 0x0107D113 File Offset: 0x0107B313
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.WorldMapView);
		}
	}
}
