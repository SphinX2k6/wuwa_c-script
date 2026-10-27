using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.NpcPerformState
{
	// Token: 0x02005029 RID: 20521
	public class CancelAssistedWalkSeqRelation : NpcRelation
	{
		// Token: 0x17008022 RID: 32802
		// (get) Token: 0x06034854 RID: 215124 RVA: 0x00C60327 File Offset: 0x00C5E527
		public override ENpcRelationType RelationType
		{
			get
			{
				return ENpcRelationType.CancelAssistedWalk;
			}
		}

		// Token: 0x0401BFDB RID: 114651
		[Nullable(1)]
		public string Key = "";
	}
}
