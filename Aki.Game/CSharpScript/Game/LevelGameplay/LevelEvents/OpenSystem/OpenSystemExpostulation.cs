using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D57 RID: 23895
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemExpostulation : OpenSystemBase
	{
		// Token: 0x0603A507 RID: 238855 RVA: 0x0107AFA7 File Offset: 0x010791A7
		public OpenSystemExpostulation(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A508 RID: 238856 RVA: 0x0107AFB0 File Offset: 0x010791B0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemExpostulation.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemExpostulation.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A509 RID: 238857 RVA: 0x0107AFF4 File Offset: 0x010791F4
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (context != null && context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				return new EUiViewName?(EUiViewName.AdviceInfoView);
			}
			return null;
		}
	}
}
