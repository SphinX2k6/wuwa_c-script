using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A8 RID: 25512
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskUiContext : IMowingRiskContextDisposable
	{
		// Token: 0x06040323 RID: 262947 RVA: 0x00F8B131 File Offset: 0x00F89331
		public MowingRiskUiContext(MowingRiskModel attachedModel)
		{
			this.AttachedModel = attachedModel;
		}

		// Token: 0x06040324 RID: 262948 RVA: 0x00F8B14B File Offset: 0x00F8934B
		public void Dispose()
		{
		}

		// Token: 0x06040325 RID: 262949 RVA: 0x00F8B150 File Offset: 0x00F89350
		public void SyncNewBuff(List<int> addBuffIds)
		{
			foreach (int item in addBuffIds)
			{
				if (!this.NewBuffToShowCache.Contains(item))
				{
					this.NewBuffToShowCache.Add(item);
				}
			}
		}

		// Token: 0x06040326 RID: 262950 RVA: 0x00F8B1B4 File Offset: 0x00F893B4
		public void ResetCacheInBattle()
		{
			this.NewBuffToShowCache.Clear();
		}

		// Token: 0x040216D1 RID: 136913
		public readonly MowingRiskModel AttachedModel;

		// Token: 0x040216D2 RID: 136914
		public EMowingBuffViewUsage CurrentBuffViewUsage;

		// Token: 0x040216D3 RID: 136915
		public EMowingBuffTabViewType CurrentBuffViewType;

		// Token: 0x040216D4 RID: 136916
		public int? CurrentChosenOverviewBuffId;

		// Token: 0x040216D5 RID: 136917
		public int? CurrentChosenProgressIndex;

		// Token: 0x040216D6 RID: 136918
		public readonly List<int> NewBuffToShowCache = new List<int>();
	}
}
