using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D79 RID: 23929
	[NullableContext(2)]
	public interface IMissionItemViewShowData
	{
		// Token: 0x17008E28 RID: 36392
		// (get) Token: 0x0603CBBA RID: 248762
		EMissionItemViewDataSource DataSource { get; }

		// Token: 0x17008E29 RID: 36393
		// (get) Token: 0x0603CBBB RID: 248763
		long Id { get; }

		// Token: 0x17008E2A RID: 36394
		// (get) Token: 0x0603CBBC RID: 248764
		int ShowPriority { get; }

		// Token: 0x17008E2B RID: 36395
		// (get) Token: 0x0603CBBD RID: 248765
		int TrackIconConfigId { get; }

		// Token: 0x17008E2C RID: 36396
		// (get) Token: 0x0603CBBE RID: 248766
		string TitleTextKey { get; }

		// Token: 0x17008E2D RID: 36397
		// (get) Token: 0x0603CBBF RID: 248767
		MissionViewStepTextInfoBase MainStepInfo { get; }

		// Token: 0x17008E2E RID: 36398
		// (get) Token: 0x0603CBC0 RID: 248768
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

		// Token: 0x17008E2F RID: 36399
		// (get) Token: 0x0603CBC1 RID: 248769
		long? ParentId { get; }
	}
}
