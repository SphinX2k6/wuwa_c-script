using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C24 RID: 27684
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemTakePhotoView : OpenSystemBase
	{
		// Token: 0x06044481 RID: 279681 RVA: 0x010D2BAF File Offset: 0x010D0DAF
		public OpenSystemTakePhotoView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044482 RID: 279682 RVA: 0x010D2BB8 File Offset: 0x010D0DB8
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemTakePhotoView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemTakePhotoView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044483 RID: 279683 RVA: 0x010D2BF3 File Offset: 0x010D0DF3
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.PhotographView);
		}
	}
}
