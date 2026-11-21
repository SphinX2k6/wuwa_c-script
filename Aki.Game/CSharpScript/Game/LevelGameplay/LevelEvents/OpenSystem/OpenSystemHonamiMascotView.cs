using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D69 RID: 23913
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemHonamiMascotView : OpenSystemBase
	{
		// Token: 0x0603A53C RID: 238908 RVA: 0x0107B5C7 File Offset: 0x010797C7
		public OpenSystemHonamiMascotView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A53D RID: 238909 RVA: 0x0107B5D0 File Offset: 0x010797D0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemHonamiMascotView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemHonamiMascotView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A53E RID: 238910 RVA: 0x0107B613 File Offset: 0x01079813
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.HonamiStoryMascotCollectBookView);
		}
	}
}
