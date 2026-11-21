using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004987 RID: 18823
	public class TaskEndTipsViewData : UiViewData
	{
		// Token: 0x0401908B RID: 102539
		public EQuestCommonTipType QuestType;

		// Token: 0x0401908C RID: 102540
		[Nullable(1)]
		public string TipTextKey = "";

		// Token: 0x0401908D RID: 102541
		public int? Duration;
	}
}
