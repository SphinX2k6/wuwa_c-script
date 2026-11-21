using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Parkour
{
	// Token: 0x02005C33 RID: 23603
	public class ParkourPointInfo
	{
		// Token: 0x06039F79 RID: 237433 RVA: 0x0104DFA6 File Offset: 0x0104C1A6
		[NullableContext(1)]
		public ParkourPointInfo(TsParkourCheckPoint point)
		{
			this.Point = point;
			this.IsRecycled = false;
		}

		// Token: 0x0401EA55 RID: 125525
		[Nullable(2)]
		public TsParkourCheckPoint Point;

		// Token: 0x0401EA56 RID: 125526
		public bool IsRecycled;
	}
}
