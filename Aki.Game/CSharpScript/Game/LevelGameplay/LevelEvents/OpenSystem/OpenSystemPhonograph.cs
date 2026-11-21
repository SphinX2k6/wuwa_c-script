using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D7E RID: 23934
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhonograph : OpenSystemBase
	{
		// Token: 0x0603A57B RID: 238971 RVA: 0x0107BF2F File Offset: 0x0107A12F
		public OpenSystemPhonograph(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A57C RID: 238972 RVA: 0x0107BF38 File Offset: 0x0107A138
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemPhonograph.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemPhonograph.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A57D RID: 238973 RVA: 0x0107BF7B File Offset: 0x0107A17B
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.PhonographView);
			}
			if (PhonographModel.Instance.GetUnlockItemIds().Count > 0)
			{
				return new EUiViewName?(EUiViewName.PhonographNewMusicView);
			}
			return new EUiViewName?(EUiViewName.PhonographView);
		}
	}
}
