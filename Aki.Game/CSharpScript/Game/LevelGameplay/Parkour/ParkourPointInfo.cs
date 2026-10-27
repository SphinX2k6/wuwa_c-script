using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.Parkour
{
	// Token: 0x02006ABB RID: 27323
	public class ParkourPointInfo
	{
		// Token: 0x06043E32 RID: 278066 RVA: 0x010A49C2 File Offset: 0x010A2BC2
		[NullableContext(1)]
		public ParkourPointInfo(TsParkourCheckPoint point)
		{
			this.Point = point;
			this.IsRecycled = false;
		}

		// Token: 0x040237B8 RID: 145336
		[Nullable(2)]
		public TsParkourCheckPoint Point;

		// Token: 0x040237B9 RID: 145337
		public bool IsRecycled;
	}
}
