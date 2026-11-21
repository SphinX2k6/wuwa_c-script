using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D4D RID: 23885
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemDangoAbyssView : OpenSystemBase
	{
		// Token: 0x0603A4E9 RID: 238825 RVA: 0x0107AB47 File Offset: 0x01078D47
		public OpenSystemDangoAbyssView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4EA RID: 238826 RVA: 0x0107AB50 File Offset: 0x01078D50
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DangoAbyssEntranceView);
		}

		// Token: 0x0603A4EB RID: 238827 RVA: 0x0107AB5C File Offset: 0x01078D5C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemDangoAbyssView.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemDangoAbyssView.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}
	}
}
