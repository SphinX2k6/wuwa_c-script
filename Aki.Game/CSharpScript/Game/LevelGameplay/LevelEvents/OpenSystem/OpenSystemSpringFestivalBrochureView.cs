using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C21 RID: 27681
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSpringFestivalBrochureView : OpenSystemBase
	{
		// Token: 0x06044478 RID: 279672 RVA: 0x010D2AB7 File Offset: 0x010D0CB7
		public OpenSystemSpringFestivalBrochureView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044479 RID: 279673 RVA: 0x010D2AC0 File Offset: 0x010D0CC0
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSpringFestivalBrochureView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSpringFestivalBrochureView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0604447A RID: 279674 RVA: 0x010D2AFB File Offset: 0x010D0CFB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorBrochureView);
		}
	}
}
