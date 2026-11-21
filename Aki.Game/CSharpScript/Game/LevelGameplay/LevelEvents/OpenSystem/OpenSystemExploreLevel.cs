using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D56 RID: 23894
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemExploreLevel : OpenSystemBase
	{
		// Token: 0x0603A504 RID: 238852 RVA: 0x0107AF56 File Offset: 0x01079156
		public OpenSystemExploreLevel(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A505 RID: 238853 RVA: 0x0107AF60 File Offset: 0x01079160
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemExploreLevel.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemExploreLevel.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A506 RID: 238854 RVA: 0x0107AF9B File Offset: 0x0107919B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.ExploreLevelView);
		}
	}
}
