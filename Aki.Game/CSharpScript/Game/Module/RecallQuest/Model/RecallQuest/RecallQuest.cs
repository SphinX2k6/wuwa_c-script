using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;

namespace CSharpScript.Game.Module.RecallQuest.Model.RecallQuest
{
	// Token: 0x02003EEC RID: 16108
	public class RecallQuest : global::Quest
	{
		// Token: 0x06028D9A RID: 167322 RVA: 0x00B768FC File Offset: 0x00B74AFC
		[NullableContext(1)]
		public RecallQuest(EQuest questType, IQuest questConfig) : base(questType, questConfig)
		{
			IQuestRecallConfig recallConfig = questConfig.RecallConfig;
			IQuest questConfig2 = QuestNewModel.Instance.GetQuestConfig((recallConfig != null) ? recallConfig.RecallId : 0);
			this.SourceQuest = questConfig2;
		}

		// Token: 0x06028D9B RID: 167323 RVA: 0x00B76936 File Offset: 0x00B74B36
		protected override void OnQuestToProgress()
		{
			RecallQuestController.Instance.ClearAcceptQuestTrack(this.Id);
			base.OnQuestToProgress();
		}

		// Token: 0x06028D9C RID: 167324 RVA: 0x00B7694E File Offset: 0x00B74B4E
		protected override bool CanShowInRecall()
		{
			IQuest sourceQuest = this.SourceQuest;
			return sourceQuest == null || sourceQuest.Type != EQuest.Hidden;
		}

		// Token: 0x0401636D RID: 90989
		[Nullable(2)]
		public readonly IQuest SourceQuest;
	}
}
