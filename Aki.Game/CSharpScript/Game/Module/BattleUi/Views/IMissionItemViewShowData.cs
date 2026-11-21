using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D5B RID: 19803
	[NullableContext(2)]
	public interface IMissionItemViewShowData
	{
		// Token: 0x170061FA RID: 25082
		// (get) Token: 0x06031B16 RID: 203542
		EMissionItemViewDataSource DataSource { get; }

		// Token: 0x170061FB RID: 25083
		// (get) Token: 0x06031B17 RID: 203543
		long Id { get; }

		// Token: 0x170061FC RID: 25084
		// (get) Token: 0x06031B18 RID: 203544
		int ShowPriority { get; }

		// Token: 0x170061FD RID: 25085
		// (get) Token: 0x06031B19 RID: 203545
		int TrackIconConfigId { get; }

		// Token: 0x170061FE RID: 25086
		// (get) Token: 0x06031B1A RID: 203546
		string TitleTextKey { get; }

		// Token: 0x170061FF RID: 25087
		// (get) Token: 0x06031B1B RID: 203547
		MissionViewStepTextInfoBase MainStepInfo { get; }

		// Token: 0x17006200 RID: 25088
		// (get) Token: 0x06031B1C RID: 203548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IReadOnlyList<MissionViewStepTextInfoBase> SubStepInfos { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; }

		// Token: 0x17006201 RID: 25089
		// (get) Token: 0x06031B1D RID: 203549
		long? ParentId { get; }
	}
}
