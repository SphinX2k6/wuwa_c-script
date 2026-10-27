using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D81 RID: 23937
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionItemViewStartTrackProcess : TPendingProcess
	{
		// Token: 0x0603CC33 RID: 248883 RVA: 0x00E96A36 File Offset: 0x00E94C36
		public MissionItemViewStartTrackProcess(IMissionItemViewShowData showData, ETreeTextExpressReason reason, bool isSkipAnim)
		{
		}

		// Token: 0x17008E55 RID: 36437
		// (get) Token: 0x0603CC34 RID: 248884 RVA: 0x00E96A53 File Offset: 0x00E94C53
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewStartTrack;
			}
		}

		// Token: 0x17008E56 RID: 36438
		// (get) Token: 0x0603CC35 RID: 248885 RVA: 0x00E96A56 File Offset: 0x00E94C56
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401FA6F RID: 129647
		public readonly IMissionItemViewShowData ShowData = showData;

		// Token: 0x0401FA70 RID: 129648
		public readonly ETreeTextExpressReason Reason = reason;
	}
}
