using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D84 RID: 23940
	[NullableContext(1)]
	[Nullable(0)]
	public class ShowQuestUpdateTipsProcess : TPendingProcess
	{
		// Token: 0x0603CC3C RID: 248892 RVA: 0x00E96AA7 File Offset: 0x00E94CA7
		public ShowQuestUpdateTipsProcess(QuestUpdateTipsShowData info)
		{
		}

		// Token: 0x17008E5B RID: 36443
		// (get) Token: 0x0603CC3D RID: 248893 RVA: 0x00E96AC2 File Offset: 0x00E94CC2
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.ShowQuestUpdateTips;
			}
		}

		// Token: 0x17008E5C RID: 36444
		// (get) Token: 0x0603CC3E RID: 248894 RVA: 0x00E96AC5 File Offset: 0x00E94CC5
		public override bool IsSkipAnim { get; } = info.IsSkipAnim;

		// Token: 0x0401FA77 RID: 129655
		public readonly QuestUpdateTipsShowData Info = info;
	}
}
