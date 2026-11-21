using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D3F RID: 23871
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivitySubView : OpenSystemBase
	{
		// Token: 0x0603A4BF RID: 238783 RVA: 0x0107A597 File Offset: 0x01078797
		public OpenSystemActivitySubView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4C0 RID: 238784 RVA: 0x0107A5A0 File Offset: 0x010787A0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemActivitySubView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemActivitySubView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4C1 RID: 238785 RVA: 0x0107A5E4 File Offset: 0x010787E4
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			ActivityViewName? config = ConfigActivityViewNameById.GetConfig(inParams.BoardId, true);
			if (config != null)
			{
				return new EUiViewName?((EUiViewName)config.Value.ViewName);
			}
			return null;
		}
	}
}
