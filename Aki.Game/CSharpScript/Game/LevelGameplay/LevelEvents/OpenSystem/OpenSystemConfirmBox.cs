using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D48 RID: 23880
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemConfirmBox : OpenSystemBase
	{
		// Token: 0x0603A4DA RID: 238810 RVA: 0x0107A8DB File Offset: 0x01078ADB
		public OpenSystemConfirmBox(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A4DB RID: 238811 RVA: 0x0107A8E4 File Offset: 0x01078AE4
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

		// Token: 0x0603A4DC RID: 238812 RVA: 0x0107A938 File Offset: 0x01078B38
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return null;
			}
			return ConfirmBoxController.Instance.GetUiViewName(inParams.BoardId);
		}

		// Token: 0x0603A4DD RID: 238813 RVA: 0x0107A964 File Offset: 0x01078B64
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
