using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9D RID: 23965
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTakePhotoView : OpenSystemBase
	{
		// Token: 0x0603A5D9 RID: 239065 RVA: 0x0107CB03 File Offset: 0x0107AD03
		public OpenSystemTakePhotoView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5DA RID: 239066 RVA: 0x0107CB0C File Offset: 0x0107AD0C
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTakePhotoView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTakePhotoView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5DB RID: 239067 RVA: 0x0107CB47 File Offset: 0x0107AD47
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.PhotographView);
		}
	}
}
