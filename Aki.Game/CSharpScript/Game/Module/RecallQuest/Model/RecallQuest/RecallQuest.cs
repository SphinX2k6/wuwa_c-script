using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.RecallQuest.Model.RecallQuest
{
	// Token: 0x02004F23 RID: 20259
	public class RecallQuest : global::Quest
	{
		// Token: 0x06033F2C RID: 212780 RVA: 0x00C2D140 File Offset: 0x00C2B340
		[NullableContext(1)]
		public RecallQuest(EQuest questType, IQuest questConfig) : base(questType, questConfig)
		{
			IQuestRecallConfig recallConfig = questConfig.RecallConfig;
			IQuest questConfig2 = QuestNewModel.Instance.GetQuestConfig((recallConfig != null) ? recallConfig.RecallId : 0);
			this.SourceQuest = questConfig2;
		}

		// Token: 0x06033F2D RID: 212781 RVA: 0x00C2D17A File Offset: 0x00C2B37A
		protected override void OnQuestToProgress()
		{
			RecallQuestController.Instance.ClearAcceptQuestTrack(this.Id);
			base.OnQuestToProgress();
		}

		// Token: 0x06033F2E RID: 212782 RVA: 0x00C2D192 File Offset: 0x00C2B392
		protected override bool CanShowInRecall()
		{
			IQuest sourceQuest = this.SourceQuest;
			return sourceQuest == null || sourceQuest.Type != EQuest.Hidden;
		}

		// Token: 0x0401B998 RID: 113048
		[Nullable(2)]
		public readonly IQuest SourceQuest;
	}
}
