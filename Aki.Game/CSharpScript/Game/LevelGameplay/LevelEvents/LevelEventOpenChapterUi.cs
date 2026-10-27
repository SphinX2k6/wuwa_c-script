using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B45 RID: 27461
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventOpenChapterUi : LevelEventBase
	{
		// Token: 0x06044176 RID: 278902 RVA: 0x010BFCFB File Offset: 0x010BDEFB
		public LevelEventOpenChapterUi(int id) : base(id)
		{
		}

		// Token: 0x06044177 RID: 278903 RVA: 0x010BFD04 File Offset: 0x010BDF04
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044178 RID: 278904 RVA: 0x010BFD10 File Offset: 0x010BDF10
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
