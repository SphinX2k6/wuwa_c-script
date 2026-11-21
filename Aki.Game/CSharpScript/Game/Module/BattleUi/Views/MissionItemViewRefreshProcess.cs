using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D65 RID: 19813
	[NullableContext(1)]
	[Nullable(0)]
	public class MissionItemViewRefreshProcess : TPendingProcess
	{
		// Token: 0x06031B95 RID: 203669 RVA: 0x00DE72CE File Offset: 0x00DE54CE
		public MissionItemViewRefreshProcess(IMissionItemViewShowData showData, bool isSkipAnim)
		{
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x06031B96 RID: 203670 RVA: 0x00DE72E4 File Offset: 0x00DE54E4
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.MissionItemViewRefresh;
			}
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x06031B97 RID: 203671 RVA: 0x00DE72E7 File Offset: 0x00DE54E7
		public override bool IsSkipAnim { get; } = isSkipAnim;

		// Token: 0x0401A52D RID: 107821
		public readonly IMissionItemViewShowData ShowData = showData;
	}
}
