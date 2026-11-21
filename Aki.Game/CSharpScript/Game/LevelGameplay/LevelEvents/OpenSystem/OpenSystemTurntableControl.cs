using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005DA2 RID: 23970
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTurntableControl : OpenSystemBase
	{
		// Token: 0x0603A5EB RID: 239083 RVA: 0x0107CDE3 File Offset: 0x0107AFE3
		public OpenSystemTurntableControl(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5EC RID: 239084 RVA: 0x0107CDEC File Offset: 0x0107AFEC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTurntableControl.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTurntableControl.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5ED RID: 239085 RVA: 0x0107CE2F File Offset: 0x0107B02F
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.TurntableControlView);
		}
	}
}
