using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D6B RID: 23915
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiTalentTreeView : OpenSystemBase
	{
		// Token: 0x0603A542 RID: 238914 RVA: 0x0107B677 File Offset: 0x01079877
		public OpenSystemHonamiTalentTreeView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A543 RID: 238915 RVA: 0x0107B680 File Offset: 0x01079880
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiTalentTreeView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiTalentTreeView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A544 RID: 238916 RVA: 0x0107B6BB File Offset: 0x010798BB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryTechnologyView);
		}
	}
}
