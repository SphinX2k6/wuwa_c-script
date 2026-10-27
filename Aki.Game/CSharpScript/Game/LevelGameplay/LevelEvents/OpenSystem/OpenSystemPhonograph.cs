using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006C05 RID: 27653
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemPhonograph : OpenSystemBase
	{
		// Token: 0x06044423 RID: 279587 RVA: 0x010D1FDB File Offset: 0x010D01DB
		public OpenSystemPhonograph(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044424 RID: 279588 RVA: 0x010D1FE4 File Offset: 0x010D01E4
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

		// Token: 0x06044425 RID: 279589 RVA: 0x010D2027 File Offset: 0x010D0227
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
