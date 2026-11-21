using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D59 RID: 23897
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemFishingCage : OpenSystemBase
	{
		// Token: 0x0603A50D RID: 238861 RVA: 0x0107B08F File Offset: 0x0107928F
		public OpenSystemFishingCage(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A50E RID: 238862 RVA: 0x0107B098 File Offset: 0x01079298
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemFishingCage.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemFishingCage.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A50F RID: 238863 RVA: 0x0107B0DB File Offset: 0x010792DB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.DockyardCageView);
		}
	}
}
