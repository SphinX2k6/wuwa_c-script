using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D83 RID: 23939
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionItemViewRefreshProcess : TPendingProcess
	{
		// Token: 0x0603CC39 RID: 248889 RVA: 0x00E96A86 File Offset: 0x00E94C86
		public MissionItemViewRefreshProcess(IMissionItemViewShowData showData, bool isSkipAnim)
		{
		}

		// Token: 0x17008E59 RID: 36441
		// (get) Token: 0x0603CC3A RID: 248890 RVA: 0x00E96A9C File Offset: 0x00E94C9C
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewRefresh;
			}
		}

		// Token: 0x17008E5A RID: 36442
		// (get) Token: 0x0603CC3B RID: 248891 RVA: 0x00E96A9F File Offset: 0x00E94C9F
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401FA75 RID: 129653
		public readonly IMissionItemViewShowData ShowData = showData;
	}
}
