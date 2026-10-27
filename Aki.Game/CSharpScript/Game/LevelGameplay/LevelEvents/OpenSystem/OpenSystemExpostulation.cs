using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BDE RID: 27614
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemExpostulation : OpenSystemBase
	{
		// Token: 0x060443AF RID: 279471 RVA: 0x010D1053 File Offset: 0x010CF253
		public OpenSystemExpostulation(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x060443B0 RID: 279472 RVA: 0x010D105C File Offset: 0x010CF25C
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

		// Token: 0x060443B1 RID: 279473 RVA: 0x010D10A0 File Offset: 0x010CF2A0
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
