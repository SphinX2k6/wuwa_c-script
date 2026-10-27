using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C20 RID: 27680
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSoundAreaPlayInfo : OpenSystemBase
	{
		// Token: 0x06044475 RID: 279669 RVA: 0x010D2A5F File Offset: 0x010D0C5F
		public OpenSystemSoundAreaPlayInfo(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044476 RID: 279670 RVA: 0x010D2A68 File Offset: 0x010D0C68
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

		// Token: 0x06044477 RID: 279671 RVA: 0x010D2AAB File Offset: 0x010D0CAB
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SoundAreaPlayTips);
		}
	}
}
