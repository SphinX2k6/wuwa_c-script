using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BC4 RID: 27588
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivity : OpenSystemBase
	{
		// Token: 0x06044361 RID: 279393 RVA: 0x010D0599 File Offset: 0x010CE799
		public OpenSystemActivity(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044362 RID: 279394 RVA: 0x010D05A4 File Offset: 0x010CE7A4
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemActivity.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemActivity.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044363 RID: 279395 RVA: 0x010D05E7 File Offset: 0x010CE7E7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CommonActivityView);
		}
	}
}
