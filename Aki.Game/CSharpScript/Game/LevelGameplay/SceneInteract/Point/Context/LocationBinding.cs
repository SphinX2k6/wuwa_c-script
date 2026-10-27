using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8D RID: 27277
	[NullableContext(1)]
	[Nullable(0)]
	public class LocationBinding
	{
		// Token: 0x06043C77 RID: 277623 RVA: 0x010970E4 File Offset: 0x010952E4
		public LocationBinding(Vector Location)
		{
			this.Location = Location;
		}

		// Token: 0x0402369B RID: 145051
		public readonly Vector Location;
	}
}
