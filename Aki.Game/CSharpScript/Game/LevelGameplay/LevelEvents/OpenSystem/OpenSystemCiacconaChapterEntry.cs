using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D46 RID: 23878
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCiacconaChapterEntry : OpenSystemBase
	{
		// Token: 0x0603A4D4 RID: 238804 RVA: 0x0107A82B File Offset: 0x01078A2B
		public OpenSystemCiacconaChapterEntry(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4D5 RID: 238805 RVA: 0x0107A834 File Offset: 0x01078A34
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CiacconaGalChapterEntryView);
		}

		// Token: 0x0603A4D6 RID: 238806 RVA: 0x0107A840 File Offset: 0x01078A40
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
