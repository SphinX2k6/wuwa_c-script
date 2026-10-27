using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02005027 RID: 20519
	public class AssistedWalkSeqRelation : NpcRelation
	{
		// Token: 0x1700801F RID: 32799
		// (get) Token: 0x0603484A RID: 215114 RVA: 0x00C5FC4B File Offset: 0x00C5DE4B
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.AssistedWalk;
			}
		}

		// Token: 0x0401BFD8 RID: 114648
		[Nullable(1)]
		public string Key = "";

		// Token: 0x0401BFD9 RID: 114649
		public int LeaderEntityId;

		// Token: 0x0401BFDA RID: 114650
		public int FollowerEntityId;
	}
}
