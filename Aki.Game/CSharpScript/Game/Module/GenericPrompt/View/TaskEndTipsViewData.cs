using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059AE RID: 22958
	public class TaskEndTipsViewData : UiViewData
	{
		// Token: 0x0401E5ED RID: 124397
		public EQuestCommonTipType QuestType;

		// Token: 0x0401E5EE RID: 124398
		[Nullable(1)]
		public string TipTextKey = "";

		// Token: 0x0401E5EF RID: 124399
		public int? Duration;
	}
}
