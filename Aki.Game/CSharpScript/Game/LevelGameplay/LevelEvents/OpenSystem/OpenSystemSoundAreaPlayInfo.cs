using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D99 RID: 23961
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSoundAreaPlayInfo : OpenSystemBase
	{
		// Token: 0x0603A5CD RID: 239053 RVA: 0x0107C9B3 File Offset: 0x0107ABB3
		public OpenSystemSoundAreaPlayInfo(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5CE RID: 239054 RVA: 0x0107C9BC File Offset: 0x0107ABBC
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSoundAreaPlayInfo.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSoundAreaPlayInfo.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5CF RID: 239055 RVA: 0x0107C9FF File Offset: 0x0107ABFF
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SoundAreaPlayTips);
		}
	}
}
