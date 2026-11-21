using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004094 RID: 16532
	public class FlowActionOpenQuestChapterView : FlowActionBase
	{
		// Token: 0x06029DF1 RID: 171505 RVA: 0x00BD6F64 File Offset: 0x00BD5164
		protected override void OnExecute()
		{
			PromptQuestChapterUI promptQuestChapterUI = this.ActionInfo.Params as PromptQuestChapterUI;
			if (promptQuestChapterUI == null)
			{
				return;
			}
			GeneralContext context = this.Context.Context;
			int? num = null;
			if (promptQuestChapterUI.QuestId != null)
			{
				num = promptQuestChapterUI.QuestId;
			}
			else
			{
				EGeneralContextType? type = context.Type;
				if (type != null)
				{
					EGeneralContextType valueOrDefault = type.GetValueOrDefault();
					if (valueOrDefault != EGeneralContextType.Quest)
					{
						if (valueOrDefault == EGeneralContextType.GeneralLogicTree)
						{
							GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
							num = ((generalLogicTreeContext != null) ? new int?(generalLogicTreeContext.TreeConfigId) : null);
						}
					}
					else
					{
						QuestContext questContext = context as QuestContext;
						num = ((questContext != null) ? new int?(questContext.QuestId) : null);
					}
				}
			}
			if (num == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "非任务系统不可使用章节提示事件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GeneralLogicTreeUtil.Instance.OpenQuestChapterView(promptQuestChapterUI, num.Value, new Action(this.OnCloseView));
		}

		// Token: 0x06029DF2 RID: 171506 RVA: 0x00BD7060 File Offset: 0x00BD5260
		private void OnCloseView()
		{
			base.FinishExecute(true, true);
		}
	}
}
