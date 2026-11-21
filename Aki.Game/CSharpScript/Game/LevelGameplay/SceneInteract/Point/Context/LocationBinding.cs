using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BEA RID: 23530
	[NullableContext(1)]
	[Nullable(0)]
	public class LocationBinding
	{
		// Token: 0x06039CC5 RID: 236741 RVA: 0x0103B938 File Offset: 0x01039B38
		public LocationBinding(Vector Location)
		{
			this.Location = Location;
		}

		// Token: 0x0401E88D RID: 125069
		public readonly Vector Location;
	}
}
