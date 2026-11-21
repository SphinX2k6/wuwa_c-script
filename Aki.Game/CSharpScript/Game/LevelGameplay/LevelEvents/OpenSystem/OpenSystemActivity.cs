using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D3D RID: 23869
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemActivity : OpenSystemBase
	{
		// Token: 0x0603A4B9 RID: 238777 RVA: 0x0107A4ED File Offset: 0x010786ED
		public OpenSystemActivity(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4BA RID: 238778 RVA: 0x0107A4F8 File Offset: 0x010786F8
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

		// Token: 0x0603A4BB RID: 238779 RVA: 0x0107A53B File Offset: 0x0107873B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.CommonActivityView);
		}
	}
}
