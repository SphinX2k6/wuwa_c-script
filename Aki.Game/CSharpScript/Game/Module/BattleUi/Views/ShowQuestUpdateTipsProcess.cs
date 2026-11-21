using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D66 RID: 19814
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowQuestUpdateTipsProcess : TPendingProcess
	{
		// Token: 0x06031B98 RID: 203672 RVA: 0x00DE72EF File Offset: 0x00DE54EF
		public ShowQuestUpdateTipsProcess(QuestUpdateTipsShowData info)
		{
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x06031B99 RID: 203673 RVA: 0x00DE730A File Offset: 0x00DE550A
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.ShowQuestUpdateTips;
			}
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x06031B9A RID: 203674 RVA: 0x00DE730D File Offset: 0x00DE550D
		public override bool IsSkipAnim { get; } = info.IsSkipAnim;

		// Token: 0x0401A52F RID: 107823
		public readonly QuestUpdateTipsShowData Info = info;
	}
}
