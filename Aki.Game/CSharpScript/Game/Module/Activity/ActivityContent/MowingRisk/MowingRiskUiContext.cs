using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005326 RID: 21286
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskUiContext : IMowingRiskContextDisposable
	{
		// Token: 0x06034FE4 RID: 217060 RVA: 0x00ED20D1 File Offset: 0x00ED02D1
		public MowingRiskUiContext(MowingRiskModel attachedModel)
		{
			this.AttachedModel = attachedModel;
		}

		// Token: 0x06034FE5 RID: 217061 RVA: 0x00ED20EB File Offset: 0x00ED02EB
		public void Dispose()
		{
		}

		// Token: 0x06034FE6 RID: 217062 RVA: 0x00ED20F0 File Offset: 0x00ED02F0
		public void SyncNewBuff(IEnumerable<int> addBuffIds)
		{
			foreach (int item in addBuffIds)
			{
				if (!this.NewBuffToShowCache.Contains(item))
				{
					this.NewBuffToShowCache.Add(item);
				}
			}
		}

		// Token: 0x06034FE7 RID: 217063 RVA: 0x00ED214C File Offset: 0x00ED034C
		public void ResetCacheInBattle()
		{
			this.NewBuffToShowCache.Clear();
		}

		// Token: 0x0401C000 RID: 114688
		public readonly MowingRiskModel AttachedModel;

		// Token: 0x0401C001 RID: 114689
		public EMowingBuffViewUsage CurrentBuffViewUsage;

		// Token: 0x0401C002 RID: 114690
		public EMowingBuffTabViewType CurrentBuffViewType;

		// Token: 0x0401C003 RID: 114691
		public int? CurrentChosenOverviewBuffId;

		// Token: 0x0401C004 RID: 114692
		public int? CurrentChosenProgressIndex;

		// Token: 0x0401C005 RID: 114693
		public readonly List<int> NewBuffToShowCache = new List<int>();
	}
}
