using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050C4 RID: 20676
	public class FlowActionOpenQuestChapterView : FlowActionBase
	{
		// Token: 0x06034EF8 RID: 216824 RVA: 0x00C89C7C File Offset: 0x00C87E7C
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

		// Token: 0x06034EF9 RID: 216825 RVA: 0x00C89D78 File Offset: 0x00C87F78
		private void OnCloseView()
		{
			base.FinishExecute(true, true);
		}
	}
}
