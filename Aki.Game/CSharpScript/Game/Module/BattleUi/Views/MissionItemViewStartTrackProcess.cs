using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D63 RID: 19811
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionItemViewStartTrackProcess : TPendingProcess
	{
		// Token: 0x06031B8F RID: 203663 RVA: 0x00DE727E File Offset: 0x00DE547E
		public MissionItemViewStartTrackProcess(IMissionItemViewShowData showData, ETreeTextExpressReason reason, bool isSkipAnim)
		{
		}

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x06031B90 RID: 203664 RVA: 0x00DE729B File Offset: 0x00DE549B
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewStartTrack;
			}
		}

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x06031B91 RID: 203665 RVA: 0x00DE729E File Offset: 0x00DE549E
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401A527 RID: 107815
		public readonly IMissionItemViewShowData ShowData = showData;

		// Token: 0x0401A528 RID: 107816
		public readonly ETreeTextExpressReason Reason = reason;
	}
}
