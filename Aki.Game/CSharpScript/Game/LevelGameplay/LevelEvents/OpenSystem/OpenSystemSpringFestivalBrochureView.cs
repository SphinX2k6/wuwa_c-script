using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9A RID: 23962
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSpringFestivalBrochureView : OpenSystemBase
	{
		// Token: 0x0603A5D0 RID: 239056 RVA: 0x0107CA0B File Offset: 0x0107AC0B
		public OpenSystemSpringFestivalBrochureView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5D1 RID: 239057 RVA: 0x0107CA14 File Offset: 0x0107AC14
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSpringFestivalBrochureView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSpringFestivalBrochureView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5D2 RID: 239058 RVA: 0x0107CA4F File Offset: 0x0107AC4F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorBrochureView);
		}
	}
}
