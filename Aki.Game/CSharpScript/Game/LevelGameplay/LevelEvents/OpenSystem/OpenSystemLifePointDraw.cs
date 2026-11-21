using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D72 RID: 23922
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemLifePointDraw : OpenSystemBase
	{
		// Token: 0x0603A557 RID: 238935 RVA: 0x0107BA76 File Offset: 0x01079C76
		public OpenSystemLifePointDraw(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A558 RID: 238936 RVA: 0x0107BA80 File Offset: 0x01079C80
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemLifePointDraw.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemLifePointDraw.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A559 RID: 238937 RVA: 0x0107BABB File Offset: 0x01079CBB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.LifePointDrawEntranceView);
		}
	}
}
