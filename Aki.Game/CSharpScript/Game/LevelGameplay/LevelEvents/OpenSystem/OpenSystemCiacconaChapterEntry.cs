using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCD RID: 27597
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCiacconaChapterEntry : OpenSystemBase
	{
		// Token: 0x0604437C RID: 279420 RVA: 0x010D08D7 File Offset: 0x010CEAD7
		public OpenSystemCiacconaChapterEntry(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0604437D RID: 279421 RVA: 0x010D08E0 File Offset: 0x010CEAE0
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CiacconaGalChapterEntryView);
		}

		// Token: 0x0604437E RID: 279422 RVA: 0x010D08EC File Offset: 0x010CEAEC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemCiacconaChapterEntry.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemCiacconaChapterEntry.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
