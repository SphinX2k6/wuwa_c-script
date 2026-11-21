using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF1 RID: 16369
	public class AssistedWalkSeqRelation : NpcRelation
	{
		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x060296ED RID: 169709 RVA: 0x00BAB1C3 File Offset: 0x00BA93C3
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.AssistedWalk;
			}
		}

		// Token: 0x040169C3 RID: 92611
		[Nullable(1)]
		public string Key = "";

		// Token: 0x040169C4 RID: 92612
		public int LeaderEntityId;

		// Token: 0x040169C5 RID: 92613
		public int FollowerEntityId;
	}
}
