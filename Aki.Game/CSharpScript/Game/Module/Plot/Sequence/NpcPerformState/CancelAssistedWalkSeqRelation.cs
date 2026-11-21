using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02003FF3 RID: 16371
	public class CancelAssistedWalkSeqRelation : NpcRelation
	{
		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x060296F7 RID: 169719 RVA: 0x00BAB89F File Offset: 0x00BA9A9F
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.CancelAssistedWalk;
			}
		}

		// Token: 0x040169C6 RID: 92614
		[Nullable(1)]
		public string Key = "";
	}
}
