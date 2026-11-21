using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D47 RID: 23879
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCiacconaChapterView : OpenSystemBase
	{
		// Token: 0x0603A4D7 RID: 238807 RVA: 0x0107A883 File Offset: 0x01078A83
		public OpenSystemCiacconaChapterView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4D8 RID: 238808 RVA: 0x0107A88C File Offset: 0x01078A8C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CiacconaGalChapterView);
		}

		// Token: 0x0603A4D9 RID: 238809 RVA: 0x0107A898 File Offset: 0x01078A98
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
