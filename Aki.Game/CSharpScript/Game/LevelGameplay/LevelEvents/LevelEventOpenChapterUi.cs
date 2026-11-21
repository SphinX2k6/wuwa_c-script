using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CBD RID: 23741
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventOpenChapterUi : LevelEventBase
	{
		// Token: 0x0603A2C8 RID: 238280 RVA: 0x01069777 File Offset: 0x01067977
		public LevelEventOpenChapterUi(int id) : base(id)
		{
		}

		// Token: 0x0603A2C9 RID: 238281 RVA: 0x01069780 File Offset: 0x01067980
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A2CA RID: 238282 RVA: 0x0106978C File Offset: 0x0106798C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PromptQuestChapterUI promptQuestChapterUI = inParams as PromptQuestChapterUI;
			if (promptQuestChapterUI == null)
			{
				return;
			}
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
							num = new int?((context as GeneralLogicTreeContext).TreeConfigId);
						}
					}
					else
					{
						num = new int?((context as QuestContext).QuestId);
					}
				}
			}
			if (num == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "非任务系统不可使用章节提示事件", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			GeneralLogicTreeUtil.Instance.OpenQuestChapterView(promptQuestChapterUI, num.Value, null);
		}
	}
}
