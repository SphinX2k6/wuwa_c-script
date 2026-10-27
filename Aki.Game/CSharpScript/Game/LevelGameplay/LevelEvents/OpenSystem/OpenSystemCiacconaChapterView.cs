using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCE RID: 27598
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCiacconaChapterView : OpenSystemBase
	{
		// Token: 0x0604437F RID: 279423 RVA: 0x010D092F File Offset: 0x010CEB2F
		public OpenSystemCiacconaChapterView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044380 RID: 279424 RVA: 0x010D0938 File Offset: 0x010CEB38
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CiacconaGalChapterView);
		}

		// Token: 0x06044381 RID: 279425 RVA: 0x010D0944 File Offset: 0x010CEB44
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemCiacconaChapterView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemCiacconaChapterView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
