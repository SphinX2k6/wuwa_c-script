using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC6 RID: 27590
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivitySubView : OpenSystemBase
	{
		// Token: 0x06044367 RID: 279399 RVA: 0x010D0643 File Offset: 0x010CE843
		public OpenSystemActivitySubView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044368 RID: 279400 RVA: 0x010D064C File Offset: 0x010CE84C
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

		// Token: 0x06044369 RID: 279401 RVA: 0x010D0690 File Offset: 0x010CE890
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
