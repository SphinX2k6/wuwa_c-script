using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02006BCF RID: 27599
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemConfirmBox : OpenSystemBase
	{
		// Token: 0x06044382 RID: 279426 RVA: 0x010D0987 File Offset: 0x010CEB87
		public OpenSystemConfirmBox(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x06044383 RID: 279427 RVA: 0x010D0990 File Offset: 0x010CEB90
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemConfirmBox.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.context = context;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemConfirmBox.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x06044384 RID: 279428 RVA: 0x010D09E4 File Offset: 0x010CEBE4
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			return ConfirmBoxController.Instance.GetUiViewName(inParams.BoardId);
		}

		// Token: 0x06044385 RID: 279429 RVA: 0x010D0A10 File Offset: 0x010CEC10
		private int? GetQuestIdByContext(GeneralContext context)
		{
			int? result = null;
			EGeneralContextType? type = context.Type;
			if (type != null)
			{
				EGeneralContextType valueOrDefault = type.GetValueOrDefault();
				if (valueOrDefault != EGeneralContextType.Quest)
				{
					if (valueOrDefault == EGeneralContextType.GeneralLogicTree)
					{
						result = new int?((context as GeneralLogicTreeContext).TreeConfigId);
					}
				}
				else
				{
					result = new int?((context as QuestContext).QuestId);
				}
			}
			return result;
		}
	}
}
