using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C0F RID: 27663
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemRogueEventSelect : OpenSystemBase
	{
		// Token: 0x06044441 RID: 279617 RVA: 0x010D23E0 File Offset: 0x010D05E0
		public OpenSystemRogueEventSelect(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044442 RID: 279618 RVA: 0x010D23EC File Offset: 0x010D05EC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemRogueEventSelect.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemRogueEventSelect.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044443 RID: 279619 RVA: 0x010D2427 File Offset: 0x010D0627
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.RoguelikeRandomEventView);
		}
	}
}
